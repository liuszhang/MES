using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult EnergyConsumption() {
            return DashboardDemoView("EnergyConsumption");
        }

        [ValidateInput(false)]
        public ActionResult EnergyConsumptionPartial() {
            return PartialView("EnergyConsumptionPartial", EnergyConsumptionSettings.Model);
        }

        public FileStreamResult EnergyConsumptionPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", EnergyConsumptionSettings.Model);
        }
    }
}
