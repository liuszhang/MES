using System.Web.Mvc;
using MES_MVC.Models;

namespace MES_MVC.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult BlogPost(int? id)
        {
            var blogPost = BlogPostsProvider.GetBlogPost(id);
            if(blogPost == null)
                return RedirectToAction("BlogTimeline");
            return View("BlogPost", blogPost);
        }
        public ActionResult BlogTimeline()
        {
            return View();
        }
        public ActionResult BlogPostsDataViewPartial(int? year, int? month)
        {
            ViewBag.Year = year;
            ViewBag.Month = month;
            return PartialView("BlogPostsDataViewPartial", BlogPostsProvider.GetBlogPosts(year, month));
        }
        [ValidateInput(false)]
        public ActionResult Search(string query) {
            ViewBag.ShowSearchEditor = false;
            return View((object)query);
        }
        [ValidateInput(false)]
        public ActionResult SearchGridViewPartial(string query) {
            ViewBag.Query = query;
            return PartialView(BlogPostsProvider.GetBlogPosts());
        }
    }
}