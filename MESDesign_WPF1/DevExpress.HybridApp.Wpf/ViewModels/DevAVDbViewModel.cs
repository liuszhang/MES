using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.DevAVDbDataModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;

namespace DevExpress.DevAV.ViewModels {
    public partial class DevAVDbViewModel : DocumentsViewModel<DevAVDbModuleDescription, IDevAVDbUnitOfWork> {
        const string MyWorldGroup = "生产与操作";
        const string OperationsGroup = "查询与检验";
        public new DevAVDbModuleDescription[] Modules { get; }



        public DevAVDbViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
            IsTablet = true;
        }

        protected override DevAVDbModuleDescription[] CreateModules() {
            var modules = new DevAVDbModuleDescription[] {
                new DevAVDbModuleDescription("计划任务", "DashboardView", MyWorldGroup, FiltersSettings.GetDashboardFilterTree(this)),
                new DevAVDbModuleDescription("生产作业", "TaskCollectionView", MyWorldGroup, FiltersSettings.GetTasksFilterTree(this)),
                new DevAVDbModuleDescription("人员信息", "EmployeeCollectionView", MyWorldGroup, FiltersSettings.GetEmployeesFilterTree(this)),
                new DevAVDbModuleDescription("产品数据", "ProductCollectionView", OperationsGroup, FiltersSettings.GetProductsFilterTree(this)),
                new DevAVDbModuleDescription("质量检验", "CustomerCollectionView", OperationsGroup, FiltersSettings.GetCustomersFilterTree(this)),
                new DevAVDbModuleDescription("设备点检", "OrderCollectionView", OperationsGroup, FiltersSettings.GetSalesFilterTree(this)),
                new DevAVDbModuleDescription("异常申报", "QuoteCollectionView", OperationsGroup, FiltersSettings.GetOpportunitiesFilterTree(this))
            };
            foreach(var module in modules) {
                DevAVDbModuleDescription moduleRef = module;
                module.FilterTreeViewModel.NavigateAction = (() => {
                    Show(moduleRef);
                });
            }
            return modules;
        }

        protected override void OnActiveModuleChanged(DevAVDbModuleDescription oldModule) {
            base.OnActiveModuleChanged(oldModule);
            if(ActiveModule != null && ActiveModule.FilterTreeViewModel != null)
                ActiveModule.FilterTreeViewModel.SetViewModel(DocumentManagerService.ActiveDocument.Content);
        }

        protected override string GetModuleTitle(DevAVDbModuleDescription module) {
            return base.GetModuleTitle(module) + " - DevAV";
        }

        public override void OnLoaded(DevAVDbModuleDescription module) {
            base.OnLoaded(module);
            IsTablet = DeviceDetector.IsTablet;
            RegisterJumpList();
        }

        public override void SaveLogicalLayout() { }
        public override bool RestoreLogicalLayout() {
            return false;
        }

        LinksViewModel linksViewModel;
        public LinksViewModel LinksViewModel {
            get {
                if(linksViewModel == null)
                    linksViewModel = LinksViewModel.Create();
                return linksViewModel;
            }
        }
        public override DevAVDbModuleDescription DefaultModule {
            get {
                return Modules[2];
            }
        }
        public virtual bool IsTablet { get; set; }

        void RegisterJumpList() {
#if !CLICKONCE
            IApplicationJumpListService jumpListService = this.GetService<IApplicationJumpListService>();
            jumpListService.Items.AddOrReplace("Become a UI Superhero", "Explore DevExpress Universal", UniversalIcon, () => { LinksViewModel.UniversalSubscription(); });
            jumpListService.Items.AddOrReplace("Online Tutorials", "Explore DevExpress Universal", TutorialsIcon, () => { LinksViewModel.GettingStarted(); });
            jumpListService.Items.AddOrReplace("Buy Now", "Explore DevExpress Universal", BuyIcon, () => { LinksViewModel.BuyNow(); });
            jumpListService.Apply();
#endif
        }
        ImageSource UniversalIcon { get { return new BitmapImage(new Uri("pack://application:,,,/DevExpress.HybridApp.Wpf;component/Resources/Universal.ico")); } }
        ImageSource TutorialsIcon { get { return new BitmapImage(new Uri("pack://application:,,,/DevExpress.HybridApp.Wpf;component/Resources/WPF.ico")); } }
        ImageSource BuyIcon { get { return new BitmapImage(new Uri("pack://application:,,,/DevExpress.HybridApp.Wpf;component/Resources/DevExpress.ico")); } }
    }

    public partial class DevAVDbModuleDescription : ModuleDescription<DevAVDbModuleDescription> {
        public DevAVDbModuleDescription(string title, string documentType, string group, IFilterTreeViewModel filterTreeViewModel)
            : base(title, documentType, group, null)
        {
            ImageSource = new Uri(string.Format(@"pack://application:,,,/DevExpress.HybridApp.Wpf;component/Resources/Menu/{0}.png", title));
            FilterTreeViewModel = filterTreeViewModel;
            ModuleGroup = group;
            ModuleTitle = title;
        }
        public Uri ImageSource { get; private set; }

        public IFilterTreeViewModel FilterTreeViewModel { get; private set; }

        public new string ModuleGroup { get; }

        public new string ModuleTitle { get; }

    }

}
