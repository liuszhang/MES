using System.Xml.Serialization;
using System.Collections.Generic;

namespace DevExpress.Web.Demos {

    public class IntroPageModel : DemoModel {
        string _bannerTitle;
        string _bannerText;
        string _bannerImageUrl;
        string _bannerUrl;
        string _descriptionTitle;
        string _descriptionFooter;
        List<ExternalDemoModel> _externalDemos = new List<ExternalDemoModel>();

        [XmlIgnore]
        public override string Key {
            get { return Utils.IsMvc ? "Index" : "Default"; }
            set { }
        }
        
        [XmlElement]
        public string BannerTitle {
            get {
                if(_bannerTitle == null)
                    return "";
                return _bannerTitle;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _bannerTitle = value;
            }
        }

        [XmlElement]
        public string BannerText {
            get {
                if(_bannerText == null)
                    return "";
                return _bannerText;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _bannerText = value;
            }
        }

        [XmlElement]
        public string BannerImageUrl {
            get {
                if(_bannerImageUrl == null)
                    return "";
                return _bannerImageUrl;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _bannerImageUrl = value;
            }
        }

        [XmlElement]
        public string BannerUrl {
            get {
                if(_bannerUrl == null)
                    return "";
                return _bannerUrl;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _bannerUrl = value;
            }
        }

        [XmlElement]
        public string DescriptionTitle {
            get {
                if(_descriptionTitle == null)
                    return "";
                return _descriptionTitle;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _descriptionTitle = value;
            }
        }

        // Html is allowed here
        [XmlElement]
        public string DescriptionFooter {
            get {
                if(_descriptionFooter == null)
                    return "";
                return _descriptionFooter;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _descriptionFooter = value;
            }
        }

        [XmlElement("ExternalDemo")]
        public List<ExternalDemoModel> ExternalDemos {
            get { return _externalDemos; }
        }

    }

}
