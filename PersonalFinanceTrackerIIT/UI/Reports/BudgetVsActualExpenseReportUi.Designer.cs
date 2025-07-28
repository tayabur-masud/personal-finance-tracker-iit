namespace PersonalFinanceTrackerIIT.UI.Reports;

partial class BudgetVsActualExpenseUi
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
        barPanel = new Panel();
        monthLabel = new Label();
        monthComboBox = new ComboBox();
        SuspendLayout();
        // 
        // barPanel
        // 
        barPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        barPanel.Location = new Point(0, 57);
        barPanel.Name = "barPanel";
        barPanel.Size = new Size(837, 434);
        barPanel.TabIndex = 0;
        // 
        // monthLabel
        // 
        monthLabel.Anchor = AnchorStyles.Top;
        monthLabel.AutoSize = true;
        monthLabel.Location = new Point(227, 14);
        monthLabel.Name = "monthLabel";
        monthLabel.Size = new Size(65, 25);
        monthLabel.TabIndex = 3;
        monthLabel.Text = "Month";
        // 
        // monthComboBox
        // 
        monthComboBox.Anchor = AnchorStyles.Top;
        monthComboBox.FormattingEnabled = true;
        monthComboBox.Location = new Point(332, 11);
        monthComboBox.Name = "monthComboBox";
        monthComboBox.Size = new Size(282, 33);
        monthComboBox.TabIndex = 2;
        monthComboBox.SelectionChangeCommitted += monthComboBox_SelectionChangeCommitted;
        // 
        // BudgetVsActualExpenseUi
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(837, 491);
        Controls.Add(monthLabel);
        Controls.Add(monthComboBox);
        Controls.Add(barPanel);
        Name = "BudgetVsActualExpenseUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Budget vs Actual Expense Report";
        Load += BudgetVsActualExpenseUi_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel barPanel;
    private Label monthLabel;
    private ComboBox monthComboBox;
}