using PersonalFinanceTrackerIIT.Models;
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

    private void CategoryUi_Load(object sender, EventArgs e)
    {

    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        nameTextBox.Text = string.Empty;
        descriptionRichTextBox.Text = string.Empty;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        CategoryModel category = new CategoryModel();
        category.Name = nameTextBox.Text.Trim();
        category.Description = descriptionRichTextBox.Text.Trim();

        _categoryService.AddCategory(category);
    }
}
