using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Description;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MES_DAL.Models;
using Newtonsoft.Json;

namespace MES_DAL.Controllers.ApiControllers
{
    public class ProductsApiController : ApiController
    {
        private ProductContext db = new ProductContext();

        // GET: api/ProductsApi
        [HttpGet]
        public HttpResponseMessage GetProducts(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(db.Products, loadOptions));
        }

        [HttpPut]
        public HttpResponseMessage PutProduct(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = db.Products.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage PostProduct(FormDataCollection form)
        {
            var values = form.Get("values");

            var newType = new Product();
            JsonConvert.PopulateObject(values, newType);

            Validate(newType);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.Products.Add(newType);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }


        [HttpDelete]
        public void DeleteProduct(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = db.Products.First(o => o.ID == key);

            db.Products.Remove(order);
            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.ID == id) > 0;
        }
    }
}