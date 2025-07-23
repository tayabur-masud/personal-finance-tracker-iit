using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;

namespace PersonalFinanceTrackerIIT.UI.Transactions;

public partial class ExpenseUi : Form
{
    private readonly ICategoryService _categoryService;
    private IReadOnlyCollection<CategoryModel> _categories;

    public ExpenseUi(ICategoryService categoryService)
    {
        InitializeComponent();
        _categoryService = categoryService;
    }

    private async void ExpenseUi_Load(object sender, EventArgs e)
    {
        _categories = await _categoryService.GetCategoriesByType(CategoryType.Expense);
        categoryComboBox.DisplayMember = nameof(CategoryModel.Name);
        categoryComboBox.ValueMember = nameof(CategoryModel.Id);
        categoryComboBox.DataSource = _categories.ToList();
    }
}
