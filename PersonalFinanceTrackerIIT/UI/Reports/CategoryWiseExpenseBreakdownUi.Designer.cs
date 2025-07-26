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
        piePanel = new Panel();
        SuspendLayout();
        // 
        // piePanel
        // 
        piePanel.Dock = DockStyle.Fill;
        piePanel.Location = new Point(0, 0);
        piePanel.Name = "piePanel";
        piePanel.Size = new Size(837, 491);
        piePanel.TabIndex = 0;
        // 
        // CategoryWiseExpenseBreakdownUi
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(837, 491);
        Controls.Add(piePanel);
        Name = "CategoryWiseExpenseBreakdownUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Category-Wise Expense Breakdown";
        Load += CategoryWiseExpenseBreakdownUi_Load;
        ResumeLayout(false);
    }

    #endregion

    private Panel piePanel;
}