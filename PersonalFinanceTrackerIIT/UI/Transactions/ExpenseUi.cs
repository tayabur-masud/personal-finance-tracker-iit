using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;

namespace PersonalFinanceTrackerIIT.UI.Transactions;

public partial class ExpenseUi : Form
{
    private readonly ICategoryService _categoryService;
    private readonly ITransactionService _transactionService;

    public ExpenseUi(
        ICategoryService categoryService, 
        ITransactionService transactionService)
    {
        InitializeComponent();
        _categoryService = categoryService;
        _transactionService = transactionService;
    }

    private async void ExpenseUi_Load(object sender, EventArgs e)
    {
        var categories = await _categoryService.GetCategoriesByType(CategoryType.Expense);
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
