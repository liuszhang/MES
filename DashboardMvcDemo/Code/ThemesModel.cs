using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Linq;

namespace DevExpress.Web.Demos {

    [XmlRoot("Themes")]
    public class ThemesModel {
        static ThemesModel _current;
        static readonly object _currentLock = new object();

        public static ThemesModel Current {
            get {
                lock(_currentLock) {
                    if(_current == null) {
                        using(Stream stream = File.OpenRead(HttpContext.Current.Server.MapPath("~/App_Data/Themes.xml"))) {
                            XmlSerializer serializer = new XmlSerializer(typeof(ThemesModel));
                            _current = (ThemesModel)serializer.Deserialize(stream);
                        }
                    }
                    return _current;
                }
            }
        }

        List<ThemeGroupModel> _groups = new List<ThemeGroupModel>();

        [XmlElement("ThemeGroup")]
        public List<ThemeGroupModel> Groups {
            get { return _groups; }
        }
        public List<ThemeGroupModel> LeftGroups {
            get { return (from g in Groups where g.Float == "Left" select g).ToList(); }
        }
        public List<ThemeGroupModel> RightGroups {
            get { return (from g in Groups where g.Float == "Right" select g).ToList(); }
        }
    }

}
