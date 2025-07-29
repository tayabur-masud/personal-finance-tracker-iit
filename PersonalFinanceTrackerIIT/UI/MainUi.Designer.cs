namespace PersonalFinanceTrackerIIT.UI
{
    partial class MainUi
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
            mainMenuStrip = new MenuStrip();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            incomeToolStripMenuItem = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            categoryAddUpdateDeleteToolStripMenuItem = new ToolStripMenuItem();
            budgetToolStripMenuItem = new ToolStripMenuItem();
            addUpdateDeleteToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            monthlyIncomeExpenseSummaryToolStripMenuItem = new ToolStripMenuItem();
            categoryWiseExpenseBreakdownToolStripMenuItem = new ToolStripMenuItem();
            budgetVsActualExpenseReportToolStripMenuItem = new ToolStripMenuItem();
            expenseOverTimeReportToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            currentBalanceLabel = new Label();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(24, 24);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { transactionToolStripMenuItem, categoryToolStripMenuItem, budgetToolStripMenuItem, reportsToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(5, 2, 0, 2);
            mainMenuStrip.Size = new Size(1288, 28);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incomeToolStripMenuItem, expenseToolStripMenuItem });
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(98, 24);
            transactionToolStripMenuItem.Text = "Transaction";
            // 
            // incomeToolStripMenuItem
            // 
            incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            incomeToolStripMenuItem.Size = new Size(146, 26);
            incomeToolStripMenuItem.Text = "Income";
            incomeToolStripMenuItem.Click += incomeToolStripMenuItem_Click;
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Size = new Size(146, 26);
            expenseToolStripMenuItem.Text = "Expense";
            expenseToolStripMenuItem.Click += expenseToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoryAddUpdateDeleteToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(83, 24);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // categoryAddUpdateDeleteToolStripMenuItem
            // 
            categoryAddUpdateDeleteToolStripMenuItem.Name = "categoryAddUpdateDeleteToolStripMenuItem";
            categoryAddUpdateDeleteToolStripMenuItem.Size = new Size(225, 26);
            categoryAddUpdateDeleteToolStripMenuItem.Text = "Add/Update/Delete";
            categoryAddUpdateDeleteToolStripMenuItem.Click += categoryAddUpdateDeleteToolStripMenuItem_Click;
            // 
            // budgetToolStripMenuItem
            // 
            budgetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUpdateDeleteToolStripMenuItem });
            budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            budgetToolStripMenuItem.Size = new Size(71, 24);
            budgetToolStripMenuItem.Text = "Budget";
            // 
            // addUpdateDeleteToolStripMenuItem
            // 
            addUpdateDeleteToolStripMenuItem.Name = "addUpdateDeleteToolStripMenuItem";
            addUpdateDeleteToolStripMenuItem.Size = new Size(225, 26);
            addUpdateDeleteToolStripMenuItem.Text = "Add/Update/Delete";
            addUpdateDeleteToolStripMenuItem.Click += addUpdateDeleteToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { monthlyIncomeExpenseSummaryToolStripMenuItem, categoryWiseExpenseBreakdownToolStripMenuItem, budgetVsActualExpenseReportToolStripMenuItem, expenseOverTimeReportToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // monthlyIncomeExpenseSummaryToolStripMenuItem
            // 
            monthlyIncomeExpenseSummaryToolStripMenuItem.Name = "monthlyIncomeExpenseSummaryToolStripMenuItem";
            monthlyIncomeExpenseSummaryToolStripMenuItem.Size = new Size(339, 26);
            monthlyIncomeExpenseSummaryToolStripMenuItem.Text = "Monthly Income && Expense Summary";
            monthlyIncomeExpenseSummaryToolStripMenuItem.Click += monthlyIncomeExpenseSummaryToolStripMenuItem_Click;
            // 
            // categoryWiseExpenseBreakdownToolStripMenuItem
            // 
            categoryWiseExpenseBreakdownToolStripMenuItem.Name = "categoryWiseExpenseBreakdownToolStripMenuItem";
            categoryWiseExpenseBreakdownToolStripMenuItem.Size = new Size(339, 26);
            categoryWiseExpenseBreakdownToolStripMenuItem.Text = "Category-Wise Expense Breakdown";
            categoryWiseExpenseBreakdownToolStripMenuItem.Click += categoryWiseExpenseBreakdownToolStripMenuItem_Click;
            // 
            // budgetVsActualExpenseReportToolStripMenuItem
            // 
            budgetVsActualExpenseReportToolStripMenuItem.Name = "budgetVsActualExpenseReportToolStripMenuItem";
            budgetVsActualExpenseReportToolStripMenuItem.Size = new Size(339, 26);
            budgetVsActualExpenseReportToolStripMenuItem.Text = "Budget vs Actual Expense Report";
            budgetVsActualExpenseReportToolStripMenuItem.Click += budgetVsActualExpenseReportToolStripMenuItem_Click;
            // 
            // expenseOverTimeReportToolStripMenuItem
            // 
            expenseOverTimeReportToolStripMenuItem.Name = "expenseOverTimeReportToolStripMenuItem";
            expenseOverTimeReportToolStripMenuItem.Size = new Size(339, 26);
            expenseOverTimeReportToolStripMenuItem.Text = "Expense Over Time Report";
            expenseOverTimeReportToolStripMenuItem.Click += expenseOverTimeReportToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1123, 439);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 80);
            label1.TabIndex = 2;
            label1.Text = "Developed for\r\nAdvanced OOP Course\r\nExecutive MIT\r\nIIT, University of Dhaka";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentBalanceLabel
            // 
            currentBalanceLabel.AutoSize = true;
            currentBalanceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentBalanceLabel.Location = new Point(40, 51);
            currentBalanceLabel.Name = "currentBalanceLabel";
            currentBalanceLabel.Size = new Size(196, 31);
            currentBalanceLabel.TabIndex = 3;
            currentBalanceLabel.Text = "Current Balance: ";
            // 
            // MainUi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 526);
            Controls.Add(currentBalanceLabel);
            Controls.Add(label1);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(2);
            Name = "MainUi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Finance Tracker";
            WindowState = FormWindowState.Maximized;
            Load += MainUi_Load;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem incomeToolStripMenuItem;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem budgetToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem categoryAddUpdateDeleteToolStripMenuItem;
        private ToolStripMenuItem monthlyIncomeExpenseSummaryToolStripMenuItem;
        private ToolStripMenuItem addUpdateDeleteToolStripMenuItem;
        private ToolStripMenuItem categoryWiseExpenseBreakdownToolStripMenuItem;
        private ToolStripMenuItem budgetVsActualExpenseReportToolStripMenuItem;
        private ToolStripMenuItem expenseOverTimeReportToolStripMenuItem;
        private Label currentBalanceLabel;
    }
}