using OfficeOpenXml;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Models.ReportModels;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.UI.Reports;

public partial class MonthlyIncomeAndExpenseSummaryUi : Form
{
    private readonly ICategoryService _categoryService;
    private readonly IReportService _reportService;

    public MonthlyIncomeAndExpenseSummaryUi(
        ICategoryService categoryService,
        IReportService reportService)
    {
        InitializeComponent();
        _categoryService = categoryService;
        _reportService = reportService;
    }

    private async void MonthlyIncomeAndExpenseSummaryReportUi_Load(object sender, EventArgs e)
    {
        try
        {
            var _categories = await _categoryService.GetCategories();
            categoryCheckedListBox.Items.Clear();
            categoryCheckedListBox.DisplayMember = nameof(CategoryModel.Name);
            categoryCheckedListBox.ValueMember = nameof(CategoryModel.Id);
            foreach (var category in _categories)
            {
                categoryCheckedListBox.Items.Add(category, true);
            }

            monthComboBox.DataSource = null;
            monthComboBox.Items.Clear();
            var _months = MonthService.GetMonths();
            monthComboBox.DisplayMember = nameof(Month.Name);
            monthComboBox.ValueMember = nameof(Month.Id);
            monthComboBox.DataSource = _months.ToList();
            monthComboBox.Text = MonthService.GetCurrentMonth().Name;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (monthComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedMonth = (Month)monthComboBox.SelectedItem;

            var filterModel = new MonthlyIncomeAndExpenseSummaryFilterModel
            {
                MonthId = selectedMonth.Id,
                Categories = selectedCategories.Select(c => c.Id).ToList(),
            };

            var report = await _reportService.GetMonthlyIncomeAndExpenseSummaryReport(filterModel);

            if (report is not null && report.Count == 0)
            {
                MessageBox.Show("No data found for the selected criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exportExcelButton.Enabled = false;
                return;
            }

            exportExcelButton.Enabled = true;

            LoadResultListView(report);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void exportExcelButton_Click(object sender, EventArgs e)
    {
        try
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = $"{monthComboBox.Text}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;

                    var EPPlusLicense = new EPPlusLicense();
                    EPPlusLicense.SetNonCommercialPersonal("Tayabur  Rahman Masud");

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Data");

                        for (int i = 0; i < resultListView.Columns.Count; i++)
                        {
                            var cell = worksheet.Cells[1, i + 1];
                            cell.Value = resultListView.Columns[i].Text;

                            cell.Style.Font.Bold = true;
                            cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            cell.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                            cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            cell.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        }

                        for (int i = 0; i < resultListView.Items.Count; i++)
                        {
                            for (int j = 0; j < resultListView.Items[i].SubItems.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = resultListView.Items[i].SubItems[j].Text;
                                worksheet.Cells[i + 2, j + 1].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                            }
                        }

                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        package.SaveAs(new FileInfo(filePath));

                        MessageBox.Show("Excel file exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void LoadResultListView(IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryModel> report)
    {
        resultListView.Items.Clear();

        foreach (var data in report)
        {
            ListViewItem item = new ListViewItem(data.DateString);
            item.SubItems.Add(data.Category);
            if (data.IncomeAmount > 0)
            {
                item.SubItems.Add(data.IncomeAmount.ToString("#,#"));
                item.SubItems.Add(string.Empty);
            }
            if (data.ExpenseAmount > 0)
            {
                item.SubItems.Add(string.Empty);
                item.SubItems.Add(data.ExpenseAmount.ToString("#,#"));
            }
            item.SubItems.Add(data.Description);
            resultListView.Items.Add(item);
        }
    }
}

