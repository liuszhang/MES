using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Mvc;
using MES_Dashboard.App_Data.Dashboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MES_Dashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DashboardDesigner()
        {
            return View("DashboardDesigner");
        }

        public ActionResult DashboardViewer()
        {
            return View("DashboardViewer");
        }

        public ActionResult QualityDashboardViewer()
        {
            return View("QualityDashboardViewer");
        }

        [ValidateInput(false)]
        public ActionResult DashboardViewerPartial()
        {
            return PartialView("_DashboardViewerPartial", ViewerExtensionSettings.Model);
        }
        public FileStreamResult DashboardViewerPartialExport()
        {
            return DevExpress.DashboardWeb.Mvc.DashboardViewerExtension.Export("ViewerExtension", ViewerExtensionSettings.Model);
        }

        [ValidateInput(false)]
        public ActionResult QualityDashboardViewerPartial()
        {
            return PartialView("_QualityDashboardViewerPartial", QualityDashboardViewerSettings.Model);
        }
        public FileStreamResult QualityDashboardViewerPartialExport()
        {
            return DevExpress.DashboardWeb.Mvc.DashboardViewerExtension.Export("QualityDashboardViewer", QualityDashboardViewerSettings.Model);
        }
    }
    class QualityDashboardViewerSettings
    {
        public static DevExpress.DashboardWeb.Mvc.DashboardSourceModel Model
        {
            get
            {
                DashboardSourceModel model = new DashboardSourceModel();
                model.DashboardSource = typeof(QualityDashboard);
                return model;
            }
        }
    }

    class ViewerExtensionSettings
    {
        public static DevExpress.DashboardWeb.Mvc.DashboardSourceModel Model
        {
            get
            {
                DashboardSourceModel model = new DashboardSourceModel();
                model.DashboardSource = typeof(TasksDashboard);
                return model;

                //return new DevExpress.DashboardWeb.Mvc.DashboardSourceModel();
            }
        }
    }

}