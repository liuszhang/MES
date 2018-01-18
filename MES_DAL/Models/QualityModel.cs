using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class NGType
    {
        [Key]
        public int ID { get; set; }
        [Required]

        public string Name { get; set; }
    }

    public class NG
    {
        [Key]
        public int ID { get; set; }

        public int TaskID { get; set; }

        public int NGNumber { get; set; }

        public int NGTypeID { get; set; }
    }
}