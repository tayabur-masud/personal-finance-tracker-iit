using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;

namespace PersonalFinanceTrackerIIT.UI.Categories;
public partial class CategoryUi : Form
{
    private readonly ICategoryService _categoryService;
    private int selectedCategoryId = 0;

    public CategoryUi(ICategoryService categoryService)
    {
        InitializeComponent();
        _categoryService = categoryService;
        MessageBox.Show("Category UI initialized successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void CategoryUi_Load(object sender, EventArgs e)
    {
        try
        {
            await LoadCategories();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the category UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        try
        {
            ResetForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while resetting the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                throw new ArgumentException("Please enter a category name");
            }

            CategoryModel category = new CategoryModel();
            category.Name = nameTextBox.Text.Trim();
            category.Description = descriptionRichTextBox.Text.Trim();
            if (incomeRadioButton.Checked)
            {
                category.TypeId = (int)CategoryType.Income;
            }
            else if (expenseRadioButton.Checked)
            {
                category.TypeId = (int)CategoryType.Expense;
            }

            category.Id = selectedCategoryId;

            await _categoryService.AddOrUpdateCategory(category);
            MessageBox.Show("Category saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadCategories();

            ResetForm();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while saving the category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (categoryListView.SelectedItems.Count > 0)
            {
                var selectedItem = categoryListView.SelectedItems[0];
                var category = (CategoryModel)selectedItem.Tag;

                var confirmResult = MessageBox.Show($"Are you sure you want to delete the category '{category.Name}'?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    await _categoryService.DeleteCategory(category.Id);
                    await LoadCategories();
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while deleting the category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            if (categoryListView.SelectedItems.Count > 0)
            {
                var selectedItem = categoryListView.SelectedItems[0];
                var category = (CategoryModel)selectedItem.Tag;

                selectedCategoryId = category.Id;
                if (category.TypeId == (int)CategoryType.Income)
                {
                    incomeRadioButton.Checked = true;
                }
                else if (category.TypeId == (int)CategoryType.Expense)
                {
                    expenseRadioButton.Checked = true;
                }
                nameTextBox.Text = category.Name;
                descriptionRichTextBox.Text = category.Description;
            }
            else
            {
                MessageBox.Show("Please select a category to edit.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while editing the category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ResetForm();
            return;
        }
    }

    private async Task LoadCategories()
    {
        var categories = await _categoryService.GetCategories();
        categoryListView.Items.Clear();
        foreach (var category in categories)
        {
            ListViewItem item = new ListViewItem(category.TypeName);
            item.SubItems.Add(category.Name);
            item.SubItems.Add(category.Description);
            item.Tag = category;
            categoryListView.Items.Add(item);
        }
    }

    private void ResetForm()
    {
        selectedCategoryId = 0;
        incomeRadioButton.Checked = false;
        expenseRadioButton.Checked = false;
        nameTextBox.Text = string.Empty;
        descriptionRichTextBox.Text = string.Empty;
    }

    private void CategoryUi_FormClosed(object sender, FormClosedEventArgs e)
    {
        try
        {
            //Close();
            //Dispose(true);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
