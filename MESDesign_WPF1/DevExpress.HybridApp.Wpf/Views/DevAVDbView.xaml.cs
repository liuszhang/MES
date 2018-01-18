using DevExpress.DevAV.Views;
using Lsz.MES.Data.Filters;
using Lsz.MES.Data.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DevExpress.DevAV.Views {
    public partial class DevAVDbView : UserControl {
        public DevAVDbView() {
            
            InitializeComponent();
            TileBarItem_Click(null,null);
        }
        void OnNavButtonCloseClick(object sender, EventArgs e) {
            Application.Current.MainWindow.Close();
        }
        //生产执行
        private void TileBarItem_Click(object sender, EventArgs e)
        {   
            NavP.Source = new TaskCollectionView();
        }
        //计划任务
        private void TileBarItem_Click_1(object sender, EventArgs e)
        {
            FilterItemViewModel.filterItems = new List<FilterItem>()
            {
                new FilterItem() { Name = "13", EntitiesCount = 3, DisplayText = "全部任务", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\产品数据.png" },
                new FilterItem() { Name = "1", EntitiesCount = 3, DisplayText = "已开工", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\计划任务.png" },
                new FilterItem() { Name = "2", EntitiesCount = 3, DisplayText = "已下发", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\人员信息.png" },
                new FilterItem() { Name = "10", EntitiesCount = 3, DisplayText = "未下发", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\设备点检.png" },
            };
            NavP.Source = new DashboardView(); 
        }
        //人员信息
        private void TileBarItem_Click_2(object sender, EventArgs e)
        {
            FilterItemViewModel.filterItems = new List<FilterItem>()
            {
                new FilterItem() { Name = "设计部", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\产品数据.png" },
                new FilterItem() { Name = "质量部", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\计划任务.png" },
                new FilterItem() { Name = "焊装车间", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\人员信息.png" },
                new FilterItem() { Name = "涂装车间", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\设备点检.png" },
                new FilterItem() { Name = "总装车间", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\生产作业.png" },
                new FilterItem() { Name = "管理部", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\异常申报.png" }
            };
            NavP.Source = new EmployeeCollectionView();
        }
        //产品资料
        private void TileBarItem_Click_3(object sender, EventArgs e)
        {
            FilterItemViewModel.filterItems = new List<FilterItem>()
            {
                new FilterItem() { Name = "设计图纸", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\产品数据.png" },
                new FilterItem() { Name = "作业指导", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\计划任务.png" },
                new FilterItem() { Name = "BOM树", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\人员信息.png" },
                new FilterItem() { Name = "加工程序", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\设备点检.png" },
                new FilterItem() { Name = "其他资料", EntitiesCount = 3, DisplayText = "", ImageUri = @"C:\Users\Public\Documents\DevExpress Demos 16.2\Components\WPF\DevExpress.HybridApp.Wpf\CS\DevExpress.HybridApp.Wpf\Resources\Menu\生产作业.png" },
            };
            NavP.Source = new ProductCollectionView();
        }
        //质量检验
        private void TileBarItem_Click_4(object sender, EventArgs e)
        {
            
            NavP.Source = new CustomerCollectionView();
        }
        //设备点检
        private void TileBarItem_Click_5(object sender, EventArgs e)
        {
            NavP.Source = new OrderCollectionView();
        }
        //异常反馈
        private void TileBarItem_Click_6(object sender, EventArgs e)
        {
            NavP.Source = new QuoteCollectionView();
        }
    }
}
