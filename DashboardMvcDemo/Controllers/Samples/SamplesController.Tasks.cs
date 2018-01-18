using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult Tasks() {
            return DashboardDemoView("Tasks");
        }

        [ValidateInput(false)]
        public ActionResult TasksPartial() {
            return PartialView("TasksPartial", TasksSettings.Model);
        }

        public FileStreamResult TasksPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", TasksSettings.Model);
        }

        public ActionResult TasksScripts()
        {
            return PartialView("TasksScripts", Request.RequestContext.RouteData.GetRequiredString("action"));
        }
    }
}
