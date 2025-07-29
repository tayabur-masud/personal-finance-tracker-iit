namespace PersonalFinanceTrackerIIT.UI.Reports;

partial class ExpenseOverTimeUi
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
        showButton = new Button();
        categoryCheckedListBox = new CheckedListBox();
        categoryLabel = new Label();
        groupByLabel = new Label();
        monthlyRadioButton = new RadioButton();
        weeklyRadioButton = new RadioButton();
        dailyRadioButton = new RadioButton();
        toDateLabel = new Label();
        toDateTimePicker = new DateTimePicker();
        fromDateLabel = new Label();
        fromDateTimePicker = new DateTimePicker();
        barChartPanel = new Panel();
        panel2 = new Panel();
        resultListView = new ListView();
        filterGroupBox.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // filterGroupBox
        // 
        filterGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        filterGroupBox.Controls.Add(showButton);
        filterGroupBox.Controls.Add(categoryCheckedListBox);
        filterGroupBox.Controls.Add(categoryLabel);
        filterGroupBox.Controls.Add(groupByLabel);
        filterGroupBox.Controls.Add(monthlyRadioButton);
        filterGroupBox.Controls.Add(weeklyRadioButton);
        filterGroupBox.Controls.Add(dailyRadioButton);
        filterGroupBox.Controls.Add(toDateLabel);
        filterGroupBox.Controls.Add(toDateTimePicker);
        filterGroupBox.Controls.Add(fromDateLabel);
        filterGroupBox.Controls.Add(fromDateTimePicker);
        filterGroupBox.Location = new Point(12, 12);
        filterGroupBox.Name = "filterGroupBox";
        filterGroupBox.Size = new Size(1557, 291);
        filterGroupBox.TabIndex = 0;
        filterGroupBox.TabStop = false;
        filterGroupBox.Text = "Filter";
        // 
        // showButton
        // 
        showButton.Anchor = AnchorStyles.Top;
        showButton.Location = new Point(632, 229);
        showButton.Name = "showButton";
        showButton.Size = new Size(112, 34);
        showButton.TabIndex = 10;
        showButton.Text = "Show";
        showButton.UseVisualStyleBackColor = true;
        showButton.Click += showButton_Click;
        // 
        // categoryCheckedListBox
        // 
        categoryCheckedListBox.Anchor = AnchorStyles.Top;
        categoryCheckedListBox.FormattingEnabled = true;
        categoryCheckedListBox.Location = new Point(917, 35);
        categoryCheckedListBox.Name = "categoryCheckedListBox";
        categoryCheckedListBox.Size = new Size(245, 228);
        categoryCheckedListBox.TabIndex = 9;
        // 
        // categoryLabel
        // 
        categoryLabel.Anchor = AnchorStyles.Top;
        categoryLabel.AutoSize = true;
        categoryLabel.Location = new Point(811, 35);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new Size(84, 25);
        categoryLabel.TabIndex = 8;
        categoryLabel.Text = "Category";
        // 
        // groupByLabel
        // 
        groupByLabel.Anchor = AnchorStyles.Top;
        groupByLabel.AutoSize = true;
        groupByLabel.Location = new Point(317, 136);
        groupByLabel.Name = "groupByLabel";
        groupByLabel.Size = new Size(86, 25);
        groupByLabel.TabIndex = 7;
        groupByLabel.Text = "Group By";
        // 
        // monthlyRadioButton
        // 
        monthlyRadioButton.Anchor = AnchorStyles.Top;
        monthlyRadioButton.AutoSize = true;
        monthlyRadioButton.Location = new Point(651, 136);
        monthlyRadioButton.Name = "monthlyRadioButton";
        monthlyRadioButton.Size = new Size(103, 29);
        monthlyRadioButton.TabIndex = 6;
        monthlyRadioButton.TabStop = true;
        monthlyRadioButton.Text = "Monthly";
        monthlyRadioButton.UseVisualStyleBackColor = true;
        // 
        // weeklyRadioButton
        // 
        weeklyRadioButton.Anchor = AnchorStyles.Top;
        weeklyRadioButton.AutoSize = true;
        weeklyRadioButton.Location = new Point(533, 136);
        weeklyRadioButton.Name = "weeklyRadioButton";
        weeklyRadioButton.Size = new Size(93, 29);
        weeklyRadioButton.TabIndex = 5;
        weeklyRadioButton.TabStop = true;
        weeklyRadioButton.Text = "Weekly";
        weeklyRadioButton.UseVisualStyleBackColor = true;
        // 
        // dailyRadioButton
        // 
        dailyRadioButton.Anchor = AnchorStyles.Top;
        dailyRadioButton.AutoSize = true;
        dailyRadioButton.Location = new Point(432, 136);
        dailyRadioButton.Name = "dailyRadioButton";
        dailyRadioButton.Size = new Size(76, 29);
        dailyRadioButton.TabIndex = 4;
        dailyRadioButton.TabStop = true;
        dailyRadioButton.Text = "Daily";
        dailyRadioButton.UseVisualStyleBackColor = true;
        // 
        // toDateLabel
        // 
        toDateLabel.Anchor = AnchorStyles.Top;
        toDateLabel.AutoSize = true;
        toDateLabel.Location = new Point(317, 89);
        toDateLabel.Name = "toDateLabel";
        toDateLabel.Size = new Size(30, 25);
        toDateLabel.TabIndex = 3;
        toDateLabel.Text = "To";
        // 
        // toDateTimePicker
        // 
        toDateTimePicker.Anchor = AnchorStyles.Top;
        toDateTimePicker.Location = new Point(432, 84);
        toDateTimePicker.Name = "toDateTimePicker";
        toDateTimePicker.Size = new Size(312, 31);
        toDateTimePicker.TabIndex = 2;
        // 
        // fromDateLabel
        // 
        fromDateLabel.Anchor = AnchorStyles.Top;
        fromDateLabel.AutoSize = true;
        fromDateLabel.Location = new Point(317, 40);
        fromDateLabel.Name = "fromDateLabel";
        fromDateLabel.Size = new Size(54, 25);
        fromDateLabel.TabIndex = 1;
        fromDateLabel.Text = "From";
        // 
        // fromDateTimePicker
        // 
        fromDateTimePicker.Anchor = AnchorStyles.Top;
        fromDateTimePicker.Location = new Point(432, 35);
        fromDateTimePicker.Name = "fromDateTimePicker";
        fromDateTimePicker.Size = new Size(312, 31);
        fromDateTimePicker.TabIndex = 0;
        // 
        // barChartPanel
        // 
        barChartPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        barChartPanel.Location = new Point(12, 309);
        barChartPanel.Name = "barChartPanel";
        barChartPanel.Size = new Size(777, 293);
        barChartPanel.TabIndex = 1;
        // 
        // panel2
        // 
        panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        panel2.Controls.Add(resultListView);
        panel2.Location = new Point(792, 309);
        panel2.Name = "panel2";
        panel2.Size = new Size(777, 293);
        panel2.TabIndex = 2;
        // 
        // resultListView
        // 
        resultListView.Dock = DockStyle.Fill;
        resultListView.FullRowSelect = true;
        resultListView.GridLines = true;
        resultListView.Location = new Point(0, 0);
        resultListView.Name = "resultListView";
        resultListView.Size = new Size(777, 293);
        resultListView.TabIndex = 0;
        resultListView.UseCompatibleStateImageBehavior = false;
        resultListView.View = View.Details;
        resultListView.Visible = false;
        // 
        // ExpenseOverTimeUi
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1581, 614);
        Controls.Add(panel2);
        Controls.Add(barChartPanel);
        Controls.Add(filterGroupBox);
        Name = "ExpenseOverTimeUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Expense Over Time Report";
        WindowState = FormWindowState.Maximized;
        FormClosing += ExpenseOverTimeUi_FormClosing;
        Load += ExpenseOverTimeUi_Load;
        filterGroupBox.ResumeLayout(false);
        filterGroupBox.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox filterGroupBox;
    private DateTimePicker fromDateTimePicker;
    private Label fromDateLabel;
    private Label groupByLabel;
    private RadioButton monthlyRadioButton;
    private RadioButton weeklyRadioButton;
    private RadioButton dailyRadioButton;
    private Label toDateLabel;
    private DateTimePicker toDateTimePicker;
    private CheckedListBox categoryCheckedListBox;
    private Label categoryLabel;
    private Button showButton;
    private Panel barChartPanel;
    private Panel panel2;
    private ListView resultListView;
}