using System;
using System.Linq;
using System.Windows.Controls;
using System.Collections.Generic;
using DevExpress.Xpf.WindowsUI;
using DevExpress.Mvvm.UI;
using System.Windows.Input;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.Services;
using static DevExpress.Utils.MVVM.Services.DocumentManagerService;

namespace DevExpress.DevAV.Views {
    public partial class EmployeeCollectionView : UserControl {
        public EmployeeCollectionView() {
            InitializeComponent();
        }


        private void AppBarButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Content = new EmployeeView();
        }

    }

}
