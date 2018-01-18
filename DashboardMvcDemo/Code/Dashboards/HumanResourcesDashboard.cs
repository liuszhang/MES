using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class HumanResourcesDashboard : Dashboard {
    private PieDashboardItem piePayrollStructureSum;
    private DashboardObjectDataSource dsEmployees;
    private GridDashboardItem gridStaffTurnoverTime;
    private DashboardObjectDataSource dsDepartments;
    private CardDashboardItem cardStaffTurnoverByDept;
    private PieDashboardItem pieAbsenceReasonSum;
    private ChartDashboardItem chartPayrollStructure;
    private ChartDashboardItem chartAbsenseDuration;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public HumanResourcesDashboard() {
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
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn2 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.GridColumnTotal gridColumnTotal1 = new DevExpress.DashboardCommon.GridColumnTotal();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridDeltaColumn gridDeltaColumn1 = new DevExpress.DashboardCommon.GridDeltaColumn();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule1 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionColorRangeBar formatConditionColorRangeBar1 = new DevExpress.DashboardCommon.FormatConditionColorRangeBar();
            DevExpress.DashboardCommon.RangeInfo rangeInfo1 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.BarStyleSettings barStyleSettings1 = new DevExpress.DashboardCommon.BarStyleSettings();
            DevExpress.DashboardCommon.RangeInfo rangeInfo2 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.BarStyleSettings barStyleSettings2 = new DevExpress.DashboardCommon.BarStyleSettings();
            DevExpress.DashboardCommon.RangeInfo rangeInfo3 = new DevExpress.DashboardCommon.RangeInfo();
            DevExpress.DashboardCommon.BarStyleSettings barStyleSettings3 = new DevExpress.DashboardCommon.BarStyleSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanResourcesDashboard));
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure8 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries3 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure9 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure10 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane2 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries4 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries5 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.Measure measure11 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure12 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure13 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure14 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure15 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup3 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup4 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem5 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem6 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.gridStaffTurnoverTime = new DevExpress.DashboardCommon.GridDashboardItem();
            this.dsDepartments = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.cardStaffTurnoverByDept = new DevExpress.DashboardCommon.CardDashboardItem();
            this.chartPayrollStructure = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dsEmployees = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.chartAbsenseDuration = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.piePayrollStructureSum = new DevExpress.DashboardCommon.PieDashboardItem();
            this.pieAbsenceReasonSum = new DevExpress.DashboardCommon.PieDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaffTurnoverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardStaffTurnoverByDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayrollStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAbsenseDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piePayrollStructureSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieAbsenceReasonSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // gridStaffTurnoverTime
            // 
            dimension1.DataMember = "CurrentDate";
            dimension1.Name = "Year";
            gridDimensionColumn1.Name = "Year";
            gridDimensionColumn1.Weight = 55.650319829424305D;
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension1);
            dimension2.DataMember = "CurrentDate";
            dimension2.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
            dimension2.Name = "Month";
            gridDimensionColumn2.Name = "Month";
            gridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn2.AddDataItem("Dimension", dimension2);
            measure1.DataMember = "StaffTurnrover";
            measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent;
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            gridMeasureColumn1.Name = "Turnover";
            gridColumnTotal1.TotalType = DevExpress.DashboardCommon.GridColumnTotalType.Auto;
            gridMeasureColumn1.Totals.AddRange(new DevExpress.DashboardCommon.GridColumnTotal[] {
            gridColumnTotal1});
            gridMeasureColumn1.Weight = 84.914712153518124D;
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn1.AddDataItem("Measure", measure1);
            measure2.DataMember = "StaffTurnrover";
            measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent;
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            measure3.DataMember = "StaffTurnroverCritical";
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            gridDeltaColumn1.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.WarningIfGreater;
            gridDeltaColumn1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue;
            gridDeltaColumn1.Name = "Turnover";
            gridDeltaColumn1.Weight = 84.434968017057571D;
            gridDeltaColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDeltaColumn1.AddDataItem("ActualValue", measure2);
            gridDeltaColumn1.AddDataItem("TargetValue", measure3);
            this.gridStaffTurnoverTime.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridDimensionColumn2,
            gridMeasureColumn1,
            gridDeltaColumn1});
            this.gridStaffTurnoverTime.ComponentName = "gridStaffTurnoverTime";
            this.gridStaffTurnoverTime.DataItemRepository.Clear();
            this.gridStaffTurnoverTime.DataItemRepository.Add(measure2, "DataItem4");
            this.gridStaffTurnoverTime.DataItemRepository.Add(dimension2, "DataItem0");
            this.gridStaffTurnoverTime.DataItemRepository.Add(dimension1, "DataItem3");
            this.gridStaffTurnoverTime.DataItemRepository.Add(measure1, "DataItem2");
            this.gridStaffTurnoverTime.DataItemRepository.Add(measure3, "DataItem5");
            this.gridStaffTurnoverTime.DataSource = this.dsDepartments;
            formatConditionColorRangeBar1.BarOptions.ShowBarOnly = true;
            barStyleSettings1.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Green;
            rangeInfo1.StyleSettings = barStyleSettings1;
            rangeInfo1.Value = 0D;
            barStyleSettings2.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Blue;
            rangeInfo2.StyleSettings = barStyleSettings2;
            rangeInfo2.Value = 33D;
            barStyleSettings3.PredefinedColor = DevExpress.DashboardCommon.FormatConditionAppearanceType.Red;
            rangeInfo3.StyleSettings = barStyleSettings3;
            rangeInfo3.Value = 67D;
            formatConditionColorRangeBar1.RangeSet.AddRange(new DevExpress.DashboardCommon.RangeInfo[] {
            rangeInfo1,
            rangeInfo2,
            rangeInfo3});
            formatConditionColorRangeBar1.ValueType = DevExpress.DashboardCommon.DashboardFormatConditionValueType.Percent;
            gridItemFormatRule1.Condition = formatConditionColorRangeBar1;
            gridItemFormatRule1.DataItem = measure1;
            gridItemFormatRule1.Name = "FormatRule 1";
            this.gridStaffTurnoverTime.FormatRules.AddRange(new DevExpress.DashboardCommon.GridItemFormatRule[] {
            gridItemFormatRule1});
            this.gridStaffTurnoverTime.GridOptions.ShowHorizontalLines = false;
            this.gridStaffTurnoverTime.InteractivityOptions.IgnoreMasterFilters = true;
            this.gridStaffTurnoverTime.InteractivityOptions.IsDrillDownEnabled = true;
            this.gridStaffTurnoverTime.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single;
            this.gridStaffTurnoverTime.IsMasterFilterCrossDataSource = true;
            this.gridStaffTurnoverTime.Name = "Staff Turnover through Time";
            this.gridStaffTurnoverTime.ShowCaption = true;
            // 
            // dsDepartments
            // 
            this.dsDepartments.ComponentName = "dsDepartments";
            this.dsDepartments.DataMember = "DepartmentData";
            this.dsDepartments.DataSchema = resources.GetString("dsDepartments.DataSchema");
            this.dsDepartments.Name = "Departments";
            // 
            // cardStaffTurnoverByDept
            // 
            measure4.DataMember = "StaffTurnrover";
            measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent;
            measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            measure5.DataMember = "StaffTurnroverCritical";
            measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Average;
            card1.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.WarningIfGreater;
            card1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue;
            card1.Name = "StaffTurnrover (Average) vs StaffTurnroverCritical (Average)";
            card1.AddDataItem("ActualValue", measure4);
            card1.AddDataItem("TargetValue", measure5);
            this.cardStaffTurnoverByDept.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1});
            this.cardStaffTurnoverByDept.ComponentName = "cardStaffTurnoverByDept";
            this.cardStaffTurnoverByDept.ContentLineCount = 4;
            dimension3.DataMember = "Department";
            this.cardStaffTurnoverByDept.DataItemRepository.Clear();
            this.cardStaffTurnoverByDept.DataItemRepository.Add(measure4, "DataItem0");
            this.cardStaffTurnoverByDept.DataItemRepository.Add(measure5, "DataItem1");
            this.cardStaffTurnoverByDept.DataItemRepository.Add(dimension3, "DataItem2");
            this.cardStaffTurnoverByDept.DataSource = this.dsDepartments;
            this.cardStaffTurnoverByDept.InteractivityOptions.IgnoreMasterFilters = false;
            this.cardStaffTurnoverByDept.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single;
            this.cardStaffTurnoverByDept.IsMasterFilterCrossDataSource = true;
            this.cardStaffTurnoverByDept.Name = " Staff Turnover by Department";
            this.cardStaffTurnoverByDept.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.cardStaffTurnoverByDept.ShowCaption = true;
            // 
            // chartPayrollStructure
            // 
            dimension4.DataMember = "Employee";
            dimension4.TopNOptions.Enabled = true;
            measure6.DataMember = "Salary";
            dimension4.TopNOptions.Measure = measure6;
            this.chartPayrollStructure.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.chartPayrollStructure.AxisX.TitleVisible = false;
            this.chartPayrollStructure.ComponentName = "chartPayrollStructure";
            measure7.DataMember = "Bonus";
            measure8.DataMember = "Overtime";
            this.chartPayrollStructure.DataItemRepository.Clear();
            this.chartPayrollStructure.DataItemRepository.Add(measure6, "DataItem0");
            this.chartPayrollStructure.DataItemRepository.Add(measure7, "DataItem1");
            this.chartPayrollStructure.DataItemRepository.Add(measure8, "DataItem2");
            this.chartPayrollStructure.DataItemRepository.Add(dimension4, "DataItem3");
            this.chartPayrollStructure.DataSource = this.dsEmployees;
            this.chartPayrollStructure.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartPayrollStructure.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartPayrollStructure.Name = " Payroll Structure for Top 5 Employees";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "Value";
            chartPane1.PrimaryAxisY.TitleVisible = false;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.Name = "Salary";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar;
            simpleSeries1.AddDataItem("Value", measure6);
            simpleSeries2.Name = "Bonus";
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar;
            simpleSeries2.AddDataItem("Value", measure7);
            simpleSeries3.Name = "Overtime";
            simpleSeries3.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar;
            simpleSeries3.AddDataItem("Value", measure8);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1,
            simpleSeries2,
            simpleSeries3});
            this.chartPayrollStructure.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartPayrollStructure.ShowCaption = true;
            // 
            // dsEmployees
            // 
            this.dsEmployees.ComponentName = "dsEmployees";
            this.dsEmployees.DataMember = "EmployeeData";
            this.dsEmployees.DataSchema = resources.GetString("dsEmployees.DataSchema");
            this.dsEmployees.Name = "Employees";
            // 
            // chartAbsenseDuration
            // 
            dimension5.DataMember = "Employee";
            dimension5.TopNOptions.Enabled = true;
            measure9.DataMember = "VacationDays";
            measure9.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General;
            dimension5.TopNOptions.Measure = measure9;
            this.chartAbsenseDuration.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.chartAbsenseDuration.AxisX.TitleVisible = false;
            this.chartAbsenseDuration.ComponentName = "chartAbsenseDuration";
            measure10.DataMember = "SickLeaveDays";
            measure10.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General;
            this.chartAbsenseDuration.DataItemRepository.Clear();
            this.chartAbsenseDuration.DataItemRepository.Add(measure9, "DataItem0");
            this.chartAbsenseDuration.DataItemRepository.Add(measure10, "DataItem1");
            this.chartAbsenseDuration.DataItemRepository.Add(dimension5, "DataItem2");
            this.chartAbsenseDuration.DataSource = this.dsEmployees;
            this.chartAbsenseDuration.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartAbsenseDuration.Legend.OutsidePosition = DevExpress.DashboardCommon.ChartLegendOutsidePosition.BottomCenterHorizontal;
            this.chartAbsenseDuration.Name = "Absence Duration for Top 5 Employees";
            chartPane2.Name = "Pane 1";
            chartPane2.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.PrimaryAxisY.ShowGridLines = true;
            chartPane2.PrimaryAxisY.Title = "Value";
            chartPane2.PrimaryAxisY.TitleVisible = false;
            chartPane2.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane2.SecondaryAxisY.ShowGridLines = false;
            chartPane2.SecondaryAxisY.TitleVisible = true;
            simpleSeries4.Name = "Vacation";
            simpleSeries4.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar;
            simpleSeries4.AddDataItem("Value", measure9);
            simpleSeries5.Name = "Sick Leave";
            simpleSeries5.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar;
            simpleSeries5.AddDataItem("Value", measure10);
            chartPane2.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries4,
            simpleSeries5});
            this.chartAbsenseDuration.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane2});
            this.chartAbsenseDuration.ShowCaption = true;
            // 
            // piePayrollStructureSum
            // 
            this.piePayrollStructureSum.ComponentName = "piePayrollStructureSum";
            measure11.DataMember = "Salary";
            measure11.Name = "Salary";
            measure12.DataMember = "Bonus";
            measure12.Name = "Bonus";
            measure13.DataMember = "Overtime";
            measure13.Name = "Overtime";
            this.piePayrollStructureSum.DataItemRepository.Clear();
            this.piePayrollStructureSum.DataItemRepository.Add(measure11, "DataItem0");
            this.piePayrollStructureSum.DataItemRepository.Add(measure12, "DataItem1");
            this.piePayrollStructureSum.DataItemRepository.Add(measure13, "DataItem2");
            this.piePayrollStructureSum.DataSource = this.dsEmployees;
            this.piePayrollStructureSum.InteractivityOptions.IgnoreMasterFilters = false;
            this.piePayrollStructureSum.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument;
            this.piePayrollStructureSum.Name = "Payroll Structure Summary";
            this.piePayrollStructureSum.ShowCaption = true;
            this.piePayrollStructureSum.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure11,
            measure12,
            measure13});
            // 
            // pieAbsenceReasonSum
            // 
            this.pieAbsenceReasonSum.ComponentName = "pieAbsenceReasonSum";
            measure14.DataMember = "VacationDays";
            measure14.Name = "Vacation";
            measure14.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General;
            measure15.DataMember = "SickLeaveDays";
            measure15.Name = "Sick Leave";
            measure15.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General;
            this.pieAbsenceReasonSum.DataItemRepository.Clear();
            this.pieAbsenceReasonSum.DataItemRepository.Add(measure14, "DataItem0");
            this.pieAbsenceReasonSum.DataItemRepository.Add(measure15, "DataItem1");
            this.pieAbsenceReasonSum.DataSource = this.dsEmployees;
            this.pieAbsenceReasonSum.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieAbsenceReasonSum.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument;
            this.pieAbsenceReasonSum.Name = "Absence Reason Summary";
            this.pieAbsenceReasonSum.ShowCaption = true;
            this.pieAbsenceReasonSum.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure14,
            measure15});
            // 
            // HumanResourcesDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsDepartments,
            this.dsEmployees});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.piePayrollStructureSum,
            this.gridStaffTurnoverTime,
            this.cardStaffTurnoverByDept,
            this.pieAbsenceReasonSum,
            this.chartPayrollStructure,
            this.chartAbsenseDuration});
            dashboardLayoutItem1.DashboardItem = this.gridStaffTurnoverTime;
            dashboardLayoutItem1.Weight = 66.996047430830046D;
            dashboardLayoutItem2.DashboardItem = this.cardStaffTurnoverByDept;
            dashboardLayoutItem2.Weight = 33.003952569169961D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 40.0196656833825D;
            dashboardLayoutItem3.DashboardItem = this.chartPayrollStructure;
            dashboardLayoutItem3.Weight = 32.213438735177867D;
            dashboardLayoutItem4.DashboardItem = this.chartAbsenseDuration;
            dashboardLayoutItem4.Weight = 34.387351778656125D;
            dashboardLayoutItem5.DashboardItem = this.piePayrollStructureSum;
            dashboardLayoutItem5.Weight = 54.918032786885249D;
            dashboardLayoutItem6.DashboardItem = this.pieAbsenceReasonSum;
            dashboardLayoutItem6.Weight = 45.081967213114751D;
            dashboardLayoutGroup4.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem5,
            dashboardLayoutItem6});
            dashboardLayoutGroup4.DashboardItem = null;
            dashboardLayoutGroup4.Weight = 33.399209486166008D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4,
            dashboardLayoutGroup4});
            dashboardLayoutGroup3.DashboardItem = null;
            dashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup3.Weight = 59.9803343166175D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Human Resources";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.HumanResourcesDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaffTurnoverTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardStaffTurnoverByDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayrollStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAbsenseDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piePayrollStructureSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieAbsenceReasonSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    void HumanResourcesDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        if(e.DataSource == dsDepartments)
            e.Data = DataLoader.HumanResourcesData.DepartmentData;
        else if(e.DataSource == dsEmployees)
            e.Data = DataLoader.HumanResourcesData.EmployeeData;
    }
}
