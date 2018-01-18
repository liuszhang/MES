using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MES_MVC.Models
{
    //public class FactoryContext: DbContext
    //{
    //    public FactoryContext()
    //    : base("name=MESConnection")
    //    {
    //        Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FactoryContext>());
    //    }
    //    public DbSet<Factory> Factories { get; set; }
    //    public DbSet<ProductLine> ProductLines { get; set; }
    //    public DbSet<Station> Stations { get; set; }
    //    public DbSet<WorkShop> WorkShops { get; set; }

    //}


    public class StationContext : DbContext
    {
        public StationContext()
        : base("name=MESConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<StationContext>());
        }

        public DbSet<Station> Stations { get; set; }

    }


    public class ProductLineContext : DbContext
    {
        public ProductLineContext()
        : base("name=MESConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProductLineContext>());
        }
        
        public DbSet<ProductLine> ProductLines { get; set; }

    }


    public class WorkShopContext : DbContext
    {
        public WorkShopContext()
        : base("name=MESConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WorkShopContext>());
        }
        public DbSet<WorkShop> WorkShops { get; set; }

    }


    public class FactoryContext : DbContext
    {
        public FactoryContext()
        : base("name=MESConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<FactoryContext>());
        }
        public DbSet<Factory> Factories { get; set; }

    }
}