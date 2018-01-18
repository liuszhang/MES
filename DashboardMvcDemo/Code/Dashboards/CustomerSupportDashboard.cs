using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description for Dashboard1
/// </summary>
public class CustomerSupportDashboard : Dashboard {
    private ChartDashboardItem chartProcessedIssuesByPlatform;
    private DashboardObjectDataSource dsCustomerSupport;
    private RangeFilterDashboardItem range;
    private ChartDashboardItem chartAvgResponseTimeByPlatform;
    private ChartDashboardItem chartOpenedIssuesByMonth;
    private ChartDashboardItem chartAvgResponseTimeByMonth;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public CustomerSupportDashboard() {
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSupportDashboard));
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane2 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane3 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries3 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension8 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension9 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension10 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane4 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries4 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension11 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension12 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
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
            DevExpress.DashboardCommon.SimpleSeries simpleSeries5 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry1 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.DimensionDefinition dimensionDefinition1 = new DevExpress.DashboardCommon.DimensionDefinition("IssueType");
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey1 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Critical");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry2 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey2 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Urgent");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry3 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey3 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition1, "Normal");
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry4 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.DimensionDefinition dimensionDefinition2 = new DevExpress.DashboardCommon.DimensionDefinition("Opened");
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey4 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition2, 2015);
            DevExpress.DashboardCommon.ColorSchemeEntry colorSchemeEntry5 = new DevExpress.DashboardCommon.ColorSchemeEntry();
            DevExpress.DashboardCommon.ColorSchemeDimensionKey colorSchemeDimensionKey5 = new DevExpress.DashboardCommon.ColorSchemeDimensionKey(dimensionDefinition2, 2016);
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup4 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem5 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.dsCustomerSupport = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.chartOpenedIssuesByMonth = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.chartProcessedIssuesByPlatform = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.chartAvgResponseTimeByMonth = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.chartAvgResponseTimeByPlatform = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.range = new DevExpress.DashboardCommon.RangeFilterDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOpenedIssuesByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcessedIssuesByPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgResponseTimeByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgResponseTimeByPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dsCustomerSupport
            // 
            this.dsCustomerSupport.ComponentName = "dsCustomerSupport";
            this.dsCustomerSupport.DataMember = "CustomerSupportItem";
            this.dsCustomerSupport.DataSchema = resources.GetString("dsCustomerSupport.DataSchema");
            this.dsCustomerSupport.Name = "Customer Support";
            // 
            // chartOpenedIssuesByMonth
            // 
            dimension1.DataMember = "Opened";
            dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
            this.chartOpenedIssuesByMonth.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.chartOpenedIssuesByMonth.AxisX.TitleVisible = false;
            this.chartOpenedIssuesByMonth.ComponentName = "chartOpenedIssuesByMonth";
            dimension2.DataMember = "Opened";
            measure1.DataMember = "Opened";
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.chartOpenedIssuesByMonth.DataItemRepository.Clear();
            this.chartOpenedIssuesByMonth.DataItemRepository.Add(dimension2, "DataItem1");
            this.chartOpenedIssuesByMonth.DataItemRepository.Add(dimension1, "DataItem2");
            this.chartOpenedIssuesByMonth.DataItemRepository.Add(measure1, "DataItem3");
            this.chartOpenedIssuesByMonth.DataSource = this.dsCustomerSupport;
            this.chartOpenedIssuesByMonth.InteractivityOptions.IgnoreMasterFilters = true;
            this.chartOpenedIssuesByMonth.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartOpenedIssuesByMonth.Name = "Opened Issues by Month";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "Opened (Count)";
            chartPane1.PrimaryAxisY.TitleVisible = false;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.Name = "Opened (Count)";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartOpenedIssuesByMonth.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartOpenedIssuesByMonth.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.chartOpenedIssuesByMonth.ShowCaption = true;
            // 
            // chartProcessedIssuesByPlatform
            // 
            dimension3.DataMember = "ProductName";
            measure2.DataMember = "Opened";
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            dimension3.SortByMeasure = measure2;
            dimension3.TopNOptions.Count = 3;
            dimension3.TopNOptions.Measure = measure2;
            dimension4.DataMember = "Employee";
            dimension4.SortByMeasure = measure2;
            this.chartProcessedIssuesByPlatform.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.chartProcessedIssuesByPlatform.AxisX.TitleVisible = false;
            this.chartProcessedIssuesByPlatform.ComponentName = "chartProcessedIssuesByPlatform";
            dimension5.DataMember = "IssueType";
            measure3.DataMember = "IssueTypeIndex";
            dimension5.SortByMeasure = measure3;
            this.chartProcessedIssuesByPlatform.DataItemRepository.Clear();
            this.chartProcessedIssuesByPlatform.DataItemRepository.Add(dimension5, "DataItem0");
            this.chartProcessedIssuesByPlatform.DataItemRepository.Add(measure2, "DataItem1");
            this.chartProcessedIssuesByPlatform.DataItemRepository.Add(dimension3, "DataItem2");
            this.chartProcessedIssuesByPlatform.DataItemRepository.Add(dimension4, "DataItem4");
            this.chartProcessedIssuesByPlatform.DataItemRepository.Add(measure3, "DataItem5");
            this.chartProcessedIssuesByPlatform.DataSource = this.dsCustomerSupport;
            this.chartProcessedIssuesByPlatform.HiddenMeasures.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure3});
            this.chartProcessedIssuesByPlatform.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartProcessedIssuesByPlatform.InteractivityOptions.IsDrillDownEnabled = true;
            this.chartProcessedIssuesByPlatform.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartProcessedIssuesByPlatform.Name = "Processed Issues by Platform / Employee";
            chartPane2.Name = "Pane 1";
            chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.PrimaryAxisY.ShowGridLines = true;
            chartPane2.PrimaryAxisY.Title = "Issue Count";
            chartPane2.PrimaryAxisY.TitleVisible = true;
            chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.SecondaryAxisY.ShowGridLines = false;
            chartPane2.SecondaryAxisY.TitleVisible = true;
            simpleSeries2.Name = "Opened (Count)";
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar;
            simpleSeries2.AddDataItem("Value", measure2);
            chartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries2});
            this.chartProcessedIssuesByPlatform.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane2});
            this.chartProcessedIssuesByPlatform.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.chartProcessedIssuesByPlatform.ShowCaption = true;
            // 
            // chartAvgResponseTimeByMonth
            // 
            dimension6.DataMember = "Opened";
            dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
            this.chartAvgResponseTimeByMonth.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension6});
            this.chartAvgResponseTimeByMonth.AxisX.TitleVisible = false;
            this.chartAvgResponseTimeByMonth.ComponentName = "chartAvgResponseTimeByMonth";
            dimension7.DataMember = "Opened";
            measure4.DataMember = "ResolvedTime";
            measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            this.chartAvgResponseTimeByMonth.DataItemRepository.Clear();
            this.chartAvgResponseTimeByMonth.DataItemRepository.Add(dimension7, "DataItem1");
            this.chartAvgResponseTimeByMonth.DataItemRepository.Add(dimension6, "DataItem2");
            this.chartAvgResponseTimeByMonth.DataItemRepository.Add(measure4, "DataItem0");
            this.chartAvgResponseTimeByMonth.DataSource = this.dsCustomerSupport;
            this.chartAvgResponseTimeByMonth.InteractivityOptions.IgnoreMasterFilters = true;
            this.chartAvgResponseTimeByMonth.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartAvgResponseTimeByMonth.Name = " Average Response Time (h) by Month";
            chartPane3.Name = "Pane 1";
            chartPane3.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane3.PrimaryAxisY.ShowGridLines = true;
            chartPane3.PrimaryAxisY.Title = "ResolvedTime (Average)";
            chartPane3.PrimaryAxisY.TitleVisible = false;
            chartPane3.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane3.SecondaryAxisY.ShowGridLines = false;
            chartPane3.SecondaryAxisY.TitleVisible = true;
            simpleSeries3.Name = "ResolvedTime (Average)";
            simpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries3.AddDataItem("Value", measure4);
            chartPane3.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries3});
            this.chartAvgResponseTimeByMonth.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane3});
            this.chartAvgResponseTimeByMonth.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension7});
            this.chartAvgResponseTimeByMonth.ShowCaption = true;
            // 
            // chartAvgResponseTimeByPlatform
            // 
            dimension8.DataMember = "ProductName";
            dimension8.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            dimension9.DataMember = "Employee";
            measure5.DataMember = "ResolvedTime";
            measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            dimension9.SortByMeasure = measure5;
            this.chartAvgResponseTimeByPlatform.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension8,
            dimension9});
            this.chartAvgResponseTimeByPlatform.AxisX.TitleVisible = false;
            this.chartAvgResponseTimeByPlatform.ComponentName = "chartAvgResponseTimeByPlatform";
            dimension10.DataMember = "IssueType";
            measure6.DataMember = "IssueTypeIndex";
            measure6.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            dimension10.SortByMeasure = measure6;
            this.chartAvgResponseTimeByPlatform.DataItemRepository.Clear();
            this.chartAvgResponseTimeByPlatform.DataItemRepository.Add(measure5, "DataItem4");
            this.chartAvgResponseTimeByPlatform.DataItemRepository.Add(dimension10, "DataItem3");
            this.chartAvgResponseTimeByPlatform.DataItemRepository.Add(dimension8, "DataItem2");
            this.chartAvgResponseTimeByPlatform.DataItemRepository.Add(measure6, "DataItem0");
            this.chartAvgResponseTimeByPlatform.DataItemRepository.Add(dimension9, "DataItem5");
            this.chartAvgResponseTimeByPlatform.DataSource = this.dsCustomerSupport;
            this.chartAvgResponseTimeByPlatform.HiddenMeasures.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure6});
            this.chartAvgResponseTimeByPlatform.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartAvgResponseTimeByPlatform.InteractivityOptions.IsDrillDownEnabled = true;
            this.chartAvgResponseTimeByPlatform.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartAvgResponseTimeByPlatform.Name = "Average Response Time by Platform / Employee";
            chartPane4.Name = "Pane 1";
            chartPane4.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane4.PrimaryAxisY.ShowGridLines = true;
            chartPane4.PrimaryAxisY.Title = "Response Time, Hours";
            chartPane4.PrimaryAxisY.TitleVisible = true;
            chartPane4.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane4.SecondaryAxisY.ShowGridLines = false;
            chartPane4.SecondaryAxisY.TitleVisible = true;
            simpleSeries4.Name = "ResolvedTime (Average)";
            simpleSeries4.AddDataItem("Value", measure5);
            chartPane4.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries4});
            this.chartAvgResponseTimeByPlatform.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane4});
            this.chartAvgResponseTimeByPlatform.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension10});
            this.chartAvgResponseTimeByPlatform.ShowCaption = true;
            // 
            // range
            // 
            dimension11.DataMember = "Opened";
            dimension11.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear;
            dimension11.Name = "Date";
            this.range.Argument = dimension11;
            this.range.ComponentName = "range";
            dimension12.DataMember = "IssueType";
            measure7.DataMember = "Opened";
            measure7.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            this.range.DataItemRepository.Clear();
            this.range.DataItemRepository.Add(dimension11, "DataItem1");
            this.range.DataItemRepository.Add(dimension12, "DataItem2");
            this.range.DataItemRepository.Add(measure7, "DataItem0");
            this.range.DataSource = this.dsCustomerSupport;
            dateTimePeriod1.Name = "3 Months";
            flowDateTimePeriodLimit1.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month;
            flowDateTimePeriodLimit1.Offset = -2;
            dateTimePeriod1.Start = flowDateTimePeriodLimit1;
            dateTimePeriod2.Name = "6 Months";
            flowDateTimePeriodLimit2.Interval = DevExpress.DashboardCommon.DateTimeInterval.Month;
            flowDateTimePeriodLimit2.Offset = -5;
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
            simpleSeries5.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries5.AddDataItem("Value", measure7);
            this.range.Series.AddRange(new DevExpress.DashboardCommon.SimpleSeries[] {
            simpleSeries5});
            this.range.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension12});
            this.range.ShowCaption = false;
            // 
            // CustomerSupportDashboard
            // 
            colorSchemeEntry1.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-4567727));
            colorSchemeEntry1.DataSource = this.dsCustomerSupport;
            colorSchemeEntry1.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey1});
            colorSchemeEntry2.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-5273005));
            colorSchemeEntry2.DataSource = this.dsCustomerSupport;
            colorSchemeEntry2.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey2});
            colorSchemeEntry3.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-10515563));
            colorSchemeEntry3.DataSource = this.dsCustomerSupport;
            colorSchemeEntry3.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey3});
            colorSchemeEntry4.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-6987919));
            colorSchemeEntry4.DataSource = this.dsCustomerSupport;
            colorSchemeEntry4.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey4});
            colorSchemeEntry5.ColorDefinition = new DevExpress.DashboardCommon.ColorDefinition(System.Drawing.Color.FromArgb(-8022426));
            colorSchemeEntry5.DataSource = this.dsCustomerSupport;
            colorSchemeEntry5.DimensionKeys.AddRange(new DevExpress.DashboardCommon.ColorSchemeDimensionKey[] {
            colorSchemeDimensionKey5});
            this.ColorScheme.AddRange(new DevExpress.DashboardCommon.ColorSchemeEntry[] {
            colorSchemeEntry1,
            colorSchemeEntry2,
            colorSchemeEntry3,
            colorSchemeEntry4,
            colorSchemeEntry5});
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsCustomerSupport});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartProcessedIssuesByPlatform,
            this.range,
            this.chartAvgResponseTimeByPlatform,
            this.chartOpenedIssuesByMonth,
            this.chartAvgResponseTimeByMonth});
            dashboardLayoutItem1.DashboardItem = this.chartOpenedIssuesByMonth;
            dashboardLayoutItem1.Weight = 36.381709741550694D;
            dashboardLayoutItem2.DashboardItem = this.chartProcessedIssuesByPlatform;
            dashboardLayoutItem2.Weight = 63.618290258449306D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup3.DashboardItem = null;
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup3.Weight = 52.023546725533478D;
            dashboardLayoutItem3.DashboardItem = this.chartAvgResponseTimeByMonth;
            dashboardLayoutItem3.Weight = 36.381709741550694D;
            dashboardLayoutItem4.DashboardItem = this.chartAvgResponseTimeByPlatform;
            dashboardLayoutItem4.Weight = 63.618290258449306D;
            dashboardLayoutGroup4.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup4.DashboardItem = null;
            dashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup4.Weight = 47.976453274466522D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup3,
            dashboardLayoutGroup4});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 85.544217687074834D;
            dashboardLayoutItem5.DashboardItem = this.range;
            dashboardLayoutItem5.Weight = 14.45578231292517D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem5});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Customer Support";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.CustomerSupport_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(this.dsCustomerSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOpenedIssuesByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProcessedIssuesByPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgResponseTimeByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAvgResponseTimeByPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

	void CustomerSupport_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
		e.Data = DataLoader.CustomerSupportData;
	}
}
