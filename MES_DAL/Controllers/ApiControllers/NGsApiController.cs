using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MES_DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MES_DAL.Controllers.ApiControllers
{
    public class NGsApiController : ApiController
    {
        private NGContext db = new NGContext();

        // GET: api/ProductsApi
        [HttpGet]
        public HttpResponseMessage GetNGs(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(db.NGs, loadOptions));
        }

        [HttpPut]
        public HttpResponseMessage PutNG(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = db.NGs.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage PostNG(FormDataCollection form)
        {
            var values = form.Get("values");

            var newType = new NG();
            JsonConvert.PopulateObject(values, newType);

            Validate(newType);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.NGs.Add(newType);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }


        [HttpDelete]
        public void DeleteNG(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = db.NGs.First(o => o.ID == key);

            db.NGs.Remove(order);
            db.SaveChanges();
        }
    }
}