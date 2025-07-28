namespace PersonalFinanceTrackerIIT.UI.Reports;

partial class MonthlyIncomeAndExpenseSummaryUi
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        filterGroupBox = new GroupBox();
        categoryCheckedListBox = new CheckedListBox();
        showButton = new Button();
        categoryLabel = new Label();
        monthLabel = new Label();
        monthComboBox = new ComboBox();
        resultGroupBox = new GroupBox();
        exportExcelButton = new Button();
        resultListView = new ListView();
        dateColumnHeader = new ColumnHeader();
        categoryColumnHeader = new ColumnHeader();
        incomeColumnHeader = new ColumnHeader();
        expenseColumnHeader = new ColumnHeader();
        descriptionColumnHeader = new ColumnHeader();
        filterGroupBox.SuspendLayout();
        resultGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // filterGroupBox
        // 
        filterGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        filterGroupBox.Controls.Add(categoryCheckedListBox);
        filterGroupBox.Controls.Add(showButton);
        filterGroupBox.Controls.Add(categoryLabel);
        filterGroupBox.Controls.Add(monthLabel);
        filterGroupBox.Controls.Add(monthComboBox);
        filterGroupBox.Location = new Point(12, 12);
        filterGroupBox.Name = "filterGroupBox";
        filterGroupBox.Size = new Size(1646, 273);
        filterGroupBox.TabIndex = 0;
        filterGroupBox.TabStop = false;
        filterGroupBox.Text = "Filter";
        // 
        // categoryCheckedListBox
        // 
        categoryCheckedListBox.FormattingEnabled = true;
        categoryCheckedListBox.Location = new Point(267, 30);
        categoryCheckedListBox.Name = "categoryCheckedListBox";
        categoryCheckedListBox.Size = new Size(245, 228);
        categoryCheckedListBox.TabIndex = 5;
        // 
        // showButton
        // 
        showButton.Location = new Point(1084, 30);
        showButton.Name = "showButton";
        showButton.Size = new Size(112, 34);
        showButton.TabIndex = 4;
        showButton.Text = "Show";
        showButton.UseVisualStyleBackColor = true;
        showButton.Click += showButton_Click;
        // 
        // categoryLabel
        // 
        categoryLabel.AutoSize = true;
        categoryLabel.Location = new Point(161, 30);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new Size(84, 25);
        categoryLabel.TabIndex = 3;
        categoryLabel.Text = "Category";
        // 
        // monthLabel
        // 
        monthLabel.AutoSize = true;
        monthLabel.Location = new Point(636, 33);
        monthLabel.Name = "monthLabel";
        monthLabel.Size = new Size(65, 25);
        monthLabel.TabIndex = 1;
        monthLabel.Text = "Month";
        // 
        // monthComboBox
        // 
        monthComboBox.FormattingEnabled = true;
        monthComboBox.Location = new Point(741, 30);
        monthComboBox.Name = "monthComboBox";
        monthComboBox.Size = new Size(282, 33);
        monthComboBox.TabIndex = 0;
        // 
        // resultGroupBox
        // 
        resultGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        resultGroupBox.Controls.Add(exportExcelButton);
        resultGroupBox.Controls.Add(resultListView);
        resultGroupBox.Location = new Point(12, 302);
        resultGroupBox.Name = "resultGroupBox";
        resultGroupBox.Size = new Size(1646, 347);
        resultGroupBox.TabIndex = 1;
        resultGroupBox.TabStop = false;
        resultGroupBox.Text = "Result";
        // 
        // exportExcelButton
        // 
        exportExcelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        exportExcelButton.Enabled = false;
        exportExcelButton.Location = new Point(1472, 24);
        exportExcelButton.Name = "exportExcelButton";
        exportExcelButton.Size = new Size(168, 34);
        exportExcelButton.TabIndex = 1;
        exportExcelButton.Text = "Export Excel";
        exportExcelButton.UseVisualStyleBackColor = true;
        exportExcelButton.Click += exportExcelButton_Click;
        // 
        // resultListView
        // 
        resultListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        resultListView.Columns.AddRange(new ColumnHeader[] { dateColumnHeader, categoryColumnHeader, incomeColumnHeader, expenseColumnHeader, descriptionColumnHeader });
        resultListView.FullRowSelect = true;
        resultListView.GridLines = true;
        resultListView.Location = new Point(6, 64);
        resultListView.Name = "resultListView";
        resultListView.Size = new Size(1634, 277);
        resultListView.TabIndex = 0;
        resultListView.UseCompatibleStateImageBehavior = false;
        resultListView.View = View.Details;
        // 
        // dateColumnHeader
        // 
        dateColumnHeader.Text = "Date";
        dateColumnHeader.Width = 200;
        // 
        // categoryColumnHeader
        // 
        categoryColumnHeader.Text = "Category";
        categoryColumnHeader.Width = 300;
        // 
        // incomeColumnHeader
        // 
        incomeColumnHeader.Text = "Income";
        incomeColumnHeader.TextAlign = HorizontalAlignment.Right;
        incomeColumnHeader.Width = 200;
        // 
        // expenseColumnHeader
        // 
        expenseColumnHeader.Text = "Expense";
        expenseColumnHeader.TextAlign = HorizontalAlignment.Right;
        expenseColumnHeader.Width = 200;
        // 
        // descriptionColumnHeader
        // 
        descriptionColumnHeader.Text = "Description";
        descriptionColumnHeader.Width = 600;
        // 
        // MonthlyIncomeAndExpenseSummaryUi
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1670, 661);
        Controls.Add(resultGroupBox);
        Controls.Add(filterGroupBox);
        Name = "MonthlyIncomeAndExpenseSummaryUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Monthly Income & Expense Summary Report";
        WindowState = FormWindowState.Maximized;
        Load += MonthlyIncomeAndExpenseSummaryReportUi_Load;
        filterGroupBox.ResumeLayout(false);
        filterGroupBox.PerformLayout();
        resultGroupBox.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox filterGroupBox;
    private Label monthLabel;
    private ComboBox monthComboBox;
    private Label categoryLabel;
    private Button showButton;
    private CheckedListBox categoryCheckedListBox;
    private GroupBox resultGroupBox;
    private ListView resultListView;
    private ColumnHeader dateColumnHeader;
    private ColumnHeader incomeColumnHeader;
    private ColumnHeader expenseColumnHeader;
    private ColumnHeader categoryColumnHeader;
    private ColumnHeader descriptionColumnHeader;
    private Button exportExcelButton;
}