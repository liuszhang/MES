using MES_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MES_DAL.ViewModels
{
    public class FactoryViewModel
    {
        public Factory Factory { get; set; }

        public WorkShop WorkShop { get; set; }

        public Line Line { get; set; }

        public Station Station { get; set; }

    }
}