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
    public class EmployeesApiController : ApiController
    {
        private EmployeeContext db = new EmployeeContext();


        [HttpGet]
        public HttpResponseMessage GetEmployees(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(db.Employees, loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage PostEmployee(FormDataCollection form)
        {
            var values = form.Get("values");

            var newOrder = new Employee();
            JsonConvert.PopulateObject(values, newOrder);

            Validate(newOrder);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.Employees.Add(newOrder);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public HttpResponseMessage PutEmployee(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = db.Employees.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteEmployee(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = db.Employees.First(o => o.ID == key);

            db.Employees.Remove(order);
            db.SaveChanges();
        }
     


    }
}