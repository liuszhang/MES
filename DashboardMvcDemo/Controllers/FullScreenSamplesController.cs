using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {

    public class FullScreenSamplesController : SamplesController {

        public override string Name { get { return "FullScreenSamples"; } }

        protected override ActionResult DashboardDemoView(string actionName) {
            return View(actionName);
        }
    }
}
