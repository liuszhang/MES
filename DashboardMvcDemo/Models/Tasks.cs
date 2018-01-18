using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DashboardCommon;

namespace DevExpress.Web.Demos.Models {
    public class TasksSettings {
        public static DashboardSourceModel Model {
            get {
                DashboardSourceModel model = new DashboardSourceModel();
                model.DashboardSource = typeof(TasksDashboard);
                return model;
            }
        }
    }
}
