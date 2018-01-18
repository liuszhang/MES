using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class OverviewDashboard : Dashboard {
    private RangeFilterDashboardItem range;
    private DashboardObjectDataSource dsSales;
    private GridDashboardItem gridSalesByState;
	private ChartDashboardItem chartSalesByCategory;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public OverviewDashboard() {
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
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.gridSalesByState = new DevExpress.DashboardCommon.GridDashboardItem();
            this.chartSalesByCategory = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.range = new DevExpress.DashboardCommon.RangeFilterDashboardItem();
            this.dsSales = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesByState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // gridSalesByState
            // 
            dimension1.DataMember = "State";
            measure1.DataMember = "Sales";
            dimension1.SortByMeasure = measure1;
            dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            gridDimensionColumn1.Name = "State";
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension1);
            this.gridSalesByState.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1});
            this.gridSalesByState.ComponentName = "gridSalesByState";
            dimension2.DataMember = "CurrentDate";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.gridSalesByState.DataItemRepository.Clear();
            this.gridSalesByState.DataItemRepository.Add(dimension1, "DataItem1");
            this.gridSalesByState.DataItemRepository.Add(dimension2, "DataItem6");
            this.gridSalesByState.DataMember = null;
            this.gridSalesByState.DataSource = this.dsSales;
            this.gridSalesByState.GridOptions.ShowColumnHeaders = false;
            this.gridSalesByState.GridOptions.ShowHorizontalLines = false;
            this.gridSalesByState.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridSalesByState.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single;
            this.gridSalesByState.Name = "State";
            this.gridSalesByState.ShowCaption = true;
            this.gridSalesByState.SparklineArgument = dimension2;
            // 
            // chartSalesByCategory
            // 
            dimension3.DataMember = "CurrentDate";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            this.chartSalesByCategory.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartSalesByCategory.AxisX.TitleVisible = false;
            this.chartSalesByCategory.ComponentName = "chartSalesByCategory";
            measure2.DataMember = "Sales";
            dimension4.DataMember = "Category";
            dimension4.TopNOptions.Count = 2;
            dimension4.TopNOptions.Enabled = true;
            dimension4.TopNOptions.Measure = measure2;
            this.chartSalesByCategory.DataItemRepository.Clear();
            this.chartSalesByCategory.DataItemRepository.Add(measure2, "DataItem1");
            this.chartSalesByCategory.DataItemRepository.Add(dimension3, "DataItem2");
            this.chartSalesByCategory.DataItemRepository.Add(dimension4, "DataItem3");
            this.chartSalesByCategory.DataMember = null;
            this.chartSalesByCategory.DataSource = this.dsSales;
            this.chartSalesByCategory.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartSalesByCategory.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartSalesByCategory.Legend.Visible = false;
            this.chartSalesByCategory.Name = "Sales by Product Category";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "Sales";
            chartPane1.PrimaryAxisY.TitleVisible = false;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.Name = "Sales (Sum)";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure2);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartSalesByCategory.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartSalesByCategory.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.chartSalesByCategory.ShowCaption = true;
            // 
            // range
            // 
            dimension5.DataMember = "CurrentDate";
            dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            dimension5.Name = "Date";
            this.range.Argument = dimension5;
            this.range.ComponentName = "range";
            measure3.DataMember = "Sales";
            this.range.DataItemRepository.Clear();
            this.range.DataItemRepository.Add(measure3, "DataItem0");
            this.range.DataItemRepository.Add(dimension5, "DataItem1");
            this.range.DataMember = null;
            this.range.DataSource = this.dsSales;
            this.range.InteractivityOptions.IgnoreMasterFilters = true;
            this.range.Name = "Range Filter 1";
            simpleSeries2.Name = "Sales (Sum)";
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries2.AddDataItem("Value", measure3);
            this.range.Series.AddRange(new DevExpress.DashboardCommon.SimpleSeries[] {
            simpleSeries2});
            this.range.ShowCaption = false;
            // 
            // dsSales
            // 
            this.dsSales.ComponentName = "dsSales";
            this.dsSales.DataMember = "DataItem";
            this.dsSales.Name = "Sales";
            // 
            // OverviewDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsSales});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.range,
            this.gridSalesByState,
            this.chartSalesByCategory});
            dashboardLayoutItem1.DashboardItem = this.gridSalesByState;
            dashboardLayoutItem1.Weight = 29.989969909729187D;
            dashboardLayoutItem2.DashboardItem = this.chartSalesByCategory;
            dashboardLayoutItem2.Weight = 70.010030090270817D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 76.061120543293711D;
            dashboardLayoutItem3.DashboardItem = this.range;
            dashboardLayoutItem3.Weight = 23.938879456706282D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ShowMasterFilterState = false;
            this.Title.Text = "Overview Dashboard";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.OverviewDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesByState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    void OverviewDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.SalesOverviewData;
    }
}
