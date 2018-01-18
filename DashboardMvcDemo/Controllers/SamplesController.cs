using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;

namespace DevExpress.Web.Demos.Controllers
{
    public partial class SamplesController : DemoController {
        public override string Name { get { return "Samples"; } }

        protected virtual ActionResult DashboardDemoView(string actionName) {
            return DemoView(actionName);
        }

        public ActionResult FullscreenButton() {
            return PartialView("FullscreenButton", Request.RequestContext.RouteData.GetRequiredString("action"));
        }

        public ActionResult Index()
        {
            return DemoView("SalesOverview");
        }
    }
}
