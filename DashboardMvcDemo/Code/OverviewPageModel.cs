using System.Xml.Serialization;
using System.Collections.Generic;
using System.Web;

namespace DevExpress.Web.Demos {

    public class OverviewPageModel: DemoPageModel {
        List<KeyFeatureModel> _keyFeatures = new List<KeyFeatureModel>();
        string _descriptionTitle;

        [XmlIgnore]
        public override string Key {
            get { return "Overview"; }
            set { }
        }
        [XmlElement("KeyFeature")]
        public List<KeyFeatureModel> KeyFeatures {
            get { return _keyFeatures; }
            set { _keyFeatures = value; } 
        }
        [XmlElement("DescriptionTitle")]
        public string DescriptionTitle {
            get { return _descriptionTitle; }
            set { _descriptionTitle = value; }
        }
    }
    public class KeyFeatureModel {
        string _name;
        string _demoUrl;
        string _description;

        [XmlAttribute]
        public string Name {
            get { return _name; }
            set { _name = value; } 
        }
        [XmlAttribute]
        public string DemoUrl {
            get { return _demoUrl; }
            set { _demoUrl = value; }
        }
        [XmlElement]
        public string Description { 
            get { return _description; } 
            set { _description = value; } 
        }
        public string GetNameHtml() {
            return !string.IsNullOrEmpty(DemoUrl) ? string.Format("<a href='{0}'>{1}</a>", VirtualPathUtility.ToAbsolute(DemoUrl), Name) : Name;
        }
    }
}
