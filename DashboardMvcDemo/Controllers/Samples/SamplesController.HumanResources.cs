using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult HumanResources() {
            return DashboardDemoView("HumanResources");
        }

        [ValidateInput(false)]
        public ActionResult HumanResourcesPartial() {
            return PartialView("HumanResourcesPartial", HumanResourcesSettings.Model);
        }

        public FileStreamResult HumanResourcesPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", HumanResourcesSettings.Model);
        }
    }
}
