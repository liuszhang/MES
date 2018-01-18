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
    public class ProductTypesApiController : ApiController
    {
        private ProductTypeContext db = new ProductTypeContext();
        private ProductContext tdb = new ProductContext();

        // GET: api/ProductTypesApi
        public IQueryable<ProductType> GetProductTypes()
        {
            return db.ProductTypes;
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(db.ProductTypes, loadOptions));
        }

        // PUT: api/ProductTypesApi/5

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = db.ProductTypes.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST: api/ProductTypesApi
        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            var values = form.Get("values");

            var newType = new ProductType();
            JsonConvert.PopulateObject(values, newType);

            Validate(newType);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.ProductTypes.Add(newType);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // DELETE: api/ProductTypesApi/5
        [HttpDelete]
        public void DeleteProductType(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = db.ProductTypes.First(o => o.ID == key);

            db.ProductTypes.Remove(order);
            db.SaveChanges();
        }


        [HttpGet]
        public HttpResponseMessage TypeList(int typeID, DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(
                from i in tdb.Products
                where i.TypeID == typeID
                select new
                {
                    Name = i.Name,
                    SeriesNumber = i.SeriNum,
                    Count = i.Count,
                },
                loadOptions
            ));
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductTypeExists(int id)
        {
            return db.ProductTypes.Count(e => e.ID == id) > 0;
        }
    }
}