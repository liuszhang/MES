using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class SalesOverviewDashboard : Dashboard {
    private RangeFilterDashboardItem range;
    private DashboardObjectDataSource dsSales;
    private GridDashboardItem gridSalesByState;
    private ChartDashboardItem chartSalesByCategory;
    private GaugeDashboardItem gaugeSalesVsTargetByCategory;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public SalesOverviewDashboard() {
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
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridSparklineColumn gridSparklineColumn1 = new DevExpress.DashboardCommon.GridSparklineColumn();
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.GridColumnTotal gridColumnTotal1 = new DevExpress.DashboardCommon.GridColumnTotal();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridDeltaColumn gridDeltaColumn1 = new DevExpress.DashboardCommon.GridDeltaColumn();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule1 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionBar formatConditionBar1 = new DevExpress.DashboardCommon.FormatConditionBar();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOverviewDashboard));
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Gauge gauge1 = new DevExpress.DashboardCommon.Gauge();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure8 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod1 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit1 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod2 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit2 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod3 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit3 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit4 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.DateTimePeriod dateTimePeriod4 = new DevExpress.DashboardCommon.DateTimePeriod();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit5 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.FlowDateTimePeriodLimit flowDateTimePeriodLimit6 = new DevExpress.DashboardCommon.FlowDateTimePeriodLimit();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.gridSalesByState = new DevExpress.DashboardCommon.GridDashboardItem();
            this.dsSales = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.chartSalesByCategory = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.gaugeSalesVsTargetByCategory = new DevExpress.DashboardCommon.GaugeDashboardItem();
            this.range = new DevExpress.DashboardCommon.RangeFilterDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesByState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeSalesVsTargetByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // gridSalesByState
            // 
            measure1.DataMember = "Sales";
            gridSparklineColumn1.FixedWidth = 13.32D;
            gridSparklineColumn1.Name = "Trend";
            gridSparklineColumn1.SparklineOptions.HighlightStartEndPoints = false;
            gridSparklineColumn1.Weight = 94.079439418762021D;
            gridSparklineColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth;
            gridSparklineColumn1.AddDataItem("SparklineValue", measure1);
            dimension1.DataMember = "State";
            dimension1.SortByMeasure = measure1;
            dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            gridDimensionColumn1.FixedWidth = 16.16D;
            gridDimensionColumn1.Name = "State";
            gridDimensionColumn1.Weight = 88.125044518840369D;
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth;
            gridDimensionColumn1.AddDataItem("Dimension", dimension1);
            measure2.DataMember = "Sales";
            gridMeasureColumn1.FixedWidth = 20.98D;
            gridMeasureColumn1.Name = "Sales";
            gridColumnTotal1.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Sum;
            gridMeasureColumn1.Totals.AddRange(new DevExpress.DashboardCommon.GridColumnTotal[] {
            gridColumnTotal1});
            gridMeasureColumn1.Weight = 88.720484008832543D;
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth;
            gridMeasureColumn1.AddDataItem("Measure", measure2);
            measure3.DataMember = "Sales";
            measure4.DataMember = "SalesTarget";
            gridDeltaColumn1.DeltaOptions.ResultIndicationThreshold = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            gridDeltaColumn1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.PercentVariation;
            gridDeltaColumn1.FixedWidth = 14.15D;
            gridDeltaColumn1.Name = "Sales vs Target";
            gridDeltaColumn1.Weight = 60.139388489208635D;
            gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.FixedWidth;
            gridDeltaColumn1.AddDataItem("ActualValue", measure3);
            gridDeltaColumn1.AddDataItem("TargetValue", measure4);
            this.gridSalesByState.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridSparklineColumn1,
            gridDimensionColumn1,
            gridMeasureColumn1,
            gridDeltaColumn1});
            this.gridSalesByState.ComponentName = "gridSalesByState";
            dimension2.DataMember = "CurrentDate";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            this.gridSalesByState.DataItemRepository.Clear();
            this.gridSalesByState.DataItemRepository.Add(measure1, "DataItem0");
            this.gridSalesByState.DataItemRepository.Add(dimension1, "DataItem1");
            this.gridSalesByState.DataItemRepository.Add(measure2, "DataItem3");
            this.gridSalesByState.DataItemRepository.Add(measure3, "DataItem4");
            this.gridSalesByState.DataItemRepository.Add(measure4, "DataItem5");
            this.gridSalesByState.DataItemRepository.Add(dimension2, "DataItem6");
            this.gridSalesByState.DataSource = this.dsSales;
            formatConditionBar1.NegativeStyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.PaleRed;
            formatConditionBar1.StyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.PaleGreen;
            gridItemFormatRule1.Condition = formatConditionBar1;
            gridItemFormatRule1.DataItem = measure2;
            gridItemFormatRule1.Name = "FormatRule 1";
            this.gridSalesByState.FormatRules.AddRange(new DevExpress.DashboardCommon.GridItemFormatRule[] {
            gridItemFormatRule1});
            this.gridSalesByState.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.Manual;
            this.gridSalesByState.GridOptions.ShowHorizontalLines = false;
            this.gridSalesByState.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridSalesByState.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.gridSalesByState.Name = "Sales by State";
            this.gridSalesByState.ShowCaption = true;
            this.gridSalesByState.SparklineArgument = dimension2;
            // 
            // dsSales
            // 
            this.dsSales.ComponentName = "dsSales";
            this.dsSales.DataMember = "DataItem";
            this.dsSales.DataSchema = resources.GetString("dsSales.DataSchema");
            this.dsSales.Name = "Sales";
            // 
            // chartSalesByCategory
            // 
            dimension3.DataMember = "CurrentDate";
            dimension3.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.DayMonthYear;
            this.chartSalesByCategory.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartSalesByCategory.AxisX.TitleVisible = false;
            this.chartSalesByCategory.ComponentName = "chartSalesByCategory";
            measure5.DataMember = "Sales";
            dimension4.DataMember = "Category";
            this.chartSalesByCategory.DataItemRepository.Clear();
            this.chartSalesByCategory.DataItemRepository.Add(measure5, "DataItem1");
            this.chartSalesByCategory.DataItemRepository.Add(dimension3, "DataItem2");
            this.chartSalesByCategory.DataItemRepository.Add(dimension4, "DataItem3");
            this.chartSalesByCategory.DataSource = this.dsSales;
            this.chartSalesByCategory.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartSalesByCategory.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartSalesByCategory.Name = "Sales by Product Category";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = false;
            chartPane1.PrimaryAxisY.Logarithmic = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "Sales";
            chartPane1.PrimaryAxisY.TitleVisible = false;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.Name = "Sales (Sum)";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure5);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartSalesByCategory.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartSalesByCategory.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.chartSalesByCategory.ShowCaption = true;
            // 
            // gaugeSalesVsTargetByCategory
            // 
            this.gaugeSalesVsTargetByCategory.ComponentName = "gaugeSalesVsTargetByCategory";
            this.gaugeSalesVsTargetByCategory.ContentLineCount = 4;
            measure6.DataMember = "Sales";
            measure7.DataMember = "SalesTarget";
            dimension5.DataMember = "Category";
            this.gaugeSalesVsTargetByCategory.DataItemRepository.Clear();
            this.gaugeSalesVsTargetByCategory.DataItemRepository.Add(measure6, "DataItem1");
            this.gaugeSalesVsTargetByCategory.DataItemRepository.Add(measure7, "DataItem2");
            this.gaugeSalesVsTargetByCategory.DataItemRepository.Add(dimension5, "DataItem3");
            this.gaugeSalesVsTargetByCategory.DataSource = this.dsSales;
            gauge1.DeltaOptions.ResultIndicationThreshold = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            gauge1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.PercentVariation;
            gauge1.Name = "Sales (Sum) vs SalesTarget (Sum)";
            gauge1.AddDataItem("ActualValue", measure6);
            gauge1.AddDataItem("TargetValue", measure7);
            this.gaugeSalesVsTargetByCategory.Gauges.AddRange(new DevExpress.DashboardCommon.Gauge[] {
            gauge1});
            this.gaugeSalesVsTargetByCategory.InteractivityOptions.IgnoreMasterFilters = false;
            this.gaugeSalesVsTargetByCategory.Name = "Sales vs Target by Product Category";
            this.gaugeSalesVsTargetByCategory.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.gaugeSalesVsTargetByCategory.ShowCaption = true;
            this.gaugeSalesVsTargetByCategory.ViewType = DevExpress.DashboardCommon.GaugeViewType.CircularHalf;
            // 
            // range
            // 
            dimension6.DataMember = "CurrentDate";
            dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            dimension6.Name = "Date";
            this.range.Argument = dimension6;
            this.range.ComponentName = "range";
            dimension7.DataMember = "Category";
            measure8.DataMember = "Sales";
            this.range.DataItemRepository.Clear();
            this.range.DataItemRepository.Add(dimension6, "DataItem1");
            this.range.DataItemRepository.Add(dimension7, "DataItem2");
            this.range.DataItemRepository.Add(measure8, "DataItem0");
            this.range.DataSource = this.dsSales;
            dateTimePeriod1.Name = "6 Months";
            flowDateTimePeriodLimit1.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month;
            flowDateTimePeriodLimit1.Offset = -5;
            dateTimePeriod1.Start = flowDateTimePeriodLimit1;
            dateTimePeriod2.Name = "12 Months";
            flowDateTimePeriodLimit2.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month;
            flowDateTimePeriodLimit2.Offset = -11;
            dateTimePeriod2.Start = flowDateTimePeriodLimit2;
            dateTimePeriod3.Name = "Quarter to date";
            flowDateTimePeriodLimit3.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day;
            dateTimePeriod3.End = flowDateTimePeriodLimit3;
            flowDateTimePeriodLimit4.Interval = DevExpress.DashboardCommon.DateTimeInterval.Quarter;
            dateTimePeriod3.Start = flowDateTimePeriodLimit4;
            dateTimePeriod4.Name = "Year to date";
            flowDateTimePeriodLimit5.Interval = DevExpress.DashboardCommon.DateTimeInterval.Day;
            dateTimePeriod4.End = flowDateTimePeriodLimit5;
            dateTimePeriod4.Start = flowDateTimePeriodLimit6;
            this.range.DateTimePeriods.AddRange(new DevExpress.DashboardCommon.DateTimePeriod[] {
            dateTimePeriod1,
            dateTimePeriod2,
            dateTimePeriod3,
            dateTimePeriod4});
            this.range.InteractivityOptions.IgnoreMasterFilters = true;
            this.range.Name = "Range Filter 1";
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar;
            simpleSeries2.AddDataItem("Value", measure8);
            this.range.Series.AddRange(new DevExpress.DashboardCommon.SimpleSeries[] {
            simpleSeries2});
            this.range.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension7});
            this.range.ShowCaption = false;
            // 
            // SalesOverviewDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsSales});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.range,
            this.gridSalesByState,
            this.chartSalesByCategory,
            this.gaugeSalesVsTargetByCategory});
            dashboardLayoutItem1.DashboardItem = this.gridSalesByState;
            dashboardLayoutItem1.Weight = 50.997605746209096D;
            dashboardLayoutItem2.DashboardItem = this.chartSalesByCategory;
            dashboardLayoutItem2.Weight = 49.002394253790904D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 54.931972789115648D;
            dashboardLayoutItem3.DashboardItem = this.gaugeSalesVsTargetByCategory;
            dashboardLayoutItem3.Weight = 55.094339622641506D;
            dashboardLayoutItem4.DashboardItem = this.range;
            dashboardLayoutItem4.Weight = 44.905660377358494D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup3.DashboardItem = null;
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup3.Weight = 45.068027210884352D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Sales Overview";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.SalesOverviewDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalesByState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeSalesVsTargetByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    void SalesOverviewDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.SalesOverviewData;
    }
}
