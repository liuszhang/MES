using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.DashboardCommon;
using DashboardMainDemo;

public class EUTradeOverviewDashboard : Dashboard {
    private TreemapDashboardItem treeMapTradeOverviewDetails;
    private DashboardExtractDataSource dashboardExtractDataSource1;
    private ListBoxDashboardItem listBoxFilterPartner;
    private ListBoxDashboardItem listBoxFilterProductGroup;
    private PieDashboardItem pieImportVsExport;

    public EUTradeOverviewDashboard() {
        InitializeComponent();
    }
    private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Measure measure4 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem4 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.listBoxFilterPartner = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.dashboardExtractDataSource1 = new DevExpress.DashboardCommon.DashboardExtractDataSource();
            this.listBoxFilterProductGroup = new DevExpress.DashboardCommon.ListBoxDashboardItem();
            this.pieImportVsExport = new DevExpress.DashboardCommon.PieDashboardItem();
            this.treeMapTradeOverviewDetails = new DevExpress.DashboardCommon.TreemapDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterProductGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieImportVsExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapTradeOverviewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // listBoxFilterPartner
            // 
            this.listBoxFilterPartner.ComponentName = "listBoxFilterPartner";
            dimension1.DataMember = "Partner";
            this.listBoxFilterPartner.DataItemRepository.Clear();
            this.listBoxFilterPartner.DataItemRepository.Add(dimension1, "DataItem0");
            this.listBoxFilterPartner.DataSource = this.dashboardExtractDataSource1;
            this.listBoxFilterPartner.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.listBoxFilterPartner.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxFilterPartner.ListBoxType = DevExpress.DashboardCommon.ListBoxDashboardItemType.Radio;
            this.listBoxFilterPartner.Name = "Partner";
            this.listBoxFilterPartner.ShowCaption = true;
            // 
            // dashboardExtractDataSource1
            // 
            calculatedField1.Expression = "Iif([FLOW] = \'EXPORT\', [VALUE], 0)";
            calculatedField1.Name = "Export_Value";
            calculatedField2.Expression = "Iif([FLOW] = \'IMPORT\', [VALUE], 0)";
            calculatedField2.Name = "Import_Value";
            this.dashboardExtractDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2});
            this.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1";
            this.dashboardExtractDataSource1.FileName = "|DataDirectory|\\EUTradeOverview.dat";
            this.dashboardExtractDataSource1.Name = "Extract Data Source 1";
            // 
            // listBoxFilterProductGroup
            // 
            this.listBoxFilterProductGroup.ComponentName = "listBoxFilterProductGroup";
            dimension2.DataMember = "Product_Group";
            dimension2.Name = "Product Group";
            this.listBoxFilterProductGroup.DataItemRepository.Clear();
            this.listBoxFilterProductGroup.DataItemRepository.Add(dimension2, "DataItem0");
            this.listBoxFilterProductGroup.DataSource = this.dashboardExtractDataSource1;
            this.listBoxFilterProductGroup.FilterDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.listBoxFilterProductGroup.InteractivityOptions.IgnoreMasterFilters = true;
            this.listBoxFilterProductGroup.Name = "Product Group";
            this.listBoxFilterProductGroup.ShowCaption = true;
            // 
            // pieImportVsExport
            // 
            this.pieImportVsExport.ComponentName = "pieImportVsExport";
            measure1.DataMember = "Import_Value";
            measure1.Name = "Import";
            measure1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            measure2.DataMember = "Export_Value";
            measure2.Name = "Export";
            measure2.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            this.pieImportVsExport.DataItemRepository.Clear();
            this.pieImportVsExport.DataItemRepository.Add(measure1, "DataItem0");
            this.pieImportVsExport.DataItemRepository.Add(measure2, "DataItem1");
            this.pieImportVsExport.DataSource = this.dashboardExtractDataSource1;
            this.pieImportVsExport.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieImportVsExport.LabelContentType = DevExpress.DashboardCommon.PieValueType.Argument;
            this.pieImportVsExport.Name = "Import vs Export";
            this.pieImportVsExport.ShowCaption = true;
            this.pieImportVsExport.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1,
            measure2});
            // 
            // treeMapTradeOverviewDetails
            // 
            dimension3.DataMember = "Product_Group";
            dimension3.GroupChildValues = true;
            dimension3.Name = "Product Group";
            dimension4.DataMember = "Product";
            this.treeMapTradeOverviewDetails.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.treeMapTradeOverviewDetails.ColoringOptions.MeasuresColoringMode = DevExpress.DashboardCommon.ColoringMode.None;
            this.treeMapTradeOverviewDetails.ComponentName = "treeMapTradeOverviewDetails";
            measure3.DataMember = "Export_Value";
            measure3.Name = "Export";
            measure3.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            measure4.DataMember = "Import_Value";
            measure4.Name = "Import";
            measure4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.Currency;
            this.treeMapTradeOverviewDetails.DataItemRepository.Clear();
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(measure3, "DataItem3");
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(measure4, "DataItem0");
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(dimension3, "DataItem1");
            this.treeMapTradeOverviewDetails.DataItemRepository.Add(dimension4, "DataItem2");
            this.treeMapTradeOverviewDetails.DataSource = this.dashboardExtractDataSource1;
            this.treeMapTradeOverviewDetails.InteractivityOptions.IgnoreMasterFilters = false;
            this.treeMapTradeOverviewDetails.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            this.treeMapTradeOverviewDetails.Name = "Product";
            this.treeMapTradeOverviewDetails.ShowCaption = true;
            this.treeMapTradeOverviewDetails.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure3,
            measure4});
            // 
            // EUTradeOverviewDashboard
            // 
            this.CurrencyCultureName = "gsw-FR";
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExtractDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.treeMapTradeOverviewDetails,
            this.listBoxFilterPartner,
            this.listBoxFilterProductGroup,
            this.pieImportVsExport});
            dashboardLayoutItem1.DashboardItem = this.listBoxFilterPartner;
            dashboardLayoutItem1.Weight = 44.062947067238916D;
            dashboardLayoutItem2.DashboardItem = this.listBoxFilterProductGroup;
            dashboardLayoutItem2.Weight = 28.755364806866954D;
            dashboardLayoutItem3.DashboardItem = this.pieImportVsExport;
            dashboardLayoutItem3.Weight = 27.181688125894134D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2,
            dashboardLayoutItem3});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 22.329162656400385D;
            dashboardLayoutItem4.DashboardItem = this.treeMapTradeOverviewDetails;
            dashboardLayoutItem4.Weight = 77.670837343599615D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem4});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "EU Trade Overview 2015";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExtractDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxFilterProductGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieImportVsExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapTradeOverviewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }
}
