using System;
using System.Data;
using System.Collections.Generic;

namespace DashboardMainDemo {
    public class HumanResourcesData {
        public class HistoryItem {
            DateTime? retDate;
            DateTime? hirDate;

            public DateTime? HiredDate {
                get { return hirDate; }
                set { hirDate = value; }
            }
            public DateTime? RetiredDate {
                get { return retDate; }
                set { retDate = value; }
            }

            public bool IsEmployeed(DateTime dt) {
                return (!HiredDate.HasValue || HiredDate.Value <= dt) && (!RetiredDate.HasValue || RetiredDate.Value >= dt);
            }
            public bool IsRetired(DateTime dt) {
                return RetiredDate.HasValue && RetiredDate.Value == dt;
            }
        }

        const int FullYears = 9;

        static string GetEmployeeFullName(DataRow employee) {
            return (string)employee["FullName"];
        }
        static int GetEmployeeDepartmentID(DataRow employee) {
            return (int)employee["DepartmentID"];
        }
        static string GetDepartmentName(DataRow department) {
            return (string)department["DepartmentName"];
        }
        static decimal GetDepartmentBaseSalary(DataRow department) {
            return (decimal)department["BaseSalary"];
        }

        readonly DataTable employeesTable;
        readonly DataTable departmentsTable;
        readonly DateTime startDate;
        readonly DateTime endDate;
        readonly Dictionary<string, HistoryItem> employeesHistory = new Dictionary<string, HistoryItem>();
        readonly Random rand = new Random();
        readonly Dictionary<DepartmentDataKey, DepartmentData> deptData = new Dictionary<DepartmentDataKey, DepartmentData>();
        readonly List<EmployeeData> empData = new List<EmployeeData>();

        DataRowCollection Employees { get { return employeesTable.Rows; } }
        public IEnumerable<DepartmentData> DepartmentData { get { return deptData.Values; } }
        public IEnumerable<EmployeeData> EmployeeData { get { return empData; } }

        public HumanResourcesData(DataSet dataSet) {
            employeesTable = dataSet.Tables["Employees"];
            departmentsTable = dataSet.Tables["Departments"];
            endDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            endDate = endDate.AddMonths(-1);
            startDate = new DateTime(endDate.Year - FullYears, 1, 1);
            CreateImployeesHistory();
            DateTime dt = startDate;
            while(dt <= endDate) {
                foreach(DataRow employee in Employees) {
                    string fullName = GetEmployeeFullName(employee);
                    HistoryItem historyItem = employeesHistory[fullName];
                    if(historyItem.IsEmployeed(dt)) {
                        int departmentID = GetEmployeeDepartmentID(employee);
                        DataRow department = GetDepartmentByDepartmentID(departmentID);
                        string departmentName = GetDepartmentName(department);
                        DepartmentDataKey departmentDataKey = new DepartmentDataKey(dt, departmentName);
                        DepartmentData departmentDataValue = null;
                        if(!deptData.TryGetValue(departmentDataKey, out departmentDataValue)) {
                            departmentDataValue = new DepartmentData {
                                CurrentDate = dt,
                                Department = departmentName
                            };
                            deptData.Add(departmentDataKey, departmentDataValue);
                        }
                        departmentDataValue.HeadCount++;
                        if(historyItem.IsRetired(dt))
                            departmentDataValue.RetiredCount++;

                        decimal baseSalary = GetDepartmentBaseSalary(department);
                        decimal salary = baseSalary + (decimal)DataHelper.Random(rand, (double)baseSalary / rand.Next(1, 5));
                        decimal bonus = (decimal)DataHelper.Random(rand, (double)salary, true);
                        decimal overtime = (decimal)DataHelper.Random(rand, (double)salary / rand.Next(1, 5), true);

                        int vacationDays = 0;
                        if(rand.NextDouble() > 0.5)
                            vacationDays = rand.Next(0, 10);
                        int sickLeaveDays = 0;
                        if(rand.NextDouble() > 0.5)
                            sickLeaveDays = rand.Next(0, 5);

                        empData.Add(new EmployeeData {
                            CurrentDate = dt,
                            Department = departmentName,
                            Employee = fullName,
                            Salary = salary,
                            Bonus = bonus,
                            Overtime = overtime,
                            VacationDays = vacationDays,
                            SickLeaveDays = sickLeaveDays
                        });
                    }
                }
                dt = dt.AddMonths(1);
            }
            foreach(DepartmentData data in deptData.Values) {
                data.StaffTurnrover = data.HeadCount > 0 ? (double)data.RetiredCount / data.HeadCount : 0;
                data.StaffTurnroverCritical = 0.01;                
            }
        }
        void CreateImployeesHistory() {
            int totalMonths = FullYears * 12 + endDate.Month;
            foreach(DataRow employee in Employees) {
                DateTime? hiredDate = null;
                int hiredMonth = 0;
                if(rand.NextDouble() > 0.2) {
                    hiredMonth = (int)Math.Round(DataHelper.Random(rand, totalMonths, true));
                    hiredDate = startDate.AddMonths(hiredMonth);
                }
                DateTime? retiredDate = null;
                if(rand.NextDouble() > 0.3) {
                    int retiredMonth = (int)Math.Round(DataHelper.Random(rand, totalMonths, true));
                    if(retiredMonth > hiredMonth)
                        retiredDate = startDate.AddMonths(retiredMonth);
                }
                employeesHistory.Add(GetEmployeeFullName(employee), new HistoryItem { HiredDate = hiredDate, RetiredDate = retiredDate });
            }
        }
        DataRow GetDepartmentByDepartmentID(int departmentID) {
            return departmentsTable.Select(string.Format("DepartmentID = {0}", departmentID))[0];
        }
    }

    public class DepartmentData {
        double staffTurnCritical;
        double staffTurn;
        int retCount;
        int hCount;
        string dept;
        DateTime curtDate;

        public DateTime CurrentDate {
            get { return curtDate; }
            set { curtDate = value; }
        }
        public string Department {
            get { return dept; }
            set { dept = value; }
        }
        public int HeadCount {
            get { return hCount; }
            set { hCount = value; }
        }
        public int RetiredCount {
            get { return retCount; }
            set { retCount = value; }
        }
        public double StaffTurnrover {
            get { return staffTurn; }
            set { staffTurn = value; }
        }
        public double StaffTurnroverCritical {
            get { return staffTurnCritical; }
            set { staffTurnCritical = value; }
        }
    }

    public class DepartmentDataKey {
        readonly DateTime dt;
        readonly string dept;

        public DepartmentDataKey(DateTime dt, string dept) {
            this.dt = dt;
            this.dept = dept;
        }
        public override bool Equals(object obj) {
            DepartmentDataKey key = (DepartmentDataKey)obj;
            return key.dt == dt && key.dept == dept;
        }
        public override int GetHashCode() {
            return dt.GetHashCode() ^ dept.GetHashCode();
        }
    }

    public class EmployeeData {
        int sickLDays;
        decimal overt;
        int vacDays;
        decimal bon;
        decimal sal;
        string emp;
        string dept;
        DateTime curtDate;

        public DateTime CurrentDate {
            get { return curtDate; }
            set { curtDate = value; }
        }
        public string Department {
            get { return dept; }
            set { dept = value; }
        }
        public string Employee {
            get { return emp; }
            set { emp = value; }
        }
        public decimal Salary {
            get { return sal; }
            set { sal = value; }
        }
        public decimal Bonus {
            get { return bon; }
            set { bon = value; }
        }
        public decimal Overtime {
            get { return overt; }
            set { overt = value; }
        }
        public int VacationDays {
            get { return vacDays; }
            set { vacDays = value; }
        }
        public int SickLeaveDays {
            get { return sickLDays; }
            set { sickLDays = value; }
        }
    }
}
