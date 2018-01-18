using System;
using System.Data;
using System.Collections.Generic;

namespace DashboardMainDemo {
    public class RevenueAnalysisDataGenerator : SalesDataGenerator {
        public class DataItem {
            int uSold;
            decimal rev;
            string prod;
            string cat;
            string st;
            int y;

            public int Year {
                get { return y; }
                set { y = value; }
            }
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
            public decimal Revenue {
                get { return rev; }
                set { rev = value; }
            }
            public int UnitsSold {
                get { return uSold; }
                set { uSold = value; }
            }
        }

        const int YearsCount = 3;

        readonly List<DataItem> dat = new List<DataItem>();

        public IEnumerable<DataItem> Data { get { return dat; } }

        public RevenueAnalysisDataGenerator(DataSet dataSet)
            : base(dataSet) {
        }
        protected override void Generate(Context context) {
            int startYear = DateTime.Today.Year - YearsCount;
            for(int i = 0; i < YearsCount; i++) {
                int year = startYear + i;
                context.UnitsSoldGenerator.Next();
                int unitsSold = context.UnitsSoldGenerator.UnitsSold * 12;
                decimal revenue = unitsSold * context.ListPrice;
                dat.Add(new DataItem {
                    State = context.State,
                    Category = context.CategoryName,
                    Product = context.ProductName,
                    Year = year,
                    Revenue = revenue,
                    UnitsSold = unitsSold
                });
            }
        }
    }
}
