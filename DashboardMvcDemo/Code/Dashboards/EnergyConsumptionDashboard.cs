using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class EnergyConsumptionDashboard : Dashboard {
    private ChartDashboardItem chartConsumptionHistory;
    private DashboardObjectDataSource dsConsumptionBySector;
    private PieDashboardItem pieConsumption;
    private BubbleMapDashboardItem mapProduction;
    private DashboardObjectDataSource dsConsumptionTotal;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public EnergyConsumptionDashboard() {
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
            DevExpress.DashboardCommon.UniformScale uniformScale1 = new DevExpress.DashboardCommon.UniformScale();
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField3 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField4 = new DevExpress.DashboardCommon.CalculatedField();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergyConsumptionDashboard));
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.CalculatedField calculatedField5 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardParameter dashboardParameter1 = new DevExpress.DashboardCommon.DashboardParameter();
            DevExpress.DashboardCommon.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.DashboardCommon.StaticListLookUpSettings();
            this.mapProduction = new DevExpress.DashboardCommon.BubbleMapDashboardItem();
            this.dsConsumptionTotal = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.pieConsumption = new DevExpress.DashboardCommon.PieDashboardItem();
            this.dsConsumptionBySector = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.chartConsumptionHistory = new DevExpress.DashboardCommon.ChartDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.mapProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsumptionTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsumptionBySector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumptionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // mapProduction
            // 
            this.mapProduction.Area = DevExpress.DashboardCommon.ShapefileArea.Europe;
            measure1.DataMember = "YearShortage";
            measure1.Name = "Shortage (Color)";
            measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            this.mapProduction.Color = measure1;
            uniformScale1.LevelsCount = 5;
            this.mapProduction.ColorScale = uniformScale1;
            this.mapProduction.ComponentName = "mapProduction";
            dimension1.DataMember = "Longitude";
            dimension2.DataMember = "Latitude";
            measure2.DataMember = "YearProduction";
            measure2.Name = "Production (Size)";
            measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            dimension3.DataMember = "Country";
            measure3.DataMember = "YearConsumption";
            measure3.Name = "Consumption";
            measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            this.mapProduction.DataItemRepository.Clear();
            this.mapProduction.DataItemRepository.Add(dimension1, "DataItem1");
            this.mapProduction.DataItemRepository.Add(dimension2, "DataItem0");
            this.mapProduction.DataItemRepository.Add(measure2, "DataItem2");
            this.mapProduction.DataItemRepository.Add(measure1, "DataItem3");
            this.mapProduction.DataItemRepository.Add(dimension3, "DataItem4");
            this.mapProduction.DataItemRepository.Add(measure3, "DataItem5");
            this.mapProduction.DataSource = this.dsConsumptionTotal;
            this.mapProduction.InteractivityOptions.IgnoreMasterFilters = false;
            this.mapProduction.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single;
            this.mapProduction.IsMasterFilterCrossDataSource = true;
            this.mapProduction.Latitude = dimension2;
            this.mapProduction.Legend.Orientation = DevExpress.DashboardCommon.MapLegendOrientation.Horizontal;
            this.mapProduction.Legend.Position = DevExpress.DashboardCommon.MapLegendPosition.BottomRight;
            this.mapProduction.Legend.Visible = true;
            this.mapProduction.Longitude = dimension1;
            this.mapProduction.Name = "Energy Production vs Shortage";
            this.mapProduction.ShapeTitleAttributeName = "NAME";
            this.mapProduction.ShowCaption = true;
            this.mapProduction.TooltipDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3});
            this.mapProduction.TooltipMeasures.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure3});
            this.mapProduction.Viewport.BottomLatitude = 27.646386718750023D;
            this.mapProduction.Viewport.CenterPointLatitude = 54.855558031681227D;
            this.mapProduction.Viewport.CenterPointLongitude = 17.541333007812533D;
            this.mapProduction.Viewport.LeftLongitude = -31.282958984375D;
            this.mapProduction.Viewport.RightLongitude = 66.365625000000051D;
            this.mapProduction.Viewport.TopLatitude = 71.177685546874955D;
            this.mapProduction.Weight = measure2;
            this.mapProduction.WeightedLegend.Position = DevExpress.DashboardCommon.MapLegendPosition.BottomLeft;
            this.mapProduction.WeightedLegend.Type = DevExpress.DashboardCommon.WeightedLegendType.Nested;
            this.mapProduction.WeightedLegend.Visible = true;
            // 
            // dsConsumptionTotal
            // 
            calculatedField1.Expression = "ToDecimal([Consumption] - [Production])";
            calculatedField1.Name = "Shortage";
            calculatedField2.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Production], 0.0))";
            calculatedField2.Name = "YearProduction";
            calculatedField3.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Shortage], 0.0))";
            calculatedField3.Name = "YearShortage";
            calculatedField4.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Consumption], 0.0))";
            calculatedField4.Name = "YearConsumption";
            this.dsConsumptionTotal.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2,
            calculatedField3,
            calculatedField4});
            this.dsConsumptionTotal.ComponentName = "dsConsumptionTotal";
            this.dsConsumptionTotal.DataMember = "CountriesTotal";
            this.dsConsumptionTotal.DataSchema = resources.GetString("dsConsumptionTotal.DataSchema");
            this.dsConsumptionTotal.Name = "Energy Consumption Total";
            // 
            // pieConsumption
            // 
            dimension4.DataMember = "Sector";
            this.pieConsumption.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.pieConsumption.ComponentName = "pieConsumption";
            dimension5.DataMember = "Country";
            measure4.DataMember = "YearConsumption";
            measure4.Name = "YearConsumption (Sum)";
            measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            this.pieConsumption.DataItemRepository.Clear();
            this.pieConsumption.DataItemRepository.Add(dimension5, "DataItem3");
            this.pieConsumption.DataItemRepository.Add(dimension4, "DataItem2");
            this.pieConsumption.DataItemRepository.Add(measure4, "DataItem0");
            this.pieConsumption.DataSource = this.dsConsumptionBySector;
            this.pieConsumption.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieConsumption.Name = "Energy Consumption by Sector";
            this.pieConsumption.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.pieConsumption.ShowCaption = true;
            this.pieConsumption.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure4});
            // 
            // dsConsumptionBySector
            // 
            calculatedField5.Expression = "ToDecimal(Iif(GetYear([Year]) = [Parameters.Year], [Consumption], 0.0))";
            calculatedField5.Name = "YearConsumption";
            this.dsConsumptionBySector.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField5});
            this.dsConsumptionBySector.ComponentName = "dsConsumptionBySector";
            this.dsConsumptionBySector.DataMember = "CountriesBySector";
            this.dsConsumptionBySector.DataSchema = resources.GetString("dsConsumptionBySector.DataSchema");
            this.dsConsumptionBySector.Name = "Energy Consumption by Sector";
            // 
            // chartConsumptionHistory
            // 
            dimension6.DataMember = "Year";
            this.chartConsumptionHistory.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension6});
            this.chartConsumptionHistory.AxisX.TitleVisible = false;
            this.chartConsumptionHistory.ComponentName = "chartConsumptionHistory";
            dimension7.DataMember = "Sector";
            measure5.DataMember = "Consumption";
            measure5.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Number;
            this.chartConsumptionHistory.DataItemRepository.Clear();
            this.chartConsumptionHistory.DataItemRepository.Add(dimension7, "DataItem2");
            this.chartConsumptionHistory.DataItemRepository.Add(dimension6, "DataItem1");
            this.chartConsumptionHistory.DataItemRepository.Add(measure5, "DataItem0");
            this.chartConsumptionHistory.DataSource = this.dsConsumptionBySector;
            this.chartConsumptionHistory.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartConsumptionHistory.Legend.Visible = false;
            this.chartConsumptionHistory.Name = "Energy Consumption History by Sector";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = false;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StepLine;
            simpleSeries1.AddDataItem("Value", measure5);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartConsumptionHistory.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartConsumptionHistory.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension7});
            this.chartConsumptionHistory.ShowCaption = false;
            // 
            // EnergyConsumptionDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsConsumptionTotal,
            this.dsConsumptionBySector});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartConsumptionHistory,
            this.pieConsumption,
            this.mapProduction});
            dashboardLayoutItem1.DashboardItem = this.mapProduction;
            dashboardLayoutItem1.Weight = 56.027164685908318D;
            dashboardLayoutItem2.DashboardItem = this.pieConsumption;
            dashboardLayoutItem2.Weight = 50.952858575727184D;
            dashboardLayoutItem3.DashboardItem = this.chartConsumptionHistory;
            dashboardLayoutItem3.Weight = 49.047141424272816D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem2,
            dashboardLayoutItem3});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Weight = 43.972835314091682D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutGroup2});
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
            this.Title.Text = "Energy Consumption";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.WorldwideEnergyUseDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsumptionTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsumptionBySector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumptionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void WorldwideEnergyUseDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        if(e.DataSource == dsConsumptionTotal)
            e.Data = DataLoader.EnergyConsumptionTotal.Tables["CountriesTotal"];
        else if(e.DataSource == dsConsumptionBySector)
            e.Data = DataLoader.EnergyConsumptionBySector.Tables["CountriesBySector"];
    }
}
