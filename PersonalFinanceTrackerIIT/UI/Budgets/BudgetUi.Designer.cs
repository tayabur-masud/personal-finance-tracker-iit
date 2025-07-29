namespace PersonalFinanceTrackerIIT.UI.Budgets;

partial class BudgetUi
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetUi));
        budgetFormGroupBox = new GroupBox();
        resetButton = new Button();
        saveButton = new Button();
        amountLabel = new Label();
        amountTextBox = new TextBox();
        categoryLabel = new Label();
        categoryComboBox = new ComboBox();
        monthLabel = new Label();
        monthComboBox = new ComboBox();
        budgetListGroupBox = new GroupBox();
        budgetListView = new ListView();
        monthColumnHeader = new ColumnHeader();
        categoryColumnHeader = new ColumnHeader();
        amountColumnHeader = new ColumnHeader();
        budgetContextMenuStrip = new ContextMenuStrip(components);
        editToolStripMenuItem = new ToolStripMenuItem();
        deleteToolStripMenuItem = new ToolStripMenuItem();
        budgetFormGroupBox.SuspendLayout();
        budgetListGroupBox.SuspendLayout();
        budgetContextMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // budgetFormGroupBox
        // 
        budgetFormGroupBox.Anchor = AnchorStyles.Top;
        budgetFormGroupBox.Controls.Add(resetButton);
        budgetFormGroupBox.Controls.Add(saveButton);
        budgetFormGroupBox.Controls.Add(amountLabel);
        budgetFormGroupBox.Controls.Add(amountTextBox);
        budgetFormGroupBox.Controls.Add(categoryLabel);
        budgetFormGroupBox.Controls.Add(categoryComboBox);
        budgetFormGroupBox.Controls.Add(monthLabel);
        budgetFormGroupBox.Controls.Add(monthComboBox);
        budgetFormGroupBox.Location = new Point(13, 13);
        budgetFormGroupBox.Name = "budgetFormGroupBox";
        budgetFormGroupBox.Size = new Size(875, 263);
        budgetFormGroupBox.TabIndex = 0;
        budgetFormGroupBox.TabStop = false;
        budgetFormGroupBox.Text = "Budget Form";
        // 
        // resetButton
        // 
        resetButton.Location = new Point(437, 193);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(112, 34);
        resetButton.TabIndex = 7;
        resetButton.Text = "Reset";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(555, 193);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(112, 34);
        saveButton.TabIndex = 6;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // amountLabel
        // 
        amountLabel.AutoSize = true;
        amountLabel.Location = new Point(189, 150);
        amountLabel.Name = "amountLabel";
        amountLabel.Size = new Size(123, 25);
        amountLabel.TabIndex = 5;
        amountLabel.Text = "Amount (BDT)";
        // 
        // amountTextBox
        // 
        amountTextBox.Location = new Point(331, 147);
        amountTextBox.MaxLength = 10;
        amountTextBox.Name = "amountTextBox";
        amountTextBox.Size = new Size(336, 31);
        amountTextBox.TabIndex = 4;
        amountTextBox.KeyPress += amountTextBox_KeyPress;
        // 
        // categoryLabel
        // 
        categoryLabel.AutoSize = true;
        categoryLabel.Location = new Point(189, 100);
        categoryLabel.Name = "categoryLabel";
        categoryLabel.Size = new Size(84, 25);
        categoryLabel.TabIndex = 3;
        categoryLabel.Text = "Category";
        // 
        // categoryComboBox
        // 
        categoryComboBox.FormattingEnabled = true;
        categoryComboBox.Location = new Point(331, 97);
        categoryComboBox.Name = "categoryComboBox";
        categoryComboBox.Size = new Size(336, 33);
        categoryComboBox.TabIndex = 2;
        // 
        // monthLabel
        // 
        monthLabel.AutoSize = true;
        monthLabel.Location = new Point(189, 52);
        monthLabel.Name = "monthLabel";
        monthLabel.Size = new Size(65, 25);
        monthLabel.TabIndex = 1;
        monthLabel.Text = "Month";
        // 
        // monthComboBox
        // 
        monthComboBox.FormattingEnabled = true;
        monthComboBox.Location = new Point(331, 49);
        monthComboBox.Name = "monthComboBox";
        monthComboBox.Size = new Size(336, 33);
        monthComboBox.TabIndex = 0;
        monthComboBox.SelectionChangeCommitted += monthComboBox_SelectionChangeCommitted;
        // 
        // budgetListGroupBox
        // 
        budgetListGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        budgetListGroupBox.Controls.Add(budgetListView);
        budgetListGroupBox.Location = new Point(13, 282);
        budgetListGroupBox.Name = "budgetListGroupBox";
        budgetListGroupBox.Size = new Size(875, 283);
        budgetListGroupBox.TabIndex = 1;
        budgetListGroupBox.TabStop = false;
        budgetListGroupBox.Text = "Budget List";
        // 
        // budgetListView
        // 
        budgetListView.Columns.AddRange(new ColumnHeader[] { monthColumnHeader, categoryColumnHeader, amountColumnHeader });
        budgetListView.Dock = DockStyle.Fill;
        budgetListView.FullRowSelect = true;
        budgetListView.GridLines = true;
        budgetListView.Location = new Point(3, 27);
        budgetListView.Name = "budgetListView";
        budgetListView.Size = new Size(869, 253);
        budgetListView.TabIndex = 0;
        budgetListView.UseCompatibleStateImageBehavior = false;
        budgetListView.View = View.Details;
        // 
        // monthColumnHeader
        // 
        monthColumnHeader.Text = "Month";
        monthColumnHeader.Width = 200;
        // 
        // categoryColumnHeader
        // 
        categoryColumnHeader.Text = "Category";
        categoryColumnHeader.Width = 200;
        // 
        // amountColumnHeader
        // 
        amountColumnHeader.Text = "Amount (BDT)";
        amountColumnHeader.TextAlign = HorizontalAlignment.Right;
        amountColumnHeader.Width = 200;
        // 
        // budgetContextMenuStrip
        // 
        budgetContextMenuStrip.ImageScalingSize = new Size(24, 24);
        budgetContextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
        budgetContextMenuStrip.Name = "budgetContextMenuStrip";
        budgetContextMenuStrip.Size = new Size(135, 68);
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
        // BudgetUi
        // 
        AcceptButton = saveButton;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 579);
        Controls.Add(budgetListGroupBox);
        Controls.Add(budgetFormGroupBox);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "BudgetUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Budget";
        FormClosed += BudgetUi_FormClosed;
        Load += BudgetUi_Load;
        budgetFormGroupBox.ResumeLayout(false);
        budgetFormGroupBox.PerformLayout();
        budgetListGroupBox.ResumeLayout(false);
        budgetContextMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private GroupBox budgetFormGroupBox;
    private Label monthLabel;
    private ComboBox monthComboBox;
    private Label categoryLabel;
    private ComboBox categoryComboBox;
    private Button resetButton;
    private Button saveButton;
    private Label amountLabel;
    private TextBox amountTextBox;
    private GroupBox budgetListGroupBox;
    private ListView budgetListView;
    private ColumnHeader monthColumnHeader;
    private ColumnHeader categoryColumnHeader;
    private ColumnHeader amountColumnHeader;
    private ContextMenuStrip budgetContextMenuStrip;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem deleteToolStripMenuItem;
}