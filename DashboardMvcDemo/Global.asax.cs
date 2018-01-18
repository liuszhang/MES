using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new {
                    controller = "Home", action = "Index", id = ""
                }  // Parameter defaults
            );
        }

        protected void Application_Start() {
            RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.DefaultBinder = new DevExpressEditorsBinder();
            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(CallbackError);
        }

        void CallbackError(object sender, EventArgs e) {
            // Logging exceptions occur on callback events of DevExpress ASP.NET MVC controls. 
            // To learn more, see http://www.devexpress.com/Support/Center/Example/Details/E4588
            var exception = HttpContext.Current.Server.GetLastError();
            if(exception is DemoException) {
                DevExpress.Web.ASPxWebControl.SetCallbackErrorMessage(exception.Message);
            }
        }

        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e) {
            DevExpressHelper.Theme = Utils.CurrentTheme;
            Utils.ResolveThemeParametes();
            if(DevExpressHelper.IsCallback)
                Utils.RegisterCurrentMvcDemoOnCallback();

            if (Utils.IsAccessibilityDemo)
                DevExpress.Web.ASPxWebControl.GlobalAccessibilityCompliant = true;
        }
    }
}
