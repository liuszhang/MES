using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DashboardCommon;
using DashboardMainDemo;

/// <summary>
/// Summary description for ChampionsLeagueStatisticsDashboard
/// </summary>
public class ProductDetailsDashboard : Dashboard {
    private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
    private DevExpress.DashboardCommon.TextBoxDashboardItem textBoxDashboardItem1;
    private DevExpress.DashboardCommon.BoundImageDashboardItem boundImageDashboardItem1;
    private ComboBoxDashboardItem comboBoxDashboardItem1;
    private DashboardItemGroup dashboardItemGroup1;
    private DashboardItemGroup dashboardItemGroup2;
    private ComboBoxDashboardItem comboBoxDashboardItem2;
    private BoundImageDashboardItem boundImageDashboardItem2;
    private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;

    public ProductDetailsDashboard() {
        InitializeComponent();
    }

    private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField3 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField4 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField5 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField6 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters xmlFileConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsDashboard));
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure5 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure6 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure7 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure8 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure9 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure10 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.RunningTotalCalculation runningTotalCalculation1 = new DevExpress.DashboardCommon.RunningTotalCalculation();
            DevExpress.DashboardCommon.ChartWindowDefinition chartWindowDefinition1 = new DevExpress.DashboardCommon.ChartWindowDefinition();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries2 = new DevExpress.DashboardCommon.SimpleSeries();
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
            this.comboBoxDashboardItem1 = new DevExpress.DashboardCommon.ComboBoxDashboardItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            this.textBoxDashboardItem1 = new DevExpress.DashboardCommon.TextBoxDashboardItem();
            this.dashboardItemGroup1 = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.boundImageDashboardItem1 = new DevExpress.DashboardCommon.BoundImageDashboardItem();
            this.boundImageDashboardItem2 = new DevExpress.DashboardCommon.BoundImageDashboardItem();
            this.comboBoxDashboardItem2 = new DevExpress.DashboardCommon.ComboBoxDashboardItem();
            this.dashboardItemGroup2 = new DevExpress.DashboardCommon.DashboardItemGroup();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardItemGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundImageDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundImageDashboardItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDashboardItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardItemGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // comboBoxDashboardItem1
            // 
            this.comboBoxDashboardItem1.ComponentName = "comboBoxDashboardItem1";
            dimension1.DataMember = "Products_Name";
            dimension1.Name = "Product Name";
            this.comboBoxDashboardItem1.DataItemRepository.Clear();
            this.comboBoxDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.comboBoxDashboardItem1.DataMember = "Customers";
            this.comboBoxDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.comboBoxDashboardItem1.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.comboBoxDashboardItem1.Group = this.dashboardItemGroup1;
            this.comboBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.comboBoxDashboardItem1.Name = "Product";
            this.comboBoxDashboardItem1.ShowAllValue = false;
            this.comboBoxDashboardItem1.ShowCaption = false;
            // 
            // dashboardSqlDataSource1
            // 
            calculatedField1.DataMember = "Customers";
            calculatedField1.Expression = "Aggr(Sum([SalesAmount]), GetYear([OrderDate]))";
            calculatedField1.Name = "ProductSalesByYear";
            calculatedField2.DataMember = "Customers";
            calculatedField2.Expression = "Aggr(Sum([SalesAmount]), [Name])";
            calculatedField2.Name = "ProductSalesByCustomer";
            calculatedField3.DataMember = "Customers";
            calculatedField3.Expression = "Aggr(Max([ProductSalesByYear]))";
            calculatedField3.Name = "MaxProductSalesYear";
            calculatedField4.DataMember = "Customers";
            calculatedField4.Expression = "Aggr(Max([ProductSalesByCustomer]))";
            calculatedField4.Name = "MaxProductSalesCustomer";
            calculatedField5.DataMember = "Customers";
            calculatedField5.Expression = "Iif([MaxProductSalesYear] = [ProductSalesByYear], GetYear([OrderDate]), null)";
            calculatedField5.Name = "YearOfMaxSales";
            calculatedField6.DataMember = "Customers";
            calculatedField6.Expression = "Iif([MaxProductSalesCustomer] = [ProductSalesByCustomer], [Name], null)";
            calculatedField6.Name = "TopSeller";
            this.dashboardSqlDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2,
            calculatedField3,
            calculatedField4,
            calculatedField5,
            calculatedField6});
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "Source";
            xmlFileConnectionParameters1.FileName = "CSHTML\\App_Data\\DashboardProductDetails.xml";
            this.dashboardSqlDataSource1.ConnectionParameters = xmlFileConnectionParameters1;
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            columnExpression1.ColumnName = "Name";
            table1.Name = "Customers";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Street";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "City";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Latitude";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Longitude";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Phone";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            column7.Alias = "States_Name";
            columnExpression7.ColumnName = "Name";
            table2.Name = "States";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "OrderDate";
            table3.Name = "Orders";
            columnExpression8.Table = table3;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "SalesAmount";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            column10.Alias = "Products_Name";
            columnExpression10.ColumnName = "Name";
            table4.Name = "Products";
            columnExpression10.Table = table4;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "Description";
            columnExpression11.Table = table4;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "ProductionStart";
            columnExpression12.Table = table4;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "RetailPrice";
            columnExpression13.Table = table4;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "ConsumerRating";
            columnExpression14.Table = table4;
            column14.Expression = columnExpression14;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Columns.Add(column13);
            selectQuery1.Columns.Add(column14);
            selectQuery1.Name = "Customers";
            relationColumnInfo1.NestedKeyColumn = "Id";
            relationColumnInfo1.ParentKeyColumn = "StateId";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "CustomerId";
            relationColumnInfo2.ParentKeyColumn = "Id";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table1;
            relationColumnInfo3.NestedKeyColumn = "OrderId";
            relationColumnInfo3.ParentKeyColumn = "Id";
            join3.KeyColumns.Add(relationColumnInfo3);
            table5.Name = "OrderItems";
            join3.Nested = table5;
            join3.Parent = table3;
            relationColumnInfo4.NestedKeyColumn = "Id";
            relationColumnInfo4.ParentKeyColumn = "ProductId";
            join4.KeyColumns.Add(relationColumnInfo4);
            join4.Nested = table4;
            join4.Parent = table5;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Relations.Add(join3);
            selectQuery1.Relations.Add(join4);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table5);
            selectQuery1.Tables.Add(table4);
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // textBoxDashboardItem1
            // 
            this.textBoxDashboardItem1.ComponentName = "textBoxDashboardItem1";
            measure1.Calculation = null;
            measure1.DataMember = "Products_Name";
            measure1.Name = "Product Name";
            measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure1.WindowDefinition = null;
            measure2.Calculation = null;
            measure2.DataMember = "Description";
            measure2.Name = "Description";
            measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure2.WindowDefinition = null;
            measure3.Calculation = null;
            measure3.DataMember = "ProductionStart";
            measure3.Name = "Production Start";
            measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure3.WindowDefinition = null;
            measure4.Calculation = null;
            measure4.DataMember = "ConsumerRating";
            measure4.Name = "Consumer Rating";
            measure4.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure4.WindowDefinition = null;
            measure5.Calculation = null;
            measure5.DataMember = "RetailPrice";
            measure5.Name = "Retail Price";
            measure5.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure5.WindowDefinition = null;
            measure6.Calculation = null;
            measure6.DataMember = "YearOfMaxSales";
            measure6.Name = "Best Sales Year";
            measure6.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General;
            measure6.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure6.WindowDefinition = null;
            measure7.Calculation = null;
            measure7.DataMember = "TopSeller";
            measure7.Name = "Best Sales Company";
            measure7.SummaryType = DevExpress.DashboardCommon.SummaryType.Min;
            measure7.WindowDefinition = null;
            this.textBoxDashboardItem1.DataItemRepository.Clear();
            this.textBoxDashboardItem1.DataItemRepository.Add(measure1, "DataItem0");
            this.textBoxDashboardItem1.DataItemRepository.Add(measure2, "DataItem2");
            this.textBoxDashboardItem1.DataItemRepository.Add(measure3, "DataItem3");
            this.textBoxDashboardItem1.DataItemRepository.Add(measure4, "DataItem4");
            this.textBoxDashboardItem1.DataItemRepository.Add(measure5, "DataItem6");
            this.textBoxDashboardItem1.DataItemRepository.Add(measure6, "DataItem5");
            this.textBoxDashboardItem1.DataItemRepository.Add(measure7, "DataItem7");
            this.textBoxDashboardItem1.DataMember = "Customers";
            this.textBoxDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.textBoxDashboardItem1.Group = this.dashboardItemGroup1;
            this.textBoxDashboardItem1.InnerRtf = resources.GetString("textBoxDashboardItem1.InnerRtf");
            this.textBoxDashboardItem1.Name = "Product Description";
            this.textBoxDashboardItem1.ShowCaption = false;
            this.textBoxDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2,
            measure3,
            measure4,
            measure5,
            measure6,
            measure7});
            // 
            // dashboardItemGroup1
            // 
            this.dashboardItemGroup1.ComponentName = "dashboardItemGroup1";
            this.dashboardItemGroup1.InteractivityOptions.IgnoreMasterFilters = false;
            this.dashboardItemGroup1.InteractivityOptions.IsMasterFilter = true;
            this.dashboardItemGroup1.Name = "Product Details";
            this.dashboardItemGroup1.ShowCaption = false;
            // 
            // boundImageDashboardItem1
            // 
            this.boundImageDashboardItem1.ComponentName = "primaryImage";
            this.boundImageDashboardItem1.DataBindingMode = DevExpress.DashboardCommon.ImageDataBindingMode.Uri;
            dimension2.DataMember = "Products_Name";
            dimension2.Name = "Product Name";
            this.boundImageDashboardItem1.DataItemRepository.Clear();
            this.boundImageDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0");
            this.boundImageDashboardItem1.DataMember = "Customers";
            this.boundImageDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.boundImageDashboardItem1.Group = this.dashboardItemGroup1;
            this.boundImageDashboardItem1.ImageDimension = dimension2;
            this.boundImageDashboardItem1.Name = "Product Image";
            this.boundImageDashboardItem1.ShowCaption = false;
            this.boundImageDashboardItem1.SizeMode = DevExpress.DashboardCommon.ImageSizeMode.Squeeze;
            this.boundImageDashboardItem1.UriPattern = "CSHTML\\Content\\ProductDetailsImages\\{0}.jpg";
            // 
            // boundImageDashboardItem2
            // 
            this.boundImageDashboardItem2.ComponentName = "secondaryImage";
            this.boundImageDashboardItem2.DataBindingMode = DevExpress.DashboardCommon.ImageDataBindingMode.Uri;
            dimension3.DataMember = "Products_Name";
            dimension3.Name = "Product Name";
            this.boundImageDashboardItem2.DataItemRepository.Clear();
            this.boundImageDashboardItem2.DataItemRepository.Add(dimension3, "DataItem0");
            this.boundImageDashboardItem2.DataMember = "Customers";
            this.boundImageDashboardItem2.DataSource = this.dashboardSqlDataSource1;
            this.boundImageDashboardItem2.Group = this.dashboardItemGroup1;
            this.boundImageDashboardItem2.ImageDimension = dimension3;
            this.boundImageDashboardItem2.Name = "Product Image";
            this.boundImageDashboardItem2.ShowCaption = false;
            this.boundImageDashboardItem2.SizeMode = DevExpress.DashboardCommon.ImageSizeMode.Squeeze;
            this.boundImageDashboardItem2.UriPattern = "CSHTML\\Content\\ProductDetailsImages\\{0} Secondary.jpg";
            // 
            // comboBoxDashboardItem2
            // 
            this.comboBoxDashboardItem2.ComponentName = "comboBoxDashboardItem2";
            dimension4.DataMember = "Name";
            dimension4.Name = "Company Name";
            measure8.Calculation = null;
            measure8.DataMember = "SalesAmount";
            measure8.WindowDefinition = null;
            dimension4.SortByMeasure = measure8;
            dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending;
            this.comboBoxDashboardItem2.DataItemRepository.Clear();
            this.comboBoxDashboardItem2.DataItemRepository.Add(dimension4, "DataItem0");
            this.comboBoxDashboardItem2.DataItemRepository.Add(measure8, "DataItem2");
            this.comboBoxDashboardItem2.DataMember = "Customers";
            this.comboBoxDashboardItem2.DataSource = this.dashboardSqlDataSource1;
            this.comboBoxDashboardItem2.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.comboBoxDashboardItem2.Group = this.dashboardItemGroup2;
            this.comboBoxDashboardItem2.HiddenMeasures.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure8});
            this.comboBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = true;
            this.comboBoxDashboardItem2.Name = "Customer";
            this.comboBoxDashboardItem2.ShowAllValue = false;
            this.comboBoxDashboardItem2.ShowCaption = false;
            // 
            // dashboardItemGroup2
            // 
            this.dashboardItemGroup2.ComponentName = "dashboardItemGroup2";
            this.dashboardItemGroup2.InteractivityOptions.IgnoreMasterFilters = false;
            this.dashboardItemGroup2.Name = "Sales by Company";
            this.dashboardItemGroup2.ShowCaption = false;
            // 
            // chartDashboardItem1
            // 
            dimension5.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue;
            dimension5.DataMember = "OrderDate";
            dimension5.Name = "Order Year";
            dimension6.DataMember = "OrderDate";
            dimension6.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Quarter;
            dimension6.Name = "Order Quarter";
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5,
            dimension6});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.None;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            measure9.Calculation = null;
            measure9.DataMember = "SalesAmount";
            measure9.Name = "Sales Amount";
            measure9.WindowDefinition = null;
            measure10.Calculation = runningTotalCalculation1;
            measure10.DataMember = "SalesAmount";
            measure10.Name = "Running total of Sales Amount";
            chartWindowDefinition1.DefinitionMode = DevExpress.DashboardCommon.ChartWindowDefinitionMode.Arguments;
            measure10.WindowDefinition = chartWindowDefinition1;
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(measure9, "DataItem2");
            this.chartDashboardItem1.DataItemRepository.Add(measure10, "DataItem3");
            this.chartDashboardItem1.DataItemRepository.Add(dimension6, "DataItem5");
            this.chartDashboardItem1.DataMember = "Customers";
            this.chartDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.chartDashboardItem1.Group = this.dashboardItemGroup2;
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Running Total by Year";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.Title = "Sales by Company";
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = false;
            simpleSeries1.AddDataItem("Value", measure9);
            simpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries2.AddDataItem("Value", measure10);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1,
            simpleSeries2});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = false;
            // 
            // ProductDetailsDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Groups.AddRange(new DevExpress.DashboardCommon.DashboardItemGroup[] {
            this.dashboardItemGroup1,
            this.dashboardItemGroup2});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.comboBoxDashboardItem1,
            this.textBoxDashboardItem1,
            this.boundImageDashboardItem1,
            this.chartDashboardItem1,
            this.comboBoxDashboardItem2,
            this.boundImageDashboardItem2});
            dashboardLayoutItem1.DashboardItem = this.comboBoxDashboardItem1;
            dashboardLayoutItem1.Weight = 6.7368421052631575D;
            dashboardLayoutItem2.DashboardItem = this.textBoxDashboardItem1;
            dashboardLayoutItem2.Weight = 66.3157894736842D;
            dashboardLayoutItem3.DashboardItem = this.boundImageDashboardItem1;
            dashboardLayoutItem3.Weight = 65.863453815261039D;
            dashboardLayoutItem4.DashboardItem = this.boundImageDashboardItem2;
            dashboardLayoutItem4.Weight = 34.136546184738954D;
            dashboardLayoutGroup3.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem3,
            dashboardLayoutItem4});
            dashboardLayoutGroup3.DashboardItem = null;
            dashboardLayoutGroup3.Weight = 26.94736842105263D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2,
            dashboardLayoutGroup3});
            dashboardLayoutGroup2.DashboardItem = this.dashboardItemGroup1;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 48.967551622418881D;
            dashboardLayoutItem5.DashboardItem = this.comboBoxDashboardItem2;
            dashboardLayoutItem5.Weight = 6.7368421052631575D;
            dashboardLayoutItem6.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem6.Weight = 93.263157894736835D;
            dashboardLayoutGroup4.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem5,
            dashboardLayoutItem6});
            dashboardLayoutGroup4.DashboardItem = this.dashboardItemGroup2;
            dashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup4.Weight = 51.032448377581119D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutGroup4});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Product Details";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardItemGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundImageDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundImageDashboardItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDashboardItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardItemGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
}
