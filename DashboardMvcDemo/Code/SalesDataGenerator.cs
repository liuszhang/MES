using System;
using System.Data;

namespace DashboardMainDemo {
    public abstract class SalesDataGenerator {
        public class Context {
            readonly string st;
            readonly string prodName;
            readonly string catName;
            readonly decimal lPrice;
            readonly UnitsSoldRandomGenerator uSoldGenerator;

            public string State { get { return st; } }
            public string ProductName { get { return prodName; } }
            public string CategoryName { get { return catName; } }
            public decimal ListPrice { get { return lPrice; } }
            public UnitsSoldRandomGenerator UnitsSoldGenerator { get { return uSoldGenerator; } }

            public Context(string st, string prodName, string catName, decimal lPrice, UnitsSoldRandomGenerator uSoldGenerator) {
                this.st = st;
                this.prodName = prodName;
                this.catName = catName;
                this.lPrice = lPrice;
                this.uSoldGenerator = uSoldGenerator;
            }
        }

        protected static string GetState(DataRow region) {
            return (string)region["Region"];
        }
        protected static string GetProductName(DataRow product) {
            return (string)product["Name"];
        }
        protected static decimal GetListPrice(DataRow product) {
            return (decimal)product["ListPrice"];
        }

        readonly DataSet ds;
        readonly DataTable categoriesTable;
        readonly DataTable productsTable;
        readonly DataTable regionsTable;
        readonly Random rand = new Random(1);
        readonly ProductClasses prodClasses;
        readonly RegionClasses regClasses;

        protected DataRowCollection Regions { get { return regionsTable.Rows; } }
        protected DataRowCollection Products { get { return productsTable.Rows; } }
        protected ProductClasses ProdClasses { get { return prodClasses; } }
        protected RegionClasses RegClasses { get { return regClasses; } }
        protected Random Random { get { return rand; } }

        protected SalesDataGenerator(DataSet ds) {
            this.ds = ds;
            categoriesTable = ds.Tables["Categories"];
            productsTable = ds.Tables["Products"];
            regionsTable = ds.Tables["Regions"];
            prodClasses = new ProductClasses(productsTable.Rows);
            regClasses = new RegionClasses(regionsTable.Rows);
        }
        protected double GetRegionWeigtht(DataRow region) {
            return regClasses[(int)region["RegionID"]];
        }
        protected ProductClass GetProductClass(DataRow product) {
            return prodClasses[(int)product["ProductID"]];
        }
        protected string GetCategoryName(DataRow product) {
            return (string)categoriesTable.Select(string.Format("CategoryID = {0}", product["CategoryID"]))[0]["CategoryName"];
        }
        protected UnitsSoldRandomGenerator CreateUnitsSoldGenerator(double regionWeight, ProductClass productClass) {
            return new UnitsSoldRandomGenerator(rand, (int)Math.Ceiling(productClass.SaleProbability * regionWeight));
        }
        protected abstract void Generate(Context context);
        protected virtual void EndGenerate() {
        }
        public void Generate() {
            foreach(DataRow region in Regions) {
                string state = GetState(region);
                double regionWeight = GetRegionWeigtht(region);
                foreach(DataRow product in Products) {
                    UnitsSoldRandomGenerator unitsSoldgenerator = CreateUnitsSoldGenerator(regionWeight, GetProductClass(product));
                    Generate(new Context(state, GetProductName(product), GetCategoryName(product), GetListPrice(product), unitsSoldgenerator));
                }
            }
            EndGenerate();
        }
    }
}
