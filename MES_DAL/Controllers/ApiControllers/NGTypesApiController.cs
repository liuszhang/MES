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
    public class NGTypesApiController : ApiController
    {
        private NGTypeContext db = new NGTypeContext();

        // GET: api/ProductsApi
        [HttpGet]
        public HttpResponseMessage GetNGTypes(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(db.NGTypes, loadOptions));
        }

        [HttpPut]
        public HttpResponseMessage PutNGType(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = db.NGTypes.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage PostNGType(FormDataCollection form)
        {
            var values = form.Get("values");

            var newType = new NGType();
            JsonConvert.PopulateObject(values, newType);

            Validate(newType);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.NGTypes.Add(newType);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }


        [HttpDelete]
        public void DeleteNGType(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = db.NGTypes.First(o => o.ID == key);

            db.NGTypes.Remove(order);
            db.SaveChanges();
        }

    }
}
