using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult SalesOverview() {
            return DashboardDemoView("SalesOverview");
        }

        [ValidateInput(false)]
        public ActionResult SalesOverviewPartial() {
            return PartialView("SalesOverviewPartial", SalesOverviewSettings.Model);
        }

        public FileStreamResult SalesOverviewPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", SalesOverviewSettings.Model);
        }
    }
}
