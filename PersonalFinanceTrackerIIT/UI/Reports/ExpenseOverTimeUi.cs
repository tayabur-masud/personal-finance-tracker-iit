using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Models.ReportModels;
using PersonalFinanceTrackerIIT.Services;
using SkiaSharp;

namespace PersonalFinanceTrackerIIT.UI.Reports;
public partial class ExpenseOverTimeUi : Form
{
    private readonly ICategoryService _categoryService;
    private readonly IReportService _reportService;

    public ExpenseOverTimeUi(
        ICategoryService categoryService,
        IReportService reportService)
    {
        InitializeComponent();
        _categoryService = categoryService;
        _reportService = reportService;
    }

    private async void ExpenseOverTimeUi_Load(object sender, EventArgs e)
    {
        try
        {
            var _categories = await _categoryService.GetCategoriesByType(CategoryType.Expense);
            categoryCheckedListBox.Items.Clear();
            categoryCheckedListBox.DisplayMember = nameof(CategoryModel.Name);
            categoryCheckedListBox.ValueMember = nameof(CategoryModel.Id);
            foreach (var category in _categories)
            {
                categoryCheckedListBox.Items.Add(category, true);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void ExpenseOverTimeUi_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            ResetForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private async void showButton_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedCategories = categoryCheckedListBox.CheckedItems.Cast<CategoryModel>().ToList();
            if (selectedCategories.Count == 0)
            {
                MessageBox.Show("Please select at least one category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filterModel = new ExpenseOverTimeFilterModel
            {
                Categories = selectedCategories.Select(c => c.Id).ToList(),
                From = fromDateTimePicker.Value,
                To = toDateTimePicker.Value,
            };

            if( dailyRadioButton.Checked)
            {
                filterModel.GroupBy = GroupByPeriod.Daily;
            }
            else if (weeklyRadioButton.Checked)
            {
                filterModel.GroupBy = GroupByPeriod.Weekly;
            }
            else if (monthlyRadioButton.Checked)
            {
                filterModel.GroupBy = GroupByPeriod.Monthly;
            }
            else
            {
                MessageBox.Show("Please select a grouping option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var report = await _reportService.GetExpenseOverTimeReport(filterModel);

            if (report is not null && report.Count == 0)
            {
                MessageBox.Show("No data found for the selected criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LoadBarChart(report, filterModel.GroupBy);
            LoadResultListView(report, filterModel.GroupBy);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while showing the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void LoadBarChart(IReadOnlyCollection<ExpenseOverTimeModel> reportData, GroupByPeriod groupBy)
    {
        var labels = reportData.Select(x => x.PeriodLabel).ToList();

        var expenseSeries = new ColumnSeries<double>()
        {
            Name = "Total Expense",
            Values = reportData.Select(x => x.TotalExpense).ToList(),
            Stroke = null,
        };

        var axisName = "Period";
        if (groupBy == GroupByPeriod.Daily)
        {
            axisName = "Date";
        }
        else if (groupBy == GroupByPeriod.Weekly)
        {
            axisName = "Week Starting";
        }
        else if (groupBy == GroupByPeriod.Monthly)
        {
            axisName = "Month";
        }

        var cartesianChart = new CartesianChart
        {
            Series = new ISeries[] { expenseSeries },
            XAxes = new[]
            {
                new Axis
                {
                    Labels = labels,
                    Name = axisName,
                    UnitWidth = 1,
                    MinStep = 1,
                    LabelsRotation = 45,
                }
            },
            YAxes = new[]
            {
                new Axis
                {
                    Name = "Total Expense Amount (BDT)",
                    LabelsPaint = new SolidColorPaint(SKColors.Black),
                }
            },
            LegendPosition = LiveChartsCore.Measure.LegendPosition.Hidden,
            Dock = DockStyle.Fill,
            ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both,
        };

        barChartPanel.Controls.Clear();
        barChartPanel.Controls.Add(cartesianChart);
    }

    private void LoadResultListView(IReadOnlyCollection<ExpenseOverTimeModel> reportData, GroupByPeriod groupBy)
    {
        var columnName = "Period";
        if (groupBy == GroupByPeriod.Daily)
        {
            columnName = "Date";
        }
        else if (groupBy == GroupByPeriod.Weekly)
        {
            columnName = "Week Starting";
        }
        else if (groupBy == GroupByPeriod.Monthly)
        {
            columnName = "Month";
        }

        resultListView.Visible = true;
        resultListView.Items.Clear();
        resultListView.Columns.Clear();
        resultListView.Columns.Add(columnName, 300, HorizontalAlignment.Left);
        resultListView.Columns.Add("Total Expense Amount (BDT)", 300, HorizontalAlignment.Right);

        foreach (var data in reportData)
        {
            ListViewItem item = new ListViewItem(data.PeriodLabel);
            if (data.TotalExpense > 0)
            {
                item.SubItems.Add(data.TotalExpense.ToString("#,#"));
                item.SubItems.Add(string.Empty);
            }
            resultListView.Items.Add(item);
        }
    }

    private void ResetForm()
    {
        resultListView.Columns.Clear();
        resultListView.Items.Clear();
        resultListView.Visible = false;
        barChartPanel.Controls.Clear();
        categoryCheckedListBox.Items.Clear();
        dailyRadioButton.Checked = false;
        weeklyRadioButton.Checked = false;
        monthlyRadioButton.Checked = false;
    }
}
