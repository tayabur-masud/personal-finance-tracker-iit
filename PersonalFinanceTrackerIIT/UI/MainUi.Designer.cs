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
            expenseTrendGroupBox = new GroupBox();
            expenseTrendLineChartPanel = new Panel();
            refreshButton = new Button();
            mainMenuStrip.SuspendLayout();
            recentTransactionsGroupBox.SuspendLayout();
            expenseTrendGroupBox.SuspendLayout();
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
            label1.Location = new Point(1123, 573);
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
            currentBalanceLabel.Location = new Point(12, 44);
            currentBalanceLabel.Name = "currentBalanceLabel";
            currentBalanceLabel.Size = new Size(196, 31);
            currentBalanceLabel.TabIndex = 3;
            currentBalanceLabel.Text = "Current Balance: ";
            // 
            // recentTransactionsGroupBox
            // 
            recentTransactionsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            recentTransactionsGroupBox.Controls.Add(recentTransactionsListView);
            recentTransactionsGroupBox.Location = new Point(628, 78);
            recentTransactionsGroupBox.Margin = new Padding(2);
            recentTransactionsGroupBox.Name = "recentTransactionsGroupBox";
            recentTransactionsGroupBox.Padding = new Padding(2);
            recentTransactionsGroupBox.Size = new Size(650, 374);
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
            recentTransactionsListView.Location = new Point(2, 22);
            recentTransactionsListView.Margin = new Padding(2);
            recentTransactionsListView.Name = "recentTransactionsListView";
            recentTransactionsListView.Size = new Size(646, 350);
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
            // expenseTrendGroupBox
            // 
            expenseTrendGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            expenseTrendGroupBox.Controls.Add(expenseTrendLineChartPanel);
            expenseTrendGroupBox.Location = new Point(10, 78);
            expenseTrendGroupBox.Margin = new Padding(2);
            expenseTrendGroupBox.Name = "expenseTrendGroupBox";
            expenseTrendGroupBox.Padding = new Padding(2);
            expenseTrendGroupBox.Size = new Size(614, 374);
            expenseTrendGroupBox.TabIndex = 5;
            expenseTrendGroupBox.TabStop = false;
            expenseTrendGroupBox.Text = "Expense Trend";
            // 
            // expenseTrendLineChartPanel
            // 
            expenseTrendLineChartPanel.Dock = DockStyle.Fill;
            expenseTrendLineChartPanel.Location = new Point(2, 22);
            expenseTrendLineChartPanel.Margin = new Padding(2);
            expenseTrendLineChartPanel.Name = "expenseTrendLineChartPanel";
            expenseTrendLineChartPanel.Size = new Size(610, 350);
            expenseTrendLineChartPanel.TabIndex = 0;
            // 
            // refreshButton
            // 
            refreshButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.Location = new Point(1125, 33);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(153, 52);
            refreshButton.TabIndex = 6;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // MainUi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 660);
            Controls.Add(refreshButton);
            Controls.Add(expenseTrendGroupBox);
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
            expenseTrendGroupBox.ResumeLayout(false);
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
        private GroupBox expenseTrendGroupBox;
        private Panel expenseTrendLineChartPanel;
        private Button refreshButton;
    }
}