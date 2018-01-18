using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lsz.MES.Data
{
    public class MESClientViewModel
    {
        const string MyWorldGroup = "生产与操作";
        const string OperationsGroup = "查询与检验";

        public MESModuleDescription[] Modules=new MESModuleDescription[] {
               new MESModuleDescription("计划任务", "DashboardView", MyWorldGroup),
               new  MESModuleDescription("生产作业", "TaskCollectionView", MyWorldGroup),
               new  MESModuleDescription("人员信息", "EmployeeCollectionView", MyWorldGroup),
               new  MESModuleDescription("产品数据", "ProductCollectionView", OperationsGroup),
               new  MESModuleDescription("质量检验", "CustomerCollectionView", OperationsGroup),
               new  MESModuleDescription("设备点检", "OrderCollectionView", OperationsGroup),
               new  MESModuleDescription("异常申报", "QuoteCollectionView", OperationsGroup)
        };

        public MESClientViewModel()
        {
            Modules = new MESModuleDescription[] {
                new MESModuleDescription("计划任务", "DashboardView", MyWorldGroup),
                new MESModuleDescription("生产作业", "TaskCollectionView", MyWorldGroup),
                new MESModuleDescription("人员信息", "EmployeeCollectionView", MyWorldGroup),
                new MESModuleDescription("产品数据", "ProductCollectionView", OperationsGroup),
                new MESModuleDescription("质量检验", "CustomerCollectionView", OperationsGroup),
                new MESModuleDescription("设备点检", "OrderCollectionView", OperationsGroup),
                new MESModuleDescription("异常申报", "QuoteCollectionView", OperationsGroup)
            };
            foreach (var module in Modules)
            {
                MESModuleDescription moduleRef = module;
                //module.FilterTreeViewModel.NavigateAction = (() => {
                //    Show(moduleRef);
                //});
            }
            //return modules;
        }

        private void Show(MESModuleDescription moduleRef)
        {
            throw new NotImplementedException();
        }
    }


    public class MESModuleDescription
    {
        public MESModuleDescription(string title, string documentType, string group)
            
        {
            ImageSource = new Uri(string.Format(@"pack://application:,,,/DevExpress.HybridApp.Wpf;component/Resources/Menu/{0}.png", title));
            //FilterTreeViewModel = filterTreeViewModel;
            ModuleGroup = group;
            ModuleTitle = title;
        }
        public Uri ImageSource { get; private set; }

        //public IFilterTreeViewModel FilterTreeViewModel { get; private set; }

        public string ModuleGroup { get; }

        public string ModuleTitle { get; }



    }


    public interface IFilterTreeViewModel
    {
        void SetViewModel(object content);
        Action NavigateAction { get; set; }
    }
}
