namespace WinFormsApp.Views
{
    partial class GroupForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SpecialityTextBox = new TextBox();
            GroupNameTextBox = new TextBox();
            SaveGroupButton = new Button();
            yearComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя группы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Специальность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Год создания";
            // 
            // SpecialityTextBox
            // 
            SpecialityTextBox.Location = new Point(148, 66);
            SpecialityTextBox.Name = "SpecialityTextBox";
            SpecialityTextBox.Size = new Size(220, 27);
            SpecialityTextBox.TabIndex = 4;
            // 
            // GroupNameTextBox
            // 
            GroupNameTextBox.Location = new Point(148, 18);
            GroupNameTextBox.Name = "GroupNameTextBox";
            GroupNameTextBox.Size = new Size(220, 27);
            GroupNameTextBox.TabIndex = 5;
            // 
            // SaveGroupButton
            // 
            SaveGroupButton.Location = new Point(131, 169);
            SaveGroupButton.Name = "SaveGroupButton";
            SaveGroupButton.Size = new Size(115, 39);
            SaveGroupButton.TabIndex = 6;
            SaveGroupButton.Text = "Сохранить";
            SaveGroupButton.UseVisualStyleBackColor = true;
            SaveGroupButton.Click += SaveGroupButton_Click;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(148, 112);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(103, 28);
            yearComboBox.TabIndex = 7;
            // 
            // GroupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 220);
            Controls.Add(yearComboBox);
            Controls.Add(SaveGroupButton);
            Controls.Add(GroupNameTextBox);
            Controls.Add(SpecialityTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GroupForm";
            Text = "Форма \"Группа\"";
            Load += GroupForm_OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox SpecialityTextBox;
        private TextBox GroupNameTextBox;
        private Button SaveGroupButton;
        private ComboBox yearComboBox;
    }
}