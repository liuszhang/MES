using DashboardMainDemo;
using DevExpress.DashboardCommon;

/// <summary>
/// Summary description
/// </summary>
public class SalesDetailsDashboard : Dashboard {
    private CardDashboardItem cardSalesByProduct;
    private DashboardObjectDataSource dsSales;
    private ListBoxDashboardItem listBoxCategory;
    private ListBoxDashboardItem listBoxDashboardItem1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public SalesDetailsDashboard() {
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
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDetailsDashboard));
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card1 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card2 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Card card3 = new DevExpress.DashboardCommon.Card();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.listBoxCategory = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.dsSales = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.listBoxDashboardItem1 = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.cardSalesByProduct = new DevExpress.DashboardCommon.CardDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSalesByProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.ComponentName = "listBoxCategory";
            dimension1.DataMember = "Category";
            this.listBoxCategory.DataItemRepository.Clear();
            this.listBoxCategory.DataItemRepository.Add(dimension1, "DataItem0");
            this.listBoxCategory.DataSource = this.dsSales;
            this.listBoxCategory.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.listBoxCategory.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxCategory.ListBoxType = DevExpress.DashboardCommon.ListBoxDashboardItemType.Radio;
            this.listBoxCategory.Name = "Category";
            this.listBoxCategory.ShowCaption = true;
            // 
            // dsSales
            // 
            calculatedField1.Expression = "ToInt([UnitsReceived] - [UnitsSold] + [Returns])";
            calculatedField1.Name = "UnitsInStock";
            this.dsSales.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1});
            this.dsSales.ComponentName = "dsSales";
            this.dsSales.DataMember = "DataItem";
            this.dsSales.DataSchema = resources.GetString("dsSales.DataSchema");
            this.dsSales.Name = "Sales";
            // 
            // listBoxDashboardItem1
            // 
            this.listBoxDashboardItem1.ComponentName = "listBoxDashboardItem1";
            dimension2.DataMember = "State";
            this.listBoxDashboardItem1.DataItemRepository.Clear();
            this.listBoxDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0");
            this.listBoxDashboardItem1.DataSource = this.dsSales;
            this.listBoxDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.listBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxDashboardItem1.Name = "State";
            this.listBoxDashboardItem1.ShowCaption = true;
            // 
            // cardSalesByProduct
            // 
            measure1.DataMember = "Revenue";
            measure1.Name = "Revenue";
            measure2.DataMember = "RevenueTarget";
            measure2.Name = "Revenue Target";
            card1.Name = "Revenue vs Target";
            card1.AddDataItem("ActualValue", measure1);
            card1.AddDataItem("TargetValue", measure2);
            measure3.DataMember = "UnitsSold";
            measure3.Name = "Units Sold";
            measure4.DataMember = "UnitsSoldTarget";
            measure4.Name = "Units Sold Target";
            card2.Name = "Units Sold vs Target";
            card2.AddDataItem("ActualValue", measure3);
            card2.AddDataItem("TargetValue", measure4);
            measure5.DataMember = "Returns";
            measure5.Name = "Returns";
            measure6.DataMember = "ReturnsTarget";
            measure6.Name = "Returns Target";
            card3.DeltaOptions.ResultIndicationMode = DevExpress.DashboardCommon.DeltaIndicationMode.LessIsGood;
            card3.Name = "Returns vs Target";
            card3.AddDataItem("ActualValue", measure5);
            card3.AddDataItem("TargetValue", measure6);
            this.cardSalesByProduct.Cards.AddRange(new DevExpress.DashboardCommon.Card[] {
            card1,
            card2,
            card3});
            this.cardSalesByProduct.ComponentName = "cardSalesByProduct";
            this.cardSalesByProduct.ContentArrangementMode = DevExpress.DashboardCommon.ContentArrangementMode.FixedColumnCount;
            this.cardSalesByProduct.ContentLineCount = 4;
            dimension3.DataMember = "Category";
            dimension4.DataMember = "Product";
            dimension5.DataMember = "CurrentDate";
            dimension5.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
            measure7.DataMember = "UnitsInStock";
            measure7.Name = "Units In Stock";
            this.cardSalesByProduct.DataItemRepository.Clear();
            this.cardSalesByProduct.DataItemRepository.Add(measure2, "DataItem1");
            this.cardSalesByProduct.DataItemRepository.Add(measure3, "DataItem2");
            this.cardSalesByProduct.DataItemRepository.Add(measure4, "DataItem3");
            this.cardSalesByProduct.DataItemRepository.Add(measure5, "DataItem4");
            this.cardSalesByProduct.DataItemRepository.Add(measure1, "DataItem0");
            this.cardSalesByProduct.DataItemRepository.Add(measure6, "DataItem5");
            this.cardSalesByProduct.DataItemRepository.Add(dimension3, "DataItem6");
            this.cardSalesByProduct.DataItemRepository.Add(dimension4, "DataItem7");
            this.cardSalesByProduct.DataItemRepository.Add(dimension5, "DataItem8");
            this.cardSalesByProduct.DataItemRepository.Add(measure7, "DataItem9");
            this.cardSalesByProduct.DataSource = this.dsSales;
            this.cardSalesByProduct.HiddenMeasures.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure7});
            this.cardSalesByProduct.InteractivityOptions.IgnoreMasterFilters = false;
            this.cardSalesByProduct.Name = "Sales by Product";
            this.cardSalesByProduct.SeriesDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.cardSalesByProduct.ShowCaption = true;
            this.cardSalesByProduct.SparklineArgument = dimension5;
            // 
            // SalesDetailsDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dsSales});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.cardSalesByProduct,
            this.listBoxCategory,
            this.listBoxDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.listBoxCategory;
            dashboardLayoutItem1.Weight = 23.122529644268774D;
            dashboardLayoutItem2.DashboardItem = this.listBoxDashboardItem1;
            dashboardLayoutItem2.Weight = 76.877470355731219D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 21.042281219272368D;
            dashboardLayoutItem3.DashboardItem = this.cardSalesByProduct;
            dashboardLayoutItem3.Weight = 78.957718780727632D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Sales Details";
            this.DataLoading += new DevExpress.DashboardCommon.DashboardDataLoadingEventHandler(this.SalesDetailsDashboard_DataLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSalesByProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    void SalesDetailsDashboard_DataLoading(object sender, DashboardDataLoadingEventArgs e) {
        e.Data = DataLoader.SalesDetailsData;
    }
}
