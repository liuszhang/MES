using System;
using System.Collections.Generic;
using System.Web;
using System.Xml.Serialization;

namespace DevExpress.Web.Demos {

    public class DemoModelBase : ModelBase {
        string _key;
        string _title;
        string _seoTitle;
        bool _isNew;
        bool _isPreview;
        bool _isUpdated;

        [XmlAttribute]
        public virtual string Key {
            get {
                if(_key == null)
                    return "";
                return _key;
            }
            set {
                _key = value;
            }
        }

        [XmlAttribute]
        public string Title {
            get {
                if(_title == null)
                    return "";
                return _title;
            }
            set {
                _title = value;
            }
        }

        [XmlAttribute]
        public string SeoTitle {
            get {
                if(_seoTitle == null)
                    return "";
                return _seoTitle;
            }
            set {
                _seoTitle = value;
            }
        }

        [XmlAttribute]
        public bool IsNew {
            get {
                return _isNew;
            }
            set {
                _isNew = value;
            }
        }

        [XmlAttribute]
        public bool IsPreview {
            get {
                return _isPreview;
            }
            set {
                _isPreview = value;
            }
        }

        [XmlAttribute]
        public bool IsUpdated {
            get {
                return _isUpdated;
            }
            set {
                _isUpdated = value;
            }
        }

        public override string ToString() {
            return Title;
        }
    }

    public class ModelBase {
        string _keywords;
        Dictionary<string, int> _keywordsRankList;
        string _highlightedTagNames;

        [XmlAttribute]
        public string HighlightedTagNames {
            get {
                return _highlightedTagNames;
            }
            set {
                _highlightedTagNames = value;
            }
        }

        [XmlElement]
        public string Keywords {
            get {
                if(_keywords == null)
                    return "";
                return _keywords;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _keywords = value;
            }
        }

        [XmlIgnore]
        public Dictionary<string, int> KeywordsRankList {
            get {
                if(_keywordsRankList == null)
                    _keywordsRankList = SearchUtils.GetKeywordsRankList(this);
                return _keywordsRankList;
            }
        }

        public string[] GetHighlightedTagNames() {
            if(!string.IsNullOrEmpty(HighlightedTagNames))
                return HighlightedTagNames.Split();
            return new string[0];
        }
    }

}
