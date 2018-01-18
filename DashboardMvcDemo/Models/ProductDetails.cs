using System.Web;
using DashboardMainDemo;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.ConnectionParameters;

namespace DevExpress.Web.Demos.Models {
    public class ProductDetailsSettings {
        public static DashboardSourceModel Model {
            get {
                DashboardSourceModel model = new DashboardSourceModel();
                model.DashboardSource = typeof(ProductDetailsDashboard);
                model.ConfigureDataConnection += OnConfigureDataConnection;
                model.DashboardLoaded += OnDashboardLoaded;
                return model;
            }
        }
        static void OnConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e) {
            XmlFileConnectionParameters xmlConnectionParameters = e.ConnectionParameters as XmlFileConnectionParameters;
            xmlConnectionParameters.FileName = DataLoader.GetProductDetailsXmlData();
        }
        static void OnDashboardLoaded(object sender, DashboardLoadedWebEventArgs e) {
            HttpContext currentContext = HttpContext.Current;
            if(currentContext != null) {
                string applicationPath = currentContext.Request.ApplicationPath.TrimEnd('/') + "/";
                BoundImageDashboardItem primaryImage = e.Dashboard.Items["primaryImage"] as BoundImageDashboardItem;
                if(primaryImage != null)
                    primaryImage.UriPattern = applicationPath + "Content/ProductDetailsImages/{0}.jpg";
                BoundImageDashboardItem secondaryImage = e.Dashboard.Items["secondaryImage"] as BoundImageDashboardItem;
                if(secondaryImage != null)
                    secondaryImage.UriPattern = applicationPath + "Content/ProductDetailsImages/{0} Secondary.jpg";
            }
        }
    }
}

