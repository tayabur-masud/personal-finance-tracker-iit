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
            groupBox1 = new GroupBox();
            label4 = new Label();
            saveButton = new Button();
            descriptionRichTextBox = new RichTextBox();
            label3 = new Label();
            categoryComboBox = new ComboBox();
            amountTextBox = new TextBox();
            label2 = new Label();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox1.Size = new Size(834, 510);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 8;
            label4.Text = "Description";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(489, 386);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(118, 36);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(294, 229);
            descriptionRichTextBox.Margin = new Padding(4);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(312, 149);
            descriptionRichTextBox.TabIndex = 6;
            descriptionRichTextBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 182);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(294, 178);
            categoryComboBox.Margin = new Padding(4);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(312, 33);
            categoryComboBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(294, 124);
            amountTextBox.Margin = new Padding(4);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(312, 31);
            amountTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(294, 78);
            dateTimePicker.Margin = new Padding(4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(312, 31);
            dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // ExpenseUi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 540);
            Controls.Add(groupBox1);
            Name = "ExpenseUi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense";
            Load += ExpenseUi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}