using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;

namespace DashboardMainDemo {
    public class WebsiteStatisticsDataGenerator {
        public class WebsiteStatisticsItem {
            int count;
            DateTime date;
            string trafficSource;
            string trafficSourceDetails ;
            string browser ;
            string browserDetails ;

            public int Count {
                get { return count; }
                set { count = value; }
            }
            public DateTime Date {
                get { return date; }
                set { date = value; }
            }
            public string TrafficSource {
                get { return trafficSource; }
                set { trafficSource = value; }
            }
            public string TrafficSourceDetails {
                get { return trafficSourceDetails; }
                set { trafficSourceDetails = value; }
            }
            public string Browser {
                get { return browser; }
                set { browser = value; }
            }
            public string BrowserDetails {
                get { return browserDetails; }
                set { browserDetails = value; }
            }
        }
        interface IChanceInterval {
            double Chance { get; set; }
        }
        class DataPairElement : IChanceInterval {
            string data;
            string dataDetails;
            double chance;
            public string Data {
                get { return data; }
                set { data = value; }
            }
            public string DataDetails {
                get { return dataDetails; }
                set { dataDetails = value; }
            }
            public double Chance {
                get { return chance; }
                set { chance = value; }
            }
            double IChanceInterval.Chance {
                get { return chance; }
                set { chance = value; }
            }
        }
        class UserDataElement : IChanceInterval {
            string userId;
            double chance;
            public string UserId {
                get { return userId; }
                set { userId = value; }
            }
            public double Chance {
                get { return chance; }
                set { chance = value; }
            }
            double IChanceInterval.Chance {
                get { return chance; }
                set { chance = value; }
            }
        }

        readonly Random rand = new Random();
        readonly List<WebsiteStatisticsItem> items = new List<WebsiteStatisticsItem>();        
        public IEnumerable<WebsiteStatisticsItem> WebsiteStatistics { get { return items; } }

        public WebsiteStatisticsDataGenerator() {
            InitializeData();
        }
        void InitializeData() {
            IList<DataPairElement> dataTrafficSourceList = GetTrafficSourceData();
            IList<DataPairElement> browsersDataList = GetBrowserData();
            IList<UserDataElement> usersDataList = GetUsersData(10000);
            DateTime currentDate = DateTime.Today.AddYears(-1);
            DateTime endDate = DateTime.Today.AddDays(-1);
            while (currentDate < endDate) {
                double monthModifier = 1 + 0.03 * Math.Abs(currentDate.Month - 6);
                int baseCount = rand.Next(100000, 150000);
                foreach (DataPairElement browserData in browsersDataList) {
                    foreach (DataPairElement trafficData in dataTrafficSourceList) {
                        WebsiteStatisticsItem item = new WebsiteStatisticsItem();
                        item.Count = Convert.ToInt32(baseCount * (browserData.Chance / 100) * (trafficData.Chance / 100) * monthModifier);
                        item.Date = currentDate;
                        item.TrafficSource = trafficData.Data;
                        item.TrafficSourceDetails = trafficData.DataDetails;
                        item.Browser = browserData.Data;
                        item.BrowserDetails = browserData.DataDetails;
                        items.Add(item);
                    }
                }
                currentDate = currentDate.AddMonths(1);
            }
        }
        IList<UserDataElement> GetUsersData(int count) {
            IList<UserDataElement> result = Enumerable
                .Range(0, count)
                .Select(i => new UserDataElement() { UserId = Guid.NewGuid().ToString(), Chance = rand.Next(1, 3) })
                .ToList();
            InitChance(result.Cast<IChanceInterval>().ToList());
            return result;
        }
        IList<DataPairElement> GetBrowserData() {
            IList<DataPairElement> result = new List<DataPairElement>();
            result.Add(new DataPairElement() { Chance = 2.6, Data = "IE", DataDetails = "8" });
            result.Add(new DataPairElement() { Chance = 4.7, Data = "IE", DataDetails = "9" });
            result.Add(new DataPairElement() { Chance = 5.3, Data = "IE", DataDetails = "11" });
            result.Add(new DataPairElement() { Chance = 0.3, Data = "IE", DataDetails = "Others" });

            result.Add(new DataPairElement() { Chance = 38.0, Data = "Chrome", DataDetails = "Latest" });
            result.Add(new DataPairElement() { Chance = 17.3, Data = "Chrome", DataDetails = "Others" });

            result.Add(new DataPairElement() { Chance = 11.4, Data = "Firefox", DataDetails = "Latest" });
            result.Add(new DataPairElement() { Chance = 6.4, Data = "Firefox", DataDetails = "Others" });

            result.Add(new DataPairElement() { Chance = 1.7, Data = "Safari", DataDetails = "Others" });

            result.Add(new DataPairElement() { Chance = 0.7, Data = "Opera", DataDetails = "O Mini" });
            result.Add(new DataPairElement() { Chance = 3.0, Data = "Opera", DataDetails = "Others" });

            InitChance(result.Cast<IChanceInterval>().ToList());
            return result;
        }
        IList<DataPairElement> GetTrafficSourceData() {
            IList<DataPairElement> result = new List<DataPairElement>();
            result.Add(new DataPairElement() { Chance = 51.0, Data = "Direct", DataDetails = "Direct" });
            result.Add(new DataPairElement() { Chance = 19.0, Data = "Referring Site", DataDetails = "Facebook" });
            result.Add(new DataPairElement() { Chance = 02.0, Data = "Referring Site", DataDetails = "Google Ads" });
            result.Add(new DataPairElement() { Chance = 10.0, Data = "Referring Site", DataDetails = "Google+" });
            result.Add(new DataPairElement() { Chance = 13.3, Data = "Referring Site", DataDetails = "Twitter" });
            result.Add(new DataPairElement() { Chance = 02.3, Data = "Referring Site", DataDetails = "LinkedIn" });
            result.Add(new DataPairElement() { Chance = 03.3, Data = "Search Engine", DataDetails = "Bing" });
            result.Add(new DataPairElement() { Chance = 10.3, Data = "Search Engine", DataDetails = "Google" });
            result.Add(new DataPairElement() { Chance = 02.3, Data = "Search Engine", DataDetails = "Yahoo" });
            InitChance(result.Cast<IChanceInterval>().ToList());
            return result;
        }
        void InitChance(IList<IChanceInterval> dataList) {
            double sum = dataList.Sum(d => d.Chance);
            foreach (IChanceInterval data in dataList)
                data.Chance = 100 * data.Chance / sum;
        }
    }
}
