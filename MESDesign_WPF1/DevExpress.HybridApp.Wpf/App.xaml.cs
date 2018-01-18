using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Media.Animation;
using DevExpress.Images;
using DevExpress.Internal;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using DevExpress.DevAV;
using DevExpress.Xpf.Printing;

namespace DevExpress.DevAV {
    public partial class App : Application {
        static IDisposable singleInstanceApplicationGuard;

        protected override void OnStartup(StartupEventArgs e) {
            Start(() => base.OnStartup(e), this);
        }
        public static void Start(Action baseStart, Application application) {
            ExceptionHelper.Initialize();
            AppDomain.CurrentDomain.AssemblyResolve += OnCurrentDomainAssemblyResolve;
            DataDirectoryHelper.LocalPrefix = "WpfHybridApp";
            ImagesAssemblyLoader.Load();
            Timeline.DesiredFrameRateProperty.OverrideMetadata(typeof(Timeline), new FrameworkPropertyMetadata(200));
            LoadPlugins();
            baseStart();
            ViewLocator.Default = new ViewLocator(typeof(App).Assembly);
            bool exit;
            singleInstanceApplicationGuard = DataDirectoryHelper.SingleInstanceApplicationGuard("DevExpressWpfHybridApp", out exit);
            if(exit) {
                application.Shutdown();
                return;
            }
            ApplicationThemeHelper.ApplicationThemeName = Theme.HybridApp.Name;
            SetCultureInfo();
            SetLocalization();
        }
        static void SetCultureInfo() {
            CultureInfo demoCI = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            demoCI.NumberFormat.CurrencySymbol = "$";
            demoCI.DateTimeFormat = new DateTimeFormatInfo();
            Thread.CurrentThread.CurrentCulture = demoCI;
            CultureInfo demoUI = (CultureInfo)Thread.CurrentThread.CurrentUICulture.Clone();
            demoUI.NumberFormat.CurrencySymbol = "$";
            demoUI.DateTimeFormat = new DateTimeFormatInfo();
            Thread.CurrentThread.CurrentUICulture = demoUI;
        }
        static void SetLocalization() {
            EditorLocalizer.Active = new HybridAppEditorLocalizer();
        }
        static Assembly OnCurrentDomainAssemblyResolve(object sender, ResolveEventArgs args) {
            string partialName = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower();
            if(partialName == "entityframework" || partialName == "system.data.sqlite" || partialName == "system.data.sqlite.ef6") {
                string path = Path.Combine(Path.GetDirectoryName(typeof(App).Assembly.Location), partialName + ".dll");
                return Assembly.LoadFrom(path);
            }
            return null;
        }
        #region LoadPlugins
        static void LoadPlugins() {
            foreach(string file in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments), "DevExpress.HybridApp.Wpf.Plugins.*.exe")) {
                Assembly.LoadFrom(file)
                    .With(x => x.GetType("Global.Program"))
                    .With(x => x.GetMethod("Start", BindingFlags.Static | BindingFlags.Public, null, new Type[] { }, null))
                    .Do(x => x.Invoke(null, new object[] { }));
            }
        }
        #endregion
    }
    public class HybridAppEditorLocalizer : EditorLocalizer {
        protected override void PopulateStringTable() {
            base.PopulateStringTable();
            AddString(EditorStringId.LookUpSearch, "Enter text to search...");
        }
    }
}
#if CLICKONCE
    namespace DevExpress.Internal.DemoLauncher {
        public static class ClickOnceEntryPoint {
            public static Window CreateMainWindow() {
                Application app = Application.Current;
                app.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = DevExpress.Utils.AssemblyHelper.GetResourceUri(typeof(ClickOnceEntryPoint).Assembly, "Themes/Shared.xaml") });
                DevExpress.DevAV.App.Start(() => { }, app);
                return new DevExpress.DevAV.MainWindow();
            }
        }
    }
#endif
