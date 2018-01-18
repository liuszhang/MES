using System.Data;
using System;
using System.Collections.Generic;

namespace DashboardMainDemo {
    public class CustomerSupportData {
        public class CustomerSupportItem {
            int resTime;
            DateTime open;
            int itIndex;
            string it;
            string emp;
            string cust;
            string prodName;

            public string ProductName {
                get { return prodName; }
                set { prodName = value; }
            }
            public string Customer {
                get { return cust; }
                set { cust = value; }
            }
            public string Employee {
                get { return emp; }
                set { emp = value; }
            }
            public string IssueType {
                get { return it; }
                set { it = value; }
            }
            public int IssueTypeIndex {
                get { return itIndex; }
                set { itIndex = value; }
            }
            public DateTime Opened {
                get { return open; }
                set { open = value; }
            }
            public int ResolvedTime {
                get { return resTime; }
                set { resTime = value; }
            }
        }

        readonly Random rand = new Random();
        readonly string issueTypesTableName = "IssueTypes";
        readonly string productsTableName = "Products";
        DataTable employees, products, issueTypes;
        int issueDistributionCount;
        int employeeCount;
        DateTime endDate = DateTime.Today;
        DateTime startDate = new DateTime(DateTime.Today.Year - 1, 1, 1);
        int startYear = DateTime.Today.Year;
        int productCount;
        int customerCount;
        int issueTypesCount;
        readonly List<CustomerSupportItem> items = new List<CustomerSupportItem>();

        public CustomerSupportData(DataSet dsCustomerSupport, DataSet dsEmployees) {
            LoadDataTables(dsCustomerSupport, dsEmployees);
            List<int> monthResolvedDeviation = GetMonthResolvedDeviation();
            List<int> monthIssuesDeviation = GetMonthIssuesDeviation();
            Dictionary<int, int> yearDeviation = GetYearDeviation();
            Dictionary<int, int> employeeProducts = GetEmployeeByProduct();
            List<List<int>> employeeSolvedDev = GetEmployeeSolvedDeviation();
            List<List<int>> issueDistribution = GetIssueDistribution();

            while (startDate < endDate) {
                int count = rand.Next(monthIssuesDeviation[startDate.Month], monthIssuesDeviation[startDate.Month] + yearDeviation[startDate.Year] + 5);
                for (int i = 0; i < count; i++) {
                    int employeeIndex = rand.Next(0, employeeCount);
                    int customerIndex = rand.Next(employeeCount - 1, customerCount);
                    int productIndex = employeeProducts[employeeIndex];
                    int issueTypeIndex = issueDistribution[productIndex][rand.Next(0, issueDistributionCount)];

                    int issueSolvedAverage = (int)issueTypes.Rows[issueTypeIndex][3];
                    int issueSolvedDev = (int)issueTypes.Rows[issueTypeIndex][4] + employeeSolvedDev[employeeIndex][issueTypeIndex];

                    items.Add(new CustomerSupportItem() {
                        ProductName = (string)products.Rows[productIndex][1],
                        Customer = (string)employees.Rows[customerIndex][1],
                        Employee = (string)employees.Rows[employeeIndex][1],
                        IssueType = (string)issueTypes.Rows[issueTypeIndex][1],
                        IssueTypeIndex = (int)issueTypes.Rows[issueTypeIndex][2],
                        ResolvedTime = rand.Next(Math.Max(0, issueSolvedAverage - issueSolvedDev), issueSolvedAverage + issueSolvedDev + monthResolvedDeviation[startDate.Month] - 2 * (startDate.Year - startYear)),
                        Opened = startDate
                    });
                }
                startDate = startDate.AddDays(1);
            }
        }

        public IEnumerable<CustomerSupportItem> CustomerSupport { get { return items; } }

        void LoadDataTables(DataSet dsCustomerSupport, DataSet dsEmployees) {
            employees = dsEmployees.Tables["Employees"];
            products = dsCustomerSupport.Tables[productsTableName];
            issueTypes = dsCustomerSupport.Tables[issueTypesTableName];
            productCount = products.Rows.Count;
            customerCount = employees.Rows.Count;
            issueTypesCount = issueTypes.Rows.Count;
        }
        List<int> GetMonthResolvedDeviation() {
            List<int> monthResolvedDeviation = new List<int>(12);
            for (int i = 0; i <= 12; i++) {
                monthResolvedDeviation.Add(rand.Next(0, 10));
            }
            return monthResolvedDeviation;
        }
        List<int> GetMonthIssuesDeviation() {
            List<int> monthIssuesDeviation = new List<int>(12);
            for (int i = 0; i <= 12; i++) {
                monthIssuesDeviation.Add(rand.Next(15, 20));
            }
            monthIssuesDeviation[5] -= 2;
            monthIssuesDeviation[6] -= 7;
            monthIssuesDeviation[7] -= 8;
            monthIssuesDeviation[8] -= 9;
            return monthIssuesDeviation;
        }
        Dictionary<int, int> GetYearDeviation() {
            Dictionary<int, int> yearDeviation = new Dictionary<int, int>();
            for (int i = startDate.Year; i <= endDate.Year; i++)
                yearDeviation.Add(i, rand.Next(0, 10) + i - startYear);
            return yearDeviation;
        }
        Dictionary<int, int> GetEmployeeByProduct() {
            Dictionary<int, int> employeeProducts = new Dictionary<int, int>();
            employeeCount = -1;
            for (int i = 0; i < productCount; i++)
                for (int j = 0; j < (int)products.Rows[i][2]; j++)
                    employeeProducts.Add(++employeeCount, i);
            employeeCount++;
            return employeeProducts;
        }
        List<List<int>> GetEmployeeSolvedDeviation() {
            List<List<int>> employeeSolvedDev = new List<List<int>>();
            for (int i = 0; i < employeeCount; i++) {
                employeeSolvedDev.Add(new List<int>(issueTypesCount));
                int solveDev = rand.Next(0, 5);
                for (int j = 0; j < issueTypesCount; j++)
                    employeeSolvedDev[i].Add(rand.Next(solveDev - j, solveDev + j));
            }
            return employeeSolvedDev;
        }
        List<List<int>> GetIssueDistribution() {
            List<List<int>> issueDistribution = new List<List<int>>();
            for (int k = 0; k < productCount; k++) {
                issueDistribution.Add(new List<int>());
                for (int i = 0; i < issueTypesCount; i++) {
                    int count = rand.Next((int)issueTypes.Rows[i][5] - 1, (int)issueTypes.Rows[i][5] + 1);
                    for (int j = 0; j < count; j++)
                        issueDistribution[k].Add(i);
                }
            }
            issueDistributionCount = Int32.MaxValue;
            for (int i = 0; i < issueDistribution.Count; i++)
                issueDistributionCount = Math.Min(issueDistributionCount, issueDistribution[i].Count);
            return issueDistribution;
        }
    }
}
