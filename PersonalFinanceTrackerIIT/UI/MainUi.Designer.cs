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
            label1 = new Label();
            categoryWiseExpenseBreakdownToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(24, 24);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { transactionToolStripMenuItem, categoryToolStripMenuItem, budgetToolStripMenuItem, reportsToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(800, 33);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incomeToolStripMenuItem, expenseToolStripMenuItem });
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(116, 29);
            transactionToolStripMenuItem.Text = "Transaction";
            // 
            // incomeToolStripMenuItem
            // 
            incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            incomeToolStripMenuItem.Size = new Size(178, 34);
            incomeToolStripMenuItem.Text = "Income";
            incomeToolStripMenuItem.Click += incomeToolStripMenuItem_Click;
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Size = new Size(178, 34);
            expenseToolStripMenuItem.Text = "Expense";
            expenseToolStripMenuItem.Click += expenseToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoryAddUpdateDeleteToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(100, 29);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // categoryAddUpdateDeleteToolStripMenuItem
            // 
            categoryAddUpdateDeleteToolStripMenuItem.Name = "categoryAddUpdateDeleteToolStripMenuItem";
            categoryAddUpdateDeleteToolStripMenuItem.Size = new Size(270, 34);
            categoryAddUpdateDeleteToolStripMenuItem.Text = "Add/Update/Delete";
            categoryAddUpdateDeleteToolStripMenuItem.Click += categoryAddUpdateDeleteToolStripMenuItem_Click;
            // 
            // budgetToolStripMenuItem
            // 
            budgetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUpdateDeleteToolStripMenuItem });
            budgetToolStripMenuItem.Name = "budgetToolStripMenuItem";
            budgetToolStripMenuItem.Size = new Size(85, 29);
            budgetToolStripMenuItem.Text = "Budget";
            // 
            // addUpdateDeleteToolStripMenuItem
            // 
            addUpdateDeleteToolStripMenuItem.Name = "addUpdateDeleteToolStripMenuItem";
            addUpdateDeleteToolStripMenuItem.Size = new Size(270, 34);
            addUpdateDeleteToolStripMenuItem.Text = "Add/Update/Delete";
            addUpdateDeleteToolStripMenuItem.Click += addUpdateDeleteToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { monthlyIncomeExpenseSummaryToolStripMenuItem, categoryWiseExpenseBreakdownToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(89, 29);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // monthlyIncomeExpenseSummaryToolStripMenuItem
            // 
            monthlyIncomeExpenseSummaryToolStripMenuItem.Name = "monthlyIncomeExpenseSummaryToolStripMenuItem";
            monthlyIncomeExpenseSummaryToolStripMenuItem.Size = new Size(413, 34);
            monthlyIncomeExpenseSummaryToolStripMenuItem.Text = "Monthly Income && Expense Summary";
            monthlyIncomeExpenseSummaryToolStripMenuItem.Click += monthlyIncomeExpenseSummaryToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(594, 341);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 100);
            label1.TabIndex = 2;
            label1.Text = "Developed for\r\nAdvanced OOP Course\r\nExecutive MIT\r\nIIT, University of Dhaka";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // categoryWiseExpenseBreakdownToolStripMenuItem
            // 
            categoryWiseExpenseBreakdownToolStripMenuItem.Name = "categoryWiseExpenseBreakdownToolStripMenuItem";
            categoryWiseExpenseBreakdownToolStripMenuItem.Size = new Size(413, 34);
            categoryWiseExpenseBreakdownToolStripMenuItem.Text = "Category-Wise Expense Breakdown";
            categoryWiseExpenseBreakdownToolStripMenuItem.Click += categoryWiseExpenseBreakdownToolStripMenuItem_Click;
            // 
            // MainUi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(2);
            Name = "MainUi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Finance Tracker";
            WindowState = FormWindowState.Maximized;
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
    }
}