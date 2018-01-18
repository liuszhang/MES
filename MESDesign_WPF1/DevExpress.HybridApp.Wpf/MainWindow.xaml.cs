using System.Windows;
using DevExpress.DevAV.Common.Utils;
using DevExpress.Utils.TouchHelpers;
using DevExpress.Xpf.Core;

namespace DevExpress.DevAV {
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWPF, this);
            InitializeComponent();
            if(Height > SystemParameters.VirtualScreenHeight || Width > SystemParameters.VirtualScreenWidth)
                WindowState = WindowState.Maximized;
            if(DeviceDetector.IsTablet) {
                TouchKeyboardSupport.EnableTouchKeyboard = true;
                TouchKeyboardSupport.EnableFocusTracking();
                WindowStyle = WindowStyle.None;
                ResizeMode = ResizeMode.CanMinimize;
                WindowState = WindowState.Maximized;
            }
        }
        void MainWindowLoaded(object sender, RoutedEventArgs e) {
            if(!DeviceDetector.IsTablet && (Left < 0 || Top < 0))
                WindowState = WindowState.Maximized;
        }
    }
}
