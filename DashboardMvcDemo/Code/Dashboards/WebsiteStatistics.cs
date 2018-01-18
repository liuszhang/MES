using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class WebsiteStatisticsDashboard : Dashboard {
    private ChartDashboardItem trafficSourceChart;
    private DashboardObjectDataSource siteVisitosDataSource;
    private DashboardItemGroup trafficSourceGroup;
    private TreeViewDashboardItem trafficSourceFilter;
    private TreeViewDashboardItem browsersFilter;
    private DashboardItemGroup browsersGroup;
    private ChartDashboardItem browsersChart;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public WebsiteStatisticsDashboard() {
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
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebsiteStatisticsDashboard));
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane2 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry1 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.DimensionDefinition dimensionDefinition1 = new DevExpress.DashboardCommon.DimensionDefinition("BrowserName");
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey1 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Chrome Latest");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry2 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey2 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Chrome Others");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry3 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey3 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Firefox Latest");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry4 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey4 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Firefox Others");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry5 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey5 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE 11");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry6 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey6 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE 8");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry7 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey7 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE 9");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry8 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey8 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "IE Others");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry9 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey9 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Opera O Mini");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry10 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey10 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Opera Others");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry11 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey11 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Safari Others");
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.siteVisitosDataSource = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.trafficSourceFilter = new DevExpress.DashboardCommon.TreeViewDashboardItem();
            this.trafficSourceGroup = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.trafficSourceChart = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.browsersFilter = new DevExpress.DashboardCommon.TreeViewDashboardItem();
            this.browsersGroup = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.browsersChart = new DevExpress.DashboardCommon.ChartDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.siteVisitosDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSourceFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSourceGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSourceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsersFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsersGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsersChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // siteVisitosDataSource
            // 
            calculatedField1.Expression = "[Browser] + \' \' + [BrowserDetails]";
            calculatedField1.Name = "BrowserName";
            this.siteVisitosDataSource.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1});
            this.siteVisitosDataSource.ComponentName = "siteVisitosDataSource";
            this.siteVisitosDataSource.DataMember = "Data";
            this.siteVisitosDataSource.DataSchema = resources.GetString("siteVisitosDataSource.DataSchema");
            this.siteVisitosDataSource.Name = "Site Visitors";
            // 
            // trafficSourceFilter
            // 
            this.trafficSourceFilter.ComponentName = "trafficSourceFilter";
            dimension1.DataMember = "TrafficSource";
            dimension2.DataMember = "TrafficSourceDetails";
            this.trafficSourceFilter.DataItemRepository.Clear();
            this.trafficSourceFilter.DataItemRepository.Add(dimension1, "DataItem0");
            this.trafficSourceFilter.DataItemRepository.Add(dimension2, "DataItem1");
            this.trafficSourceFilter.DataSource = this.siteVisitosDataSource;
            this.trafficSourceFilter.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2});
            this.trafficSourceFilter.Group = this.trafficSourceGroup;
            this.trafficSourceFilter.InteractivityOptions.IgnoreMasterFilters = true;
            this.trafficSourceFilter.Name = "Traffic Source";
            this.trafficSourceFilter.ShowCaption = true;
            // 
            // trafficSourceGroup
            // 
            this.trafficSourceGroup.ComponentName = "trafficSourceGroup";
            this.trafficSourceGroup.InteractivityOptions.IgnoreMasterFilters = false;
            this.trafficSourceGroup.Name = " Traffic Sources Overview";
            this.trafficSourceGroup.ShowCaption = false;
            // 
            // trafficSourceChart
            // 
            dimension3.DataMember = "Date";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.trafficSourceChart.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.trafficSourceChart.AxisX.TitleVisible = false;
            this.trafficSourceChart.ComponentName = "trafficSourceChart";
            dimension4.DataMember = "TrafficSource";
            measure1.DataMember = "Count";
            measure1.Name = "Users Count";
            this.trafficSourceChart.DataItemRepository.Clear();
            this.trafficSourceChart.DataItemRepository.Add(dimension4, "DataItem1");
            this.trafficSourceChart.DataItemRepository.Add(dimension3, "DataItem0");
            this.trafficSourceChart.DataItemRepository.Add(measure1, "DataItem2");
            this.trafficSourceChart.DataSource = this.siteVisitosDataSource;
            this.trafficSourceChart.Group = this.trafficSourceGroup;
            this.trafficSourceChart.InteractivityOptions.IgnoreMasterFilters = false;
            this.trafficSourceChart.Name = "Visitors";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = false;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedSplineArea;
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.trafficSourceChart.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.trafficSourceChart.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.trafficSourceChart.ShowCaption = true;
            // 
            // browsersFilter
            // 
            this.browsersFilter.ComponentName = "browsersFilter";
            dimension5.DataMember = "Browser";
            this.browsersFilter.DataItemRepository.Clear();
            this.browsersFilter.DataItemRepository.Add(dimension5, "DataItem0");
            this.browsersFilter.DataSource = this.siteVisitosDataSource;
            this.browsersFilter.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.browsersFilter.Group = this.browsersGroup;
            this.browsersFilter.InteractivityOptions.IgnoreMasterFilters = true;
            this.browsersFilter.Name = "Browser";
            this.browsersFilter.ShowCaption = true;
            // 
            // browsersGroup
            // 
            this.browsersGroup.ComponentName = "browsersGroup";
            this.browsersGroup.InteractivityOptions.IgnoreMasterFilters = true;
            this.browsersGroup.Name = "Browser statistics";
            this.browsersGroup.ShowCaption = false;
            // 
            // browsersChart
            // 
            dimension6.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue;
            dimension6.DataMember = "BrowserName";
            dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            this.browsersChart.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension6});
            this.browsersChart.AxisX.TitleVisible = false;
            this.browsersChart.ComponentName = "browsersChart";
            measure2.DataMember = "Count";
            measure2.Name = "Users Count";
            this.browsersChart.DataItemRepository.Clear();
            this.browsersChart.DataItemRepository.Add(measure2, "DataItem2");
            this.browsersChart.DataItemRepository.Add(dimension6, "DataItem0");
            this.browsersChart.DataSource = this.siteVisitosDataSource;
            this.browsersChart.Group = this.browsersGroup;
            this.browsersChart.InteractivityOptions.IgnoreMasterFilters = false;
            this.browsersChart.Legend.Visible = false;
            this.browsersChart.Name = "Browser Usage";
            chartPane2.Name = "Pane 1";
            chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.PrimaryAxisY.ShowGridLines = true;
            chartPane2.PrimaryAxisY.TitleVisible = false;
            chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.SecondaryAxisY.ShowGridLines = false;
            chartPane2.SecondaryAxisY.TitleVisible = true;
            simpleSeries2.AddDataItem("Value", measure2);
            chartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries2});
            this.browsersChart.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane2});
            this.browsersChart.Rotated = true;
            this.browsersChart.ShowCaption = true;
            // 
            // WebsiteStatisticsDashboard
            // 
            colorSchemeEntry1.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-6987919));
            colorSchemeEntry1.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry1.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey1});
            colorSchemeEntry2.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-6987919));
            colorSchemeEntry2.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry2.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey2});
            colorSchemeEntry3.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8022426));
            colorSchemeEntry3.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry3.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey3});
            colorSchemeEntry4.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8022426));
            colorSchemeEntry4.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry4.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey4});
            colorSchemeEntry5.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916));
            colorSchemeEntry5.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry5.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey5});
            colorSchemeEntry6.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916));
            colorSchemeEntry6.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry6.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey6});
            colorSchemeEntry7.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916));
            colorSchemeEntry7.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry7.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey7});
            colorSchemeEntry8.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8492916));
            colorSchemeEntry8.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry8.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey8});
            colorSchemeEntry9.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-10523243));
            colorSchemeEntry9.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry9.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey9});
            colorSchemeEntry10.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-10523243));
            colorSchemeEntry10.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry10.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey10});
            colorSchemeEntry11.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-5482852));
            colorSchemeEntry11.DataSource = this.siteVisitosDataSource;
            colorSchemeEntry11.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey11});
            this.ColorScheme.AddRange(new DevExpress.DashboardCommon.ColorSchemeEntry[] {
            colorSchemeEntry1,
            colorSchemeEntry2,
            colorSchemeEntry3,
            colorSchemeEntry4,
            colorSchemeEntry5,
            colorSchemeEntry6,
            colorSchemeEntry7,
            colorSchemeEntry8,
            colorSchemeEntry9,
            colorSchemeEntry10,
            colorSchemeEntry11});
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.siteVisitosDataSource});
            this.Groups.AddRange(new DevExpress.DashboardCommon.DashboardItemGroup[] {
            this.browsersGroup,
            this.trafficSourceGroup});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.trafficSourceChart,
            this.trafficSourceFilter,
            this.browsersFilter,
            this.browsersChart});
            dashboardLayoutItem1.DashboardItem = this.trafficSourceFilter;
            dashboardLayoutItem1.Weight = 18.97018970189702D;
            dashboardLayoutItem2.DashboardItem = this.trafficSourceChart;
            dashboardLayoutItem2.Weight = 81.029810298102987D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = this.trafficSourceGroup;
            dashboardLayoutGroup2.Weight = 46.990291262135919D;
            dashboardLayoutItem3.DashboardItem = this.browsersFilter;
            dashboardLayoutItem3.Weight = 18.97018970189702D;
            dashboardLayoutItem4.DashboardItem = this.browsersChart;
            dashboardLayoutItem4.Weight = 81.029810298102987D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup3.DashboardItem = this.browsersGroup;
            dashboardLayoutGroup3.Weight = 53.027522935779814D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Website Statistics";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.WebsiteStatisticsDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(this.siteVisitosDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSourceFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSourceGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSourceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsersFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsersGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browsersChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void WebsiteStatisticsDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.WebsiteStatistics;
    }
}
