using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.UI.Reports;

public partial class CategoryWiseExpenseBreakdownUi : Form
{
    private readonly IReportService _reportService;

    public CategoryWiseExpenseBreakdownUi(IReportService reportService)
    {
        InitializeComponent();
        _reportService = reportService;
    }

    private async void CategoryWiseExpenseBreakdownUi_Load(object sender, EventArgs e)
    {
        try
        {
            var _months = MonthService.GetMonths();
            monthComboBox.Items.Clear();
            monthComboBox.DisplayMember = nameof(Month.Name);
            monthComboBox.ValueMember = nameof(Month.Id);
            monthComboBox.DataSource = _months.ToList();
            monthComboBox.Text = MonthService.GetCurrentMonth().Name;

            var selectedMonth = (Month)monthComboBox.SelectedItem;

            await LoadPieChart(selectedMonth.Id);
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

            await LoadPieChart(selectedMonth.Id);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async Task LoadPieChart(string monthId)
    {
        var report = await _reportService.GetCategoryWiseExpenseBreakdownAsync(monthId);

        var pieSeries1 = new List<PieSeries<decimal>>();

        foreach (var item in report)
        {
            pieSeries1.Add(new PieSeries<decimal>
            {
                Values = new decimal[] { item.TotalExpense },
                Name = item.CategoryName,
                DataLabelsSize = 16,
                DataLabelsFormatter = point => $"{point.Context.Series.Name}: ${point.Coordinate.PrimaryValue:N0}",
                ToolTipLabelFormatter = point => $"BDT {point.Coordinate.PrimaryValue:N0}",
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle
            });
        }

        var pieChart = new PieChart
        {
            Series = pieSeries1,
            Dock = DockStyle.Fill,
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
        };

        piePanel.Controls.Clear();
        piePanel.Controls.Add(pieChart);
    }
}
