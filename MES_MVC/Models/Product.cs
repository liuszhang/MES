using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MES_MVC.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public int Count { get; set; }

        public string Description { get; set; }

        public ProductType Type { get; set; }

        
    }
}