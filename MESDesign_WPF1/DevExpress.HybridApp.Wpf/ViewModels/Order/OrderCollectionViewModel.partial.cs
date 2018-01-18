using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Editors;
using Lsz.MES.Data.Models;

namespace DevExpress.DevAV.ViewModels {
    partial class OrderCollectionViewModel {
        const int NumberOfAverageOrders = 8;
        public List<Order> AverageOrders { get; set; }
        public virtual List<SalesInfo> Sales { get; set; }
        public virtual SalesInfo SelectedSale { get; set; }

        public MachInfo MachWorkInfo { get; set; }

        public List<ToggleSwitchEdit> IsNGOrOK { get; set; }

        public void ShowPrintPreview() {
            var link = this.GetRequiredService<DevExpress.DevAV.Common.View.IPrintableControlPreviewService>().GetLink();
            this.GetRequiredService<IDocumentManagerService>().CreateDocument("PrintableControlPrintPreview", PrintableControlPreviewViewModel.Create(link), null, this).Show();
        }

        protected override void OnInitializeInRuntime() {
            base.OnInitializeInRuntime();
            var unitOfWork = UnitOfWorkFactory.CreateUnitOfWork();
            //Sales = QueriesHelper.GetSales(unitOfWork.OrderItems);
            //SelectedSale = Sales[0];
            AverageOrders = new List<Order>()
            {
                new Order(){ InvoiceNumber="10010",CustomerId=1,OrderTerms="检查外壳是否光洁",PONumber="结果型"},
                new Order(){ InvoiceNumber="10020",CustomerId=2,OrderTerms="检查外壳是否光洁",PONumber="结果型"},
                new Order(){ InvoiceNumber="10030",CustomerId=3,OrderTerms="检查外壳是否光洁",PONumber="结果型"},
                new Order(){ InvoiceNumber="10040",CustomerId=4,OrderTerms="检查外壳是否光洁",PONumber="结果型"},
                new Order(){ InvoiceNumber="10050",CustomerId=5,OrderTerms="检查外壳是否光洁",PONumber="结果型"},
                new Order(){ InvoiceNumber="10060",CustomerId=6,OrderTerms="检查外壳是否光洁",PONumber="结果型"},
                new Order(){ InvoiceNumber="10070",CustomerId=7,OrderTerms="检查外壳是否光洁",PONumber="结果型"},
                new Order(){ InvoiceNumber="10080",CustomerId=8,OrderTerms="检查外壳是否光洁",PONumber="结果型"}
            };
            IsNGOrOK = new List<ToggleSwitchEdit>()
            {
                new ToggleSwitchEdit(){IsChecked=true},
                new ToggleSwitchEdit(){IsChecked=false},
                new ToggleSwitchEdit(){IsChecked=false},
                new ToggleSwitchEdit(){IsChecked=false},
                new ToggleSwitchEdit(){IsChecked=false},
                new ToggleSwitchEdit(){IsChecked=false},
                new ToggleSwitchEdit(){IsChecked=false},
                new ToggleSwitchEdit(){IsChecked=false}
            };
            
            //AverageOrders = QueriesHelper.GetAverageOrders(unitOfWork.Orders.ActualOrders(), NumberOfAverageOrders);
            MachWorkInfo = new MachInfo();

            MachWorkInfo.MachWorkTimeInfo = new List<MachWorkTime>()
            {
new MachWorkTime() { Name = "开机时间", Value = 100 },
new MachWorkTime() { Name = "工作时间", Value = 80 },
new MachWorkTime() { Name = "计划停机时间", Value = 15 },
new MachWorkTime() { Name = "异常时间", Value = 5 }
            };
        }
        protected override void OnEntitiesAssigned(Func<Order> getSelectedEntityCallback) {
            base.OnEntitiesAssigned(getSelectedEntityCallback);
            if(SelectedEntity == null)
                SelectedEntity = Entities.FirstOrDefault();
        }
    }
}
