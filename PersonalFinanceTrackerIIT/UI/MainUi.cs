using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.UI.Budgets;
using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Reports;
using PersonalFinanceTrackerIIT.UI.Transactions;
using SkiaSharp;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            await InitializeProgressBarChart();
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

            await InitializeProgressBarChart();
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
                Labels =  reportData.Select(x=>x.PeriodLabel).ToList(),
                LabelsRotation = 45,
            }
        };

        cartesianChart.ZoomMode = ZoomAndPanMode.Both;

        // Add chart to the Form
        expenseTrendLineChartPanel.Controls.Add(cartesianChart);
    }

    private async Task InitializeProgressBarChart()
    {
        var reportService = _serviceProvider.GetRequiredService<IReportService>();

        var reportData = await reportService.GetBudgetUtilizationOfCurrentMonthAsync();

        var labels = reportData.Select(x => x.Category).ToList();

        var colors = reportData.Select(x => GetColorForUtilization(x.UtilizationPercentage)).ToArray();

        var utilizationSeries = new ColumnSeries<double>()
        {
            Name = "Utilization (%)",
            Values = reportData.Select(x => x.UtilizationPercentage).ToList(),
            Stroke = null,
            DataLabelsPaint = new SolidColorPaint(SKColors.Black),
            Fill = new SolidColorPaint(SKColors.Cyan),
        };

        //var highUtilizationSeries = new ColumnSeries<double>()
        //{
        //    Name = "High (≥90%)",
        //    Values = reportData.Select(x => x.UtilizationPercentage >= 90 ? x.UtilizationPercentage : double.NaN).ToList(),
        //    Fill = new SolidColorPaint(SKColors.Red),
        //    Stroke = null,
        //    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
        //};

        //var mediumHighUtilizationSeries = new ColumnSeries<double>()
        //{
        //    Name = "Medium-High (70-89%)",
        //    Values = reportData.Select(x => x.UtilizationPercentage >= 70 && x.UtilizationPercentage < 90 ? x.UtilizationPercentage : double.NaN).ToList(),
        //    Fill = new SolidColorPaint(SKColors.Orange),
        //    Stroke = null,
        //    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
        //};

        //var mediumUtilizationSeries = new ColumnSeries<double>()
        //{
        //    Name = "Medium (50-69%)",
        //    Values = reportData.Select(x => x.UtilizationPercentage >= 50 && x.UtilizationPercentage < 70 ? x.UtilizationPercentage : double.NaN).ToList(),
        //    Fill = new SolidColorPaint(SKColors.Yellow),
        //    Stroke = null,
        //    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
        //};

        //var lowUtilizationSeries = new ColumnSeries<double>()
        //{
        //    Name = "Low (<50%)",
        //    Values = reportData.Select(x => x.UtilizationPercentage < 50 ? x.UtilizationPercentage : double.NaN).ToList(),
        //    Fill = new SolidColorPaint(SKColors.Green),
        //    Stroke = null,
        //    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
        //};

        var cartesianChart = new CartesianChart
        {
            Series = new ISeries[] { utilizationSeries },
            //Series = new ISeries[] { highUtilizationSeries, mediumHighUtilizationSeries, mediumUtilizationSeries, lowUtilizationSeries },
            XAxes = new[]
            {
                new Axis
                {
                    Labels = labels,
                    Name = "Category",
                    UnitWidth = 1,
                    MinStep = 1,
                    LabelsRotation = 45,
                }
            },
            YAxes = new[]
            {
                new Axis
                {
                    Name = "Utilization (%)",
                    LabelsPaint = new SolidColorPaint(SKColors.Black),

                }
            },
            LegendPosition = LegendPosition.Hidden,
            Dock = DockStyle.Fill,
            ZoomMode = ZoomAndPanMode.Both,
        };

        budgetUtilizationBarChartPanel.Controls.Clear();
        budgetUtilizationBarChartPanel.Controls.Add(cartesianChart);
    }

    // Helper method to determine color based on utilization percentage
    private SolidColorPaint GetColorForUtilization(double utilization)
    {
        if (utilization >= 90)
            return new SolidColorPaint(SKColors.Red);
        else if (utilization >= 70)
            return new SolidColorPaint(SKColors.Orange);
        else if (utilization >= 50)
            return new SolidColorPaint(SKColors.Yellow);
        else
            return new SolidColorPaint(SKColors.Green);
    }
}
