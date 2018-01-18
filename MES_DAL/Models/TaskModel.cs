using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MES_DAL.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int ProductID { get; set; }
        
        public int? PlanNumber { get; set; }

        public int? DoneNumber { get; set; }

        public DateTime? PlanStartTime { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? PlanEndTime { get; set; }

        public DateTime? EndTime { get; set; }
        //[DatabaseGenerated()]
        public Decimal? DonePer { get; set; }
        [Required]
        public string Status { get; set; }
        public int? EmployeeID { get; set; }

    }


    public class TaskContext : DbContext
    {
        public TaskContext() : base("name=MESConnection")
        {
            //Database.SetInitializer<TaskContext>(new DropCreateDatabaseIfModelChanges<TaskContext>());
        }
        public System.Data.Entity.DbSet<MES_DAL.Models.Task> Tasks { get; set; }
    }
}