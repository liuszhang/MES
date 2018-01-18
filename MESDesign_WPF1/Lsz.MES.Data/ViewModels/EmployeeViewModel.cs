using Lsz.MES.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lsz.MES.Data
{
    public class EmployeeViewModel
    {
        EmployeeContext db;

        public EmployeeViewModel()
        {
            db = EmployeeContext.Create();
        }

        public object Employee
        {
            get
            {
                return (db.Employees.First());
            }
        }

    }
}
