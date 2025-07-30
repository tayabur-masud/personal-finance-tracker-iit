namespace PersonalFinanceTrackerIIT.UI.Transactions
{
    partial class ExpenseUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseUi));
            groupBox1 = new GroupBox();
            resetButton = new Button();
            label4 = new Label();
            saveButton = new Button();
            descriptionRichTextBox = new RichTextBox();
            label3 = new Label();
            categoryComboBox = new ComboBox();
            amountTextBox = new TextBox();
            label2 = new Label();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            expenseHistoryGroupBox = new GroupBox();
            expenseListView = new ListView();
            dateColumnHeader = new ColumnHeader();
            amountColumnHeader = new ColumnHeader();
            categoryColumnHeader = new ColumnHeader();
            descriptionColumnHeader = new ColumnHeader();
            expenseContextMenuStrip = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            expenseHistoryGroupBox.SuspendLayout();
            expenseContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(resetButton);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(descriptionRichTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(categoryComboBox);
            groupBox1.Controls.Add(amountTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(932, 519);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense";
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Top;
            resetButton.Location = new Point(395, 339);
            resetButton.Margin = new Padding(4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(118, 36);
            resetButton.TabIndex = 10;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(163, 185);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 8;
            label4.Text = "Description";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top;
            saveButton.Location = new Point(521, 339);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(118, 36);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Anchor = AnchorStyles.Top;
            descriptionRichTextBox.Location = new Point(326, 182);
            descriptionRichTextBox.Margin = new Padding(4);
            descriptionRichTextBox.MaxLength = 500;
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(312, 149);
            descriptionRichTextBox.TabIndex = 6;
            descriptionRichTextBox.Text = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(163, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(326, 131);
            categoryComboBox.Margin = new Padding(4);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(312, 33);
            categoryComboBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            amountTextBox.Anchor = AnchorStyles.Top;
            amountTextBox.Location = new Point(326, 77);
            amountTextBox.Margin = new Padding(4);
            amountTextBox.MaxLength = 10;
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(312, 31);
            amountTextBox.TabIndex = 3;
            amountTextBox.KeyPress += amountTextBox_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(163, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount (BDT)";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top;
            dateTimePicker.Location = new Point(326, 31);
            dateTimePicker.Margin = new Padding(4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(312, 31);
            dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(163, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // expenseHistoryGroupBox
            // 
            expenseHistoryGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            expenseHistoryGroupBox.Controls.Add(expenseListView);
            expenseHistoryGroupBox.Location = new Point(15, 413);
            expenseHistoryGroupBox.Name = "expenseHistoryGroupBox";
            expenseHistoryGroupBox.Size = new Size(932, 322);
            expenseHistoryGroupBox.TabIndex = 2;
            expenseHistoryGroupBox.TabStop = false;
            expenseHistoryGroupBox.Text = "Expense History";
            // 
            // expenseListView
            // 
            expenseListView.Columns.AddRange(new ColumnHeader[] { dateColumnHeader, amountColumnHeader, categoryColumnHeader, descriptionColumnHeader });
            expenseListView.ContextMenuStrip = expenseContextMenuStrip;
            expenseListView.Dock = DockStyle.Fill;
            expenseListView.FullRowSelect = true;
            expenseListView.GridLines = true;
            expenseListView.Location = new Point(3, 27);
            expenseListView.Name = "expenseListView";
            expenseListView.Size = new Size(926, 292);
            expenseListView.TabIndex = 0;
            expenseListView.UseCompatibleStateImageBehavior = false;
            expenseListView.View = View.Details;
            // 
            // dateColumnHeader
            // 
            dateColumnHeader.Text = "Date";
            dateColumnHeader.Width = 200;
            // 
            // amountColumnHeader
            // 
            amountColumnHeader.Text = "Amount (BDT)";
            amountColumnHeader.TextAlign = HorizontalAlignment.Right;
            amountColumnHeader.Width = 200;
            // 
            // categoryColumnHeader
            // 
            categoryColumnHeader.Text = "Category";
            categoryColumnHeader.Width = 200;
            // 
            // descriptionColumnHeader
            // 
            descriptionColumnHeader.Text = "Description";
            descriptionColumnHeader.Width = 300;
            // 
            // expenseContextMenuStrip
            // 
            expenseContextMenuStrip.ImageScalingSize = new Size(24, 24);
            expenseContextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            expenseContextMenuStrip.Name = "incomeContextMenuStrip";
            expenseContextMenuStrip.Size = new Size(135, 68);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(134, 32);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(134, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // ExpenseUi
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 747);
            Controls.Add(expenseHistoryGroupBox);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "ExpenseUi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense";
            WindowState = FormWindowState.Maximized;
            FormClosing += ExpenseUi_FormClosing;
            Load += ExpenseUi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            expenseHistoryGroupBox.ResumeLayout(false);
            expenseContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Button saveButton;
        private RichTextBox descriptionRichTextBox;
        private Label label3;
        private ComboBox categoryComboBox;
        private TextBox amountTextBox;
        private Label label2;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private Button resetButton;
        private GroupBox expenseHistoryGroupBox;
        private ListView expenseListView;
        private ColumnHeader dateColumnHeader;
        private ColumnHeader amountColumnHeader;
        private ColumnHeader categoryColumnHeader;
        private ColumnHeader descriptionColumnHeader;
        private ContextMenuStrip expenseContextMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}