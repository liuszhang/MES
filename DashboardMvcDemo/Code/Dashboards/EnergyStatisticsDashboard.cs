using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class EnergyStatisticsDashboard : Dashboard {
    private GridDashboardItem gridProductionImportByCountry;
    private DashboardObjectDataSource dsCountries;
    private PieMapDashboardItem mapProduction;
    private CardDashboardItem cardProductionImportByType;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public EnergyStatisticsDashboard() {
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
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField3 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField4 = new DevExpress.DashboardCommon.CalculatedField();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergyStatisticsDashboard));
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridSparklineColumn gridSparklineColumn1 = new DevExpress.DashboardCommon.GridSparklineColumn();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule1 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionValue formatConditionValue1 = new DevExpress.DashboardCommon.FormatConditionValue();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings1 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule2 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionValue formatConditionValue2 = new DevExpress.DashboardCommon.FormatConditionValue();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings2 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.GridItemFormatRule gridItemFormatRule3 = new DevExpress.DashboardCommon.GridItemFormatRule();
            DevExpress.DashboardCommon.FormatConditionValue formatConditionValue3 = new DevExpress.DashboardCommon.FormatConditionValue();
            DevExpress.DashboardCommon.AppearanceSettings appearanceSettings3 = new DevExpress.DashboardCommon.AppearanceSettings();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardParameter dashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
            DevExpress.DashboardCommon.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.DashboardCommon.StaticListLookUpSettings();
            this.mapProduction = new DevExpress.DashboardCommon.PieMapDashboardItem();
            this.dsCountries = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.gridProductionImportByCountry = new DevExpress.DashboardCommon.GridDashboardItem();
            this.cardProductionImportByType = new DevExpress.DashboardCommon.CardDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.mapProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductionImportByCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardProductionImportByType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // mapProduction
            // 
            this.mapProduction.Area = DevExpress.DashboardCommon.ShapefileArea.Europe;
            dimension1.DataMember = "EnergyType";
            this.mapProduction.Argument = dimension1;
            this.mapProduction.ComponentName = "mapProduction";
            dimension2.DataMember = "Latitude";
            dimension3.DataMember = "Longitude";
            measure1.DataMember = "YearProduction";
            measure1.Name = "Production";
            measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            measure2.DataMember = "YearImport";
            measure2.Name = "Import";
            measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            dimension4.DataMember = "Country";
            this.mapProduction.DataItemRepository.Clear();
            this.mapProduction.DataItemRepository.Add(dimension2, "DataItem0");
            this.mapProduction.DataItemRepository.Add(dimension3, "DataItem1");
            this.mapProduction.DataItemRepository.Add(measure1, "DataItem4");
            this.mapProduction.DataItemRepository.Add(dimension1, "DataItem3");
            this.mapProduction.DataItemRepository.Add(measure2, "DataItem2");
            this.mapProduction.DataItemRepository.Add(dimension4, "DataItem5");
            this.mapProduction.DataSource = this.dsCountries;
            this.mapProduction.InteractivityOptions.IgnoreMasterFilters = true;
            this.mapProduction.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.mapProduction.Latitude = dimension2;
            this.mapProduction.Legend.Visible = true;
            this.mapProduction.Longitude = dimension3;
            this.mapProduction.Name = "Energy Statistics by Country";
            this.mapProduction.ShapeTitleAttributeName = "NAME";
            this.mapProduction.ShowCaption = true;
            this.mapProduction.TooltipDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.mapProduction.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2});
            this.mapProduction.Viewport.BottomLatitude = 27.646386718750023D;
            this.mapProduction.Viewport.CenterPointLatitude = 54.855558031681227D;
            this.mapProduction.Viewport.CenterPointLongitude = 17.541333007812533D;
            this.mapProduction.Viewport.LeftLongitude = -31.282958984375D;
            this.mapProduction.Viewport.RightLongitude = 66.365625000000051D;
            this.mapProduction.Viewport.TopLatitude = 71.177685546874955D;
            this.mapProduction.WeightedLegend.Position = DevExpress.DashboardCommon.MapLegendPosition.BottomLeft;
            this.mapProduction.WeightedLegend.Visible = true;
            // 
            // dsCountries
            // 
            calculatedField1.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Import], 0))";
            calculatedField1.Name = "YearImport";
            calculatedField2.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Production], 0))";
            calculatedField2.Name = "YearProduction";
            calculatedField3.Expression = "ToDecimal([YearProduction] + [YearImport])";
            calculatedField3.Name = "YearTotal";
            calculatedField4.Expression = "ToDecimal(Iif(Sum([YearTotal]) = 0, 0, Sum([YearProduction]) / Sum([YearTotal])))";
            calculatedField4.Name = "DomesticShare";
            this.dsCountries.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2,
            calculatedField3,
            calculatedField4});
            this.dsCountries.ComponentName = "dsCountries";
            this.dsCountries.DataMember = "Countries";
            this.dsCountries.DataSchema = resources.GetString("dsCountries.DataSchema");
            this.dsCountries.Name = "Countries";
            // 
            // gridProductionImportByCountry
            // 
            dimension5.DataMember = "Country";
            gridDimensionColumn1.Name = "Country";
            gridDimensionColumn1.Weight = 50.063938618925832D;
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension5);
            measure3.DataMember = "DomesticShare";
            measure3.Name = "Domestic Share";
            measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Percent;
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Count;
            gridMeasureColumn1.Weight = 90.632992327365741D;
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn1.AddDataItem("Measure", measure3);
            measure4.DataMember = "Production";
            measure4.Name = "Production";
            gridSparklineColumn1.Name = "";
            gridSparklineColumn1.SparklineOptions.ViewType = DevExpress.DashboardCommon.SparklineViewType.Area;
            gridSparklineColumn1.Weight = 131.20204603580564D;
            gridSparklineColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridSparklineColumn1.AddDataItem("SparklineValue", measure4);
            this.gridProductionImportByCountry.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridMeasureColumn1,
            gridSparklineColumn1});
            this.gridProductionImportByCountry.ComponentName = "gridProductionImportByCountry";
            dimension6.DataMember = "Year";
            measure5.DataMember = "Production";
            this.gridProductionImportByCountry.DataItemRepository.Clear();
            this.gridProductionImportByCountry.DataItemRepository.Add(dimension5, "DataItem0");
            this.gridProductionImportByCountry.DataItemRepository.Add(dimension6, "DataItem2");
            this.gridProductionImportByCountry.DataItemRepository.Add(measure5, "DataItem5");
            this.gridProductionImportByCountry.DataItemRepository.Add(measure4, "DataItem1");
            this.gridProductionImportByCountry.DataItemRepository.Add(measure3, "DataItem3");
            this.gridProductionImportByCountry.DataSource = this.dsCountries;
            formatConditionValue1.Condition = DevExpress.DashboardCommon.DashboardFormatCondition.GreaterOrEqual;
            appearanceSettings1.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontGreen;
            formatConditionValue1.StyleSettings = appearanceSettings1;
            formatConditionValue1.Value1 = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            gridItemFormatRule1.Condition = formatConditionValue1;
            gridItemFormatRule1.DataItem = measure3;
            gridItemFormatRule1.Name = "FormatRule 1";
            formatConditionValue2.Condition = DevExpress.DashboardCommon.DashboardFormatCondition.Less;
            appearanceSettings2.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontYellow;
            formatConditionValue2.StyleSettings = appearanceSettings2;
            formatConditionValue2.Value1 = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            gridItemFormatRule2.Condition = formatConditionValue2;
            gridItemFormatRule2.DataItem = measure3;
            gridItemFormatRule2.Name = "FormatRule 2";
            appearanceSettings3.AppearanceType = DevExpress.DashboardCommon.FormatConditionAppearanceType.FontRed;
            formatConditionValue3.StyleSettings = appearanceSettings3;
            formatConditionValue3.Value1 = 0;
            gridItemFormatRule3.Condition = formatConditionValue3;
            gridItemFormatRule3.DataItem = measure3;
            gridItemFormatRule3.Name = "FormatRule 3";
            this.gridProductionImportByCountry.FormatRules.AddRange(new DevExpress.DashboardCommon.GridItemFormatRule[] {
            gridItemFormatRule1,
            gridItemFormatRule2,
            gridItemFormatRule3});
            this.gridProductionImportByCountry.GridOptions.ShowHorizontalLines = false;
            this.gridProductionImportByCountry.HiddenMeasures.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure5});
            this.gridProductionImportByCountry.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridProductionImportByCountry.Name = "Energy Statistics by Country";
            this.gridProductionImportByCountry.ShowCaption = false;
            this.gridProductionImportByCountry.SparklineArgument = dimension6;
            // 
            // cardProductionImportByType
            // 
            measure6.DataMember = "YearImport";
            measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            measure7.DataMember = "YearProduction";
            card1.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.WarningIfGreater;
            card1.DeltaOptions.ValueType = DevExpress.DashboardCommon.DeltaValueType.ActualValue;
            card1.AddDataItem("ActualValue", measure6);
            card1.AddDataItem("TargetValue", measure7);
            this.cardProductionImportByType.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1});
            this.cardProductionImportByType.ComponentName = "cardProductionImportByType";
            this.cardProductionImportByType.ContentLineCount = 1;
            dimension7.DataMember = "EnergyType";
            this.cardProductionImportByType.DataItemRepository.Clear();
            this.cardProductionImportByType.DataItemRepository.Add(dimension7, "DataItem0");
            this.cardProductionImportByType.DataItemRepository.Add(measure7, "DataItem1");
            this.cardProductionImportByType.DataItemRepository.Add(measure6, "DataItem2");
            this.cardProductionImportByType.DataSource = this.dsCountries;
            this.cardProductionImportByType.FilterString = "[DataItem0] In (\'Petroleum Products\', \'Solid Fuels\', \'Gases\')";
            this.cardProductionImportByType.InteractivityOptions.IgnoreMasterFilters = false;
            this.cardProductionImportByType.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single;
            this.cardProductionImportByType.Name = "Energy Statistics by Type - Production vs Import";
            this.cardProductionImportByType.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension7});
            this.cardProductionImportByType.ShowCaption = true;
            // 
            // EnergyStatisticsDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsCountries});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gridProductionImportByCountry,
            this.mapProduction,
            this.cardProductionImportByType});
            dashboardLayoutItem1.DashboardItem = this.mapProduction;
            dashboardLayoutItem1.Weight = 67.001003009027087D;
            dashboardLayoutItem2.DashboardItem = this.gridProductionImportByCountry;
            dashboardLayoutItem2.Weight = 32.99899699097292D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 74.023769100169773D;
            dashboardLayoutItem3.DashboardItem = this.cardProductionImportByType;
            dashboardLayoutItem3.Weight = 25.97623089983022D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            this.LayoutRoot = dashboardLayoutGroup1;
            staticListLookUpSettings1.Values = new string[] {
        "1999",
        "2000",
        "2001",
        "2002",
        "2003",
        "2004",
        "2005",
        "2006",
        "2007",
        "2008",
        "2009"};
            dashboardParameter1.LookUpSettings = staticListLookUpSettings1;
            dashboardParameter1.Name = "Year";
            dashboardParameter1.Type = typeof(int);
            dashboardParameter1.Value = 2009;
            this.Parameters.AddRange(new DevExpress.DashboardCommon.DashboardParameter[] {
            dashboardParameter1});
            this.Title.Text = "Energy Statistics";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.WorldwideEnergyUseDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductionImportByCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardProductionImportByType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void WorldwideEnergyUseDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.EnergyStatistics.Tables["Countries"];
    }
}
