using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Web.UI;
using System.Drawing;

namespace DevExpress.Web.Demos {

    public class ThemeModel : ThemeModelBase {
        string _spriteCssClass;
        string _baseColor;
        string _fontFamily;
        string _fontSize;

        [XmlAttribute]
        public string SpriteCssClass {
            get {
                if(_spriteCssClass == null)
                    return "";
                return _spriteCssClass;
            }
            set { _spriteCssClass = value; }
        }
        [XmlAttribute]
        public string BaseColor {
            get {
                if(String.IsNullOrEmpty(_baseColor))
                    return "";
                return _baseColor;
            }
            set {
                _baseColor = value;
            }
        }
        [XmlAttribute]
        public string FontFamily {
            get {
                if(String.IsNullOrEmpty(_fontFamily))
                    return "";
                return _fontFamily;
            }
            set {
                _fontFamily = value;
            }
        }
        [XmlAttribute]
        public string FontSize {
            get {
                if(String.IsNullOrEmpty(_fontSize))
                    return "";
                return _fontSize;
            }
            set {
                _fontSize = value;
            }
        }
        public string Font {
            get {
                var result = string.Empty;
                if(!string.IsNullOrEmpty(FontSize) && !string.IsNullOrEmpty(FontFamily))
                    result = string.Format("{0} {1}", FontSize, FontFamily);
                return result;
            }
        }
    }

}
