using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult RevenueByIndustry() {
            return DashboardDemoView("RevenueByIndustry");
        }

        [ValidateInput(false)]
        public ActionResult RevenueByIndustryPartial() {
            return PartialView("RevenueByIndustryPartial", RevenueByIndustrySettings.Model);
        }

        public FileStreamResult RevenueByIndustryPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", RevenueByIndustrySettings.Model);
        }
    }
}
