using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

    }


    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=MESConnection")
        {
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.Employee> Employees { get; set; }
    }
}