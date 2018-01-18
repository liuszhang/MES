using System;
using System.Collections.Generic;
using System.Data;

namespace DashboardMainDemo {
    public class SalesOverviewDataGenerator : SalesDataGenerator {
        public class DataItem {
            decimal sTarget;
            decimal sal;
            DateTime curtDate;
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
            public DateTime CurrentDate {
                get { return curtDate; }
                set { curtDate = value; }
            }
            public decimal Sales {
                get { return sal; }
                set { sal = value; }
            }
            public decimal SalesTarget {
                get { return sTarget; }
                set { sTarget = value; }
            }
        }

        public class DataKey {
            readonly string state;
            readonly string category;
            readonly DateTime dt;

            public DataKey(string state, string category, DateTime dt) {
                this.state = state;
                this.category = category;
                this.dt = dt;
            }
            public override bool Equals(object obj) {
                DataKey key = (DataKey)obj;
                return key.state == state && key.category == category && key.dt == dt;
            }
            public override int GetHashCode() {
                return state.GetHashCode() ^ category.GetHashCode() ^ dt.GetHashCode();
            }
        }

        readonly Dictionary<DataKey, DataItem> dat = new Dictionary<DataKey, DataItem>();
        readonly DateTime startDate;
        readonly DateTime endDate;

        public IEnumerable<DataItem> Data { get { return dat.Values; } }

        public SalesOverviewDataGenerator(DataSet dataSet)
            : base(dataSet) {
            endDate = DateTime.Today;
            startDate = new DateTime(endDate.Year - 2, 1, 1);
        }
        protected override void Generate(Context context) {
            DateTime dt = startDate;
            while(dt < endDate) {
                if(dt.DayOfWeek == DayOfWeek.Monday) {
                    context.UnitsSoldGenerator.Next();
                    decimal sales = context.UnitsSoldGenerator.UnitsSold * context.ListPrice;
                    decimal salesTarget = context.UnitsSoldGenerator.UnitsSoldTarget * context.ListPrice;
                    DataKey datKey = new DataKey(context.State, context.CategoryName, dt);
                    DataItem datItem = null;
                    if(!dat.TryGetValue(datKey, out datItem)) {
                        datItem = new DataItem {
                            CurrentDate = dt,
                            Category = context.CategoryName,
                            State = context.State,
                        };
                        dat.Add(datKey, datItem);
                    }
                    datItem.Sales += sales;
                    datItem.SalesTarget += salesTarget;
                }
                dt = dt.AddDays(1);
            }
        }
    }
}
