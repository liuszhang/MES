using System.Web.Mvc;
using System.Web.UI;
using DevExpress.Web.Internal;

namespace DevExpress.Web.Demos {
    public abstract class DemoController: Controller {
        public const string ViewTitleSuffix = "DevExpress ASP.NET MVC Extensions";

        public abstract string Name { get; }

        public ActionResult DemoView(string actionName) {
            return DemoView(actionName, actionName, null);
        }
        public ActionResult DemoView(string actionName, object model) {
            return DemoView(actionName, actionName, model);
        }
        public ActionResult DemoView(string actionName, string viewName) {
            return DemoView(actionName, viewName, null);
        }
        public ActionResult DemoView(string actionName, string viewName, object model) {
            Utils.RegisterCurrentMvcDemo(Name, actionName);
            return (model != null) ? View(viewName, model) : View(viewName);
        }

        // Specific views
        public ActionResult ClientSideEventsDemoView(string[] events) {
            return ClientSideEventsDemoView(events, null);
        }
        public ActionResult ClientSideEventsDemoView(string[] events, object model) {
            return ClientSideEventsDemoView(events, true, model);
        }
        public ActionResult ClientSideEventsDemoView(string[] events, bool showEventListPanel, object model) {
            ViewData["ClientSideEvents"] = events;
            ViewData["ShowEventListPanel"] = showEventListPanel;
            return DemoView("ClientSideEvents", model);
        }
        protected internal string MapPath(string path) {
            return System.Web.HttpContext.Current.Request.MapPath(path);
        }

#if OfficeDemo
        protected override void OnActionExecuted(ActionExecutedContext filterContext) {
            DirectoryManagmentUtils.PurgeOldUserDirectories();
            base.OnActionExecuted(filterContext);
        }
#endif
    }

    public class DemosHelper {
        public static string GetFieldText(object data, string fieldName) {
            object text = DataBinder.Eval(data, fieldName);
            if (text == null || text.ToString() == string.Empty)
                return "&nbsp";
            return text.ToString();
        }
    }
}
