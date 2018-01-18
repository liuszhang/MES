using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MES_DAL.Models;

namespace MES_DAL.Controllers
{
    public class ProductTypesController : Controller
    {
        private ProductTypeContext db = new ProductTypeContext();
        private ProductContext pdb = new ProductContext();

        // GET: ProductTypes
        public ActionResult Index()
        {
            return View(pdb.Products.ToList());
        }       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
