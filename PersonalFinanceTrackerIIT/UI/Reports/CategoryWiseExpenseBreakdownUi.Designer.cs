namespace PersonalFinanceTrackerIIT.UI.Reports;

partial class CategoryWiseExpenseBreakdownUi
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryWiseExpenseBreakdownUi));
        piePanel = new Panel();
        monthLabel = new Label();
        monthComboBox = new ComboBox();
        SuspendLayout();
        // 
        // piePanel
        // 
        piePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        piePanel.Location = new Point(0, 57);
        piePanel.Name = "piePanel";
        piePanel.Size = new Size(837, 434);
        piePanel.TabIndex = 0;
        // 
        // monthLabel
        // 
        monthLabel.Anchor = AnchorStyles.Top;
        monthLabel.AutoSize = true;
        monthLabel.Location = new Point(227, 14);
        monthLabel.Name = "monthLabel";
        monthLabel.Size = new Size(65, 25);
        monthLabel.TabIndex = 5;
        monthLabel.Text = "Month";
        // 
        // monthComboBox
        // 
        monthComboBox.Anchor = AnchorStyles.Top;
        monthComboBox.FormattingEnabled = true;
        monthComboBox.Location = new Point(332, 11);
        monthComboBox.Name = "monthComboBox";
        monthComboBox.Size = new Size(282, 33);
        monthComboBox.TabIndex = 4;
        monthComboBox.SelectionChangeCommitted += monthComboBox_SelectionChangeCommitted;
        // 
        // CategoryWiseExpenseBreakdownUi
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(837, 491);
        Controls.Add(monthLabel);
        Controls.Add(monthComboBox);
        Controls.Add(piePanel);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "CategoryWiseExpenseBreakdownUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Category-Wise Expense Breakdown";
        Load += CategoryWiseExpenseBreakdownUi_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel piePanel;
    private Label monthLabel;
    private ComboBox monthComboBox;
}