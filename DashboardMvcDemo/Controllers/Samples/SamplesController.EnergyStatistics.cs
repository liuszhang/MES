using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult EnergyStatistics() {
            return DashboardDemoView("EnergyStatistics");
        }

        [ValidateInput(false)]
        public ActionResult EnergyStatisticsPartial() {
            return PartialView("EnergyStatisticsPartial", EnergyStatisticsSettings.Model);
        }

        public FileStreamResult EnergyStatisticsPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", EnergyStatisticsSettings.Model);
        }
    }
}
