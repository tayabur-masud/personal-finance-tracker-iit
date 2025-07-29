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
            components = new System.ComponentModel.Container();
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
            recentTransactionsGroupBox = new GroupBox();
            recentTransactionsListView = new ListView();
            recentDateColumnHeader = new ColumnHeader();
            recentAmountColumnHeader = new ColumnHeader();
            recentCategoryColumnHeader = new ColumnHeader();
            recentDescriptionColumnHeader = new ColumnHeader();
            recentTransactionsToolTip = new ToolTip(components);
            mainMenuStrip.SuspendLayout();
            recentTransactionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(24, 24);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { transactionToolStripMenuItem, categoryToolStripMenuItem, budgetToolStripMenuItem, reportsToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(1610, 33);
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
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { monthlyIncomeExpenseSummaryToolStripMenuItem, categoryWiseExpenseBreakdownToolStripMenuItem, budgetVsActualExpenseReportToolStripMenuItem, expenseOverTimeReportToolStripMenuItem });
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
            // categoryWiseExpenseBreakdownToolStripMenuItem
            // 
            categoryWiseExpenseBreakdownToolStripMenuItem.Name = "categoryWiseExpenseBreakdownToolStripMenuItem";
            categoryWiseExpenseBreakdownToolStripMenuItem.Size = new Size(413, 34);
            categoryWiseExpenseBreakdownToolStripMenuItem.Text = "Category-Wise Expense Breakdown";
            categoryWiseExpenseBreakdownToolStripMenuItem.Click += categoryWiseExpenseBreakdownToolStripMenuItem_Click;
            // 
            // budgetVsActualExpenseReportToolStripMenuItem
            // 
            budgetVsActualExpenseReportToolStripMenuItem.Name = "budgetVsActualExpenseReportToolStripMenuItem";
            budgetVsActualExpenseReportToolStripMenuItem.Size = new Size(413, 34);
            budgetVsActualExpenseReportToolStripMenuItem.Text = "Budget vs Actual Expense Report";
            budgetVsActualExpenseReportToolStripMenuItem.Click += budgetVsActualExpenseReportToolStripMenuItem_Click;
            // 
            // expenseOverTimeReportToolStripMenuItem
            // 
            expenseOverTimeReportToolStripMenuItem.Name = "expenseOverTimeReportToolStripMenuItem";
            expenseOverTimeReportToolStripMenuItem.Size = new Size(413, 34);
            expenseOverTimeReportToolStripMenuItem.Text = "Expense Over Time Report";
            expenseOverTimeReportToolStripMenuItem.Click += expenseOverTimeReportToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1404, 549);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 100);
            label1.TabIndex = 2;
            label1.Text = "Developed for\r\nAdvanced OOP Course\r\nExecutive MIT\r\nIIT, University of Dhaka";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentBalanceLabel
            // 
            currentBalanceLabel.AutoSize = true;
            currentBalanceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentBalanceLabel.Location = new Point(50, 64);
            currentBalanceLabel.Margin = new Padding(4, 0, 4, 0);
            currentBalanceLabel.Name = "currentBalanceLabel";
            currentBalanceLabel.Size = new Size(241, 38);
            currentBalanceLabel.TabIndex = 3;
            currentBalanceLabel.Text = "Current Balance: ";
            // 
            // recentTransactionsGroupBox
            // 
            recentTransactionsGroupBox.Controls.Add(recentTransactionsListView);
            recentTransactionsGroupBox.Location = new Point(785, 64);
            recentTransactionsGroupBox.Name = "recentTransactionsGroupBox";
            recentTransactionsGroupBox.Size = new Size(813, 326);
            recentTransactionsGroupBox.TabIndex = 4;
            recentTransactionsGroupBox.TabStop = false;
            recentTransactionsGroupBox.Text = "Recent Transactions";
            // 
            // recentTransactionsListView
            // 
            recentTransactionsListView.Columns.AddRange(new ColumnHeader[] { recentDateColumnHeader, recentAmountColumnHeader, recentCategoryColumnHeader, recentDescriptionColumnHeader });
            recentTransactionsListView.Dock = DockStyle.Fill;
            recentTransactionsListView.FullRowSelect = true;
            recentTransactionsListView.GridLines = true;
            recentTransactionsListView.Location = new Point(3, 27);
            recentTransactionsListView.Name = "recentTransactionsListView";
            recentTransactionsListView.Size = new Size(807, 296);
            recentTransactionsListView.TabIndex = 0;
            recentTransactionsListView.UseCompatibleStateImageBehavior = false;
            recentTransactionsListView.View = View.Details;
            recentTransactionsListView.MouseMove += recentTransactionsListView_MouseMove;
            // 
            // recentDateColumnHeader
            // 
            recentDateColumnHeader.Text = "Date";
            recentDateColumnHeader.Width = 150;
            // 
            // recentAmountColumnHeader
            // 
            recentAmountColumnHeader.Text = "Amount";
            recentAmountColumnHeader.TextAlign = HorizontalAlignment.Right;
            recentAmountColumnHeader.Width = 150;
            // 
            // recentCategoryColumnHeader
            // 
            recentCategoryColumnHeader.Text = "Category";
            recentCategoryColumnHeader.Width = 200;
            // 
            // recentDescriptionColumnHeader
            // 
            recentDescriptionColumnHeader.Text = "Description";
            recentDescriptionColumnHeader.Width = 300;
            // 
            // MainUi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 658);
            Controls.Add(recentTransactionsGroupBox);
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
            recentTransactionsGroupBox.ResumeLayout(false);
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
        private GroupBox recentTransactionsGroupBox;
        private ListView recentTransactionsListView;
        private ColumnHeader recentDateColumnHeader;
        private ColumnHeader recentAmountColumnHeader;
        private ColumnHeader recentCategoryColumnHeader;
        private ColumnHeader recentDescriptionColumnHeader;
        private ToolTip recentTransactionsToolTip;
    }
}