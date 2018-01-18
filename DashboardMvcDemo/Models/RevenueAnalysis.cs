using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DashboardWeb.Mvc;

namespace DevExpress.Web.Demos.Models {
    public class RevenueAnalysisSettings {
        public static DashboardSourceModel Model {
            get {
                return new DashboardSourceModel() {
                    DashboardSource = typeof(RevenueAnalysisDashboard),
                };
            }
        }
    }
}
