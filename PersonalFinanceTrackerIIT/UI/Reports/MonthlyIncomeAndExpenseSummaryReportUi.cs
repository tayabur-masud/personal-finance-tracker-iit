using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.UI.Reports;

public partial class MonthlyIncomeAndExpenseSummaryReportUi : Form
{
    private readonly ICategoryService _categoryService;
    private IReadOnlyCollection<CategoryModel> _categories;
    private IReadOnlyCollection<Month> _months;

    public MonthlyIncomeAndExpenseSummaryReportUi(ICategoryService categoryService)
    {
        InitializeComponent();
        _categoryService = categoryService;
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
}
