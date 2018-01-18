using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DashboardCommon;
using DashboardMainDemo;

public class ChampionsLeagueStatisticsDashboard : Dashboard {
    private ScatterChartDashboardItem scatterChartLeagueStatistics;
    private DashboardObjectDataSource dashboardObjectDataSource1;
    private DashboardItemGroup groupCountryStatistics;
    private PivotDashboardItem pivotGoalDifference;
    private DashboardItemGroup groupGoalDifference;
    private ComboBoxDashboardItem comboBoxCountries;
    private ChartDashboardItem chartStatisticsBySeason;

    public ChampionsLeagueStatisticsDashboard() {
        InitializeComponent();
    }
    private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.ChartPane chartPane2 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.ChartPane chartPane3 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries3 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.PivotItemFormatRule pivotItemFormatRule1 = new DevExpress.DashboardCommon.PivotItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionBar formatConditionBar1 = new DevExpress.DashboardCommon.FormatConditionBar();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.scatterChartLeagueStatistics = new DevExpress.DashboardCommon.ScatterChartDashboardItem();
            this.dashboardObjectDataSource1 = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.groupCountryStatistics = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.chartStatisticsBySeason = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.comboBoxCountries = new DevExpress.DashboardCommon.ComboBoxDashboardItem();
            this.groupGoalDifference = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.pivotGoalDifference = new DevExpress.DashboardCommon.PivotDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.scatterChartLeagueStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCountryStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatisticsBySeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGoalDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGoalDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // scatterChartLeagueStatistics
            // 
            dimension1.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue;
            dimension1.DataMember = "Country";
            dimension2.DataMember = "Club";
            this.scatterChartLeagueStatistics.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2});
            this.scatterChartLeagueStatistics.AxisX.AlwaysShowZeroLevel = false;
            this.scatterChartLeagueStatistics.AxisX.LogarithmicBase = DevExpress.DashboardCommon.LogarithmicBase.Base5;
            this.scatterChartLeagueStatistics.AxisX.ShowGridLines = true;
            this.scatterChartLeagueStatistics.AxisX.TitleVisible = true;
            measure1.DataMember = "Goals_for";
            measure1.Name = "Goals For";
            this.scatterChartLeagueStatistics.AxisXMeasure = measure1;
            this.scatterChartLeagueStatistics.AxisY.AlwaysShowZeroLevel = false;
            this.scatterChartLeagueStatistics.AxisY.ShowGridLines = true;
            this.scatterChartLeagueStatistics.AxisY.TitleVisible = true;
            measure2.DataMember = "Goals_against";
            measure2.Name = "Goals Against";
            this.scatterChartLeagueStatistics.AxisYMeasure = measure2;
            this.scatterChartLeagueStatistics.ComponentName = "scatterChartLeagueStatistics";
            measure3.DataMember = "Points";
            measure3.Name = "Points";
            this.scatterChartLeagueStatistics.DataItemRepository.Clear();
            this.scatterChartLeagueStatistics.DataItemRepository.Add(measure1, "DataItem0");
            this.scatterChartLeagueStatistics.DataItemRepository.Add(measure2, "DataItem1");
            this.scatterChartLeagueStatistics.DataItemRepository.Add(measure3, "DataItem2");
            this.scatterChartLeagueStatistics.DataItemRepository.Add(dimension1, "DataItem3");
            this.scatterChartLeagueStatistics.DataItemRepository.Add(dimension2, "DataItem4");
            this.scatterChartLeagueStatistics.DataSource = this.dashboardObjectDataSource1;
            this.scatterChartLeagueStatistics.Group = this.groupCountryStatistics;
            this.scatterChartLeagueStatistics.InteractivityOptions.IgnoreMasterFilters = false;
            this.scatterChartLeagueStatistics.InteractivityOptions.IsDrillDownEnabled = true;
            this.scatterChartLeagueStatistics.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single;
            this.scatterChartLeagueStatistics.Legend.Visible = false;
            this.scatterChartLeagueStatistics.Name = "League Statistics by Country/Club";
            this.scatterChartLeagueStatistics.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside;
            this.scatterChartLeagueStatistics.PointLabelOptions.ShowPointLabels = true;
            this.scatterChartLeagueStatistics.ShowCaption = false;
            this.scatterChartLeagueStatistics.Weight = measure3;
            // 
            // dashboardObjectDataSource1
            // 
            calculatedField1.Expression = "ToInt([Goals_for] - [Goals_against])";
            calculatedField1.Name = "Goals difference";
            calculatedField2.Expression = "ToInt(3 * [Won] + [Drawn])";
            calculatedField2.Name = "Points";
            this.dashboardObjectDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2});
            this.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1";
            this.dashboardObjectDataSource1.DataMember = "Data";
            this.dashboardObjectDataSource1.Name = "Data";
            // 
            // groupCountryStatistics
            // 
            this.groupCountryStatistics.ComponentName = "groupCountryStatistics";
            this.groupCountryStatistics.InteractivityOptions.IgnoreMasterFilters = true;
            this.groupCountryStatistics.InteractivityOptions.IsMasterFilter = true;
            this.groupCountryStatistics.Name = "Country/Club Statistics";
            this.groupCountryStatistics.ShowCaption = true;
            // 
            // chartStatisticsBySeason
            // 
            dimension3.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue;
            dimension3.DataMember = "Season";
            this.chartStatisticsBySeason.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.chartStatisticsBySeason.AxisX.TitleVisible = true;
            this.chartStatisticsBySeason.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.None;
            this.chartStatisticsBySeason.ColoringOptions.UseGlobalColors = false;
            this.chartStatisticsBySeason.ComponentName = "chartStatisticsBySeason";
            measure4.DataMember = "Goals_for";
            measure4.Name = "Goals For";
            measure5.DataMember = "Goals_against";
            measure5.Name = "Goals Against";
            measure6.DataMember = "Points";
            measure6.Name = "Points";
            this.chartStatisticsBySeason.DataItemRepository.Clear();
            this.chartStatisticsBySeason.DataItemRepository.Add(dimension3, "DataItem0");
            this.chartStatisticsBySeason.DataItemRepository.Add(measure4, "DataItem3");
            this.chartStatisticsBySeason.DataItemRepository.Add(measure5, "DataItem4");
            this.chartStatisticsBySeason.DataItemRepository.Add(measure6, "DataItem2");
            this.chartStatisticsBySeason.DataSource = this.dashboardObjectDataSource1;
            this.chartStatisticsBySeason.Group = this.groupCountryStatistics;
            this.chartStatisticsBySeason.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartStatisticsBySeason.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.chartStatisticsBySeason.Legend.Visible = false;
            this.chartStatisticsBySeason.Name = "Country/Club Statistics by Season";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside;
            simpleSeries1.PointLabelOptions.ShowPointLabels = true;
            simpleSeries1.AddDataItem("Value", measure6);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            chartPane2.Name = "Pane 2";
            chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.PrimaryAxisY.ShowGridLines = true;
            chartPane2.PrimaryAxisY.TitleVisible = true;
            chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.SecondaryAxisY.ShowGridLines = false;
            chartPane2.SecondaryAxisY.TitleVisible = true;
            simpleSeries2.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside;
            simpleSeries2.PointLabelOptions.ShowPointLabels = true;
            simpleSeries2.AddDataItem("Value", measure4);
            chartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries2});
            chartPane3.Name = "Pane 3";
            chartPane3.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane3.PrimaryAxisY.ShowGridLines = true;
            chartPane3.PrimaryAxisY.TitleVisible = true;
            chartPane3.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane3.SecondaryAxisY.ShowGridLines = false;
            chartPane3.SecondaryAxisY.TitleVisible = true;
            simpleSeries3.PointLabelOptions.Position = DevExpress.DashboardCommon.PointLabelPosition.Inside;
            simpleSeries3.PointLabelOptions.ShowPointLabels = true;
            simpleSeries3.AddDataItem("Value", measure5);
            chartPane3.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries3});
            this.chartStatisticsBySeason.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1,
            chartPane2,
            chartPane3});
            this.chartStatisticsBySeason.Rotated = true;
            this.chartStatisticsBySeason.ShowCaption = false;
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.ComboBoxType = DevExpress.DashboardCommon.ComboBoxDashboardItemType.Checked;
            this.comboBoxCountries.ComponentName = "comboBoxCountries";
            dimension4.DataMember = "Country";
            this.comboBoxCountries.DataItemRepository.Clear();
            this.comboBoxCountries.DataItemRepository.Add(dimension4, "DataItem0");
            this.comboBoxCountries.DataSource = this.dashboardObjectDataSource1;
            this.comboBoxCountries.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.comboBoxCountries.Group = this.groupGoalDifference;
            this.comboBoxCountries.InteractivityOptions.IgnoreMasterFilters = true;
            this.comboBoxCountries.Name = "Countries";
            this.comboBoxCountries.ShowCaption = false;
            // 
            // groupGoalDifference
            // 
            this.groupGoalDifference.ComponentName = "groupGoalDifference";
            this.groupGoalDifference.InteractivityOptions.IgnoreMasterFilters = true;
            this.groupGoalDifference.Name = "Goal Difference";
            this.groupGoalDifference.ShowCaption = true;
            // 
            // pivotGoalDifference
            // 
            dimension5.DataMember = "Season";
            this.pivotGoalDifference.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.pivotGoalDifference.ComponentName = "pivotGoalDifference";
            measure7.DataMember = "Goals difference";
            measure7.Name = "Goals Difference";
            dimension6.DataMember = "Club";
            dimension6.SortByMeasure = measure7;
            dimension6.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            this.pivotGoalDifference.DataItemRepository.Clear();
            this.pivotGoalDifference.DataItemRepository.Add(measure7, "DataItem0");
            this.pivotGoalDifference.DataItemRepository.Add(dimension5, "DataItem2");
            this.pivotGoalDifference.DataItemRepository.Add(dimension6, "DataItem3");
            this.pivotGoalDifference.DataSource = this.dashboardObjectDataSource1;
            formatConditionBar1.NegativeStyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Red;
            formatConditionBar1.StyleSettings.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Green;
            pivotItemFormatRule1.Condition = formatConditionBar1;
            pivotItemFormatRule1.DataItem = measure7;
            pivotItemFormatRule1.Name = "FormatRule 5";
            this.pivotGoalDifference.FormatRules.AddRange(new DevExpress.DashboardCommon.PivotItemFormatRule[] {
            pivotItemFormatRule1});
            this.pivotGoalDifference.Group = this.groupGoalDifference;
            this.pivotGoalDifference.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotGoalDifference.Name = "Goal Difference by Club";
            this.pivotGoalDifference.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension6});
            this.pivotGoalDifference.ShowCaption = false;
            this.pivotGoalDifference.ShowColumnGrandTotals = false;
            this.pivotGoalDifference.ShowColumnTotals = false;
            this.pivotGoalDifference.ShowRowGrandTotals = false;
            this.pivotGoalDifference.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure7});
            // 
            // ChampionsLeagueStatisticsDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardObjectDataSource1});
            this.Groups.AddRange(new DevExpress.DashboardCommon.DashboardItemGroup[] {
            this.groupGoalDifference,
            this.groupCountryStatistics});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.scatterChartLeagueStatistics,
            this.pivotGoalDifference,
            this.comboBoxCountries,
            this.chartStatisticsBySeason});
            dashboardLayoutItem1.DashboardItem = this.scatterChartLeagueStatistics;
            dashboardLayoutItem1.Weight = 70.308483290488425D;
            dashboardLayoutItem2.DashboardItem = this.chartStatisticsBySeason;
            dashboardLayoutItem2.Weight = 29.691516709511568D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = this.groupCountryStatistics;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 59.9687255668491D;
            dashboardLayoutItem3.DashboardItem = this.comboBoxCountries;
            dashboardLayoutItem3.Weight = 4.1131105398457581D;
            dashboardLayoutItem4.DashboardItem = this.pivotGoalDifference;
            dashboardLayoutItem4.Weight = 95.886889460154237D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup3.DashboardItem = this.groupGoalDifference;
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup3.Weight = 40.0312744331509D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Champions League Statistics";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.ChampionsLeagueStatisticsDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatterChartLeagueStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCountryStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatisticsBySeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGoalDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGoalDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    private void ChampionsLeagueStatisticsDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.ChampionsLeagueStatistics.Tables["Data"];
    }
}
