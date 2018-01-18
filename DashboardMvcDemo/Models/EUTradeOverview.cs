using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DashboardCommon;

namespace DevExpress.Web.Demos.Models {
    public class EUTradeOverviewSettings {
        public static DashboardSourceModel Model {
            get {
                DashboardSourceModel model = new DashboardSourceModel();
                model.DashboardSource = typeof(EUTradeOverviewDashboard);
                return model;
            }
        }
    }
}
