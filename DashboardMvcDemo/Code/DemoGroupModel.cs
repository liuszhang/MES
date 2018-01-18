using System.Xml.Serialization;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {

    public class DemoGroupModel : DemoModelBase {
        List<DemoPageModel> _demos = new List<DemoPageModel>();
        OverviewPageModel _overview;

        [XmlElement(Type = typeof(DemoPageModel), ElementName = "Demo")]
        public List<DemoPageModel> Demos {
            get { return _demos; }
        }

        [XmlElement(Type = typeof(OverviewPageModel), ElementName = "Overview")]
        public OverviewPageModel Overview {
            get { return _overview; }
            set { _overview = value; }
        }

        public DemoModel FindDemo(string key) {
            key = key.ToLower();
            foreach(DemoModel demo in Demos) {
                if(key == demo.Key.ToLower())
                    return demo;
            }
            if(Overview != null && key == Overview.Key.ToLower())
                return Overview;
            return null;
        }

        public List<DemoPageModel> GetAllDemos() {
            List<DemoPageModel> result = new List<DemoPageModel>();
            if(Overview != null) {
                DemoPageModel overviewDemo = Overview as DemoPageModel;
                overviewDemo.Key = Overview.Key;
                result.Add(overviewDemo);
            }
            result.AddRange(Demos);
            return result;
        }

        [XmlIgnore]
        public DemoProductModel Product { get; set; }
    }

}
