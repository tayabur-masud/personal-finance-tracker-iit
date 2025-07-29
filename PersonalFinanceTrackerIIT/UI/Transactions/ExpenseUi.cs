using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;

namespace PersonalFinanceTrackerIIT.UI.Transactions;

public partial class ExpenseUi : Form
{
    private readonly ICategoryService _categoryService;
    private readonly ITransactionService _transactionService;
    private int selectedTransactionId = 0;

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
        try
        {
            categoryComboBox.DataSource = null;
            categoryComboBox.Items.Clear();
            var categories = await _categoryService.GetCategoriesByType(CategoryType.Expense);
            categoryComboBox.DisplayMember = nameof(CategoryModel.Name);
            categoryComboBox.ValueMember = nameof(CategoryModel.Id);
            categoryComboBox.DataSource = categories.ToList();

            await LoadExpenseHistory();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(amountTextBox.Text) ||
                !decimal.TryParse(amountTextBox.Text, out decimal amount) ||
                amount <= 0)
            {
                throw new ArgumentException("Please enter a valid amount.");
            }
            if (categoryComboBox.SelectedValue == null)
            {
                throw new ArgumentException("Please select a category.");
            }

            TransactionModel transaction = new TransactionModel();
            transaction.Date = dateTimePicker.Value.Date;
            transaction.Amount = Convert.ToDecimal(amountTextBox.Text);
            transaction.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            transaction.Description = descriptionRichTextBox.Text.Trim();

            transaction.Id = selectedTransactionId;

            await _transactionService.AddOrUpdateTransaction(transaction);

            MessageBox.Show("Expense saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadExpenseHistory();

            ResetInput();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while saving the transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        try
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while processing the key press: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        try
        {
            ResetInput();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while resetting the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void ExpenseUi_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            ResetForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (expenseListView.SelectedItems.Count > 0)
            {
                var selectedItem = expenseListView.SelectedItems[0];
                var transaction = (TransactionModel)selectedItem.Tag;

                selectedTransactionId = transaction.Id;
                dateTimePicker.Value = transaction.Date;
                amountTextBox.Text = transaction.Amount.ToString();
                categoryComboBox.SelectedValue = transaction.CategoryId;
                descriptionRichTextBox.Text = transaction.Description;
            }
            else
            {
                MessageBox.Show("Please select a transaction to edit.", "No Transaction Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while editing the transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (expenseListView.SelectedItems.Count > 0)
            {
                var selectedItem = expenseListView.SelectedItems[0];
                var transaction = (TransactionModel)selectedItem.Tag;

                var confirmResult = MessageBox.Show($"Are you sure you want to delete the transaction?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    await _transactionService.DeleteTransaction(transaction.Id);

                    await LoadExpenseHistory();
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.", "No Transaction Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while deleting the transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ResetInput();
            return;
        }
    }

    private async Task LoadExpenseHistory()
    {
        var transactions = await _transactionService.GetExpenseTransactions();

        expenseListView.Items.Clear();

        foreach (var transaction in transactions)
        {
            var item = new ListViewItem(transaction.DateString);
            item.SubItems.Add(transaction.Amount.ToString("#,#"));
            item.SubItems.Add(transaction.CategoryName);
            item.SubItems.Add(transaction.Description);
            item.Tag = transaction;
            expenseListView.Items.Add(item);
        }
    }

    private void ResetInput()
    {
        selectedTransactionId = 0;
        amountTextBox.Clear();
        descriptionRichTextBox.Clear();
        dateTimePicker.Value = DateTime.Now;
    }

    private void ResetForm()
    {
        ResetInput();
        expenseListView.Items.Clear();
    }
}
