using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Services;

namespace PersonalFinanceTrackerIIT.UI.Categories;
public partial class CategoryUi : Form
{
    private readonly ICategoryService _categoryService;

    public CategoryUi(ICategoryService categoryService)
    {
        InitializeComponent();
        _categoryService = categoryService;
    }

    private async void CategoryUi_Load(object sender, EventArgs e)
    {
        await LoadCategories();
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        nameTextBox.Text = string.Empty;
        descriptionRichTextBox.Text = string.Empty;
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
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

        await _categoryService.AddCategory(category);

        await LoadCategories();
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
            categoryListView.Items.Add(item);
        }
    }
}
