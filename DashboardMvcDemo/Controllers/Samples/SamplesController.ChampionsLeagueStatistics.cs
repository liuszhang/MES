using System.Web.Mvc;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.Web.Demos.Models;

namespace DevExpress.Web.Demos.Controllers {
    public partial class SamplesController : DemoController {

        public ActionResult ChampionsLeagueStatistics() {
            return DashboardDemoView("ChampionsLeagueStatistics");
        }

        [ValidateInput(false)]
        public ActionResult ChampionsLeagueStatisticsPartial() {
            return PartialView("ChampionsLeagueStatisticsPartial", ChampionsLeagueStatisticsSettings.Model);
        }

        public FileStreamResult ChampionsLeagueStatisticsPartialExport() {
            return DashboardViewerExtension.Export("dashboardViewer1", ChampionsLeagueStatisticsSettings.Model);
        }
    }
}
