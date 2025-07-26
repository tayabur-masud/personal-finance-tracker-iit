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
        nameLabel = new Label();
        nameTextBox = new TextBox();
        descriptionRichTextBox = new RichTextBox();
        descriptionLabel = new Label();
        saveButton = new Button();
        categoryListView = new ListView();
        nameColumnHeader = new ColumnHeader();
        descriptionColumnHeader = new ColumnHeader();
        resetButton = new Button();
        incomeRadioButton = new RadioButton();
        expenseRadioButton = new RadioButton();
        typeColumnHeader = new ColumnHeader();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.Anchor = AnchorStyles.None;
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(199, 62);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(49, 20);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Name";
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.None;
        nameTextBox.Location = new Point(337, 58);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(270, 27);
        nameTextBox.TabIndex = 1;
        // 
        // descriptionRichTextBox
        // 
        descriptionRichTextBox.Anchor = AnchorStyles.None;
        descriptionRichTextBox.Location = new Point(337, 100);
        descriptionRichTextBox.Name = "descriptionRichTextBox";
        descriptionRichTextBox.Size = new Size(270, 120);
        descriptionRichTextBox.TabIndex = 2;
        descriptionRichTextBox.Text = "";
        // 
        // descriptionLabel
        // 
        descriptionLabel.Anchor = AnchorStyles.None;
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(199, 103);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(85, 20);
        descriptionLabel.TabIndex = 3;
        descriptionLabel.Text = "Description";
        // 
        // saveButton
        // 
        saveButton.Anchor = AnchorStyles.None;
        saveButton.Location = new Point(513, 227);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(94, 29);
        saveButton.TabIndex = 4;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // categoryListView
        // 
        categoryListView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        categoryListView.Columns.AddRange(new ColumnHeader[] { typeColumnHeader, nameColumnHeader, descriptionColumnHeader });
        categoryListView.FullRowSelect = true;
        categoryListView.GridLines = true;
        categoryListView.Location = new Point(16, 271);
        categoryListView.Margin = new Padding(2);
        categoryListView.Name = "categoryListView";
        categoryListView.Size = new Size(794, 235);
        categoryListView.TabIndex = 5;
        categoryListView.UseCompatibleStateImageBehavior = false;
        categoryListView.View = View.Details;
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
        // resetButton
        // 
        resetButton.Anchor = AnchorStyles.None;
        resetButton.Location = new Point(412, 227);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(94, 29);
        resetButton.TabIndex = 6;
        resetButton.Text = "Reset";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // incomeRadioButton
        // 
        incomeRadioButton.AutoSize = true;
        incomeRadioButton.Location = new Point(337, 28);
        incomeRadioButton.Name = "incomeRadioButton";
        incomeRadioButton.Size = new Size(79, 24);
        incomeRadioButton.TabIndex = 7;
        incomeRadioButton.TabStop = true;
        incomeRadioButton.Text = "Income";
        incomeRadioButton.UseVisualStyleBackColor = true;
        // 
        // expenseRadioButton
        // 
        expenseRadioButton.AutoSize = true;
        expenseRadioButton.Location = new Point(490, 28);
        expenseRadioButton.Name = "expenseRadioButton";
        expenseRadioButton.Size = new Size(84, 24);
        expenseRadioButton.TabIndex = 8;
        expenseRadioButton.TabStop = true;
        expenseRadioButton.Text = "Expense";
        expenseRadioButton.UseVisualStyleBackColor = true;
        // 
        // typeColumnHeader
        // 
        typeColumnHeader.Text = "Type";
        typeColumnHeader.Width = 100;
        // 
        // CategoryUi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(819, 598);
        Controls.Add(expenseRadioButton);
        Controls.Add(incomeRadioButton);
        Controls.Add(resetButton);
        Controls.Add(categoryListView);
        Controls.Add(saveButton);
        Controls.Add(descriptionLabel);
        Controls.Add(descriptionRichTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(nameLabel);
        Name = "CategoryUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Category";
        Load += CategoryUi_Load;
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
}