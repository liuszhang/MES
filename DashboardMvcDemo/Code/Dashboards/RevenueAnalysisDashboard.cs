using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class RevenueAnalysisDashboard : Dashboard {
    private PivotDashboardItem pivotSalesByState;
    private DashboardObjectDataSource dsSales;
    private PieDashboardItem pieSalesbyCategory;
    private ChartDashboardItem chartSalesbyYear;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RevenueAnalysisDashboard() {
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
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueAnalysisDashboard));
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule1 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionTopBottom formatConditionTopBottom1 = new DevExpress.DashboardCommon.FormatConditionTopBottom();
            DevExpress.DashboardCommon.IconSettings iconSettings1 = new DevExpress.DashboardCommon.IconSettings();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule2 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionTopBottom formatConditionTopBottom2 = new DevExpress.DashboardCommon.FormatConditionTopBottom();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings1 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule3 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionTopBottom formatConditionTopBottom3 = new DevExpress.DashboardCommon.FormatConditionTopBottom();
            DevExpress.DashboardCommon.IconSettings iconSettings2 = new DevExpress.DashboardCommon.IconSettings();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule4 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionTopBottom formatConditionTopBottom4 = new DevExpress.DashboardCommon.FormatConditionTopBottom();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings2 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule5 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionRangeGradient formatConditionRangeGradient1 = new DevExpress.DashboardCommon.FormatConditionRangeGradient();
            DevExpress.DashboardCommon.RangeInfo rangeInfo1 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings3 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.RangeInfo rangeInfo2 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo3 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo4 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo5 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo6 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo7 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo8 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo9 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo10 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings4 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule6 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionRangeGradient formatConditionRangeGradient2 = new DevExpress.DashboardCommon.FormatConditionRangeGradient();
            DevExpress.DashboardCommon.RangeInfo rangeInfo11 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings5 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.RangeInfo rangeInfo12 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo13 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo14 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo15 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo16 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo17 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo18 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo19 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo20 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings6 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule7 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionRangeGradient formatConditionRangeGradient3 = new DevExpress.DashboardCommon.FormatConditionRangeGradient();
            DevExpress.DashboardCommon.RangeInfo rangeInfo21 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings7 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.RangeInfo rangeInfo22 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo23 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo24 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo25 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo26 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo27 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo28 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo29 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.RangeInfo rangeInfo30 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings8 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.chartSalesbyYear = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dsSales = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.pieSalesbyCategory = new DevExpress.DashboardCommon.PieDashboardItem();
            this.pivotSalesByState = new DevExpress.DashboardCommon.PivotDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesbyYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieSalesbyCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotSalesByState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // chartSalesbyYear
            // 
            dimension1.DataMember = "Year";
            dimension1.IsDiscreteNumericScale = true;
            dimension1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General;
            this.chartSalesbyYear.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.chartSalesbyYear.AxisX.TitleVisible = false;
            this.chartSalesbyYear.ComponentName = "chartSalesbyYear";
            measure1.DataMember = "Revenue";
            this.chartSalesbyYear.DataItemRepository.Clear();
            this.chartSalesbyYear.DataItemRepository.Add(measure1, "DataItem0");
            this.chartSalesbyYear.DataItemRepository.Add(dimension1, "DataItem1");
            this.chartSalesbyYear.DataSource = this.dsSales;
            this.chartSalesbyYear.InteractivityOptions.IgnoreMasterFilters = true;
            this.chartSalesbyYear.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.chartSalesbyYear.Legend.Visible = false;
            this.chartSalesbyYear.Name = "Chart 1";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = false;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "Revenue ";
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.Name = "Revenue (Sum)";
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartSalesbyYear.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartSalesbyYear.ShowCaption = false;
            // 
            // dsSales
            // 
            this.dsSales.ComponentName = "dsSales";
            this.dsSales.DataMember = "DataItem";
            this.dsSales.DataSchema = resources.GetString("dsSales.DataSchema");
            this.dsSales.Name = "Sales";
            // 
            // pieSalesbyCategory
            // 
            dimension2.DataMember = "Category";
            this.pieSalesbyCategory.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pieSalesbyCategory.ComponentName = "pieSalesbyCategory";
            measure2.DataMember = "Revenue";
            measure2.Name = "Revenue by Product";
            measure3.DataMember = "UnitsSold";
            measure3.Name = "Units Sold";
            this.pieSalesbyCategory.DataItemRepository.Clear();
            this.pieSalesbyCategory.DataItemRepository.Add(measure2, "DataItem0");
            this.pieSalesbyCategory.DataItemRepository.Add(dimension2, "DataItem1");
            this.pieSalesbyCategory.DataItemRepository.Add(measure3, "DataItem2");
            this.pieSalesbyCategory.DataSource = this.dsSales;
            this.pieSalesbyCategory.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieSalesbyCategory.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.pieSalesbyCategory.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument;
            this.pieSalesbyCategory.Name = "Pies 1";
            this.pieSalesbyCategory.ShowCaption = false;
            this.pieSalesbyCategory.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure2,
            measure3});
            // 
            // pivotSalesByState
            // 
            dimension3.DataMember = "Category";
            dimension4.DataMember = "Product";
            dimension4.TopNOptions.ShowOthers = true;
            this.pivotSalesByState.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.pivotSalesByState.ComponentName = "pivotSalesByState";
            measure4.DataMember = "UnitsSold";
            measure4.Name = "Units Sold";
            dimension5.DataMember = "State";
            measure5.DataMember = "Revenue";
            measure5.Name = "Revenue";
            this.pivotSalesByState.DataItemRepository.Clear();
            this.pivotSalesByState.DataItemRepository.Add(measure4, "DataItem1");
            this.pivotSalesByState.DataItemRepository.Add(dimension4, "DataItem0");
            this.pivotSalesByState.DataItemRepository.Add(dimension5, "DataItem4");
            this.pivotSalesByState.DataItemRepository.Add(dimension3, "DataItem3");
            this.pivotSalesByState.DataItemRepository.Add(measure5, "DataItem2");
            this.pivotSalesByState.DataSource = this.dsSales;
            formatConditionTopBottom1.Rank = new decimal(new int[] {
            20,
            0,
            0,
            0});
            formatConditionTopBottom1.RankType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Percent;
            iconSettings1.IconType = DevExpress.DashboardCommon.FormatConditionIconType.RatingFullGrayStar;
            formatConditionTopBottom1.StyleSettings = iconSettings1;
            pivotItemFormatRule1.Condition = formatConditionTopBottom1;
            pivotItemFormatRule1.DataItem = measure5;
            pivotItemFormatRule1.DataItemApplyTo = dimension5;
            pivotItemFormatRule1.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel;
            pivotItemFormatRule1.Level.Row = dimension5;
            formatConditionTopBottom2.Rank = new decimal(new int[] {
            20,
            0,
            0,
            0});
            formatConditionTopBottom2.RankType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Percent;
            appearanceSettings1.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontBold;
            formatConditionTopBottom2.StyleSettings = appearanceSettings1;
            pivotItemFormatRule2.Condition = formatConditionTopBottom2;
            pivotItemFormatRule2.DataItem = measure5;
            pivotItemFormatRule2.DataItemApplyTo = dimension5;
            pivotItemFormatRule2.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel;
            pivotItemFormatRule2.Level.Row = dimension5;
            formatConditionTopBottom3.Rank = new decimal(new int[] {
            1,
            0,
            0,
            0});
            iconSettings2.IconType = DevExpress.DashboardCommon.FormatConditionIconType.RatingFullGrayStar;
            formatConditionTopBottom3.StyleSettings = iconSettings2;
            pivotItemFormatRule3.Condition = formatConditionTopBottom3;
            pivotItemFormatRule3.DataItem = measure5;
            pivotItemFormatRule3.DataItemApplyTo = dimension3;
            pivotItemFormatRule3.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel;
            pivotItemFormatRule3.Level.Column = dimension3;
            formatConditionTopBottom4.Rank = new decimal(new int[] {
            1,
            0,
            0,
            0});
            appearanceSettings2.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontBold;
            formatConditionTopBottom4.StyleSettings = appearanceSettings2;
            pivotItemFormatRule4.Condition = formatConditionTopBottom4;
            pivotItemFormatRule4.DataItem = measure5;
            pivotItemFormatRule4.DataItemApplyTo = dimension3;
            pivotItemFormatRule4.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel;
            pivotItemFormatRule4.Level.Column = dimension3;
            appearanceSettings3.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientTransparent;
            rangeInfo1.StyleSettings = appearanceSettings3;
            rangeInfo1.Value = 0;
            rangeInfo2.Value = 100000;
            rangeInfo3.Value = 120000;
            rangeInfo4.Value = 150000;
            rangeInfo5.Value = 200000;
            rangeInfo6.Value = 1000000;
            rangeInfo7.Value = 3000000;
            rangeInfo8.Value = 5000000;
            rangeInfo9.Value = 6000000;
            appearanceSettings4.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientBlue;
            rangeInfo10.StyleSettings = appearanceSettings4;
            rangeInfo10.Value = 9000000;
            formatConditionRangeGradient1.RangeSet.AddRange(new DevExpress.DashboardCommon.RangeInfo[] {
            rangeInfo1,
            rangeInfo2,
            rangeInfo3,
            rangeInfo4,
            rangeInfo5,
            rangeInfo6,
            rangeInfo7,
            rangeInfo8,
            rangeInfo9,
            rangeInfo10});
            formatConditionRangeGradient1.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Number;
            pivotItemFormatRule5.Condition = formatConditionRangeGradient1;
            pivotItemFormatRule5.DataItem = measure5;
            pivotItemFormatRule5.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.FirstLevel;
            pivotItemFormatRule5.Level.Column = dimension3;
            pivotItemFormatRule5.Level.Row = dimension5;
            appearanceSettings5.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientTransparent;
            rangeInfo11.StyleSettings = appearanceSettings5;
            rangeInfo11.Value = 0;
            rangeInfo12.Value = 1000;
            rangeInfo13.Value = 2000;
            rangeInfo14.Value = 3000;
            rangeInfo15.Value = 5000;
            rangeInfo16.Value = 10000;
            rangeInfo17.Value = 30000;
            rangeInfo18.Value = 50000;
            rangeInfo19.Value = 100000;
            appearanceSettings6.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientGreen;
            rangeInfo20.StyleSettings = appearanceSettings6;
            rangeInfo20.Value = 200000;
            formatConditionRangeGradient2.RangeSet.AddRange(new DevExpress.DashboardCommon.RangeInfo[] {
            rangeInfo11,
            rangeInfo12,
            rangeInfo13,
            rangeInfo14,
            rangeInfo15,
            rangeInfo16,
            rangeInfo17,
            rangeInfo18,
            rangeInfo19,
            rangeInfo20});
            formatConditionRangeGradient2.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Number;
            pivotItemFormatRule6.Condition = formatConditionRangeGradient2;
            pivotItemFormatRule6.DataItem = measure5;
            pivotItemFormatRule6.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.LastLevel;
            pivotItemFormatRule6.Level.Column = dimension4;
            pivotItemFormatRule6.Level.Row = dimension5;
            appearanceSettings7.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientTransparent;
            rangeInfo21.StyleSettings = appearanceSettings7;
            rangeInfo21.Value = 0;
            rangeInfo22.Value = 9000000;
            rangeInfo23.Value = 9400000;
            rangeInfo24.Value = 9500000;
            rangeInfo25.Value = 9600000;
            rangeInfo26.Value = 9700000;
            rangeInfo27.Value = 9800000;
            rangeInfo28.Value = 9900000;
            rangeInfo29.Value = 10000000;
            appearanceSettings8.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.GradientOrange;
            rangeInfo30.StyleSettings = appearanceSettings8;
            rangeInfo30.Value = 15000000;
            formatConditionRangeGradient3.RangeSet.AddRange(new DevExpress.DashboardCommon.RangeInfo[] {
            rangeInfo21,
            rangeInfo22,
            rangeInfo23,
            rangeInfo24,
            rangeInfo25,
            rangeInfo26,
            rangeInfo27,
            rangeInfo28,
            rangeInfo29,
            rangeInfo30});
            formatConditionRangeGradient3.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Number;
            pivotItemFormatRule7.Condition = formatConditionRangeGradient3;
            pivotItemFormatRule7.DataItem = measure5;
            pivotItemFormatRule7.IntersectionLevelMode = DevExpress.DashboardCommon.FormatConditionIntersectionLevelMode.SpecificLevel;
            pivotItemFormatRule7.Level.Row = dimension5;
            this.pivotSalesByState.FormatRules.AddRange(new DevExpress.DashboardCommon.PivotItemFormatRule[] {
            pivotItemFormatRule1,
            pivotItemFormatRule2,
            pivotItemFormatRule3,
            pivotItemFormatRule4,
            pivotItemFormatRule5,
            pivotItemFormatRule6,
            pivotItemFormatRule7});
            this.pivotSalesByState.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotSalesByState.Name = "Sales by State";
            this.pivotSalesByState.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.pivotSalesByState.ShowCaption = true;
            this.pivotSalesByState.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure5,
            measure4});
            // 
            // RevenueAnalysisDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsSales});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pivotSalesByState,
            this.pieSalesbyCategory,
            this.chartSalesbyYear});
            dashboardLayoutItem1.DashboardItem = this.chartSalesbyYear;
            dashboardLayoutItem1.Weight = 35.005015045135409D;
            dashboardLayoutItem2.DashboardItem = this.pieSalesbyCategory;
            dashboardLayoutItem2.Weight = 64.994984954864591D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 28.013582342954159D;
            dashboardLayoutItem3.DashboardItem = this.pivotSalesByState;
            dashboardLayoutItem3.Weight = 71.986417657045834D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Revenue Analysis";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.RevenueAnalysisDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesbyYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieSalesbyCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotSalesByState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    void RevenueAnalysisDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.RevenueAnalysisData;
    }
}
