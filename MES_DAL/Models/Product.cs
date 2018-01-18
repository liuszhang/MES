using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string SeriNum { get; set; }

        public int Count { get; set; }
        
        public int TypeID { get; set; }

    }
}