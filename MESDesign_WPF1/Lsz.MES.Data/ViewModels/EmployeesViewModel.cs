using Lsz.MES.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lsz.MES.Data
{
    public class EmployeesViewModel
    {
        EmployeeContext db;

        public EmployeesViewModel()
        {
            db = EmployeeContext.Create();
        }

        public object Employees
        {
            get
            {
                return new System.Collections.ObjectModel.ObservableCollection<Employee>(db.Employees.OrderBy(i => i.Id));
            }
        }

    }
}
