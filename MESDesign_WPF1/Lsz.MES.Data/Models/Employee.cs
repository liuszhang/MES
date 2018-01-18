using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;

namespace Lsz.MES.Data.Models
{

    public class Employee
    {
        [Key]
        public int Id { get; set; }
        //public ICollection<Quote> Quotes { get; set; }
        //public ICollection<Product> SupportedProducts { get; set; }
        //public ICollection<Product> Products { get; set; }
        //public ICollection<Order> Orders { get; set; }
        //public ICollection<Evaluation> EvaluationsCreatedBy { get; set; }
        [NotMapped]
        public Image Photo { get; set; }
        //public Address Address { get; set; }
        public string Address_Line { get; set; }
        public string Address_City { get; set; }
        public string Address_ZipCode { get; set; }
        public long? PictureId { get; set; }
        public virtual Picture Picture { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }
        public string Skype { get; set; }
        //[EmailAddress]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Mobile Phone")]
        //[Phone]
        [Required]
        public string MobilePhone { get; set; }
        [Display(Name = "Home Phone")]
        //[Phone]
        public string HomePhone { get; set; }
        //public PersonPrefix Prefix { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [InverseProperty("AssignedEmployees")]
        //public virtual List<EmployeeTask> AssignedEmployeeTasks { get; set; }
        //public EmployeeDepartment Department { get; set; }
        [Required]
        public string Title { get; set; }
        //public EmployeeStatus Status { get; set; }
        //public ICollection<CustomerCommunication> Employees { get; set; }
        //[InverseProperty("AssignedEmployee")]
       // public virtual List<EmployeeTask> AssignedTasks { get; set; }
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }
        //[InverseProperty("Employee")]
        //public virtual List<Evaluation> Evaluations { get; set; }
        public string PersonalProfile { get; set; }
        public long? ProbationReason_Id { get; set; }
        //public virtual Probation ProbationReason { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        //[InverseProperty("Owner")]
        //public virtual List<EmployeeTask> OwnedTasks { get; set; }
        [Display(Name = "Full Name")]
        [NotMapped]
        public string FullNameBindable { get; set; }

        //public void ResetBindable();
        //public override string ToString();
    }




    public class EmployeeContext : DbContext
    {
        //[TableName("EmployeeTasks")]
        public DbSet<Employee> Employees { get; set; }

        //public PlanTaskContext():base("DBConnection"){   }
        public EmployeeContext() : base(CreateConnection(), true) { }
        static EmployeeContext()
        {
            Database.SetInitializer<EmployeeContext>(null);
        }
        public static EmployeeContext Create()
        {
            return new EmployeeContext();
        }
        static DbConnection CreateConnection()
        {            
            var filePath = @"E:\_MyPro\_MESDEV\MESDesign_WPF1\Lsz.MES.Data\DB\devav.db";
            var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            connection.ConnectionString = new SQLiteConnectionStringBuilder { DataSource = filePath }.ConnectionString;
            return connection;
        }
    }

}