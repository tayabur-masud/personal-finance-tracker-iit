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
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.Anchor = AnchorStyles.None;
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(62, 51);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(49, 20);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Name";
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.None;
        nameTextBox.Location = new Point(200, 48);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(270, 27);
        nameTextBox.TabIndex = 1;
        // 
        // descriptionRichTextBox
        // 
        descriptionRichTextBox.Anchor = AnchorStyles.None;
        descriptionRichTextBox.Location = new Point(200, 81);
        descriptionRichTextBox.Name = "descriptionRichTextBox";
        descriptionRichTextBox.Size = new Size(270, 120);
        descriptionRichTextBox.TabIndex = 2;
        descriptionRichTextBox.Text = "";
        // 
        // descriptionLabel
        // 
        descriptionLabel.Anchor = AnchorStyles.None;
        descriptionLabel.AutoSize = true;
        descriptionLabel.Location = new Point(62, 84);
        descriptionLabel.Name = "descriptionLabel";
        descriptionLabel.Size = new Size(85, 20);
        descriptionLabel.TabIndex = 3;
        descriptionLabel.Text = "Description";
        // 
        // saveButton
        // 
        saveButton.Anchor = AnchorStyles.None;
        saveButton.Location = new Point(376, 207);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(94, 29);
        saveButton.TabIndex = 4;
        saveButton.Text = "Save";
        saveButton.UseVisualStyleBackColor = true;
        // 
        // CategoryUi
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(550, 288);
        Controls.Add(saveButton);
        Controls.Add(descriptionLabel);
        Controls.Add(descriptionRichTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(nameLabel);
        Name = "CategoryUi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Category";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private TextBox nameTextBox;
    private RichTextBox descriptionRichTextBox;
    private Label descriptionLabel;
    private Button saveButton;
}