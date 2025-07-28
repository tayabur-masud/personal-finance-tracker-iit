using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.UI.Budgets;
public partial class BudgetUi : Form
{
    private readonly IBudgetService _budgetService;
    private readonly ICategoryService _categoryService;
    private int selectedBudgetId = 0;

    public BudgetUi(
        IBudgetService budgetService,
        ICategoryService categoryService)
    {
        InitializeComponent();
        _budgetService = budgetService;
        _categoryService = categoryService;
    }

    private async void BudgetUi_Load(object sender, EventArgs e)
    {
        try
        {
            var _months = MonthService.GetMonths();
            monthComboBox.Items.Clear();
            monthComboBox.DisplayMember = nameof(Month.Name);
            monthComboBox.ValueMember = nameof(Month.Id);
            monthComboBox.DataSource = _months.ToList();
            monthComboBox.Text = MonthService.GetCurrentMonth().Name;

            var _categories = await _categoryService.GetCategoriesByType(CategoryType.Expense);
            categoryComboBox.Items.Clear();
            categoryComboBox.DisplayMember = nameof(CategoryModel.Name);
            categoryComboBox.ValueMember = nameof(CategoryModel.Id);
            categoryComboBox.DataSource = _categories;

            if (monthComboBox.SelectedItem == null)
            {
                throw new ArgumentException("Please select a month.");
            }
            var selectedMonth = (Month)monthComboBox.SelectedItem;
            await LoadMonthWiseBudgets(selectedMonth.Id);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the budget UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (monthComboBox.SelectedItem == null)
            {
                throw new ArgumentException("Please select a month.");
            }
            if (categoryComboBox.SelectedItem == null)
            {
                throw new ArgumentException("Please select a category.");
            }
            if (string.IsNullOrWhiteSpace(amountTextBox.Text) ||
                !decimal.TryParse(amountTextBox.Text, out decimal amount) ||
                amount <= 0)
            {
                throw new ArgumentException("Please enter a valid amount.");
            }
            var selectedMonth = (Month)monthComboBox.SelectedItem;
            var selectedCategory = (CategoryModel)categoryComboBox.SelectedItem;
            BudgetModel budget = new BudgetModel
            {
                MonthId = selectedMonth.Id,
                CategoryId = selectedCategory.Id,
                Amount = amount
            };

            budget.Id = selectedBudgetId;

            await _budgetService.AddOrUpdateBudget(budget);
            MessageBox.Show("Budget saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadMonthWiseBudgets(selectedMonth.Id);

            ResetInput();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while saving the budget: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private async void monthComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        try
        {
            if (monthComboBox.SelectedItem == null)
            {
                throw new ArgumentException("Please select a month.");
            }
            var selectedMonth = (Month)monthComboBox.SelectedItem;
            await LoadMonthWiseBudgets(selectedMonth.Id);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while changing the month: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (budgetListView.SelectedItems.Count > 0)
            {
                var selectedItem = budgetListView.SelectedItems[0];
                var category = (BudgetModel)selectedItem.Tag;

                selectedBudgetId = category.Id;
                monthComboBox.SelectedValue = category.MonthId;
                categoryComboBox.SelectedValue = category.CategoryId;
                amountTextBox.Text = category.Amount.ToString();
            }
            else
            {
                MessageBox.Show("Please select a budget to edit.", "No Budget Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while editing the budget: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ResetInput();
            return;
        }
    }

    private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (budgetListView.SelectedItems.Count > 0)
            {
                var selectedItem = budgetListView.SelectedItems[0];
                var budget = (BudgetModel)selectedItem.Tag;

                var confirmResult = MessageBox.Show($"Are you sure you want to delete the budget of '{budget.MonthName}'?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    await _budgetService.DeleteBudget(budget.Id);
                    if (monthComboBox.SelectedItem == null)
                    {
                        throw new ArgumentException("Please select a month.");
                    }
                    var selectedMonth = (Month)monthComboBox.SelectedItem;
                    await LoadMonthWiseBudgets(selectedMonth.Id);
                }
            }
            else
            {
                MessageBox.Show("Please select a budget to delete.", "No Budget Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while deleting the budget: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void BudgetUi_FormClosed(object sender, FormClosedEventArgs e)
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

    private async Task LoadMonthWiseBudgets(string monthId)
    {
        if (string.IsNullOrEmpty(monthId) || monthId.Length != 6)
        {
            throw new ArgumentException("Invalid monthId format. Expected format is 'MMYYYY'.", nameof(monthId));
        }
        if (!int.TryParse(monthId.Substring(0, 2), out int month) || !int.TryParse(monthId.Substring(2, 4), out int year))
        {
            throw new ArgumentException("Invalid monthId format. Expected format is 'MMYYYY'.", nameof(monthId));
        }

        budgetListView.Items.Clear();

        var budgets = await _budgetService.GetBudgetsByMonth(monthId);

        foreach (var budget in budgets)
        {
            ListViewItem item = new ListViewItem(budget.MonthName);
            item.SubItems.Add(budget.CategoryName);
            item.SubItems.Add(budget.Amount.ToString("#,#"));
            item.Tag = budget;
            budgetListView.Items.Add(item);
        }
    }

    private void ResetInput()
    {
        selectedBudgetId = 0;
        amountTextBox.Clear();
    }

    private void ResetForm()
    {
        ResetInput();
        budgetListView.Items.Clear();
    }
}
