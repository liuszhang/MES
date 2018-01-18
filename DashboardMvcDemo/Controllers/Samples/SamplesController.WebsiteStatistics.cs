using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult WebsiteStatistics() {
            return DashboardDemoView("WebsiteStatistics");
        }

        [ValidateInput(false)]
        public ActionResult WebsiteStatisticsPartial() {
            return PartialView("WebsiteStatisticsPartial", WebsiteStatisticsSettings.Model);
        }

        public FileStreamResult WebsiteStatisticsPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", WebsiteStatisticsSettings.Model);
        }
    }
}
