using Lsz.MES.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Web.DynamicData;

namespace Lsz.MES.Data
{
    public class PlanTasksViewModel
    {
        //public static List<PlanTask> Tasks;
        PlanTaskContext db;

        public PlanTasksViewModel()
        {
            db = PlanTaskContext.Create();
            //Tasks = db.Tasks.OrderBy(t => t.Id).ToList();
            //Tasks = new List<PlanTask>();
            //Tasks.Add(new PlanTask { Subject = "1", Product = "1", Description = "1" });
            //Tasks.Add(new PlanTask { Subject = "1", Product = "1", Description = "1" });
            //Tasks.Add(new PlanTask { Subject = "1", Product = "1", Description = "1" });
            //Tasks.Add(new PlanTask { Subject = "1", Product = "1", Description = "1" });
        }

        //[TableName("EmployeeTasks")]
        public object Tasks
        {
            get
            {                
                return new System.Collections.ObjectModel.ObservableCollection<PlanTask>(db.Tasks.OrderBy(i => i.Id));
            }
        }

        

    }
}
