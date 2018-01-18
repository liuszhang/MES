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
using MES_DAL.ViewModels;
using Newtonsoft.Json;

namespace MES_DAL.Controllers.ApiControllers
{
    public class FactoriesApiController : ApiController
    {
        private FactoryContext fdb = new FactoryContext();
        private WorkShopContext wdb = new WorkShopContext();
        private LineContext ldb = new LineContext();
        private StationContext sdb = new StationContext();


        #region 工厂
        [HttpGet]
        public HttpResponseMessage GetFactories(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(fdb.Factories, loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage PostFactory(FormDataCollection form)
        {
            var values = form.Get("values");

            var newOrder = new Factory();
            JsonConvert.PopulateObject(values, newOrder);

            Validate(newOrder);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            fdb.Factories.Add(newOrder);
            fdb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public HttpResponseMessage PutFactory(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = fdb.Factories.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            fdb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteFactory(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = fdb.Factories.First(o => o.ID == key);

            fdb.Factories.Remove(order);
            fdb.SaveChanges();
        }


        #endregion

        #region 车间
        [HttpGet]
        public HttpResponseMessage GetWorkShops(int factoryID, DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(
                from i in wdb.WorkShops
                where i.FactoryID == factoryID
                select new
                {
                    Name = i.Name
                },
                loadOptions
            ));
        }

        [HttpGet]
        public HttpResponseMessage GetWorkShops(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(wdb.WorkShops, loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage PostWorkShop(FormDataCollection form)
        {
            var values = form.Get("values");

            var newOrder = new WorkShop();
            JsonConvert.PopulateObject(values, newOrder);

            Validate(newOrder);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            wdb.WorkShops.Add(newOrder);
            wdb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public HttpResponseMessage PutWorkShop(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = wdb.WorkShops.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            wdb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteWorkShop(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = wdb.WorkShops.First(o => o.ID == key);

            wdb.WorkShops.Remove(order);
            wdb.SaveChanges();
        }


        #endregion

        #region 产线
        [HttpGet]
        public HttpResponseMessage GetLines(int workshopID, DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(
                from i in ldb.Lines
                where i.WorkShopID == workshopID
                select new
                {
                    Name = i.Name
                },
                loadOptions
            ));
        }

        [HttpGet]
        public HttpResponseMessage GetLines(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(ldb.Lines, loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage PostLine(FormDataCollection form)
        {
            var values = form.Get("values");

            var newOrder = new Line();
            JsonConvert.PopulateObject(values, newOrder);

            Validate(newOrder);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            ldb.Lines.Add(newOrder);
            ldb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public HttpResponseMessage PutLine(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = ldb.Lines.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            ldb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteLine(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = ldb.Lines.First(o => o.ID == key);

            ldb.Lines.Remove(order);
            ldb.SaveChanges();
        }


        #endregion

        #region 工位
        [HttpGet]
        public HttpResponseMessage GetStations(int lineID, DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(
                from i in sdb.Stations
                where i.LineID == lineID
                select new
                {
                    Name = i.Name
                },
                loadOptions
            ));
        }

        [HttpGet]
        public HttpResponseMessage GetStations(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(sdb.Stations, loadOptions));
        }
        [HttpPost]
        public HttpResponseMessage PostStation(FormDataCollection form)
        {
            var values = form.Get("values");

            var newOrder = new Station();
            JsonConvert.PopulateObject(values, newOrder);

            Validate(newOrder);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            sdb.Stations.Add(newOrder);
            sdb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpPut]
        public HttpResponseMessage PutStation(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = sdb.Stations.First(o => o.ID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            sdb.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteStation(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var order = sdb.Stations.First(o => o.ID == key);

            sdb.Stations.Remove(order);
            sdb.SaveChanges();
        }


        #endregion


        #region 展示
        [HttpGet]
        public HttpResponseMessage GetViewModels(int lineID, DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load(
                from i in sdb.Stations
                where i.LineID == lineID
                select new
                {
                    Name = i.Name
                },
                loadOptions
            ));
        }


        [HttpGet]
        public HttpResponseMessage GetViewModels(DataSourceLoadOptions loadOptions)
        {
            List<FactoryViewModel> fvms = new List<FactoryViewModel>();
            FactoryViewModel fvm = new FactoryViewModel();
            var stations = sdb.Stations.ToList();
            var lines = ldb.Lines.ToList();
            var workshops = wdb.WorkShops.ToList();
            var factories = fdb.Factories.ToList();


            for(int f=0;f<factories.Count();f++)
            {
                //get workshops
                int workshopcount = 0;
                for(int w=0;w<workshops.Count();w++)
                {
                    if(workshops[w].FactoryID==factories[f].ID)
                    {
                        workshopcount++;
                        //get lines
                        int linecount = 0;
                        for(int l=0;l<lines.Count();l++)
                        {
                            if(lines[l].WorkShopID==workshops[w].ID)
                            {
                                linecount++;
                                //get stations
                                int stationcount = 0;
                                for(int s=0;s<stations.Count();s++)
                                {
                                    if(stations[s].LineID==lines[l].ID)
                                    {
                                        stationcount++;
                                        fvms.Add(new FactoryViewModel() { Factory = factories[f], WorkShop = workshops[w], Line = lines[l],Station=stations[s] });
                                    }                                    
                                }
                                if(stationcount==0)
                                    fvms.Add(new FactoryViewModel() { Factory = factories[f], WorkShop = workshops[w],Line=lines[l] });
                            }
                        }
                        if(linecount==0)
                            fvms.Add(new FactoryViewModel() { Factory = factories[f],WorkShop=workshops[w] });
                    }
                    
                }
                if(workshopcount==0)
                {
                    fvms.Add(new FactoryViewModel() { Factory = factories[f] });
                }//如果不为零，说明有车间，在车间循环中添加至fvms
            }
    

            return Request.CreateResponse(DataSourceLoader.Load(
                from f in fvms
                select new
                {
                    Factory= f.Factory,
                    WorkShop=f.WorkShop,
                    Line=f.Line,
                    Station=f.Station
                }, 
                loadOptions));

            
        }

        #endregion

    }
}