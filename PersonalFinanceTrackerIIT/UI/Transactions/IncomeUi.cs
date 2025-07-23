using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;

namespace PersonalFinanceTrackerIIT.UI.Transactions
{
    public partial class IncomeUi : Form
    {
        private readonly ICategoryService _categoryService;
        private IReadOnlyCollection<CategoryModel> _categories;

        public IncomeUi(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }

        private async void IncomeUi_Load(object sender, EventArgs e)
        {
            _categories = await _categoryService.GetCategoriesByType(CategoryType.Income);
            categoryComboBox.DisplayMember = nameof(CategoryModel.Name);
            categoryComboBox.ValueMember = nameof(CategoryModel.Id);
            categoryComboBox.DataSource = _categories.ToList();
        }
    }
}
