using System.Web.Mvc;

namespace MES_MVC.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
    }
}