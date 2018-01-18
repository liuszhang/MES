using System.Data;
using System.Web;

namespace DashboardMainDemo {
    public static class DataLoader {
        static object customerSupportData;
        static HumanResourcesData humanResourcesData;
        static object revenueAnalysisData;
        static object salesDetailsData;
        static object salesOverviewData;
        static SalesPerformanceDataGenerator salesPerformanceData;
        static WebsiteStatisticsDataGenerator websiteStatisticsData;
        static DataSet revenueByIndustry;
        static DataSet energyConsumptionTotal;
        static DataSet energyConsumptionBySector;
        static DataSet energyStatistics;
        static DataSet championsLeagueStatistics;

        static HttpServerUtility Server { get { return HttpContext.Current.Server; } }

        public static object CustomerSupportData {
            get {
                if(customerSupportData == null) {
                    DataSet customerSupport = DataLoader.LoadCustomerSupport(Server);
                    DataSet employees = DataLoader.LoadEmployees(Server);
                    customerSupportData = new CustomerSupportData(customerSupport, employees).CustomerSupport;
                }
                return customerSupportData;
            }
        }
        public static HumanResourcesData HumanResourcesData {
            get {
                if(humanResourcesData == null) {
                    DataSet employees = DataLoader.LoadEmployees(Server);
                    humanResourcesData = new HumanResourcesData(employees);
                }
                return humanResourcesData;
            }
        }
        public static object RevenueAnalysisData {
            get {
                if(revenueAnalysisData == null) {
                    RevenueAnalysisDataGenerator dataGenerator = new RevenueAnalysisDataGenerator(DataLoader.LoadSales(Server));
                    dataGenerator.Generate();
                    revenueAnalysisData = dataGenerator.Data;
                }
                return revenueAnalysisData;
            }
        }
        public static object SalesDetailsData {
            get {
                if(salesDetailsData == null) {
                    DataSet sales = DataLoader.LoadSales(Server);
                    SalesDetailsDataGenerator generator = new SalesDetailsDataGenerator(sales);
                    generator.Generate();
                    salesDetailsData = generator.Data;
                }
                return salesDetailsData;
            }
        }
        public static object SalesOverviewData {
            get {
                if(salesOverviewData == null) {
                    DataSet sales = DataLoader.LoadSales(Server);
                    SalesOverviewDataGenerator generator = new SalesOverviewDataGenerator(sales);
                    generator.Generate();
                    salesOverviewData = generator.Data;
                }
                return salesOverviewData;
            }
        }
        public static SalesPerformanceDataGenerator SalesPerformanceData {
            get {
                if(salesPerformanceData == null) {
                    salesPerformanceData = new SalesPerformanceDataGenerator(DataLoader.LoadSales(Server));
                    salesPerformanceData.Generate();
                }
                return salesPerformanceData;
            }
        }
        public static DataSet RevenueByIndustry {
            get {
                if(revenueByIndustry == null)
                    revenueByIndustry = LoadRevenueByIndustry(Server);
                return revenueByIndustry;
            }
        }
        public static DataSet EnergyConsumptionTotal {
            get {
                if(energyConsumptionTotal == null)
                    energyConsumptionTotal = LoadData(Server, "DashboardEnergyConsumptionTotal");
                return energyConsumptionTotal;
            }
        }
        public static DataSet EnergyConsumptionBySector {
            get {
                if(energyConsumptionBySector == null)
                    energyConsumptionBySector = LoadData(Server, "DashboardEnergyConsumptionBySector");
                return energyConsumptionBySector;
            }
        }
        public static DataSet EnergyStatistics {
            get {
                if(energyStatistics == null)
                    energyStatistics = LoadData(Server, "DashboardEnergyStatictics");
                return energyStatistics;
            }
        }
        public static DataSet ChampionsLeagueStatistics {
            get {
                if(championsLeagueStatistics == null)
                    championsLeagueStatistics = LoadData(Server, "DashboardChampionsLeagueStatistics");
                return championsLeagueStatistics;
            }
        }
        public static object WebsiteStatistics {
            get {
                if (websiteStatisticsData == null)
                    websiteStatisticsData = new WebsiteStatisticsDataGenerator();
                return websiteStatisticsData.WebsiteStatistics;
            }
        }
        static string BuildDataFileNameBase(HttpServerUtility server, string dataSetName, string extension) {
            return server.MapPath(string.Format("~/App_Data/{0}", dataSetName + extension));
        }
        static string BuildDataFileName(HttpServerUtility server, string dataSetName) {
            return BuildDataFileNameBase(server, dataSetName, ".xml");
        }
        static string BuildExtractDataFile(HttpServerUtility server, string dataSetName) {
            return BuildDataFileNameBase(server, dataSetName, ".dat");
        }
        static DataSet LoadData(HttpServerUtility server, string dataSetName) {
            string path = BuildDataFileName(server, dataSetName);
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(path, XmlReadMode.ReadSchema);
            return dataSet;
        }
        public static DataSet LoadSales(HttpServerUtility server) {
            return LoadData(server, "DashboardSales");
        }
        public static DataSet LoadCustomerSupport(HttpServerUtility server) {
            return LoadData(server, "DashboardCustomerSupport");
        }
        public static DataSet LoadEmployees(HttpServerUtility server) {
            return LoadData(server, "DashboardEmployeesAndDepartments");
        }
        public static DataSet LoadRevenueByIndustry(HttpServerUtility server) {
            return LoadData(server, "DashboardRevenueByIndustry");
        }
        public static string GetProductDetailsXmlData() {
            return BuildDataFileName(Server, "DashboardProductDetails");
        }
        public static string GetEUTradeOverviewDataPath() {
            return BuildExtractDataFile(Server, "EUTradeOverview");
        }
    }
}
