using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult RevenueAnalysis() {
            return DashboardDemoView("RevenueAnalysis");
        }

        [ValidateInput(false)]
        public ActionResult RevenueAnalysisPartial() {
            return PartialView("RevenueAnalysisPartial", RevenueAnalysisSettings.Model);
        }

        public FileStreamResult RevenueAnalysisPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", RevenueAnalysisSettings.Model);
        }
    }
}
