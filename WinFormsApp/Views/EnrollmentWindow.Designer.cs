using WinFormsApp.DeansOfficeData;

namespace WinFormsApp.Views
{
    partial class EnrollmentsWindow
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
            MinusEnrollmentButton = new Button();
            PlusEnrollmentButton = new Button();
            StudentStatusesListView = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // MinusEnrollmentButton
            // 
            MinusEnrollmentButton.Location = new Point(370, 130);
            MinusEnrollmentButton.Name = "MinusEnrollmentButton";
            MinusEnrollmentButton.Size = new Size(42, 41);
            MinusEnrollmentButton.TabIndex = 13;
            MinusEnrollmentButton.Text = "-";
            MinusEnrollmentButton.UseVisualStyleBackColor = true;
            MinusEnrollmentButton.Click += MinusEnrollmentButton_Click;
            // 
            // PlusEnrollmentButton
            // 
            PlusEnrollmentButton.Location = new Point(370, 83);
            PlusEnrollmentButton.Name = "PlusEnrollmentButton";
            PlusEnrollmentButton.Size = new Size(42, 41);
            PlusEnrollmentButton.TabIndex = 12;
            PlusEnrollmentButton.Text = "+";
            PlusEnrollmentButton.UseVisualStyleBackColor = true;
            PlusEnrollmentButton.Click += PlusEnrollmentButton_Click;
            // 
            // StudentStatusesListView
            // 
            StudentStatusesListView.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1 });
            StudentStatusesListView.FullRowSelect = true;
            StudentStatusesListView.GridLines = true;
            StudentStatusesListView.Location = new Point(12, 83);
            StudentStatusesListView.Name = "StudentStatusesListView";
            StudentStatusesListView.Size = new Size(352, 168);
            StudentStatusesListView.TabIndex = 11;
            StudentStatusesListView.UseCompatibleStateImageBehavior = false;
            StudentStatusesListView.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Дата";
            columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Статус";
            columnHeader1.Width = 250;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 41);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 10;
            label4.Text = "Группа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "Группа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 12);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 8;
            label2.Text = "Фамилия Имя Отчество";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 7;
            label1.Text = "Студент:";
            // 
            // EnrollmentsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 290);
            Controls.Add(MinusEnrollmentButton);
            Controls.Add(PlusEnrollmentButton);
            Controls.Add(StudentStatusesListView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnrollmentsWindow";
            Text = "Статусы студента:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MinusEnrollmentButton;
        private Button PlusEnrollmentButton;
        private ListView StudentStatusesListView;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}