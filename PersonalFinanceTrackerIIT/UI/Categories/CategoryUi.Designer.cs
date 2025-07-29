namespace PersonalFinanceTrackerIIT.UI.Categories;

partial class CategoryUi
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
        nameLabel = new Label();
        nameTextBox = new TextBox();
        descriptionRichTextBox = new RichTextBox();
        descriptionLabel = new Label();
        saveButton = new Button();
        categoryListView = new ListView();
        typeColumnHeader = new ColumnHeader();
        nameColumnHeader = new ColumnHeader();
        descriptionColumnHeader = new ColumnHeader();
        categoryContextMenuStrip = new ContextMenuStrip(components);
        editToolStripMenuItem = new ToolStripMenuItem();
        deleteToolStripMenuItem = new ToolStripMenuItem();
        resetButton = new Button();
        incomeRadioButton = new RadioButton();
        expenseRadioButton = new RadioButton();
        categoryContextMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.Anchor = AnchorStyles.Top;
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(249, 78);
        nameLabel.Margin = new Padding(4, 0, 4, 0);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(59, 25);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Name";
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.Top;
        nameTextBox.Location = new Point(421, 72);
        nameTextBox.Margin = new Padding(4);
        nameTextBox.MaxLength = 200;
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(336, 31);
        nameTextBox.TabIndex = 1;
        // 
        // descriptionRichTextBox
        // 
        descriptionRichTextBox.Anchor = AnchorStyles.Top;
        descriptionRichTextBox.Location = new Point(421, 125);
        descriptionRichTextBox.Margin = new Padding(4);
        descriptionRichTextBox.MaxLength = 500;
        descriptionRichTextBox.Name = "descriptionRichTextBox";
        descriptionRichTextBox.Size = new Size(336, 149);
        descriptionRichTextBox.TabIndex = 2;
        descriptionRichTextBox.Text = "";
        // 
        // descriptionLabel
        // 
        descriptionLabel.Anchor = AnchorStyles.Top;
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(249, 129);
        descriptionLabel.Margin = new Padding(4, 0, 4, 0);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(102, 25);
        descriptionLabel.TabIndex = 3;
        descriptionLabel.Text = "Description";
        // 
        // saveButton
        // 
        saveButton.Anchor = AnchorStyles.Top;
        saveButton.Location = new Point(641, 284);
        saveButton.Margin = new Padding(4);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(118, 36);
        saveButton.TabIndex = 4;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // categoryListView
        // 
        categoryListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        categoryListView.Columns.AddRange(new ColumnHeader[] { typeColumnHeader, nameColumnHeader, descriptionColumnHeader });
        categoryListView.ContextMenuStrip = categoryContextMenuStrip;
        categoryListView.FullRowSelect = true;
        categoryListView.GridLines = true;
        categoryListView.Location = new Point(20, 339);
        categoryListView.Margin = new Padding(2);
        categoryListView.Name = "categoryListView";
        categoryListView.Size = new Size(992, 293);
        categoryListView.TabIndex = 5;
        categoryListView.UseCompatibleStateImageBehavior = false;
        categoryListView.View = View.Details;
        // 
        // typeColumnHeader
        // 
        typeColumnHeader.Text = "Type";
        typeColumnHeader.Width = 100;
        // 
        // nameColumnHeader
        // 
        nameColumnHeader.Text = "Name";
        nameColumnHeader.Width = 200;
        // 
        // descriptionColumnHeader
        // 
        descriptionColumnHeader.Text = "Description";
        descriptionColumnHeader.Width = 500;
        // 
        // categoryContextMenuStrip
        // 
        categoryContextMenuStrip.ImageScalingSize = new Size(24, 24);
        categoryContextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
        categoryContextMenuStrip.Name = "categoryContextMenuStrip";
        categoryContextMenuStrip.Size = new Size(135, 68);
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
        // resetButton
        // 
        resetButton.Anchor = AnchorStyles.Top;
        resetButton.Location = new Point(515, 284);
        resetButton.Margin = new Padding(4);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(118, 36);
        resetButton.TabIndex = 6;
        resetButton.Text = "Reset";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // incomeRadioButton
        // 
        incomeRadioButton.Anchor = AnchorStyles.Top;
        incomeRadioButton.AutoSize = true;
        incomeRadioButton.Location = new Point(421, 35);
        incomeRadioButton.Margin = new Padding(4);
        incomeRadioButton.Name = "incomeRadioButton";
        incomeRadioButton.Size = new Size(96, 29);
        incomeRadioButton.TabIndex = 7;
        incomeRadioButton.TabStop = true;
        incomeRadioButton.Text = "Income";
        incomeRadioButton.UseVisualStyleBackColor = true;
        // 
        // expenseRadioButton
        // 
        expenseRadioButton.Anchor = AnchorStyles.Top;
        expenseRadioButton.AutoSize = true;
        expenseRadioButton.Location = new Point(612, 35);
        expenseRadioButton.Margin = new Padding(4);
        expenseRadioButton.Name = "expenseRadioButton";
        expenseRadioButton.Size = new Size(101, 29);
        expenseRadioButton.TabIndex = 8;
        expenseRadioButton.TabStop = true;
        expenseRadioButton.Text = "Expense";
        expenseRadioButton.UseVisualStyleBackColor = true;
        // 
        // CategoryUi
        // 
        AcceptButton = saveButton;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 748);
        Controls.Add(expenseRadioButton);
        Controls.Add(incomeRadioButton);
        Controls.Add(resetButton);
        Controls.Add(categoryListView);
        Controls.Add(saveButton);
        Controls.Add(descriptionLabel);
        Controls.Add(descriptionRichTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(nameLabel);
        Margin = new Padding(4);
        Name = "CategoryUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Category";
        FormClosed += CategoryUi_FormClosed;
        Load += CategoryUi_Load;
        categoryContextMenuStrip.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private TextBox nameTextBox;
    private RichTextBox descriptionRichTextBox;
    private Label descriptionLabel;
    private Button saveButton;
    private ListView categoryListView;
    private ColumnHeader nameColumnHeader;
    private ColumnHeader descriptionColumnHeader;
    private Button resetButton;
    private RadioButton incomeRadioButton;
    private RadioButton expenseRadioButton;
    private ColumnHeader typeColumnHeader;
    private ContextMenuStrip categoryContextMenuStrip;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem deleteToolStripMenuItem;
}