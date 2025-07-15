using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Transactions;

namespace PersonalFinanceTrackerIIT.UI;

public partial class MainUi : Form
{
    private readonly IServiceProvider _serviceProvider;

    public MainUi(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider=serviceProvider;
    }

    private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //IncomeUi incomeUi = new IncomeUi();
        var incomeUi = _serviceProvider.GetRequiredService<IncomeUi>();
        incomeUi.ShowDialog();
    }

    private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ExpenseUi expenseUi = new ExpenseUi();
        expenseUi.ShowDialog();
    }

    private void categoryAddUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //CategoryUi categoryUi = new CategoryUi();
        var categoryUi = _serviceProvider.GetRequiredService<CategoryUi>();
        categoryUi.ShowDialog();
    }
}
