using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.CodeParser;
using DevExpress.CodeParser.CSharp;
using DevExpress.CodeParser.Html;
using DevExpress.CodeParser.VB;
using DevExpress.CodeParser.JavaScript;
using DevExpress.CodeParser.Xml;
using DevExpress.CodeParser.Css;
using System.Text;

namespace DevExpress.Web.Demos {
    public static class CodeFormatter {
        const string StartHighlightedCodeBlockMarker = "<%--start highlighted block--%>";
        const string EndHighlightedCodeBlockMarker = "<%--end highlighted block--%>";
        const string StartHighlightedDivElement = "<div class=\"HighlightedBlock\">";
        const string StartNotHighlightedDivElement = "<div class=\"NotHighlightedBlock\">";
        const string StartHighlightedMinorElement = "<div class=\"HighlightedMinorBlock\">";

        static Dictionary<TokenCategory, TokenCategoryClassProvider> _cssClasses = new Dictionary<TokenCategory, TokenCategoryClassProvider>();

        static CodeFormatter() {
            CssClasses.Add(TokenCategory.Text, new TokenCategoryClassProvider("cr-text", new KeyValuePair<TokenLanguage, string>(TokenLanguage.Html, "cr-text-html")));
            CssClasses.Add(TokenCategory.Keyword, new TokenCategoryClassProvider("cr-keyword", new KeyValuePair<TokenLanguage, string>(TokenLanguage.Html, "cr-keyword-html"), new KeyValuePair<TokenLanguage, string>(TokenLanguage.Css, "cr-keyword-css")));
            CssClasses.Add(TokenCategory.Operator, new TokenCategoryClassProvider("cr-operator"));
            CssClasses.Add(TokenCategory.PreprocessorKeyword, new TokenCategoryClassProvider("cr-preproc", new KeyValuePair<TokenLanguage, string>(TokenLanguage.Html, "cr-preproc-html")));
            CssClasses.Add(TokenCategory.String, new TokenCategoryClassProvider("cr-string", new KeyValuePair<TokenLanguage, string>(TokenLanguage.Html, "cr-string-html"), new KeyValuePair<TokenLanguage, string>(TokenLanguage.Css, "cr-string-css")));
            CssClasses.Add(TokenCategory.Number, new TokenCategoryClassProvider("cr-number"));
            CssClasses.Add(TokenCategory.Identifier, new TokenCategoryClassProvider("cr-identifier"));
            CssClasses.Add(TokenCategory.HtmlServerSideScript, new TokenCategoryClassProvider("cr-htmlserverscript"));
            CssClasses.Add(TokenCategory.HtmlString, new TokenCategoryClassProvider("cr-htmlstring"));
            CssClasses.Add(TokenCategory.Unknown, new TokenCategoryClassProvider("cr-unknown"));
            CssClasses.Add(TokenCategory.Comment, new TokenCategoryClassProvider("cr-comment"));
            CssClasses.Add(TokenCategory.XmlComment, new TokenCategoryClassProvider("cr-xmlcomment"));
            CssClasses.Add(TokenCategory.CssComment, new TokenCategoryClassProvider("cr-csscomment"));
            CssClasses.Add(TokenCategory.CssKeyword, new TokenCategoryClassProvider("cr-csskeyword"));
            CssClasses.Add(TokenCategory.CssPropertyName, new TokenCategoryClassProvider("cr-csspropertyname"));
            CssClasses.Add(TokenCategory.CssPropertyValue, new TokenCategoryClassProvider("cr-csspropertyvalue"));
            CssClasses.Add(TokenCategory.CssSelector, new TokenCategoryClassProvider("cr-cssselector"));
            CssClasses.Add(TokenCategory.CssStringValue, new TokenCategoryClassProvider("cr-cssstringvalue"));
            CssClasses.Add(TokenCategory.HtmlElementName, new TokenCategoryClassProvider("cr-htmlelementname"));
            CssClasses.Add(TokenCategory.HtmlEntity, new TokenCategoryClassProvider("cr-htmlentity"));
            CssClasses.Add(TokenCategory.HtmlOperator, new TokenCategoryClassProvider("cr-htmloperator"));
            CssClasses.Add(TokenCategory.HtmlComment, new TokenCategoryClassProvider("cr-htmlcomment"));
            CssClasses.Add(TokenCategory.HtmlAttributeName, new TokenCategoryClassProvider("cr-htmlattributename"));
            CssClasses.Add(TokenCategory.HtmlAttributeValue, new TokenCategoryClassProvider("cr-htmlattributevalue"));
            CssClasses.Add(TokenCategory.HtmlTagDelimiter, new TokenCategoryClassProvider("cr-htmltagdelimiter"));
        }

        public static Dictionary<TokenCategory, TokenCategoryClassProvider> CssClasses {
            get {
                return _cssClasses;
            }
        }

        public static TokenLanguage ParseLanguage(string lang) {
            return (TokenLanguage)Enum.Parse(typeof(TokenLanguage), lang, true);
        }

        public static TokenLanguage GetLanguageByFileExtension(string extension) {
            switch(extension.ToLower()) {
                case ".cs":
                    return TokenLanguage.CSharp;
                case ".vb":
                    return TokenLanguage.Basic;
                case ".html":
                case ".htm":
                case ".aspx":
                case ".ascx":
                case ".asax":
                case ".master":
                case ".cshtml":
                    return TokenLanguage.Html;
                case ".js":
                    return TokenLanguage.JavaScript;
                case ".xml":
                    return TokenLanguage.Xml;
                case ".css":
                    return TokenLanguage.Css;
                default:
                    return TokenLanguage.Unknown;
            }
        }

        public static string GetFormattedCode(string fileExtension, string code) {
            return GetFormattedCode(GetLanguageByFileExtension(fileExtension), code, false, new string[0]);
        }
        public static string GetFormattedCode(string fileExtension, string code, bool isMvc) {
            return GetFormattedCode(GetLanguageByFileExtension(fileExtension), code, isMvc, new string[0]);
        }
        public static string GetFormattedCode(string fileExtension, string code, bool isMvc, string[] highlightedTagNames) {
            return GetFormattedCode(GetLanguageByFileExtension(fileExtension), code, isMvc, highlightedTagNames);
        }
        public static string GetFormattedCode(TokenLanguage language, string code) {
            return GetFormattedCode(language, code, false, new string[0]);
        }
        public static string GetFormattedCode(TokenLanguage language, string code, bool isMvc) {
            return GetFormattedCode(language, code, isMvc, new string[0]);
        }
        public static string GetFormattedCode(TokenLanguage language, string code, bool isMvc, string[] highlightedTagNames) {
            DevExpress.CodeParser.TokenCollection tokens = GetTokens(language, code, isMvc);
            if(tokens != null)
                return GetFormattedCode(language, code, tokens, highlightedTagNames);
            return string.Empty;
        }

        class CodeLine {
            public int Indent;
            public string Html = "";

            public bool IsEmpty {
                get {
                    return Html.Trim().Length < 1;
                }
            }
        }
        static bool ContainsTokenInTagNames(string tokenValue, string[] highlightedTagNames) {
            foreach(string tagName in highlightedTagNames)
                if(tokenValue == tagName)
                    return true;
            return false;
        }

        static void StartNotHighlightedBlock(List<CodeLine> lines) {
            if(lines.Count == 0)
                lines.Add(new CodeLine { Html = StartNotHighlightedDivElement });
            else
                lines[lines.Count - 1].Html += StartNotHighlightedDivElement;
        }
        static void EndNotHighlightedBlock(ref CodeLine currentLine) {
            currentLine.Html += "</div>";
        }

        static void StartHighlightedBlockAndCloseNotHighlighted(List<CodeLine> lines, bool isComment) {
            lines[lines.Count - 1].Html += "</div>" + (isComment ? StartHighlightedMinorElement : StartHighlightedDivElement);
        }
        static void EndHighlightedBlockAndStartNotHighlighted(ref CodeLine currentLine) {
            currentLine.Html += "</div>" + StartNotHighlightedDivElement;
        }

        static bool HasHighlightedTagsOnPage(DevExpress.CodeParser.TokenCollection tokens, string[] highlightedTagNames) {
            foreach(CategorizedToken token in tokens) 
                if(ContainsTokenInTagNames(token.Value, highlightedTagNames))
                    return true;
            return false;
        }

        static bool IsComplexTag(DevExpress.CodeParser.TokenCollection tokens, int index) {
            for(int i = index; i < tokens.Count; i++) {
                if(tokens[i].Value == "/>")
                    return false;
                if(tokens[i].Value == ">")
                    return true;
            }
            return true;
        }

        static bool HasHighlightedCodeBlockMarker(string code) { 
            return code.Contains(StartHighlightedCodeBlockMarker);
        }

        static string GetFormattedCode(TokenLanguage language, string code, DevExpress.CodeParser.TokenCollection tokens, string[] highlightedTagNames) {
            if((int)language == (int)TokenLanguage.Html && highlightedTagNames.Length != 0 && HasHighlightedTagsOnPage(tokens, highlightedTagNames) || HasHighlightedCodeBlockMarker(code))
                return GetFormattedAspxCode(code, tokens, highlightedTagNames);
            else
                return GetFormattedOtherCode(code, tokens, highlightedTagNames);
        }
        static string GetFormattedAspxCode(string code, DevExpress.CodeParser.TokenCollection tokens, string[] highlightedTagNames) {
            int position = 0;
            int highlightedTagsCount = 0;
            bool needCloseHighlightedBlock = false;
            bool isStartedHighlightedComment = false;
            bool thisTagIsComplex = true;
            CodeLine currentLine = new CodeLine();
            List<CodeLine> lines = new List<CodeLine>();
            StartNotHighlightedBlock(lines);

            for(int i = 0; i < tokens.Count; i++) {
                CategorizedToken token = tokens[i] as CategorizedToken;
                if(token.Value == StartHighlightedCodeBlockMarker) {
                    isStartedHighlightedComment = true;
                    position = token.EndPosition;
                    continue;
                }
                if(ContainsTokenInTagNames(token.Value, highlightedTagNames)) {
                    if(tokens[i - 1].Value == "<" && tokens[i + 1].Value != ">") {
                        highlightedTagsCount++;
                        thisTagIsComplex = IsComplexTag(tokens, i);
                    }
                    if(highlightedTagsCount > 0) {
                        if(highlightedTagsCount == 1 && tokens[i + 1].Value != ">" && lines.Count > 0)
                            StartHighlightedBlockAndCloseNotHighlighted(lines, false);
                        AppendCodes(lines, ref currentLine, code, position, token);
                        if(tokens[i - 1].Value == "</" && tokens[i + 1].Value == ">") {
                            highlightedTagsCount--;
                            needCloseHighlightedBlock = highlightedTagsCount == 0;
                        }
                    }
                } else {
                    if(token.Value != StartHighlightedCodeBlockMarker && token.Value != EndHighlightedCodeBlockMarker)
                        AppendCodes(lines, ref currentLine, code, position, token);
                    if(lines.Count > 0 && isStartedHighlightedComment) {
                        StartHighlightedBlockAndCloseNotHighlighted(lines, true);
                        isStartedHighlightedComment = false;
                    }
                    if(!thisTagIsComplex && token.Value == "/>" || needCloseHighlightedBlock || token.Value == EndHighlightedCodeBlockMarker)
                        EndHighlightedBlockAndStartNotHighlighted(ref currentLine);

                    if(!thisTagIsComplex && token.Value == "/>")
                        if(highlightedTagsCount > 0)
                            highlightedTagsCount--;

                    if(needCloseHighlightedBlock)
                        needCloseHighlightedBlock = false;
                }
                position = token.EndPosition;
            }
            AppendCode(lines, ref currentLine, code.Substring(position), null);
            EndNotHighlightedBlock(ref currentLine);
            lines.Add(currentLine);
            
            return MergeCodeLines(lines);
        }
        static string GetFormattedOtherCode(string code, DevExpress.CodeParser.TokenCollection tokens, string[] highlightedTagNames) {
            CodeLine currentLine = new CodeLine();
            List<CodeLine> lines = new List<CodeLine>();
            int position = 0;
            foreach(CategorizedToken token in tokens) {
                AppendCode(lines, ref currentLine, code.Substring(position, token.StartPosition - position), null);
                AppendCode(lines, ref currentLine, token.Value, CssClasses[token.Category].GetClassName(token.Language));
                position = token.EndPosition;
            }
            AppendCode(lines, ref currentLine, code.Substring(position), null);
            lines.Add(currentLine);
            return MergeCodeLines(lines);
        }
        static void AppendCodes(List<CodeLine> lines, ref CodeLine currentLine, string code, int pos, CategorizedToken token) {
            AppendCode(lines, ref currentLine, code.Substring(pos, token.StartPosition - pos), null);
            AppendCode(lines, ref currentLine, token.Value, CssClasses[token.Category].GetClassName(token.Language));
        }
        static void AppendCode(List<CodeLine> lines, ref CodeLine currentLine, string code, string cssClass) {
            bool hasCss = !String.IsNullOrEmpty(cssClass);
            bool first = true;
            code = code.Replace("\r", "").Replace("\t", "    ");
            foreach(string line in code.Split('\n')) {
                string text = line;
                if(!first) {
                    lines.Add(currentLine);
                    currentLine = new CodeLine();
                    text = text.TrimStart();
                    currentLine.Indent = line.Length - text.Length;
                }
                if(first || text.Trim().Length > 0) {
                    if(hasCss)
                        currentLine.Html += String.Format("<span class=\"{0}\">", cssClass);
                    currentLine.Html += HttpUtility.HtmlEncode(text);
                    if(hasCss)
                        currentLine.Html += "</span>";
                }
                first = false;
            }
        }
        static string MergeCodeLines(List<CodeLine> lines) {
            int minIndent = int.MaxValue;
            foreach(CodeLine line in lines) {
                if(line.IsEmpty)
                    continue;
                if(line.Indent < minIndent)
                    minIndent = line.Indent;
            }

            StringBuilder result = new StringBuilder();
            int emptyLineCount = 0;

            foreach(CodeLine line in lines) {
                if(line.IsEmpty) {
                    if(result.Length > 0)
                        emptyLineCount++;
                    continue;
                }

                if(emptyLineCount > 0) {
                    for(int i = 0; i < emptyLineCount; i++)
                        result.Append("<br />");
                    emptyLineCount = 0;
                }

                int indent = line.Indent - minIndent;
                for(int i = 0; i < indent; i++)
                    result.Append("&nbsp;");
                result.Append(line.Html);

                if(!line.Html.Contains(StartHighlightedDivElement) && !line.Html.Contains("</div>") && result.Length > 0) 
                    result.Append("<br />");
            }

            return result.ToString().Trim();
        }

        static DevExpress.CodeParser.TokenCollection GetTokens(TokenLanguage language, string code, bool isMvc) {
            switch(language) {
                case TokenLanguage.CSharp:
                    return CSharpTokensHelper.GetTokens(code);
                case TokenLanguage.Basic:
                    return VBTokensHelper.GetTokens(code);
                case TokenLanguage.JavaScript:
                    return JavaScriptTokensHelper.GetTokens(code);
                case TokenLanguage.Html:
                    if(!isMvc)
                        return HtmlTokensHelper.GetTokens(code);
                    else
                        return HtmlTokensHelper.GetTokens(code, LanguageKind.Razor, DotNetLanguageType.CSharp);
                case TokenLanguage.Xml:
                    return new XmlTokensCategoryHelper().GetTokens(code);
                case TokenLanguage.Css:
                    return new CssTokensCategoryHelper().GetTokens(code);
                default:
                    return null;
            }
        }
    }
    public class TokenCategoryClassProvider {
        string className;
        Dictionary<TokenLanguage, string> languagesClassNames = new Dictionary<TokenLanguage, string>();

        public TokenCategoryClassProvider(string className)
            : this(className, null) {
        }
        public TokenCategoryClassProvider(string className, params KeyValuePair<TokenLanguage, string>[] languagesClassNames) {
            this.className = className;
            if(languagesClassNames != null) {
                foreach(KeyValuePair<TokenLanguage, string> languageClassName in languagesClassNames)
                    this.languagesClassNames[languageClassName.Key] = languageClassName.Value;
            }
        }
        public string GetClassName(TokenLanguage language) {
            if(this.languagesClassNames.ContainsKey(language))
                return this.languagesClassNames[language];
            return this.className;
        }
    }
}
