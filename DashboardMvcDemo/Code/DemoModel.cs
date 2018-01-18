using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using DevExpress.Web.Internal;
using System.Linq;
using System.Runtime.Serialization;

namespace DevExpress.Web.Demos {
    public class DemoPageModel : DemoModel {
        DemoGroupModel _group;
        List<SeeAlsoLinkModel> _seeAlsoLinks = new List<SeeAlsoLinkModel>();
        string _highlightedDescription = string.Empty;        

        [XmlIgnore]
        public DemoGroupModel Group {
            get { return _group; }
            internal set { _group = value; }
        }

        [XmlElement("SeeAlso")]
        public List<SeeAlsoLinkModel> SeeAlsoLinks { get { return _seeAlsoLinks; } set { _seeAlsoLinks = value; } }

        [XmlElement("HighlightedDescription")]
        public string HighlightedDescription { get { return _highlightedDescription; } set { _highlightedDescription = value; } }
    }


    public class DemoModel : DemoModelBase {        
        string _description;
        string _links;
        string _metaDescription;
        bool _hideSourceCode;        
        List<string> _sourceFiles = new List<string>();

        int _highlightedIndex = -1;
        string _highlightedImageUrl;
        string _highlightedTitle;
        string _highlightedLink;
        bool isErrorPage = false;

        DemoProductModel _product;
        bool _descriptionProcessed;
        bool _linksProcessed;

        [XmlIgnore]
        public DemoProductModel Product {
            get { return _product; }
            internal set { _product = value; }
        }

        [XmlIgnore]
        public bool IsErrorPage {
            get { return isErrorPage; }
            set { isErrorPage = value; }
        }

        [XmlAttribute]
        public virtual bool HideSourceCode {
            get { return _hideSourceCode; }
            set { _hideSourceCode = value; }
        }

        // Html is allowed here
        [XmlElement]
        public string Description {
            get {
                if(!_descriptionProcessed) {
                    ParseLinks();
                    _description = ProcessDescription(_description);
                    _descriptionProcessed = true;
                }
                return ProcessPageControlTags(_description);
            }
            set {
                if(value != null)
                    value = value.Trim();
                _description = value;
            }
        }
        [XmlIgnore]
        public string Links {
            get {
                if (!_linksProcessed) {
                    ParseLinks();
                }
                return _links;
            }            
        }
        [XmlElement]
        public string MetaDescription {
            get {
                if(_metaDescription == null)
                    return "";
                return _metaDescription;
            }
            set {
                if(value != null)
                    value = value.Trim();
                _metaDescription = value;
            }
        }

        [XmlElement("SourceFile")]
        public List<string> SourceFiles {
            get { return _sourceFiles; }
        }

        [XmlAttribute]
        public int HighlightedIndex {
            get { return _highlightedIndex; }
            set { _highlightedIndex = value; }
        }

        [XmlAttribute]
        public string HighlightedImageUrl {
            get {
                if(_highlightedImageUrl == null)
                    return "";
                return _highlightedImageUrl;
            }
            set { _highlightedImageUrl = value; }
        }

        [XmlAttribute]
        public string HighlightedTitle {
            get {
                if(_highlightedTitle == null)
                    return "";
                return _highlightedTitle;
            }
            set { _highlightedTitle = value; }
        }

        [XmlAttribute]
        public string HighlightedLink {
            get { return _highlightedLink; }
            set { _highlightedLink = value; }
        }

        public string GetHighlightedTitle() {
            if(!String.IsNullOrEmpty(HighlightedTitle))
                return HighlightedTitle;
            return Title;
        }

        static string ProcessDescription(string text) {
            if(text == null)
                text = "";
            text = Regex.Replace(text, @"<code\s+lang=([^>]+)>(.*?)</code>", DescriptionCodeReplacer, RegexOptions.Singleline);
            text = Regex.Replace(text, "<helplink([^>]*)>(.*?)</helplink>", DescriptionHelpLinkReplacer, RegexOptions.Singleline);
            return text;
        }

        static string ProcessPageControlTags(string text) {
            if(text == null)
                text = "";
            return text.Contains("<pageControl>") ? Regex.Replace(text, "<pageControl>(.*?)</pageControl>", DescriptionPageControlReplacer, RegexOptions.Singleline) : text;
        }

        string ParseLinks(string text) {
            if (text == null) {
                return string.Empty;
            }
            var groupName = "content";
            string pattern = String.Format(@"(<helplink([^>]*)>)(?<{0}>.+?)(</helplink>)", groupName);
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(text);
            var result = new List<string>();
            foreach(Match match in matches) {
                var group = match.Groups[groupName];
                if (group.Success) {
                    result.Add(group.Value);
                }
            }
            return string.Join(" ", result.Distinct());
        }

        void ParseLinks() {
            _links = ParseLinks(_description);
            _linksProcessed = true;
        }

        static string DescriptionCodeReplacer(Match match) {
            string lang = match.Groups[1].Value.Trim('"', '\'');
            string code = match.Groups[2].Value;
            string result = "<code>" + CodeFormatter.GetFormattedCode(CodeFormatter.ParseLanguage(lang), code, Utils.IsMvc, new string[0]) + "<br /></code>";
            return Utils.IsOverview ? string.Format("<div class='{0}'>{1}</div>", "CodeBlock", result) : result;
        }
        static string DescriptionHelpLinkReplacer(Match match) {
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            var reg = new Regex("(\\S+)=[\"']?((?:.(?![\"']?\\s+(?:\\S+)=|[>\"']))+.)[\"']?");
            var attrMatches = reg.Matches(match.Groups[1].Value);
            foreach(Match am in attrMatches) {
                attributes[am.Groups[1].Value] = am.Groups[2].Value;
            }
            if(!attributes.ContainsKey("href"))
                attributes["href"] = "http://help.devexpress.com/";
            return string.Format("<a href=\"{0}\" class=\"{1}\">{2}</a>", attributes["href"], "helplink", match.Groups[2].Value);
        }
        static string DescriptionPageControlReplacer(Match match) {
            MatchCollection tabPages = Regex.Matches(match.Value, @"<tabPage\s+text=([^>]+)>(.*?)</tabPage>", RegexOptions.Singleline);
            if(tabPages.Count == 0)
                return match.Groups[1].Value;
            ASPxPageControl pageControl = new ASPxPageControl();
            pageControl.ID = "OverviewPageControl";
            pageControl.CssClass = "DemoPageControl";
            pageControl.EnableTabScrolling = true;
            pageControl.TabAlign = TabAlign.Justify;
            pageControl.EnableTheming = false;
            pageControl.ActiveTabIndex = 0;
            pageControl.EnableViewState = false;
            pageControl.Width = Unit.Percentage(100);
            foreach(Match tabPage in tabPages) {
                string text = tabPage.Groups[1].Value.Trim('"', '\'');
                var tab = pageControl.TabPages.Add(text, text);
                tab.Controls.Add(RenderUtils.CreateLiteralControl(tabPage.Groups[2].Value));
            }
            return RenderUtils.GetRenderResult(pageControl);
        }

        public string GetSeoTitle() {
            if(!String.IsNullOrEmpty(SeoTitle))
                return SeoTitle;
            return Title;
        }

    }

    public class SeeAlsoLinkModel {
        string _src;
        string _title;

        [XmlAttribute]
        public string Url { get { return _src; } set { _src = value; } }
        [XmlAttribute]
        public string Title { get { return _title; } set { _title = value; } }
    }

}
