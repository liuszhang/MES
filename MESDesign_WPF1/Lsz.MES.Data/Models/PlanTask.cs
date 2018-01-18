using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.DynamicData;

namespace Lsz.MES.Data.Models
{
    [TableName("EmployeeTasks")]
    public class PlanTask
    {
        [Key]
        public int Id { get; set; }
        //public bool Overdue { get; set; }
        public bool AttachedCollectionsChanged { get; set; }
        //public virtual List<TaskAttachedFile> AttachedFiles { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public bool Private { get; set; }
        public int FollowUp { get; set; }
        public long? CustomerEmployeeId { get; set; }
        //public virtual CustomerEmployee CustomerEmployee { get; set; }
        public long? OwnerId { get; set; }
        //public virtual Employee Owner { get; set; }
        public long? AssignedEmployeeId { get; set; }
        public int AttachedFilesCount { get; }
        //public virtual Employee AssignedEmployee { get; set; }
        public bool Reminder { get; set; }
        public int Completion { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string RtfTextDescription { get; set; }
        public string Description { get; set; }
        [Required]
        public string Subject { get; set; }
        //public virtual List<Employee> AssignedEmployees { get; set; }
        public DateTime? ReminderDateTime { get; set; }
        public string AssignedEmployeesFullList { get; }

    }

    public class PlanTaskContext : DbContext
    {
        //[TableName("EmployeeTasks")]
        public DbSet<PlanTask> Tasks { get; set; }

        //public PlanTaskContext():base("DBConnection"){   }
        public PlanTaskContext() : base(CreateConnection(), true) { }
        static PlanTaskContext()
        {
            Database.SetInitializer<PlanTaskContext>(null);
        }
        public static PlanTaskContext Create()
        {            
            return new PlanTaskContext();
        }
        static DbConnection CreateConnection()
        {
            //if (filePath == null)
            //    filePath = DataDirectoryHelper.GetFile("nwind.db", DataDirectoryHelper.DataFolderName);
            //try
            //{
            //    var attributes = File.GetAttributes(filePath);
            //    if (attributes.HasFlag(FileAttributes.ReadOnly))
            //    {
            //        File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
            //    }
            //}
            //catch { }
            var filePath = @"E:\_MyPro\_MESDEV\MESDesign_WPF1\Lsz.MES.Data\DB\devav.db";
            var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            connection.ConnectionString = new SQLiteConnectionStringBuilder { DataSource = filePath }.ConnectionString;
            return connection;
        }
    }

}
