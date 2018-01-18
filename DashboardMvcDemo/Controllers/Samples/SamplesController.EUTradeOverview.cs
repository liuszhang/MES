using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult EUTradeOverview() {
            return DashboardDemoView("EUTradeOverview");
        }

        [ValidateInput(false)]
        public ActionResult EUTradeOverviewPartial() {
            return PartialView("EUTradeOverviewPartial", EUTradeOverviewSettings.Model);
        }

        public FileStreamResult EUTradeOverviewPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", EUTradeOverviewSettings.Model);
        }

        public ActionResult EUTradeOverviewScripts() {
            return PartialView("EUTradeOverviewScripts", Request.RequestContext.RouteData.GetRequiredString("action"));
        }
    }
}
