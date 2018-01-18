using System;
using System.Collections.Generic;
using System.Data;

namespace DashboardMainDemo {
    public class SalesPerformanceDataGenerator : SalesDataGenerator {
        public class TotalSalesItem {
            int uSoldYTDTarget;
            int uSoldYTD;
            decimal revQTDTarget;
            decimal revQTD;
            decimal revYTDTarget;
            decimal revYTD;
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
            public decimal RevenueYTD {
                get { return revYTD; }
                set { revYTD = value; }
            }
            public decimal RevenueYTDTarget {
                get { return revYTDTarget; }
                set { revYTDTarget = value; }
            }
            public decimal RevenueQTD {
                get { return revQTD; }
                set { revQTD = value; }
            }
            public decimal RevenueQTDTarget {
                get { return revQTDTarget; }
                set { revQTDTarget = value; }
            }
            public int UnitsSoldYTD {
                get { return uSoldYTD; }
                set { uSoldYTD = value; }
            }
            public int UnitsSoldYTDTarget {
                get { return uSoldYTDTarget; }
                set { uSoldYTDTarget = value; }
            }
        }

        public class MonthlySalesItem {
            int uSoldTarget;
            int uSold;
            decimal revTarget;
            decimal rev;
            DateTime curtDate;
            string cat;
            string prod;
            string st;

            public string State {
                get { return st; }
                set { st = value; }
            }
            public string Product {
                get { return prod; }
                set { prod = value; }
            }
            public string Category {
                get { return cat; }
                set { cat = value; }
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
        }

        public class KeyMetricsItem {
            float marShare;
            int newCustYTDTarget;
            int newCustYTD;
            decimal avgOrdrSizeYTDTarget;
            decimal avgOrdrSizeYTD;
            decimal proYTDTarget;
            decimal proYTD;
            decimal expYTDTarget;
            decimal expYTD;
            decimal revYTDTarget;
            decimal revYTD;

            public decimal RevenueYTD {
                get { return revYTD; }
                set { revYTD = value; }
            }
            public decimal RevenueYTDTarget {
                get { return revYTDTarget; }
                set { revYTDTarget = value; }
            }
            public decimal ExpencesYTD {
                get { return expYTD; }
                set { expYTD = value; }
            }
            public decimal ExpencesYTDTarget {
                get { return expYTDTarget; }
                set { expYTDTarget = value; }
            }
            public decimal ProfitYTD {
                get { return proYTD; }
                set { proYTD = value; }
            }
            public decimal ProfitYTDTarget {
                get { return proYTDTarget; }
                set { proYTDTarget = value; }
            }
            public decimal AvgOrderSizeYTD {
                get { return avgOrdrSizeYTD; }
                set { avgOrdrSizeYTD = value; }
            }
            public decimal AvgOrderSizeYTDTarget {
                get { return avgOrdrSizeYTDTarget; }
                set { avgOrdrSizeYTDTarget = value; }
            }
            public int NewCustomersYTD {
                get { return newCustYTD; }
                set { newCustYTD = value; }
            }
            public int NewCustomersYTDTarget {
                get { return newCustYTDTarget; }
                set { newCustYTDTarget = value; }
            }
            public float MarketShare {
                get { return marShare; }
                set { marShare = value; }
            }
        }

        readonly List<MonthlySalesItem> monthlySales = new List<MonthlySalesItem>();
        readonly List<TotalSalesItem> totalSales = new List<TotalSalesItem>();
        readonly KeyMetricsItem item = new KeyMetricsItem();

        public IEnumerable<MonthlySalesItem> MonthlySales { get { return monthlySales; } }
        public IEnumerable<TotalSalesItem> TotalSales { get { return totalSales; } }
        public IEnumerable<KeyMetricsItem> KeyMetrics { get { return new KeyMetricsItem[] { item }; } }

        public SalesPerformanceDataGenerator(DataSet dataSet)
            : base(dataSet) {
        }
        protected override void Generate(Context context) {
            TotalSalesItem tsItem = new TotalSalesItem { State = context.State, Category = context.CategoryName, Product = context.ProductName };
            int y = DateTime.Today.Year - 1;
            for(int month = 1; month <= 12; month++) {
                DateTime dt = new DateTime(y, month, 1);
                context.UnitsSoldGenerator.Next();
                int uSold = context.UnitsSoldGenerator.UnitsSold;
                int uSoldTarget = context.UnitsSoldGenerator.UnitsSoldTarget;
                decimal rev = uSold * context.ListPrice;
                decimal revTarget = uSoldTarget * context.ListPrice;
                monthlySales.Add(new MonthlySalesItem {
                    State = context.State,
                    Product = context.ProductName,
                    Category = context.CategoryName,
                    CurrentDate = dt,
                    UnitsSold = uSold,
                    UnitsSoldTarget = uSoldTarget,
                    Revenue = rev,
                    RevenueTarget = revTarget
                });
                tsItem.RevenueYTD += rev;
                tsItem.RevenueYTDTarget += revTarget;
                tsItem.UnitsSoldYTD += uSold;
                tsItem.UnitsSoldYTDTarget += uSoldTarget;
                if(month >= 10 && month <= 12) {
                    tsItem.RevenueQTD += rev;
                    tsItem.RevenueQTDTarget += revTarget;
                }
                item.RevenueYTD += rev;
                item.RevenueYTDTarget += revTarget;
            }
            totalSales.Add(tsItem);
        }
        protected override void EndGenerate() {
            base.EndGenerate();
            item.ExpencesYTD = item.RevenueYTDTarget * 0.2m;
            item.ExpencesYTDTarget = item.RevenueYTDTarget * 0.1999m;
            item.ProfitYTD = item.RevenueYTD - item.ExpencesYTD;
            item.ProfitYTDTarget = item.RevenueYTDTarget - item.ExpencesYTDTarget;
            item.AvgOrderSizeYTD = item.RevenueYTD * 0.006m;
            item.AvgOrderSizeYTDTarget = item.RevenueYTDTarget * 0.0055m;
            item.NewCustomersYTD = (int)Math.Round(item.RevenueYTD * 0.0013m);
            item.NewCustomersYTDTarget = (int)Math.Round(item.RevenueYTDTarget * 0.00125m);
            item.MarketShare = 0.23f;
        }
    }
}
