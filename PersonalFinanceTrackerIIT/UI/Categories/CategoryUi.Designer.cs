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
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.Anchor = AnchorStyles.None;
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(249, 77);
        nameLabel.Margin = new Padding(4, 0, 4, 0);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(59, 25);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Name";
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.None;
        nameTextBox.Location = new Point(421, 73);
        nameTextBox.Margin = new Padding(4);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(336, 31);
        nameTextBox.TabIndex = 1;
        // 
        // descriptionRichTextBox
        // 
        descriptionRichTextBox.Anchor = AnchorStyles.None;
        descriptionRichTextBox.Location = new Point(421, 114);
        descriptionRichTextBox.Margin = new Padding(4);
        descriptionRichTextBox.Name = "descriptionRichTextBox";
        descriptionRichTextBox.Size = new Size(336, 149);
        descriptionRichTextBox.TabIndex = 2;
        descriptionRichTextBox.Text = "";
        // 
        // descriptionLabel
        // 
        descriptionLabel.Anchor = AnchorStyles.None;
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(249, 118);
        descriptionLabel.Margin = new Padding(4, 0, 4, 0);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(102, 25);
        descriptionLabel.TabIndex = 3;
        descriptionLabel.Text = "Description";
        // 
        // saveButton
        // 
        saveButton.Anchor = AnchorStyles.None;
        saveButton.Location = new Point(641, 272);
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
        categoryListView.Columns.AddRange(new ColumnHeader[] { nameColumnHeader, descriptionColumnHeader });
        categoryListView.Location = new Point(20, 339);
        categoryListView.Name = "categoryListView";
        categoryListView.Size = new Size(992, 293);
        categoryListView.TabIndex = 5;
        categoryListView.UseCompatibleStateImageBehavior = false;
        categoryListView.View = View.Details;
        // 
        // nameColumnHeader
        // 
        nameColumnHeader.Text = "Name";
        nameColumnHeader.Width = 300;
        // 
        // descriptionColumnHeader
        // 
        descriptionColumnHeader.Text = "Description";
        descriptionColumnHeader.Width = 600;
        // 
        // resetButton
        // 
        resetButton.Anchor = AnchorStyles.None;
        resetButton.Location = new Point(515, 272);
        resetButton.Margin = new Padding(4);
        resetButton.Name = "resetButton";
        resetButton.Size = new Size(118, 36);
        resetButton.TabIndex = 6;
        resetButton.Text = "Reset";
        resetButton.UseVisualStyleBackColor = true;
        resetButton.Click += resetButton_Click;
        // 
        // CategoryUi
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 748);
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
}