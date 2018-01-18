using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class FactoryContext:DbContext
    {
        public FactoryContext() : base("name=MESConnection")
        {
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.Factory> Factories { get; set; }
    }

    public class WorkShopContext : DbContext
    {
        public WorkShopContext() : base("name=MESConnection")
        {
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.WorkShop> WorkShops { get; set; }
    }

    public class LineContext : DbContext
    {
        public LineContext() : base("name=MESConnection")
        {
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.Line> Lines { get; set; }
    }

    public class StationContext : DbContext
    {
        public StationContext() : base("name=MESConnection")
        {
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.Station> Stations { get; set; }
    }
}