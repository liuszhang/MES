using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Lsz.MES.Data.Filters
{
    public class FilterTreeViewModel
    {
        //static FilterTreeViewModel()
        //{
        //    //var enums = typeof(MESProductCategory).Assembly.GetTypes().Where(t => t.IsEnum);
        //    //foreach (Type e in enums)
        //    //    EnumProcessingHelper.RegisterEnum(e);
        //    StaticFilters.Add(new FilterItem() { Name = "1", EntitiesCount = 3, DisplayText = "新能源大客", ImageUri = "" });
        //    StaticFilters.Add(new FilterItem() { Name = "2", EntitiesCount = 3, DisplayText = "电机控制器", ImageUri = "" });
        //    StaticFilters.Add(new FilterItem() { Name = "3", EntitiesCount = 3, DisplayText = "汽车零配件", ImageUri = "" });
        //    StaticFilters.Add(new FilterItem() { Name = "4", EntitiesCount = 3, DisplayText = "减速箱", ImageUri = "" });
        //    StaticFilters.Add(new FilterItem() { Name = "5", EntitiesCount = 3, DisplayText = "LED显示屏", ImageUri = "" });
        //    StaticFilters.Add(new FilterItem() { Name = "6", EntitiesCount = 3, DisplayText = "其他", ImageUri = "" });
            
        //}

        //public static FilterTreeViewModel<TEntity, TPrimaryKey> Create(IFilterTreeModelPageSpecificSettings settings, IQueryable<TEntity> entities, Action<object, Action> registerEntityChangedMessageHandler)
        //{
        //    return ViewModelSource.Create(() => new FilterTreeViewModel<TEntity, TPrimaryKey>(settings, entities, registerEntityChangedMessageHandler));
        //}

        //readonly IQueryable<TEntity> entities;
        //readonly IFilterTreeModelPageSpecificSettings settings;
        //object viewModel;

        //protected FilterTreeViewModel(IFilterTreeModelPageSpecificSettings settings, IQueryable<TEntity> entities, Action<object, Action> registerEntityChangedMessageHandler)
        //{
        //    this.settings = settings;
        //    this.entities = entities;
        //    StaticFilters = CreateFilterItems(settings.StaticFilters);
        //    CustomFilters = CreateFilterItems(settings.CustomFilters);
        //    SelectedItem = StaticFilters.FirstOrDefault();
        //    AllowFiltersContextMenu = true;

        //    Messenger.Default.Register<EntityMessage<TEntity, TPrimaryKey>>(this, message => UpdateFilters());
        //    Messenger.Default.Register<CreateCustomFilterMessage<TEntity>>(this, message => CreateCustomFilter());
        //    UpdateFilters();
        //    StaticCategoryName = settings.StaticFiltersTitle;
        //    CustomCategoryName = settings.CustomFiltersTitle;
        //}

        public static List<FilterItem> StaticFilters =new List<FilterItem>()
        {

            new FilterItem() { Name = "1", EntitiesCount = 3, DisplayText = "新能源大客", ImageUri = "" },
            new FilterItem() { Name = "2", EntitiesCount = 3, DisplayText = "电机控制器", ImageUri = "" },
            new FilterItem() { Name = "3", EntitiesCount = 3, DisplayText = "汽车零配件", ImageUri = "" },
            new FilterItem() { Name = "4", EntitiesCount = 3, DisplayText = "减速箱", ImageUri = "" },
            new FilterItem() { Name = "5", EntitiesCount = 3, DisplayText = "LED显示屏", ImageUri = "" },
            new FilterItem() { Name = "6", EntitiesCount = 3, DisplayText = "其他", ImageUri = "" }
        };
        public static ObservableCollection<FilterItem> CustomFilters { get; set; }
        public static FilterItem SelectedItem { get; set; }
        public static FilterItem ActiveFilterItem { get; set; }
        public static Action NavigateAction { get; set; }
        public static string StaticCategoryName { get; private set; }
        public static string CustomCategoryName { get; private set; }
        //public bool AllowCustomFilters { get { return settings.CustomFilters != null; } }

        public static bool AllowCustomFilters { get; }
        //public bool AllowFiltersContextMenu
        //{
        //    get
        //    {
        //        return AllowCustomFilters && allowFiltersContextMenu;
        //    }
        //    set
        //    {
        //        allowFiltersContextMenu = value;
        //    }
        //}
        //bool allowFiltersContextMenu;

        //public void DeleteCustomFilter(FilterItem filterItem)
        //{
        //    CustomFilters.Remove(filterItem);
        //    SaveCustomFilters();
        //}

        //public void DuplicateFilter(FilterItem filterItem)
        //{
        //    var newItem = filterItem.Clone("Copy of " + filterItem.Name, null);
        //    CustomFilters.Add(newItem);
        //    SaveCustomFilters();
        //}

        //public void ResetCustomFilters()
        //{
        //    if (CustomFilters.Contains(SelectedItem))
        //        SelectedItem = null;
        //    settings.CustomFilters = new FilterInfoList();
        //    CustomFilters.Clear();
        //    settings.SaveSettings();
        //}

        //public void ModifyCustomFilter(FilterItem existing)
        //{
        //    FilterItem clone = existing.Clone();
        //    var filterViewModel = CreateCustomFilterViewModel(clone, true);
        //    ShowFilter(clone, filterViewModel, () =>
        //    {
        //        existing.FilterCriteria = clone.FilterCriteria;
        //        existing.Name = clone.Name;
        //        SaveCustomFilters();
        //        if (existing == SelectedItem)
        //            OnSelectedItemChanged();
        //    });
        //}
        //public void ModifyCustomFilterCriteria(FilterItem existing, CriteriaOperator criteria)
        //{
        //    if (!ReferenceEquals(existing.FilterCriteria, null) && !ReferenceEquals(criteria, null) && existing.FilterCriteria.ToString() == criteria.ToString())
        //        return;
        //    existing.FilterCriteria = criteria;
        //    SaveCustomFilters();
        //    if (existing == SelectedItem)
        //        OnSelectedItemChanged();
        //    UpdateFilters();
        //}
        //public void ResetToAll()
        //{
        //    SelectedItem = StaticFilters[0];
        //}

        //public void CreateCustomFilter()
        //{
        //    FilterItem filterItem = CreateFilterItem(string.Empty, null, null);
        //    var filterViewModel = CreateCustomFilterViewModel(filterItem, true);
        //    ShowFilter(filterItem, filterViewModel, () => AddNewCustomFilter(filterItem));
        //}
        //public void AddCustomFilter(string name, CriteriaOperator filterCriteria, string imageUri = null)
        //{
        //    AddNewCustomFilter(CreateFilterItem(name, filterCriteria, imageUri));
        //}
        //protected virtual void OnSelectedItemChanged()
        //{
        //    ActiveFilterItem = SelectedItem.Clone();
        //    UpdateFilterExpression();
        //}
        //public virtual void Navigate()
        //{
        //    NavigateCore();
        //}
        //void NavigateCore()
        //{
        //    if (NavigateAction != null)
        //        NavigateAction();
        //}
        //    void IFilterTreeViewModel.SetViewModel(object viewModel)
        //    {
        //        this.viewModel = viewModel;
        //        var viewModelContainer = viewModel as IFilterTreeViewModelContainer<TEntity, TPrimaryKey>;
        //        if (viewModelContainer != null)
        //            viewModelContainer.FilterTreeViewModel = this;
        //        UpdateFilterExpression();
        //    }

        //    void UpdateFilterExpression()
        //    {
        //        ISupportFiltering<TEntity> viewModel = this.viewModel as ISupportFiltering<TEntity>;
        //        if (viewModel != null)
        //            viewModel.FilterExpression = ActiveFilterItem == null ? null : GetWhereExpression(ActiveFilterItem.FilterCriteria);
        //    }

        //    ObservableCollection<FilterItem> CreateFilterItems(IEnumerable<FilterInfo> filters)
        //    {

        //        if (filters == null)
        //            return new ObservableCollection<FilterItem>();
        //        return new ObservableCollection<FilterItem>(filters.Select(x => CreateFilterItem(x.Name, CriteriaOperator.Parse(x.FilterCriteria), x.ImageUri)));
        //    }

        //    const string NewFilterName = @"New Filter";

        //    void AddNewCustomFilter(FilterItem filterItem)
        //    {
        //        if (string.IsNullOrEmpty(filterItem.Name))
        //        {
        //            int prevIndex = CustomFilters.Select(fi => Regex.Match(fi.Name, NewFilterName + @" (?<index>\d+)")).Where(m => m.Success).Select(m => int.Parse(m.Groups["index"].Value)).DefaultIfEmpty(0).Max();
        //            filterItem.Name = NewFilterName + " " + (prevIndex + 1);
        //        }
        //        else
        //        {
        //            var existing = CustomFilters.FirstOrDefault(fi => fi.Name == filterItem.Name);
        //            if (existing != null)
        //                CustomFilters.Remove(existing);
        //        }
        //        CustomFilters.Add(filterItem);
        //        SaveCustomFilters();
        //    }

        //    void SaveCustomFilters()
        //    {
        //        settings.CustomFilters = SaveToSettings(CustomFilters);
        //        settings.SaveSettings();
        //    }

        //    FilterInfoList SaveToSettings(ObservableCollection<FilterItem> filters)
        //    {
        //        return new FilterInfoList(filters.Select(fi => new FilterInfo { Name = fi.Name, FilterCriteria = CriteriaOperator.ToString(fi.FilterCriteria) }));
        //    }

        //    void UpdateFilters()
        //    {
        //        foreach (var item in StaticFilters.Concat(CustomFilters))
        //        {
        //            item.Update(GetEntityCount(item.FilterCriteria));
        //        }
        //    }

        //    void ShowFilter(FilterItem filterItem, CustomFilterViewModel filterViewModel, Action onSave)
        //    {
        //        if (FilterDialogService.ShowDialog(MessageButton.OKCancel, "Create Custom Filter", "CustomFilterView", filterViewModel) != MessageResult.OK)
        //            return;
        //        filterItem.FilterCriteria = filterViewModel.FilterCriteria;
        //        filterItem.Name = filterViewModel.FilterName;
        //        ActiveFilterItem = filterItem;
        //        if (filterViewModel.Save)
        //        {
        //            onSave();
        //            UpdateFilters();
        //        }
        //    }

        //    CustomFilterViewModel CreateCustomFilterViewModel(FilterItem existing, bool save)
        //    {
        //        var viewModel = CustomFilterViewModel.Create(typeof(TEntity), settings.HiddenFilterProperties, settings.AdditionalFilterProperties);
        //        viewModel.FilterCriteria = existing.FilterCriteria;
        //        viewModel.FilterName = existing.Name;
        //        viewModel.Save = save;
        //        viewModel.SetParentViewModel(this);
        //        return viewModel;
        //    }

        //    FilterItem CreateFilterItem(string name, CriteriaOperator filterCriteria, string imageUri)
        //    {
        //        return FilterItem.Create(GetEntityCount(filterCriteria), name, filterCriteria, imageUri);
        //    }

        //    int GetEntityCount(CriteriaOperator criteria)
        //    {
        //        //return 5;
        //        return entities.Where(GetWhereExpression(criteria)).Count();
        //    }

        //    Expression<Func<TEntity, bool>> GetWhereExpression(CriteriaOperator criteria)
        //    {
        //        return this.IsInDesignMode()
        //            ? CriteriaOperatorToExpressionConverter.GetLinqToObjectsWhere<TEntity>(criteria)
        //            : CriteriaOperatorToExpressionConverter.GetGenericWhere<TEntity>(criteria);

        //        //return CriteriaOperatorToExpressionConverter.GetLinqToObjectsWhere<TEntity>(criteria);


        //        //return CriteriaOperatorToExpressionConverter.GetGenericWhere<TEntity>(criteria);
        //    }

        //    IDialogService FilterDialogService { get { return this.GetRequiredService<IDialogService>("FilterDialogService"); } }
        //}

        //public interface IFilterTreeViewModelContainer<TEntity, TPrimaryKey> where TEntity : class
        //{
        //    FilterTreeViewModel<TEntity, TPrimaryKey> FilterTreeViewModel { get; set; }
        //}

        public class CreateCustomFilterMessage<TEntity> where TEntity : class
        {
        }

        public interface IFilterTreeViewModel
        {
            void SetViewModel(object content);
            Action NavigateAction { get; set; }
        }

    }
}


