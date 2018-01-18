using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class Factory
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

    }

    public class WorkShop
    {
        public int ID { get; set; }

        public string Name { get; set; }
        [Required]
        public int FactoryID { get; set; }

    }

    public class Line
    {
        public int ID { get; set; }

        public string Name { get; set; }
        [Required]
        public int WorkShopID { get; set; }

    }

    public class Station
    {
        public int ID { get; set; }

        public string Name { get; set; }
        [Required]
        public int LineID { get; set; }

    }
}