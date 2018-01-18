using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;

namespace DevExpress.Web.Demos.Models {
    public class ChampionsLeagueStatisticsSettings {
        public static DashboardSourceModel Model {
            get {
                DashboardSourceModel model = new DashboardSourceModel();
                model.DashboardSource = typeof(ChampionsLeagueStatisticsDashboard);
                model.MasterFilterDefaultValues += OnMasterFilterDefaultValues;
                return model;
            }
        }
        static void OnMasterFilterDefaultValues(object sender, MasterFilterDefaultValuesWebEventArgs e) {
            if(e.ItemComponentName == "scatterChartLeagueStatistics") {
                DashboardDataRow selRow = e.AvailableFilterValues.FirstOrDefault(row => object.Equals(row[0], "Spain"));
                if(selRow != null)
                    e.FilterValues = new[] { selRow };
            }
        }
    }
}
