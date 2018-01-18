using System.Xml.Serialization;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {

    public class IntroFeatureModel {
        string _title;
        string _description;
        string _imageUrl;

        [XmlAttribute]
        public string Title {
            get {
                if(_title == null)
                    return "";
                return _title;
            }
            set { _title = value; }
        }

        [XmlAttribute]
        public string ImageUrl {
            get {
                if(_imageUrl == null)
                    return "";
                return _imageUrl;
            }
            set { _imageUrl = value; }
        }

        [XmlElement]
        public string Description {
            get {
                if(_description == null)
                    return "";
                return _description;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _description = value;
            }
        }

    }

}
