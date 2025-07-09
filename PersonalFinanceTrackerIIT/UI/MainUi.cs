using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Transactions;

namespace PersonalFinanceTrackerIIT.UI;

public partial class MainUi : Form
{
    public MainUi()
    {
        InitializeComponent();
    }

    private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        IncomeUi incomeUi = new IncomeUi();
        incomeUi.Show();
    }

    private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ExpenseUi expenseUi = new ExpenseUi();
        expenseUi.Show();
    }

    private void categoryAddUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CategoryUi categoryUi = new CategoryUi();
        categoryUi.Show();
    }
}
