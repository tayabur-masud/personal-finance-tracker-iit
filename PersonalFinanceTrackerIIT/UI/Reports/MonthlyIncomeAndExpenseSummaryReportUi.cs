using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.UI.Reports;

public partial class MonthlyIncomeAndExpenseSummaryReportUi : Form
{
    private readonly ICategoryService _categoryService;
    private readonly IReportService _reportService;
    private IReadOnlyCollection<CategoryModel> _categories;
    private IReadOnlyCollection<Month> _months;

    public MonthlyIncomeAndExpenseSummaryReportUi(
        ICategoryService categoryService,
        IReportService reportService)
    {
        InitializeComponent();
        _categoryService = categoryService;
        _reportService = reportService;
    }

    private async void MonthlyIncomeAndExpenseSummaryReportUi_Load(object sender, EventArgs e)
    {
        _categories = await _categoryService.GetCategories();
        categoryCheckedListBox.Items.Clear();
        categoryCheckedListBox.DisplayMember = nameof(CategoryModel.Name);
        categoryCheckedListBox.ValueMember = nameof(CategoryModel.Id);
        foreach (var category in _categories)
        {
            categoryCheckedListBox.Items.Add(category, true);
        }

        _months = MonthService.GetMonths();
        monthComboBox.DisplayMember = nameof(Month.Name);
        monthComboBox.ValueMember = nameof(Month.Id);
        monthComboBox.DataSource = _months.ToList();
        monthComboBox.Text = MonthService.GetCurrentMonth().Name;
    }

    private async void showButton_Click(object sender, EventArgs e)
    {
        var selectedCategories = categoryCheckedListBox.CheckedItems.Cast<CategoryModel>().ToList();
        if (selectedCategories.Count == 0)
        {
            MessageBox.Show("Please select at least one category.");
            return;
        }
        if (monthComboBox.SelectedItem == null)
        {
            MessageBox.Show("Please select a month.");
            return;
        }
        var selectedMonth = (Month)monthComboBox.SelectedItem;

        var filterModel = new MonthlyIncomeAndExpenseSummaryFilterModel
        {
            MonthId = selectedMonth.Id,
            Categories = selectedCategories.Select(c => c.Id).ToList(),
        };

        var report = await _reportService.GetMonthlyIncomeAndExpenseSummaryReport(filterModel);
    }
}
