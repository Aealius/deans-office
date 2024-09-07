namespace WinFormsApp.Views
{
    partial class StudentForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            StudentNameTextBox = new TextBox();
            StudentSurnameTextBox = new TextBox();
            StudentLastNameTextBox = new TextBox();
            BirthYearDateTimePicker = new DateTimePicker();
            AddressTextBox = new TextBox();
            RecBookTextBox = new TextBox();
            SaveStudentButton = new Button();
            StudentGroupComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 13);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 46);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 79);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 3;
            label4.Text = "Дата рождения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 146);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Адрес";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 209);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Номер з/к";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 242);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Группа";
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(134, 6);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(154, 27);
            StudentNameTextBox.TabIndex = 7;
            // 
            // StudentSurnameTextBox
            // 
            StudentSurnameTextBox.Location = new Point(134, 39);
            StudentSurnameTextBox.Name = "StudentSurnameTextBox";
            StudentSurnameTextBox.Size = new Size(154, 27);
            StudentSurnameTextBox.TabIndex = 8;
            // 
            // StudentLastNameTextBox
            // 
            StudentLastNameTextBox.Location = new Point(134, 72);
            StudentLastNameTextBox.Name = "StudentLastNameTextBox";
            StudentLastNameTextBox.Size = new Size(154, 27);
            StudentLastNameTextBox.TabIndex = 9;
            // 
            // BirthYearDateTimePicker
            // 
            BirthYearDateTimePicker.Location = new Point(134, 105);
            BirthYearDateTimePicker.Name = "BirthYearDateTimePicker";
            BirthYearDateTimePicker.Size = new Size(154, 27);
            BirthYearDateTimePicker.TabIndex = 10;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(134, 138);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(154, 58);
            AddressTextBox.TabIndex = 11;
            // 
            // RecBookTextBox
            // 
            RecBookTextBox.Location = new Point(134, 202);
            RecBookTextBox.Name = "RecBookTextBox";
            RecBookTextBox.Size = new Size(154, 27);
            RecBookTextBox.TabIndex = 12;
            // 
            // SaveStudentButton
            // 
            SaveStudentButton.Location = new Point(155, 278);
            SaveStudentButton.Name = "SaveStudentButton";
            SaveStudentButton.Size = new Size(94, 29);
            SaveStudentButton.TabIndex = 14;
            SaveStudentButton.Text = "Сохранить";
            SaveStudentButton.UseVisualStyleBackColor = true;
            SaveStudentButton.Click += SaveStudentButton_Click;
            // 
            // StudentGroupComboBox
            // 
            StudentGroupComboBox.FormattingEnabled = true;
            StudentGroupComboBox.Location = new Point(134, 239);
            StudentGroupComboBox.Name = "StudentGroupComboBox";
            StudentGroupComboBox.Size = new Size(154, 28);
            StudentGroupComboBox.TabIndex = 15;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 330);
            Controls.Add(StudentGroupComboBox);
            Controls.Add(SaveStudentButton);
            Controls.Add(RecBookTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(BirthYearDateTimePicker);
            Controls.Add(StudentLastNameTextBox);
            Controls.Add(StudentSurnameTextBox);
            Controls.Add(StudentNameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "Форма \"Студент\"";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox StudentNameTextBox;
        private TextBox StudentSurnameTextBox;
        private TextBox StudentLastNameTextBox;
        private DateTimePicker BirthYearDateTimePicker;
        private TextBox AddressTextBox;
        private TextBox RecBookTextBox;
        private Button SaveStudentButton;
        private ComboBox StudentGroupComboBox;
    }
}