using System;
using System.Data;
using System.Collections.Generic;

namespace DashboardMainDemo {
    public class SalesDetailsDataGenerator : SalesDataGenerator {
        public class DataItem {
            int retTarget;
            int ret;
            int uSoldTarget;
            int uSold;
            int uReceived;
            decimal revTarget;
            decimal rev;
            DateTime curtDate;
            string prod;
            string cat;
            string st;

            public string State {
                get { return st; }
                set { st = value; }
            }
            public string Category {
                get { return cat; }
                set { cat = value; }
            }
            public string Product {
                get { return prod; }
                set { prod = value; }
            }
            public DateTime CurrentDate {
                get { return curtDate; }
                set { curtDate = value; }
            }
            public decimal Revenue {
                get { return rev; }
                set { rev = value; }
            }
            public decimal RevenueTarget {
                get { return revTarget; }
                set { revTarget = value; }
            }
            public int UnitsSold {
                get { return uSold; }
                set { uSold = value; }
            }
            public int UnitsSoldTarget {
                get { return uSoldTarget; }
                set { uSoldTarget = value; }
            }
            public int Returns {
                get { return ret; }
                set { ret = value; }
            }
            public int ReturnsTarget {
                get { return retTarget; }
                set { retTarget = value; }
            }
            public int UnitsReceived {
                get { return uReceived; }
                set { uReceived = value; }
            }
        }

        readonly List<DataItem> dat = new List<DataItem>();

        public IEnumerable<DataItem> Data { get { return dat; } }

        public SalesDetailsDataGenerator(DataSet dataSet)
            : base(dataSet) {
        }
        protected override void Generate(Context context) {
            Random rand = Random;
            int year = DateTime.Today.Year - 1;
            for(int month = 1; month <= 12; month++) {
                DateTime _date = new DateTime(year, month, 1);
                context.UnitsSoldGenerator.Next();
                int uSold = context.UnitsSoldGenerator.UnitsSold;
                int uSoldTarget = context.UnitsSoldGenerator.UnitsSoldTarget;
                int ret = (int)Math.Round(uSold * rand.NextDouble() * 0.5);
                int retTarget = (int)Math.Round(uSoldTarget * 0.25);
                int uReceived = uSold + rand.Next(-2, 3);
                decimal rev = (uSold - ret) * context.ListPrice;
                decimal revTarget = (uSoldTarget - retTarget) * context.ListPrice;
                dat.Add(new DataItem {
                    State = context.State,
                    Category = context.CategoryName,
                    Product = context.ProductName,
                    CurrentDate = _date,
                    UnitsSold = uSold,
                    UnitsSoldTarget = uSoldTarget,
                    Returns = ret,
                    ReturnsTarget = retTarget,
                    Revenue = rev,
                    RevenueTarget = revTarget,
                    UnitsReceived = uReceived
                });
            }
        }
    }
}
