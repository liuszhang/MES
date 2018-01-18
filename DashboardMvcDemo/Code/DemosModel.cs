using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Linq;
using System.Configuration;
using System;

namespace DevExpress.Web.Demos {

    [XmlRoot("Demos")]
    public class DemosModel {
        static DemosModel _instance;
        static DemoProductModel _current;
        GlobalHeaderModel _globalHeader = new GlobalHeaderModel();

        static readonly object _instanceLock = new object();
        static readonly object _currentLock = new object();

        bool _expandAllDemosAtFirstTime;
        bool _disableTextWrap;

        public static DemosModel Instance {
            get {
                lock(_instanceLock) {
                    if(_instance == null) {
                        using(Stream stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/Demos.xml"))) {
                            XmlSerializer serializer = new XmlSerializer(typeof(DemosModel));
                            _instance = (DemosModel)serializer.Deserialize(stream);
                        }
                        foreach(var demoProduct in _instance.DemoProducts) {
                            foreach(var group in demoProduct.Groups) {
                                foreach(var demo in group.GetAllDemos()) {
                                    demo.Group = group;
                                    demo.Product = demoProduct;
                                }
                                group.Product = demoProduct;
                            }
                            if(demoProduct.Intro != null)
                                demoProduct.Intro.Product = demoProduct;
                            if(demoProduct.Overview != null)
                                demoProduct.Overview.Product = demoProduct;
                        }
                    }
                    return _instance;
                }
            }
        }
        public static DemoProductModel Current {
            get {
                lock(_currentLock) {
                    if(_current == null)
                        _current = Instance.DemoProducts.FirstOrDefault(dp => dp.Key == ConfigurationManager.AppSettings["DemoProduct"]);
                    if(_current == null)
                        throw new Exception("The current demo is not found");
                    return _current;
                }
            }
        }

        List<DemoProductModel> _demoProducts = new List<DemoProductModel>();
        List<DemoProductModel> _sortedDemoProducts;
        SearchModel _search;

        [XmlElement("DemoProduct")]
        public List<DemoProductModel> DemoProducts { get { return _demoProducts; } }

        [XmlIgnore]
        public List<DemoProductModel> SortedDemoProducts {
            get {
                if(_sortedDemoProducts == null)
                    _sortedDemoProducts = _demoProducts.OrderBy(p => p.OrderIndex).ToList();
                return _sortedDemoProducts;
            }
        }

        [XmlElement("Search")]
        public SearchModel Search {
            get { return _search; }
            set { _search = value; }
        }
        [XmlElement("GlobalHeader")]
        public GlobalHeaderModel GlobalHeader {
            get { return _globalHeader; }
            set { _globalHeader = value; }
        }
        [XmlAttribute]
        public bool ExpandAllDemosAtFirstTime {
            get { return _expandAllDemosAtFirstTime; }
            set { _expandAllDemosAtFirstTime = value; }
        }
        [XmlAttribute]
        public bool DisableTextWrap {
            get { return _disableTextWrap; }
            set { _disableTextWrap = value; }
        }
    }
    public class GlobalHeaderModel {
        string _logoPlatformSubject = "ASP.NET AJAX";
        string _logoPlatformDescription = "WHEN THE WEB MEANS BUSINESS";
        [XmlAttribute]
        public string LogoPlatformSubject {
            get { return _logoPlatformSubject; }
            set { _logoPlatformSubject = value; }
        }
        [XmlAttribute]
        public string LogoPlatformDescription {
            get { return _logoPlatformDescription; }
            set { _logoPlatformDescription = value; }
        }
    }
    public class DemoProductModel : ModelBase {
        bool _isMvc;
        bool _isMvcRazor;
        bool _isRootDemo;
        bool _isPreview;
        bool _isNew;
        string _key;
        string _url;
        string _title;
        string _seoTitle;
        string _navItemTitle;
        bool _supportsTheming = true;
        bool _supportsThemeParameters = true;
        bool _hideNavItem = false;
        List<DemoGroupModel> _groups = new List<DemoGroupModel>();
        IntroPageModel _intro;
        OverviewPageModel _overview;

        int _orderIndex = 1000;
        bool _integrationHighlighted = false;
        string _integrationImageUrl;
        string _integrationDescription;

        string _downloadUrl;
        string _buyUrl;
        string _docUrl;

        List<DemoPageModel> _highlighledDemos;

        [XmlAttribute]
        public bool IsMvc {
            get { return _isMvc; }
            set { _isMvc = value; }
        }

        [XmlAttribute]
        public bool IsMvcRazor {
            get { return _isMvcRazor; }
            set { _isMvcRazor = value; }
        }

        [XmlAttribute]
        public bool IsRootDemo {
            get { return _isRootDemo; }
            set { _isRootDemo = value; }
        }

        [XmlAttribute]
        public bool IsPreview {
            get { return _isPreview; }
            set { _isPreview = value; }
        }

        [XmlAttribute]
        public bool IsNew {
            get { return _isNew; }
            set { _isNew = value; }
        }

        [XmlAttribute]
        public bool HideNavItem {
            get { return _hideNavItem; }
            set { _hideNavItem = value; }
        }

        [XmlAttribute]
        public string Key {
            get {
                if(_key == null)
                    return "";
                return _key;
            }
            set { _key = value; }
        }
        [XmlAttribute]
        public string Url {
            get {
                if(_url == null)
                    throw new Exception("URL is not defined");
                return _url;
            }
            set { _url = value; }
        }

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
        public string SeoTitle {
            get {
                if(_seoTitle == null)
                    return "";
                return _seoTitle;
            }
            set { _seoTitle = value; }
        }

        [XmlAttribute]
        public string NavItemTitle {
            get {
                if(_navItemTitle == null)
                    return "";
                return _navItemTitle;
            }
            set { _navItemTitle = value; }
        }

        [XmlAttribute]
        public int OrderIndex {
            get { return _orderIndex; }
            set { _orderIndex = value; }
        }

        [XmlAttribute]
        public bool IntegrationHighlighted {
            get { return _integrationHighlighted; }
            set { _integrationHighlighted = value; }
        }

        [XmlElement]
        public string DownloadUrl {
            get {
                if(_downloadUrl == null)
                    return "";
                return _downloadUrl;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _downloadUrl = value;
            }
        }

        [XmlElement]
        public string BuyUrl {
            get {
                if(_buyUrl == null)
                    return "";
                return _buyUrl;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _buyUrl = value;
            }
        }

        [XmlElement]
        public string DocUrl {
            get {
                if(_docUrl == null)
                    return "";
                return _docUrl;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _docUrl = value;
            }
        }

        [XmlElement]
        public string IntegrationImageUrl {
            get { return _integrationImageUrl; }
            set { _integrationImageUrl = value; }
        }

        [XmlElement]
        public string IntegrationDescription {
            get { return _integrationDescription; }
            set { _integrationDescription = value; }
        }

        [XmlElement("DemoGroup")]
        public List<DemoGroupModel> Groups {
            get { return _groups; }
        }

        [XmlAttribute]
        public bool SupportsTheming {
            get { return _supportsTheming; }
            set { _supportsTheming = value; }
        }

        [XmlAttribute]
        public bool SupportsThemeParameters {
            get { return _supportsThemeParameters; }
            set { _supportsThemeParameters = value; }
        }

        [XmlIgnore]
        public List<DemoPageModel> HighlightedDemos {
            get {
                if(_highlighledDemos == null)
                    _highlighledDemos = CreateHighlightedDemos();
                return _highlighledDemos;
            }
        }

        [XmlElement(Type = typeof(IntroPageModel), ElementName = "Intro")]
        public IntroPageModel Intro {
            get { return _intro; }
            set { _intro = value; }
        }

        [XmlElement(Type = typeof(OverviewPageModel), ElementName = "Overview")]
        public OverviewPageModel Overview {
            get { return _overview; }
            set { _overview = value; }
        }

        [XmlIgnore]
        public bool IsCurrent {
            get { return this == DemosModel.Current; }
        }

        public DemoGroupModel FindGroup(string key) {
            key = key.ToLower();
            foreach(DemoGroupModel group in Groups) {
                if(key == group.Key.ToLower())
                    return group;
            }
            return null;
        }

        List<DemoPageModel> CreateHighlightedDemos() {
            List<DemoPageModel> result = new List<DemoPageModel>();
            foreach(DemoGroupModel group in Groups) {
                foreach(DemoPageModel demo in group.Demos) {
                    if(demo.HighlightedIndex > -1)
                        result.Add(demo);
                }
            }
            result.Sort(CompareHighlightedDemos);
            return result;
        }

        int CompareHighlightedDemos(DemoModel x, DemoModel y) {
            return Comparer<int>.Default.Compare(x.HighlightedIndex, y.HighlightedIndex);
        }

        public string GetSeoTitle() {
            if(!string.IsNullOrEmpty(SeoTitle))
                return SeoTitle;
            return Title;
        }
    }
    public class SearchModel {
        SynonymsSearchModel _synonyms;
        ExclusionsSearchModel _exclusions;

        [XmlElement]
        public SynonymsSearchModel Synonyms {
            get { return _synonyms; }
            set { _synonyms = value; }
        }

        [XmlElement]
        public ExclusionsSearchModel Exclusions {
            get { return _exclusions; }
            set { _exclusions = value; }
        }
    }
    public class ExclusionsSearchModel {
        string _words;
        string _prefixes;
        string _postfixes;

        [XmlElement]
        public string Words {
            get { return _words; }
            set { _words = value; }
        }
        [XmlElement]
        public string Prefixes {
            get { return _prefixes; }
            set { _prefixes = value; }
        }
        [XmlElement]
        public string Postfixes {
            get { return _postfixes; }
            set { _postfixes = value; }
        }
    }
    public class SynonymsSearchModel {
        List<string> _groups = new List<string>();

        [XmlElement("Group")]
        public List<string> Groups {
            get { return _groups; }
            set { _groups = value; }
        }
    }
}
