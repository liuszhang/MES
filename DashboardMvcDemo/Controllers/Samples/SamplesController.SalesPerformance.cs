using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult SalesPerformance() {
            return DashboardDemoView("SalesPerformance");
        }

        [ValidateInput(false)]
        public ActionResult SalesPerformancePartial() {
            return PartialView("SalesPerformancePartial", SalesPerformanceSettings.Model);
        }

        public FileStreamResult SalesPerformancePartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", SalesPerformanceSettings.Model);
        }
    }
}
