namespace PersonalFinanceTrackerIIT.UI.Reports;

partial class MonthlyIncomeAndExpenseSummaryReportUi
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
        resultListView = new ListView();
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
        filterGroupBox.Size = new Size(1533, 273);
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
        monthLabel.Size = new Size(73, 25);
        monthLabel.TabIndex = 1;
        monthLabel.Text = "Month*";
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
        resultGroupBox.Controls.Add(resultListView);
        resultGroupBox.Location = new Point(12, 302);
        resultGroupBox.Name = "resultGroupBox";
        resultGroupBox.Size = new Size(1533, 281);
        resultGroupBox.TabIndex = 1;
        resultGroupBox.TabStop = false;
        resultGroupBox.Text = "Result";
        // 
        // resultListView
        // 
        resultListView.Dock = DockStyle.Fill;
        resultListView.Location = new Point(3, 27);
        resultListView.Name = "resultListView";
        resultListView.Size = new Size(1527, 251);
        resultListView.TabIndex = 0;
        resultListView.UseCompatibleStateImageBehavior = false;
        // 
        // MonthlyIncomeAndExpenseSummaryReportUi
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1557, 595);
        Controls.Add(resultGroupBox);
        Controls.Add(filterGroupBox);
        Name = "MonthlyIncomeAndExpenseSummaryReportUi";
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
}