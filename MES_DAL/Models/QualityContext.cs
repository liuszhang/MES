using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class NGTypeContext : DbContext
    {
        public NGTypeContext() : base("name=MESConnection")
        {
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.NGType> NGTypes { get; set; }
    }

    public class NGContext : DbContext
    {
        public NGContext() : base("name=MESConnection")
        {
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.NG> NGs { get; set; }
    }
}