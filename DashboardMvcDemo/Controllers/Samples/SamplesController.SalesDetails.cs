using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult SalesDetails() {
            return DashboardDemoView("SalesDetails");
        }

        [ValidateInput(false)]
        public ActionResult SalesDetailsPartial() {
            return PartialView("SalesDetailsPartial", SalesDetailsSettings.Model);
        }

        public FileStreamResult SalesDetailsPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", SalesDetailsSettings.Model);
        }

        public ActionResult SalesDetailsScripts() {
            return PartialView("SalesDetailsScripts", Request.RequestContext.RouteData.GetRequiredString("action"));
        }
    }
}
