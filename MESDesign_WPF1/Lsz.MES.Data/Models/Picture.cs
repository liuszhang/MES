using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Lsz.MES.Data.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }

        public byte[] Data { get; set; }
    }
}
