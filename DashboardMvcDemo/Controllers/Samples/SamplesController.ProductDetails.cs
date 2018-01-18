using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult ProductDetails() {
            return DashboardDemoView("ProductDetails");
        }

        [ValidateInput(false)]
        public ActionResult ProductDetailsPartial() {
            return PartialView("ProductDetailsPartial", ProductDetailsSettings.Model);
        }

        public FileStreamResult ProductDetailsPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", ProductDetailsSettings.Model);
        }
    }
}
