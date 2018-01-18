using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult CustomerSupport() {
            return DashboardDemoView("CustomerSupport");
        }

        [ValidateInput(false)]
        public ActionResult CustomerSupportPartial() {
            return PartialView("CustomerSupportPartial", CustomerSupportSettings.Model);
        }

        public FileStreamResult CustomerSupportPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", CustomerSupportSettings.Model);
        }
    }
}
