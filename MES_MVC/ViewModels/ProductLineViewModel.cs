using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MES_MVC.Controllers;
using MES_MVC.Models;

namespace MES_MVC.ViewModels
{
    public class ProductLineViewModel
    {
        public enum ProductLineEnum
        {

        }

        public static List<string> ProductLineList;

        static ProductLineViewModel()
        {
            //ProductLineContext db = new ProductLineContext();
            ////var productLines;
            //foreach (ProductLine line in db.ProductLines){
            //    ProductLineList.Add(line.Name);
            //};               
        }

    }
}