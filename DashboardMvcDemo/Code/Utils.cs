using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DevExpress.Web.Internal;
using System.Drawing;

namespace DevExpress.Web.Demos {

    public class SourceCodePage {
        public string Title = "";
        public string Code = "";
        public bool Expanded = false;

        public SourceCodePage(string title, string code, bool expanded) {
            Title = title;
            Code = code;
            Expanded = expanded;
        }
    }

    public class FeaturedDemoInfo {
        public string Title {
            get;
            set;
        }
        public string Description {
            get;
            set;
        }
        public string NavigateUrl {
            get;
            set;
        }
        public string ImageUrl {
            get;
            set;
        }
    }

    public class ProductInfo {
        public string Title {
            get;
            set;
        }
        public string Description {
            get;
            set;
        }
        public string NavigateUrl {
            get;
            set;
        }
        public string ImageUrl {
            get;
            set;
        }
    }

    public static class Utils {
        const string
            CurrentDemoKey = "DXCurrentDemo",
            CurrentThemeCookieKeyPrefix = "DXCurrentTheme",
            CurrentBaseColorCookieKey = "DXCurrentBaseColor",
            CurrentFontCookieKey = "DXCurrentFont",
            TunableThemeCookieKey = "DXTunableTheme",
            DefaultTheme = "Metropolis",
            BogusDemoTitle = "Delivered!",
            IsAccessibilityDemoKey = "IsAccessibilityDemo";

        static readonly Dictionary<DemoModel, IEnumerable<SourceCodePage>> sourceCodeCache = new Dictionary<DemoModel, IEnumerable<SourceCodePage>>();
        static readonly object sourceCodeCacheLock = new object();

        static string _codeLanguage;

        static HttpContext Context {
            get {
                return HttpContext.Current;
            }
        }

        static HttpRequest Request {
            get {
                return Context.Request;
            }
        }

        public static bool IsMvc {
            get {
                return DemosModel.Current.IsMvc;
            }
        }
        public static bool IsIncludeThirdPartyClientLibraries {
            get {
                var resources = DevExpress.Web.Internal.ConfigurationSettings.Resources;
                return resources != null && resources.Contains(ResourcesType.ThirdParty);
            }
        }

        public static DemoModel CurrentDemo {
            get {
                return (DemoModel)Context.Items[CurrentDemoKey];
            }
        }
        public static DemoProductModel RootProduct {
            get {
                return DemosModel.Instance.SortedDemoProducts.Find(p => p.IsRootDemo);
            }
        }
        public static string CurrentDemoNodeName {
            get {
                if(IsOverview && CurrentOverview.Group == null)
                    return string.Format("{0}_{1}", CurrentOverview.Product.Key, CurrentOverview.Key);
                if(CurrentDemoPage != null)
                    return string.Format("{0}_{1}_{2}", CurrentDemoPage.Product.Key, CurrentDemoPage.Group.Key, CurrentDemoPage.Key);
                if(CurrentDemo != null)
                    return CurrentDemo.Product.Key;
                return null;
            }
        }

        public static string CurrentDemoTitleHtml {
            get {
                return GetDemoTitleHtml(CurrentDemo);
            }
        }

        public static IntroPageModel CurrentIntro {
            get {
                if(CurrentDemo is IntroPageModel || CurrentDemo == null)
                    return (IntroPageModel)CurrentDemo;
                return CurrentDemo.Product.Intro;
            }
        }
        public static OverviewPageModel CurrentOverview {
            get {
                if(CurrentDemo is OverviewPageModel || CurrentDemo == null)
                    return (OverviewPageModel)CurrentDemo;
                return CurrentDemo.Product.Overview;
            }
        }
        public static DemoPageModel CurrentDemoPage {
            get {
                return CurrentDemo as DemoPageModel;
            }
        }

        public static string CurrentThemeCookieKey {
            get {
                return CurrentThemeCookieKeyPrefix;
            }
        }
        public static bool IsLargeTheme {
            get {
                return ThemesProvider.IsLargeTheme(CurrentTheme);
            }
        }
        public static string CurrentTheme {
            get {
                if(CanChangeTheme && Request.Cookies[CurrentThemeCookieKey] != null)
                    return HttpUtility.UrlDecode(Request.Cookies[CurrentThemeCookieKey].Value);
                return DefaultTheme;
            }
        }
        public static string CurrentBaseColor {
            get {
                if(Request.Cookies[CurrentBaseColorCookieKey] != null)
                    return HttpUtility.UrlDecode(Request.Cookies[CurrentBaseColorCookieKey].Value);
                return CurrentThemeDefaultBaseColor;
            }
        }
        static void SetCurrentBaseColorCookie(string value) {
            Context.Response.Cookies[CurrentBaseColorCookieKey].Value = value;
        }
        public static string CurrentFont {
            get {
                if(Request.Cookies[CurrentFontCookieKey] != null)
                    return HttpUtility.UrlDecode(Request.Cookies[CurrentFontCookieKey].Value);
                return CurrentThemeDefaultFont;
            }
        }
        static void SetCurrentFontCookie(string value) {
            Context.Response.Cookies[CurrentFontCookieKey].Value = value;
        }
        public static string CurrentThemeTitle {
            get {
                var theme = CurrentTheme;
                var themeModel = ThemesModel.Current.Groups.SelectMany(g => g.Themes).FirstOrDefault(t => t.Name == theme);
                return themeModel != null ? themeModel.Title : theme;
            }
        }
        static string TunableTheme {
            get {
                if(Request.Cookies[TunableThemeCookieKey] != null)
                    return HttpUtility.UrlDecode(Request.Cookies[TunableThemeCookieKey].Value);
                return CurrentTheme;
            }
            set {
                Context.Response.Cookies[TunableThemeCookieKey].Value = value;
            }
        }
        public static bool IsIntro {
            get {
                return Utils.CurrentDemo is IntroPageModel;
            }
        }
        public static bool IsOverview {
            get {
                return Utils.CurrentDemo is OverviewPageModel;
            }
        }
        public static bool IsBogusDemo {
            get {
                return CurrentDemo != null ? CurrentDemo.Title == BogusDemoTitle : false;
            }
        }

        public static string GetDemoTitleHtml(DemoModel demo) {
            string result = string.Empty;
            if(demo is DemoPageModel)
                result = string.Format("{0} - {1}", ((DemoPageModel)demo).Group.Title, demo.Title);
            if(string.IsNullOrEmpty(result))
                result = demo.Title;
            else if(result.Length > 60)
                result = demo.Title;
            return HttpUtility.HtmlEncode(result);
        }

        public static string CodeLanguage {
            get {
                if(_codeLanguage == null) {
                    try {
                        using(FileStream _file = File.OpenRead(Context.Server.MapPath("~/Site.master")))
                        using(TextReader reader = new StreamReader(_file)) {
                            string line = reader.ReadLine();
                            Match match = Regex.Match(line, @"language=""([^""]+)", RegexOptions.IgnoreCase);
                            if(match.Success) {
                                _codeLanguage = match.Groups[1].Value.ToUpper();
                            }
                        }
                    } catch {
                    }
                    if(String.IsNullOrEmpty(_codeLanguage))
                        _codeLanguage = "C#";
                }
                return _codeLanguage;
            }
        }

        public static IEnumerable<SourceCodePage> GetCurrentSourceCodePages() {
            return GetSourceCodePages(CurrentDemo as DemoPageModel);
        }

        public static IEnumerable<SourceCodePage> GetSourceCodePages(DemoPageModel demo) {
            lock(sourceCodeCacheLock) {
                if(!sourceCodeCache.ContainsKey(demo))
                    sourceCodeCache[demo] = CreateSourceCodePages(demo);
                return sourceCodeCache[demo];
            }
        }

        static IEnumerable<SourceCodePage> CreateSourceCodePages(DemoPageModel demo) {
            List<SourceCodePage> result = new List<SourceCodePage>();
            if(IsMvc) {
                foreach(string fileName in demo.SourceFiles) {
                    if(fileName.StartsWith("~/Models/"))
                        AddSourceCodePage(result, string.Format("Model ({0})", Path.GetFileNameWithoutExtension(fileName)), fileName, false);
                }
                string controllerUrl = string.Format("~/Controllers/{0}/{0}Controller.{1}.cs", demo.Group.Key, demo.Key);
                AddSourceCodePage(result, "Controller", controllerUrl, true, false);
                string commonControllerUrl = string.Format("~/Controllers/{0}Controller.cs", demo.Group.Key);
                AddSourceCodePage(result, "Controller (common)", commonControllerUrl, false);
                string viewUrl = string.Format("~/Views/{0}/{1}.cshtml", demo.Group.Key, demo.Key);
                AddSourceCodePage(result, "View", viewUrl, true, false);
                foreach(string fileName in demo.SourceFiles) {
                    if(fileName.StartsWith("~/Views/"))
                        AddSourceCodePage(result, string.Format("View ({0})", Path.GetFileNameWithoutExtension(fileName)), fileName, true);
                    else if(fileName.StartsWith("~/Code/"))
                        AddSourceCodePage(result, string.Format("{0}", Path.GetFileName(fileName)), fileName, true);
                    else if(!fileName.StartsWith("~/Models/"))
                        AddSourceCodePage(result, Path.GetFileName(fileName), fileName, false);
                }
            } else {
                string baseUrl = GenerateDemoUrl(demo);

                string[] highlightedTagNames = new string[0];
                if(!IsOverview)
                    highlightedTagNames = demo.Group.GetHighlightedTagNames().
                                          Concat(demo.GetHighlightedTagNames()).
                                          Concat(demo.Product.GetHighlightedTagNames()).ToArray();
                AddSourceCodePage(result, "ASPX", baseUrl, true, true, highlightedTagNames);
                if(HasCodeFile(baseUrl)) {
                    AddSourceCodePage(result, "C#", baseUrl + ".cs", CodeLanguage == "C#", true);
                    AddSourceCodePage(result, "VB", baseUrl + ".vb", CodeLanguage == "VB");
                }
                foreach(string fileName in demo.SourceFiles)
                    AddSourceCodePage(result, Path.GetFileName(fileName), fileName, false, true, highlightedTagNames);
            }
            return result;
        }

        static void AddSourceCodePage(List<SourceCodePage> list, string title, string url, bool expanded) {
            AddSourceCodePage(list, title, url, expanded, true, new string[0]);
        }
        static void AddSourceCodePage(List<SourceCodePage> list, string title, string url, bool expanded, bool showIfError) {
            AddSourceCodePage(list, title, url, expanded, showIfError, new string[0]);
        }
        static void AddSourceCodePage(List<SourceCodePage> list, string title, string url, bool expanded, bool showIfError, string[] highlightedTagNames) {
            string content = string.Empty;
            try {
                content = GetHighlightedFileContent(url, highlightedTagNames);
            } catch {
                content = showIfError ? "Error rendering source code" : string.Empty;
            }
            if(!string.IsNullOrEmpty(content))
                list.Add(new SourceCodePage(title, content, expanded));
        }
        static bool HasCodeFile(string url) {
            string filePath = GetHighlightedFilePath(url);
            if(!File.Exists(filePath))
                return false;
            string text = File.ReadAllText(filePath);
            return Regex.IsMatch(text, @"<[^>]*\bCodeFile\s*=\s*""[\w\.]+\""[^>]*>");
        }
        static string GetHighlightedFileContent(string virtualPath, string[] highlightedTagNames) {
            string filePath = GetHighlightedFilePath(virtualPath);
            string text = File.ReadAllText(filePath);
            return CodeFormatter.GetFormattedCode(Path.GetExtension(filePath), text, IsMvc, highlightedTagNames);
        }
        static string GetHighlightedFilePath(string virtualPath) {
            string result = new DirectoryInfo(Context.Server.MapPath("~/")).FullName;
            result = Path.Combine(result, ".Source");
            result = Path.Combine(result, virtualPath.Substring(2));
            if(File.Exists(result))
                return result;

            result = Context.Server.MapPath(virtualPath);
            if(!File.Exists(result))
                result = CorrectSourceFilePath(result);
            return result;
        }

        static string CorrectSourceFilePath(string filePath) {
            string csPathItem = String.Format("{0}cs{0}", Path.DirectorySeparatorChar);
            string vbPathItem = String.Format("{0}vb{0}", Path.DirectorySeparatorChar);
            filePath = filePath.ToLower();
            if(filePath.EndsWith(".cs"))
                return filePath.Replace(vbPathItem, csPathItem);
            if(filePath.EndsWith(".vb"))
                return filePath.Replace(csPathItem, vbPathItem);
            return filePath;
        }

        public static string GetVersionText() {
            string[] parts = AssemblyInfo.Version.Split('.');
            return string.Format("v{0} vol {1}.{2}", 2000 + int.Parse(parts[0]), parts[1], parts[2]);
        }

        public static string GetVersionSuffix() {
            return AssemblyInfo.Version.Replace(".", "_");
        }

        public static void RegisterCurrentWebFormsDemo(Page page) {
            string path = page.AppRelativeVirtualPath.ToLower().Replace("~/", "").Replace(".aspx", "");
            string[] parts = path.Split('/');
            if(parts.Length < 1)
                throw new ArgumentException("Invalid demo URL");

            string groupKey = "";
            string demoKey = "";

            if(parts.Length > 1) {
                groupKey = parts[0];
                demoKey = parts[1];
            } else {
                demoKey = parts[0];
            }

            RegisterCurrentDemo(groupKey, demoKey);
        }

        public static void RegisterCurrentMvcDemoOnCallback() {
            string controllerName = Request.RequestContext.RouteData.Values["controller"].ToString();
            string actionName = string.Empty;

            string[] demoUriParts = Request.UrlReferrer.Segments;
            var controllerNamePartIndex = demoUriParts.FindIndex(part => part.Trim('/') == controllerName);

            if(controllerNamePartIndex > -1 && Request.AppRelativeCurrentExecutionFilePath.Contains(controllerName)) {
                if(demoUriParts.Length > controllerNamePartIndex + 1)
                    actionName = demoUriParts[controllerNamePartIndex + 1];
                else {
                    // overview demo
                    actionName = controllerName;
                    controllerName = string.Empty;
                }
            }

            RegisterCurrentMvcDemo(controllerName, !string.IsNullOrEmpty(actionName) ? actionName : "Index");
        }
        public static void RegisterCurrentMvcDemo(string controllerName, string actionName) {
            RegisterCurrentDemo(controllerName, actionName);
        }
        public static bool IsIntroPage(string groupKey, string demoKey) {
            if(IsMvc)
                return groupKey.Equals("Home", StringComparison.InvariantCultureIgnoreCase) && demoKey.Equals("Index", StringComparison.InvariantCultureIgnoreCase);
            return demoKey.Equals("default", StringComparison.InvariantCultureIgnoreCase);
        }
        public static bool IsOverviewPage(string demoKey) {
            return demoKey.Equals("overview", StringComparison.InvariantCultureIgnoreCase);
        }
        static void RegisterCurrentDemo(string groupKey, string demoKey) {
            DemoModel demo = null;
            if(IsIntroPage(groupKey, demoKey))
                demo = DemosModel.Current.Intro;
            else if(IsOverviewPage(demoKey) && String.IsNullOrEmpty(groupKey))
                demo = DemosModel.Current.Overview;
            else if (IsErrorPage(demoKey)) {
                demo = CreateErrorPageDemoModel();
            } else {
                DemoGroupModel group = DemosModel.Current.FindGroup(groupKey);
                if(group != null)
                    demo = group.FindDemo(demoKey);
            }

            if(demo == null)
                demo = CreateBogusDemoModel();

            Context.Items[CurrentDemoKey] = demo;
            DevExpress.Web.Internal.DemoUtils.RegisterDemo(DemosModel.Current.Key, groupKey, demoKey);
        }

        static DemoPageModel CreateBogusDemoModel() {
            DemoGroupModel group = new DemoGroupModel();
            group.Title = "ASP.NET";

            DemoPageModel result = new DemoPageModel();
            result.Group = group;
            result.HideSourceCode = true;
            result.Title = BogusDemoTitle;

            return result;
        }

        static DemoPageModel CreateErrorPageDemoModel() {
            DemoPageModel result = new DemoPageModel { 
                IsErrorPage = true,
                Product = DemosModel.Current,
                Group = new DemoGroupModel()
            };
            return result;
        }

        public static string GetCurrentDemoPageTitle() {
            StringBuilder builder = new StringBuilder();
            if (CurrentDemo.IsErrorPage) { 
                builder.Append("Error Page - ");
                builder.Append(DemosModel.Current.GetSeoTitle());
                if (!DemosModel.Current.IsRootDemo) 
                    builder.Append(" Demo");
            } else if(CurrentDemo is IntroPageModel) {
                builder.Append(CurrentDemo.SeoTitle);
            }
            else if(CurrentDemo is DemoPageModel) {                
                string product = DemosModel.Current.GetSeoTitle();
                DemoGroupModel demoGroup = ((DemoPageModel)CurrentDemo).Group;
                string group = demoGroup != null ? demoGroup.SeoTitle : null;

                builder.Append(CurrentDemo.GetSeoTitle());
                builder.Append(" - ");
                builder.Append(string.IsNullOrEmpty(group) ? product : group);
                builder.Append(" Demo");
            }
            builder.Append(" | DevExpress");
            return builder.ToString();
        }

        public static string GetDemoNavigationTitle() {
            string result = Utils.CurrentDemo.Product.NavItemTitle;
            if(Utils.CurrentDemoPage.Group != null)
                result += " - " + Utils.CurrentDemoPage.Group.Title;
            return result;
        }

        public static void RegisterCssLink(Page page, string url) {
            RegisterCssLink(page, url, null);
        }

        public static string GetDescriptionTitle() {
            if(Utils.CurrentOverview != null && !string.IsNullOrEmpty(Utils.CurrentOverview.DescriptionTitle))
                return Utils.CurrentOverview.DescriptionTitle;
            return string.Format("About the {0}", Utils.CurrentDemoPage.Group == null ? Utils.CurrentDemo.Product.NavItemTitle : Utils.CurrentDemoPage.Group.Title);
        }

        public static void RegisterCssLink(Page page, string url, string clientId) {
            if(IsMvc)
                throw new NotImplementedException();
            HtmlLink link = new HtmlLink();
            page.Header.Controls.Add(link);
            link.EnableViewState = false;
            link.Attributes["type"] = "text/css";
            link.Attributes["rel"] = "stylesheet";
            if(!string.IsNullOrEmpty(clientId))
                link.Attributes["id"] = clientId;
            link.Href = url;
        }

        public static string GenerateDemoUrl(DemoModel demo) {
            if(!string.IsNullOrEmpty(demo.HighlightedLink))
                return demo.HighlightedLink;
            StringBuilder str = new StringBuilder();
            if(demo.Product.IsCurrent) {
                str.Append("~/");
            } else {
                var url = HttpContext.Current.Request.Url.AbsolutePath;
                var productUrl = "/" + CurrentDemo.Product.Url;
                url = url.Substring(0, url.IndexOf(productUrl, StringComparison.InvariantCultureIgnoreCase) + 1);
                str.AppendFormat("{0}{1}/", url, demo.Product.Url);
            }

            DemoGroupModel demoGroup = demo is DemoPageModel ? ((DemoPageModel)demo).Group : null;
            if(demoGroup != null && !string.IsNullOrEmpty(demoGroup.Key)) {
                str.Append(demoGroup.Key);
                str.Append("/");
            }
            if(!IsMvc || !string.Equals("Index", demo.Key))
                str.Append(demo.Key);
            if(!IsMvc)
                str.Append(".aspx");
            return str.ToString();
        }

        public static List<FeaturedDemoInfo> GenerateFeaturedDemos() {
            var result = new List<FeaturedDemoInfo>();
            foreach(var demo in DemosModel.Current.HighlightedDemos) {
                result.Add(new FeaturedDemoInfo {
                    Title = demo.GetHighlightedTitle(),
                    ImageUrl = demo.HighlightedImageUrl,
                    NavigateUrl = GenerateDemoUrl(demo),
                    Description = demo.HighlightedDescription
                });
            }
            if(Utils.CurrentIntro != null) {
                foreach(var demo in Utils.CurrentIntro.ExternalDemos) {
                    result.Add(new FeaturedDemoInfo {
                        Title = demo.Title,
                        ImageUrl = demo.ImageUrl,
                        NavigateUrl = demo.Url
                    });
                }
            }
            return result;
        }
        public static List<ProductInfo> GenerateProductDemos(bool highlited) {
            var result = new List<ProductInfo>();
            foreach(var item in DemosModel.Instance.SortedDemoProducts.Where(p => !p.HideNavItem && !p.IsRootDemo && p.IntegrationHighlighted == highlited)) {
                result.Add(new ProductInfo() {
                    NavigateUrl = GenerateDemoUrl(item.Intro),
                    ImageUrl = item.IntegrationImageUrl,
                    Description = item.IntegrationDescription,
                    Title = item.NavItemTitle
                });
            }
            return result;
        }
        public static void EnsureRequestValidationMode() {
            try {
                if(Environment.Version.Major >= 4) {
                    Type type = typeof(WebControl).Assembly.GetType("System.Web.Configuration.RuntimeConfig");
                    MethodInfo getConfig = type.GetMethod("GetConfig", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[] { }, null);
                    object runtimeConfig = getConfig.Invoke(null, null);
                    MethodInfo getSection = type.GetMethod("GetSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(string), typeof(Type) }, null);
                    HttpRuntimeSection httpRuntimeSection = (HttpRuntimeSection)getSection.Invoke(runtimeConfig, new object[] { "system.web/httpRuntime", typeof(HttpRuntimeSection) });
                    FieldInfo bReadOnly = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
                    bReadOnly.SetValue(httpRuntimeSection, false);

                    PropertyInfo pi = typeof(HttpRuntimeSection).GetProperty("RequestValidationMode");
                    if(pi != null) {
                        Version version = (Version)pi.GetValue(httpRuntimeSection, null);
                        Version RequiredRequestValidationMode = new Version(2, 0);
                        if(version != null && !Version.Equals(version, RequiredRequestValidationMode)) {
                            pi.SetValue(httpRuntimeSection, RequiredRequestValidationMode, null);
                        }
                    }
                    bReadOnly.SetValue(httpRuntimeSection, true);
                }
            } catch {
            }
        }

        static bool? _isSiteMode;
        public static bool IsSiteMode {
            get {
                if(!_isSiteMode.HasValue) {
                    _isSiteMode = ConfigurationManager.AppSettings["SiteMode"].Equals("true", StringComparison.InvariantCultureIgnoreCase);
                }
                return _isSiteMode.Value;
            }
        }

        public static string GetReadOnlyMessageHtml() {
            return String.Format(
                "<b>Data modifications are not allowed in the online demo.</b><br />" +
                "If you need to test data editing functionality, please install " +
                "{0} on your machine and run the demo locally.", DemosModel.Current.Title);
        }
        public static string GetReadOnlyMessageText() {
            return String.Format(
                "Data modifications are not allowed in the online demo.\n" +
                "If you need to test data editing functionality, please install \n" +
                "{0} on your machine and run the demo locally.", DemosModel.Current.Title);
        }

        public static void AssertNotReadOnly() {
            if(!IsSiteMode)
                return;
            throw new DemoException(GetReadOnlyMessageHtml());
        }
        public static void AssertNotReadOnlyText() {
            if(!IsSiteMode)
                return;
            throw new DemoException(GetReadOnlyMessageText());
        }
        public static bool CanChangeTheme {
            get {
                return !IsIntro && !IsIE6() && DemosModel.Current.SupportsTheming;
            }
        }
        public static bool CanChangeBaseColor {
            get {
                return ThemesModel.Current.Groups.Where(g => g.Themes.Where(t => t.Name == CurrentTheme && !String.IsNullOrEmpty(t.BaseColor)).Count() != 0).Count() > 0;
            }
        }
        public static bool CanApplyThemeParameters {
            get {
                return DemosModel.Current.SupportsThemeParameters && (!string.IsNullOrEmpty(CurrentThemeDefaultFont) || !string.IsNullOrEmpty(CurrentThemeDefaultBaseColor));
            }
        }
        public static string CurrentThemeDefaultFont { get { return CurrentThemeModel.Font; } }
        public static string CurrentThemeDefaultFontSize { get { return CurrentThemeModel.FontSize; } }
        public static string CurrentThemeDefaultBaseColor { get { return CurrentThemeModel.BaseColor; } }

        static ThemeModel CurrentThemeModel {
            get { return ThemesModel.Current.Groups.SelectMany(g => g.Themes).FirstOrDefault(t => t.Name == CurrentTheme); }
        }
        public static string[] CustomFonts {
            get {
                return new string[] { 
                    CurrentThemeDefaultFont, 
                    CurrentThemeDefaultFontSize + " " + "'Asap', normal",
                    CurrentThemeDefaultFontSize + " " + "'Arima Madurai', normal",
                    CurrentThemeDefaultFontSize + " " + "'Comfortaa', normal"
                };
            }
        }
        public static object GetFontFamiliesDataSource() {
            return CustomFonts.Select(f => new { Text = GetShortFontName(f), Value = f });
        }
        static string GetShortFontName(string fullName) {
            if(string.IsNullOrWhiteSpace(fullName))
                return fullName;
            return fullName.Substring(fullName.IndexOf(' ') + 1, fullName.IndexOf(',') - fullName.IndexOf(' ') - 1).Trim('\'');
        }
        public static string[] CustomBaseColors {
            get {
                return new string[] {
                    CurrentThemeDefaultBaseColor,
                    "#4796CE",
                    "#35B86B",
                    "#CE5B47",
                    "#F7A233",
                    "#9F47CE",
                    "#5C57C9",
                    "#CE4776",
                };
            }
        }
        public static void ResolveThemeParametes() {
            if(!CanChangeTheme || !DemosModel.Current.SupportsThemeParameters)
                return;

            string baseColor = CurrentBaseColor;
            string font = CurrentFont;

            if(IsThemeChanged || !string.IsNullOrEmpty(baseColor) && !CustomBaseColors.Contains(baseColor) || baseColor == CurrentThemeDefaultBaseColor) {
                baseColor = string.Empty;
                SetCurrentBaseColorCookie(baseColor);
            }
            if(IsThemeChanged || !string.IsNullOrEmpty(font) && !CustomFonts.Contains(font) || font == CurrentThemeDefaultFont) {
                font = string.Empty;
                SetCurrentFontCookie(font);
            }

            TunableTheme = CurrentTheme;
            ASPxWebControl.GlobalThemeBaseColor = baseColor;
            ASPxWebControl.GlobalThemeFont = font;
        }
        public static void ResetThemeParameters() {
            ASPxWebControl.GlobalThemeBaseColor = null;
            ASPxWebControl.GlobalThemeFont = null;
        }
        static bool IsThemeChanged {
            get {
                return CurrentTheme != TunableTheme;
            }
        }
        public static string GetAccessibilityRoleAttribute(string role) {
            if (IsAccessibilityDemo)
                return "role=\"" + role + "\"";
            return string.Empty;
        }

        public static bool IsAccessibilityDemo {
            get {
                if (Request == null)
                    return false;
                string demoUrl = Request.Url.AbsolutePath.ToLower();
                return demoUrl.IndexOf("compliance") != -1 || (demoUrl.IndexOf("accessibility") != -1 && demoUrl.IndexOf("linkedcontrols") != -1);
            }
        }

        public static void InjectDescriptionMeta(Control parent) {
            if(String.IsNullOrEmpty(Utils.CurrentDemo.MetaDescription))
                return;

            Page page = parent as Page;
            HtmlHead header = (page != null && page.Header != null) ? page.Header : RenderUtils.FindHead(parent);
            if(header != null) {
                LiteralControl metaControl = new LiteralControl(string.Format("<meta name=\"description\" content=\"{0}\" />", Utils.CurrentDemo.MetaDescription));
                header.Controls.AddAt(0, metaControl);
            }
        }

        public static bool IsIE6() {
            return RenderUtils.Browser.IsIE && RenderUtils.Browser.Version < 7;
        }

        public static bool IsIE9() {
            return RenderUtils.Browser.IsIE && RenderUtils.Browser.Version > 8;
        }

        public static bool IsIE10() {
            return RenderUtils.Browser.IsIE && RenderUtils.Browser.Version > 9;
        }

        public static string EncodeUrl(string url) {
            return Uri.EscapeUriString(url.Trim());
        }

        public static string FormatSize(object value) {
            double amount = Convert.ToDouble(value);
            string unit = "KB";
            if(amount != 0) {
                if(amount <= 1024)
                    amount = 1;
                else
                    amount /= 1024;

                if(amount > 1024) {
                    amount /= 1024;
                    unit = "MB";
                }
                if(amount > 1024) {
                    amount /= 1024;
                    unit = "GB";
                }
            }
            return String.Format("{0:#,0} {1}", Math.Round(amount, MidpointRounding.AwayFromZero), unit);
        }

        private static bool IsErrorPage(string demoKey) {
            return demoKey.Equals("Error404", StringComparison.OrdinalIgnoreCase) || 
                demoKey.Equals("Error500", StringComparison.OrdinalIgnoreCase);
        }
    }
    public static class SearchUtils {
        static readonly string[] separators = new string[] { " ", ",", "/", "\\", "-", "+" };

        static string[] _requestExclusions;
        static string[] _prefixes;
        static string[] _postfixes;
        static string[][] _synonyms;

        static string[] WordsExclusions {
            get {
                if(_requestExclusions == null)
                    _requestExclusions = DemosModel.Instance.Search.Exclusions.Words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                return _requestExclusions;
            }
        }
        static string[] PrefixesExclusions {
            get {
                if(_prefixes == null)
                    _prefixes = DemosModel.Instance.Search.Exclusions.Prefixes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                return _prefixes;
            }
        }
        static string[] PostfixesExclusions {
            get {
                if(_postfixes == null)
                    _postfixes = DemosModel.Instance.Search.Exclusions.Postfixes.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                return _postfixes;
            }
        }
        static string[][] Synonyms {
            get {
                if(_synonyms == null)
                    _synonyms = DemosModel.Instance.Search.Synonyms.Groups.Select(s => s.Split(separators, StringSplitOptions.RemoveEmptyEntries)).ToArray();
                return _synonyms;
            }
        }

        public static List<SearchResult> DoSearch(string request) {
            var results = new List<SearchResult>();
            if(!string.IsNullOrEmpty(request)) {
                var requests = SplitRequests(request);
                try {
                    var products = DemosModel.Instance.SortedDemoProducts.Where(dp => !dp.IsRootDemo && (dp == DemosModel.Current || (!dp.HideNavItem && Utils.IsSiteMode)));
                    foreach(var product in products) {
                        results.AddRange(DoSearch(requests, product));
                    }
                }
                catch {
                }
                results = results.OrderByDescending(sr => sr.Rank).ThenBy(sr => sr.Product.OrderIndex).ToList();
            }
            return results;
        }
        public static Dictionary<string, int> GetKeywordsRankList(ModelBase model) {
            List<TextRank> textRanks = new List<TextRank>() { 
                new TextRank(model.Keywords, 3)
            };

            var product = model as DemoProductModel;
            var group = model as DemoGroupModel;
            var demo = model as DemoPageModel;
            var overview = model as OverviewPageModel;

            if(product != null) {
                textRanks.Add(new TextRank(product.NavItemTitle, 5));
                textRanks.Add(new TextRank(product.Key, 3));
                textRanks.Add(new TextRank(product.Title, 3));
                textRanks.Add(new TextRank(product.SeoTitle, 2));
            } else if(group != null) {
                textRanks.Add(new TextRank(group.Title, 5));
                textRanks.Add(new TextRank(group.Key, 3));
                textRanks.Add(new TextRank(group.SeoTitle, 2));
            } else if(demo != null) {
                if(overview != null) {
                    if(overview.Group != null)
                        textRanks.Add(new TextRank(overview.Group.Title, 7));
                    else if(overview.Product != null)
                        textRanks.Add(new TextRank(overview.Product.Title, 15));
                } else
                    textRanks.Add(new TextRank(demo.Title, 5));
                textRanks.Add(new TextRank(demo.Key, 3));
                textRanks.Add(new TextRank(demo.SeoTitle, 2));
                textRanks.Add(new TextRank(demo.Links, 2));
            }
            return GetKeywordsRankList(textRanks);
        }

        static int CalculateRank(List<string[]> requests, DemoPageModel demo) {
            int resultRank = 0;
            int keywordRank = 0;
            foreach(var request in requests) {
                int requestRank = -1;
                if(CalculateRank(request, demo.KeywordsRankList, out keywordRank))
                    requestRank += keywordRank;
                if(demo.Group != null && CalculateRank(request, demo.Group.KeywordsRankList, out keywordRank))
                    requestRank += keywordRank;
                if(CalculateRank(request, demo.Product.KeywordsRankList, out keywordRank))
                    requestRank += keywordRank;
                if(requestRank == -1 && WordsExclusions.Any(re => re.Equals(request[0], StringComparison.InvariantCultureIgnoreCase)))
                    requestRank = 0;

                if(requestRank > -1)
                    resultRank += requestRank;
                else
                    return -1;
            }
            return resultRank;
        }
        static bool CalculateRank(string[] synonyms, Dictionary<string, int> keywordsRankList, out int rank) {
            var keyword = keywordsRankList.Keys.FirstOrDefault(k => MatchWord(synonyms[0], k));
            rank = keyword != null ? keywordsRankList[keyword] : -1;
            if(rank == -1) {
                foreach(var syn in synonyms.Skip(1)) {
                    keyword = keywordsRankList.Keys.FirstOrDefault(k => MatchWord(syn, k));
                    rank += keyword != null ? keywordsRankList[keyword] : -1;
                    if(rank > -1)
                        break;
                }
            }
            return rank > -1;
        }
        static IEnumerable<SearchResult> DoSearch(List<string[]> requests, DemoProductModel product) {
            var results = new List<SearchResult>();
            if(product.Overview != null)
                results.AddRange(GetRes(requests, product.Overview, string.Format("{0}", HighlightOccurences(product.Overview.Title, requests)), product.Overview.Product.Title.ToUpper()));
            foreach(var group in product.Groups) {
                if(group.Overview != null)
                    results.AddRange(GetRes(requests, group.Overview, string.Format("{0} ({1})", HighlightOccurences(group.Overview.Title, requests), HighlightOccurences(group.Overview.Group.Title, requests)), group.Overview.Product.Title.ToUpper()));
                foreach(var demo in group.Demos)
                    results.AddRange(GetRes(requests, demo, string.Format("{0} ({1})", HighlightOccurences(demo.Title, requests), HighlightOccurences(demo.Group.Title, requests)), demo.Product.Title.ToUpper()));
            }
            return results;
        }
        static IEnumerable<SearchResult> GetRes(List<string[]> requests, DemoPageModel demo, string text, string productText) {
            var results = new List<SearchResult>();
            var rank = CalculateRank(requests, demo);
            if(rank > -1) {
                var sr = new SearchResult(demo, rank);
                sr.Text = text;
                sr.ProductText = productText;
                results.Add(sr);
            }
            return results;
        }

        static string HighlightOccurences(string text, List<string[]> requests) {
            var validRequest = new Regex("[0-9a-zA-Z]{2,}", RegexOptions.IgnoreCase);
            foreach(var request in requests.SelectMany(r => r)) {
                if(validRequest.IsMatch(request)) {
                    Regex re = new Regex("([a-zA-Z0-9]*" + request + "[a-zA-Z0-9]*)", RegexOptions.IgnoreCase);
                    text = re.Replace(text, "<b>$0</b>");
                }
            }
            return text;
        }

        static List<string[]> SplitRequests(string request) {
            var words = request.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string[]>();
            foreach(var word in words) {
                var resultWord = PrepareWord(word);
                var synonymList = Synonyms.FirstOrDefault(list => list.Any(s => MatchWord(resultWord, s)));
                var wordSynonyms = new List<string>() { resultWord };
                if(synonymList != null)
                    wordSynonyms.AddRange(synonymList.Where(s => !MatchWord(resultWord, s)));
                result.Add(wordSynonyms.Distinct().ToArray());
            }
            return result;
        }
        static string PrepareWord(string word) {
            foreach(var prefix in PrefixesExclusions) {
                if(word.StartsWith(prefix, StringComparison.InvariantCultureIgnoreCase) && word.Length > prefix.Length)
                    word = word.Remove(0, prefix.Length);
            }
            foreach(var postfix in PostfixesExclusions) {
                if(word.EndsWith(postfix, StringComparison.InvariantCultureIgnoreCase) && word.Length > postfix.Length)
                    word = word.Substring(0, word.Length - postfix.Length);
            }
            return word;
        }
        static bool MatchWord(string request, string word) {
            return word.IndexOf(request, StringComparison.InvariantCultureIgnoreCase) > -1;
        }
        internal static string[] GetKeywordsList(params string[] words) {
            return words
                .SelectMany(w => w.Split(separators, StringSplitOptions.RemoveEmptyEntries))
                .Distinct()
                .ToArray();
        }

        static Dictionary<string, int> GetKeywordsRankList(List<TextRank> textRanks) {
            var result = new Dictionary<string, int>();
            foreach(var textRank in textRanks) {
                var words = textRank.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach(var word in words) {
                    var rankWord = PrepareWord(word);
                    if(!result.ContainsKey(rankWord))
                        result[rankWord] = textRank.Rank;
                }
            }
            return result.OrderByDescending(keyValuePair => keyValuePair.Value).ToDictionary(keyValuePair => keyValuePair.Key, keyValuePair => keyValuePair.Value);
        }
    }


    public class TextRank {
        public TextRank(string text, int rank) {
            this.Text = text;
            this.Rank = rank;
        }
        public string Text {
            get;
            set;
        }
        public int Rank {
            get;
            set;
        }
    }

    public class ErrorMessageModel {
        public string Title { get; set; }
        public string NavigateUrl { get; set; }
    }

    public class SearchResult : IComparable<SearchResult> {
        public SearchResult(DemoModel demo, int rank) {
            this.Demo = demo;
            this.Rank = rank;
            Product = demo.Product;
            if(demo is DemoPageModel)
                Group = (demo as DemoPageModel).Group;
        }

        public DemoProductModel Product {
            get;
            set;
        }
        public DemoModel Demo {
            get;
            set;
        }
        public DemoGroupModel Group {
            get;
            set;
        }
        public string Text {
            get;
            set;
        }
        public string ProductText {
            get;
            set;
        }

        public int Rank = 0;

        #region IComparable<SearchResult> Members

        public int CompareTo(SearchResult other) {
            return other.Rank.CompareTo(Rank);
        }

        #endregion
    }
    public class DemoException : Exception {
        public DemoException(string message) : base(message) { }
    }
}
