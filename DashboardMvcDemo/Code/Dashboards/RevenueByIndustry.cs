using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class RevenueByIndustryDashboard : Dashboard {
    private GeoPointMapDashboardItem mapRevenueByCity;
    private DashboardObjectDataSource dsStatistics;
    private ListBoxDashboardItem listBoxIndustry;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RevenueByIndustryDashboard() {
        InitializeComponent();
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if(disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueByIndustryDashboard));
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.listBoxIndustry = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.mapRevenueByCity = new DevExpress.DashboardCommon.GeoPointMapDashboardItem();
            this.dsStatistics = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxIndustry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapRevenueByCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // listBoxIndustry
            // 
            this.listBoxIndustry.ComponentName = "listBoxIndustry";
            dimension1.DataMember = "Industry";
            this.listBoxIndustry.DataItemRepository.Clear();
            this.listBoxIndustry.DataItemRepository.Add(dimension1, "DataItem0");
            this.listBoxIndustry.DataMember = null;
            this.listBoxIndustry.DataSource = this.dsStatistics;
            this.listBoxIndustry.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.listBoxIndustry.InteractivityOptions.IgnoreMasterFilters = false;
            this.listBoxIndustry.Name = "Industry";
            this.listBoxIndustry.ShowCaption = true;
            // 
            // mapRevenueByCity
            // 
            this.mapRevenueByCity.Area = DevExpress.DashboardCommon.ShapefileArea.USA;
            this.mapRevenueByCity.ComponentName = "mapRevenueByCity";
            dimension2.DataMember = "Latitude";
            dimension3.DataMember = "Longitude";
            measure1.DataMember = "Revenue";
            measure1.Name = "Revenue";
            dimension4.DataMember = "City";
            dimension5.DataMember = "Industry";
            this.mapRevenueByCity.DataItemRepository.Clear();
            this.mapRevenueByCity.DataItemRepository.Add(dimension2, "DataItem0");
            this.mapRevenueByCity.DataItemRepository.Add(dimension3, "DataItem1");
            this.mapRevenueByCity.DataItemRepository.Add(measure1, "DataItem2");
            this.mapRevenueByCity.DataItemRepository.Add(dimension4, "DataItem3");
            this.mapRevenueByCity.DataItemRepository.Add(dimension5, "DataItem4");
            this.mapRevenueByCity.DataMember = null;
            this.mapRevenueByCity.DataSource = this.dsStatistics;
            this.mapRevenueByCity.EnableClustering = true;
            this.mapRevenueByCity.InteractivityOptions.IgnoreMasterFilters = false;
            this.mapRevenueByCity.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.mapRevenueByCity.Latitude = dimension2;
            this.mapRevenueByCity.Longitude = dimension3;
            this.mapRevenueByCity.Name = "Revenue by City";
            this.mapRevenueByCity.ShapeTitleAttributeName = "NAME";
            this.mapRevenueByCity.ShowCaption = true;
            this.mapRevenueByCity.TooltipDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4,
            dimension5});
            this.mapRevenueByCity.Value = measure1;
            this.mapRevenueByCity.Viewport.BottomLatitude = 24.542349340056283D;
            this.mapRevenueByCity.Viewport.CenterPointLatitude = 37.995066405185554D;
            this.mapRevenueByCity.Viewport.CenterPointLongitude = -95.848499902568008D;
            this.mapRevenueByCity.Viewport.LeftLongitude = -124.70997774915153D;
            this.mapRevenueByCity.Viewport.RightLongitude = -66.987022055984482D;
            this.mapRevenueByCity.Viewport.TopLatitude = 49.369672064487254D;
            // 
            // dsStatistics
            // 
            this.dsStatistics.ComponentName = "dsStatistics";
            this.dsStatistics.DataMember = "Statistics";
            this.dsStatistics.DataSchema = resources.GetString("dsStatistics.DataSchema");
            this.dsStatistics.Name = "Statistics";
            // 
            // RevenueByIndustryDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsStatistics});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.mapRevenueByCity,
            this.listBoxIndustry});
            dashboardLayoutItem1.DashboardItem = this.listBoxIndustry;
            dashboardLayoutItem1.Weight = 26.980942828485457D;
            dashboardLayoutItem2.DashboardItem = this.mapRevenueByCity;
            dashboardLayoutItem2.Weight = 73.019057171514547D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Revenue by Industry";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.WorldwideEnergyUseDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxIndustry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapRevenueByCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void WorldwideEnergyUseDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.RevenueByIndustry.Tables["Statistics"];
    }
}
