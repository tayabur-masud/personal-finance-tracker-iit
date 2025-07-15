namespace PersonalFinanceTrackerIIT.UI.Transactions
{
    partial class IncomeUi
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
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            amountTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            label3 = new Label();
            descriptionRichTextBox = new RichTextBox();
            saveButton = new Button();
            label4 = new Label();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Income";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 67);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(235, 62);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 102);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(235, 99);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(250, 27);
            amountTextBox.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(235, 142);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(250, 28);
            categoryComboBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 145);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(235, 183);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(250, 120);
            descriptionRichTextBox.TabIndex = 6;
            descriptionRichTextBox.Text = "";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(391, 309);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 186);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "Description";
            // 
            // IncomeUi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 432);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "IncomeUi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income";
            Load += IncomeUi_Load;
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