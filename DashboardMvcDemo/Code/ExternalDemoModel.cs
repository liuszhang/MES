using System;
using System.Collections.Generic;
using System.Web;
using System.Xml.Serialization;

namespace DevExpress.Web.Demos {

    public class ExternalDemoModel {
        string _imageUrl;
        string _url;
        string _title;

        [XmlAttribute]
        public string ImageUrl {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }

        [XmlAttribute]
        public string Url {
            get { return _url; }
            set { _url = value; }
        }

        [XmlAttribute]
        public string Title {
            get { return _title; }
            set { _title = value; }
        }

    }

}
