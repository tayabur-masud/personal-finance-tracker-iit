using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.UI.Budgets;
using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Reports;
using PersonalFinanceTrackerIIT.UI.Transactions;

namespace PersonalFinanceTrackerIIT.UI;

public partial class MainUi : Form
{
    private readonly IServiceProvider _serviceProvider;
    private string _currentToolTipText = string.Empty;

    public MainUi(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var incomeUi = _serviceProvider.GetRequiredService<IncomeUi>();
        incomeUi.ShowDialog();
    }

    private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var expenseUi = _serviceProvider.GetRequiredService<ExpenseUi>();
        expenseUi.ShowDialog();
    }

    private void categoryAddUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var categoryUi = _serviceProvider.GetRequiredService<CategoryUi>();
        categoryUi.ShowDialog();
    }

    private void monthlyIncomeExpenseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var monthlyIncomeAndExpenseSummaryUi = _serviceProvider.GetRequiredService<MonthlyIncomeAndExpenseSummaryUi>();
        monthlyIncomeAndExpenseSummaryUi.ShowDialog();
    }

    private void addUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var budgetUi = _serviceProvider.GetRequiredService<BudgetUi>();
        budgetUi.ShowDialog();
    }

    private void categoryWiseExpenseBreakdownToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var categoryWiseExpenseBreakdownUi = _serviceProvider.GetRequiredService<CategoryWiseExpenseBreakdownUi>();
        categoryWiseExpenseBreakdownUi.ShowDialog();
    }

    private void budgetVsActualExpenseReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var budgetVsActualExpenseUi = _serviceProvider.GetRequiredService<BudgetVsActualExpenseUi>();
        budgetVsActualExpenseUi.ShowDialog();
    }

    private void expenseOverTimeReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var expenseOverTimeUi = _serviceProvider.GetRequiredService<ExpenseOverTimeUi>();
        expenseOverTimeUi.ShowDialog();
    }

    private async void MainUi_Load(object sender, EventArgs e)
    {
        try
        {
            await ShowCurrentBalance();

            await LoadRecentTransactions();

            await LoadExpenseTrendChart(30);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void recentTransactionsListView_MouseMove(object sender, MouseEventArgs e)
    {
        try
        {
            ListViewHitTestInfo info = recentTransactionsListView.HitTest(e.X, e.Y);

            if (info.Item != null && info.SubItem != null)
            {
                string subItemText = info.SubItem.Text;

                if (_currentToolTipText != subItemText)
                {
                    _currentToolTipText = subItemText;

                    recentTransactionsToolTip.Show(subItemText, recentTransactionsListView, e.Location.X + 15, e.Location.Y + 15, 2000);
                }
            }
            else
            {
                recentTransactionsToolTip.Hide(recentTransactionsListView);
                _currentToolTipText = string.Empty;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while processing the mouse move: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async Task ShowCurrentBalance()
    {
        var transactionService = _serviceProvider.GetRequiredService<ITransactionService>();
        var balance = await transactionService.GetCurrentBalance();

        currentBalanceLabel.Text = "Current Balance: BDT " + balance.ToString("#,#");
        if (balance > 0)
        {
            currentBalanceLabel.ForeColor = Color.Green;
        }
        else
        {
            currentBalanceLabel.ForeColor = Color.Red;
        }
    }

    private async Task LoadRecentTransactions()
    {
        var transactionService = _serviceProvider.GetRequiredService<ITransactionService>();

        var last10Transactions = await transactionService.GetLast10Transactions();

        recentTransactionsListView.Items.Clear();

        foreach (var transaction in last10Transactions)
        {
            var item = new ListViewItem(transaction.DateString);
            item.SubItems.Add(transaction.Amount.ToString("#,#"));
            item.SubItems.Add(transaction.CategoryName);
            item.SubItems.Add(transaction.Description);
            item.Tag = transaction;
            recentTransactionsListView.Items.Add(item);
        }
    }

    private async Task LoadExpenseTrendChart(int days)
    {
        var reportService = _serviceProvider.GetRequiredService<IReportService>();

        var reportData = await reportService.GetExpenseTrendReportByDays(days);
        // Create the CartesianChart control
        var cartesianChart = new CartesianChart
        {
            Dock = DockStyle.Fill
        };

        // Sample data for line chart
        var lineSeries = new LineSeries<double>
        {
            Values = reportData.Select(x => x.TotalExpense).ToList(),
            Name = "Total Expense Amount (BDT)"
        };

        // Assign the Series to the chart
        cartesianChart.Series = new ISeries[] { lineSeries };

        // Optional: Configure Axes Labels
        cartesianChart.XAxes = new[]
        {
            new Axis
            {
                Labels =  reportData.Select(x=>x.PeriodLabel).ToList()
            }
        };

        // Add chart to the Form
        expenseTrendLineChartPanel.Controls.Add(cartesianChart);
    }

    private async void refreshButton_Click(object sender, EventArgs e)
    {
        try
        {
            await ShowCurrentBalance();

            await LoadRecentTransactions();

            await LoadExpenseTrendChart(30);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while refreshing the dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
