using System;
using System.Collections;
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
using System.Web.UI.WebControls;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using MES_DAL.Models;
using Newtonsoft.Json;

namespace MES_DAL.Controllers.ApiControllers
{
    public class TasksApiController : ApiController
    {
        private TaskContext db = new TaskContext();

        [HttpGet]
        public HttpResponseMessage GetTasks(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(db.Tasks, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage GetTaskStatus(DataSourceLoadOptions loadOptions)
        {
            ArrayList list = new ArrayList();

            foreach (int i in Enum.GetValues(typeof(TaskStatus)))
            {
                ListItem listitem = new ListItem(Enum.GetName(typeof(TaskStatus), i), i.ToString());
                list.Add(listitem.ToString());
            }


            return Request.CreateResponse(DataSourceLoader.Load(
                list.ToArray()
                , loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage PostTask(FormDataCollection form)
        {
            var values = form.Get("values");
            
            var newOrder = new Task();
            JsonConvert.PopulateObject(values, newOrder);
            //newOrder.DonePer = Convert.ToDecimal(newOrder.DoneNumber / newOrder.PlanNumber);
            Validate(newOrder);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.Tasks.Add(newOrder);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public HttpResponseMessage PutTask(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = db.Tasks.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);
            //order.DonePer = Convert.ToDecimal(order.DoneNumber / order.PlanNumber);
            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteTask(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = db.Tasks.First(o => o.ID == key);

            db.Tasks.Remove(order);
            db.SaveChanges();
        }

    }
}