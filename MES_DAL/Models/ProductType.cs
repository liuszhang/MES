using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class ProductType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

    }
}