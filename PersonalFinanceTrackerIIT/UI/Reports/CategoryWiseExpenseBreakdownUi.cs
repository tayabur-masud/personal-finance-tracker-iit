using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using PersonalFinanceTrackerIIT.Services;

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
        await LoadPieChart();
    }

    private async Task LoadPieChart()
    {
        var report = await _reportService.GetCategoryWiseExpenseBreakdownAsync();

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

        // Create PieChart Control
        var pieChart = new PieChart
        {
            Series = pieSeries1,
            Dock = DockStyle.Fill,
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Right,
        };

        // Add PieChart to Panel
        piePanel.Controls.Clear();
        piePanel.Controls.Add(pieChart);
    }
}
