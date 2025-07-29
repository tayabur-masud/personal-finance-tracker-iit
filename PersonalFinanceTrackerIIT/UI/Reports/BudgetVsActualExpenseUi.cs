using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.Utilities;
using SkiaSharp;

namespace PersonalFinanceTrackerIIT.UI.Reports;

public partial class BudgetVsActualExpenseUi : Form
{
    private readonly IReportService _reportService;

    public BudgetVsActualExpenseUi(IReportService reportService)
    {
        InitializeComponent();
        _reportService = reportService;
    }

    private async void BudgetVsActualExpenseUi_Load(object sender, EventArgs e)
    {
        try
        {
            monthComboBox.DataSource = null;
            monthComboBox.Items.Clear();
            var _months = MonthService.GetMonths();
            monthComboBox.DisplayMember = nameof(Month.Name);
            monthComboBox.ValueMember = nameof(Month.Id);
            monthComboBox.DataSource = _months.ToList();
            monthComboBox.Text = MonthService.GetCurrentMonth().Name;

            var selectedMonth = (Month)monthComboBox.SelectedItem;

            await LoadBarChart(selectedMonth.Id);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void monthComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        try
        {
            if (monthComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedMonth = (Month)monthComboBox.SelectedItem;

            await LoadBarChart(selectedMonth.Id);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async Task LoadBarChart(string monthId)
    {
        var reportData = await _reportService.GetBudgetVsActualExpenseAsync(monthId);

        var labels = reportData.Select(x => x.CategoryName).ToList();

        var budgetSeries = new ColumnSeries<double>()
        {
            Name = "Budget",
            Values = reportData.Select(x => x.BudgetAmount).ToList(),
            Stroke = null,
        };

        var actualSeries = new ColumnSeries<double>()
        {
            Name = "Actual",
            Values = reportData.Select(x => x.ActualExpense).ToList(),
            Stroke = null,
        };

        var cartesianChart = new CartesianChart
        {
            Series = new ISeries[] { budgetSeries, actualSeries },
            XAxes = new[]
            {
                new Axis
                {
                    Labels = labels,
                    Name = "Categories",
                    UnitWidth = 1,
                    MinStep = 1,
                    LabelsRotation = 45,
                }
            },
            YAxes = new[]
            {
                new Axis
                {
                    Name = "Amount (BDT)",
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                }
            },
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
            Dock = DockStyle.Fill,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X,
        };

        barPanel.Controls.Clear();
        barPanel.Controls.Add(cartesianChart);
    }
}
