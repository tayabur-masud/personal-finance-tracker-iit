using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.UI.Budgets;
using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Reports;
using PersonalFinanceTrackerIIT.UI.Transactions;
using SkiaSharp;
using System.Threading.Tasks;

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
        try
        {
            var incomeUi = _serviceProvider.GetRequiredService<IncomeUi>();
            incomeUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Income UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var expenseUi = _serviceProvider.GetRequiredService<ExpenseUi>();
            expenseUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Expense UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void categoryAddUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var categoryUi = _serviceProvider.GetRequiredService<CategoryUi>();
            categoryUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Category UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void monthlyIncomeExpenseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var monthlyIncomeAndExpenseSummaryUi = _serviceProvider.GetRequiredService<MonthlyIncomeAndExpenseSummaryUi>();
            monthlyIncomeAndExpenseSummaryUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Monthly Income and Expense Summary UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void budgetAddUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var budgetUi = _serviceProvider.GetRequiredService<BudgetUi>();
            budgetUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Budget UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void categoryWiseExpenseBreakdownToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var categoryWiseExpenseBreakdownUi = _serviceProvider.GetRequiredService<CategoryWiseExpenseBreakdownUi>();
            categoryWiseExpenseBreakdownUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Category Wise Expense Breakdown UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void budgetVsActualExpenseReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var budgetVsActualExpenseUi = _serviceProvider.GetRequiredService<BudgetVsActualExpenseUi>();
            budgetVsActualExpenseUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Budget vs Actual Expense Report UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void expenseOverTimeReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            var expenseOverTimeUi = _serviceProvider.GetRequiredService<ExpenseOverTimeUi>();
            expenseOverTimeUi.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while opening the Expense Over Time Report UI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void MainUi_Load(object sender, EventArgs e)
    {
        try
        {
            await ShowCurrentBalance();

            await LoadRecentTransactions();

            await LoadExpenseTrendChart(30);

            InitializeProgressBarChart();
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

    private async void refreshButton_Click(object sender, EventArgs e)
    {
        try
        {
            await ShowCurrentBalance();

            await LoadRecentTransactions();

            await LoadExpenseTrendChart(30);

            InitializeProgressBarChart();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while refreshing the dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void InitializeProgressBarChart()
    {
        var cartesianChart = new CartesianChart
        {
            Dock = DockStyle.Fill
        };

        var taskProgress = new double[] { 70, 45, 85, 30 };

        var seriesList = new List<ISeries>();

        for (int i = 0; i < taskProgress.Length; i++)
        {
            var progressBar = new RowSeries<double>
            {
                Values = new double[] { taskProgress[i] },
                MaxBarWidth = 30,
                Name = $"Task {i + 1}",
                DataLabelsSize = 14,
                DataLabelsPosition = LiveChartsCore.Measure.DataLabelsPosition.Middle,
                DataLabelsFormatter = value => $"{value}%" // Formatter is the key!
            };

            seriesList.Add(progressBar);
        }

        cartesianChart.Series = seriesList;

        cartesianChart.XAxes = new[]
        {
            new Axis
            {
                MinLimit = 0,
                MaxLimit = 100,
                Name = "Progress (%)"
            }
        };

        cartesianChart.YAxes = new[]
        {
            new Axis
            {
                Labels = new[] { "Task 1", "Task 2", "Task 3", "Task 4" }
            }
        };

        // Tooltip will automatically show the series name and value on hover.
        // You can position it as needed:
        cartesianChart.TooltipPosition = TooltipPosition.Right;

        // Add Chart to Form
        budgetUtilizationBarChartPanel.Controls.Add(cartesianChart);
    }
}
