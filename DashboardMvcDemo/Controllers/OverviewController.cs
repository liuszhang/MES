using System.Web.Mvc;
using System.Collections;
using DevExpress.Web.Mvc;
using DevExpress.Web.Demos.Models;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.DashboardWeb.Mvc;

namespace DevExpress.Web.Demos {
	public partial class OverviewController : DemoController {
		public override string Name { get { return ""; } }

		public ActionResult Index() {
			return DemoView("Overview");
		}

		[ValidateInput(false)]
		public ActionResult OverviewPartial() {
			return PartialView("OverviewPartial", OverviewSettings.Model);
		}

		public FileStreamResult OverviewPartialExport() {
			return DashboardViewerExtension.Export("dashboardViewer1", OverviewSettings.Model);
		}
	}
}
