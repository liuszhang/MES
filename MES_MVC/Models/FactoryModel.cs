using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MES_MVC.Models
{
    public class Factory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Location { get; set; }

        public virtual ICollection<WorkShop> WorkShops { get; set; }

    }


    public class WorkShop
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int Factory_ID { get; set; }

        public virtual Factory Factory { get; set; }
        public virtual ICollection<ProductLine> ProductLines { get; set; }

    }


    public class ProductLine
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int WorkShop_ID { get; set; }

        public virtual WorkShop WorkShop { get; set; }
        public virtual ICollection<Station> Stations { get; set; }

    }


    public class Station
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int ProductLine_ID { get; set; }

        public virtual ProductLine ProductLine { get; set; }

    }
}