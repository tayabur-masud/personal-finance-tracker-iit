using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;

namespace PersonalFinanceTrackerIIT.UI.Transactions
{
    public partial class IncomeUi : Form
    {
        private readonly ICategoryService _categoryService;
        private readonly ITransactionService _transactionService;

        public IncomeUi(
            ICategoryService categoryService, 
            ITransactionService transactionService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _transactionService = transactionService;
        }

        private async void IncomeUi_Load(object sender, EventArgs e)
        {
            var categories = await _categoryService.GetCategoriesByType(CategoryType.Income);
            categoryComboBox.DisplayMember = nameof(CategoryModel.Name);
            categoryComboBox.ValueMember = nameof(CategoryModel.Id);
            categoryComboBox.DataSource = categories.ToList();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            TransactionModel transaction = new TransactionModel();
            transaction.Date = dateTimePicker.Value.Date;
            transaction.Amount = Convert.ToDecimal(amountTextBox.Text);
            transaction.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            transaction.Description = descriptionRichTextBox.Text.Trim();

            await _transactionService.AddTransaction(transaction);
        }
    }
}
