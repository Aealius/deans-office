namespace WinFormsApp.Views
{
    partial class PassWindow
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
            StudentPassesListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            PlusPassButton = new Button();
            MinusPassButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Студент:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 9);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 1;
            label2.Text = "Фамилия Имя Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 38);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Группа:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 38);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Группа";
            // 
            // StudentPassesListView
            // 
            StudentPassesListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            StudentPassesListView.FullRowSelect = true;
            StudentPassesListView.GridLines = true;
            StudentPassesListView.Location = new Point(12, 75);
            StudentPassesListView.Name = "StudentPassesListView";
            StudentPassesListView.Size = new Size(358, 173);
            StudentPassesListView.TabIndex = 4;
            StudentPassesListView.UseCompatibleStateImageBehavior = false;
            StudentPassesListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Дата";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Пропуск";
            columnHeader2.Width = 300;
            // 
            // PlusPassButton
            // 
            PlusPassButton.Location = new Point(376, 75);
            PlusPassButton.Name = "PlusPassButton";
            PlusPassButton.Size = new Size(42, 41);
            PlusPassButton.TabIndex = 5;
            PlusPassButton.Text = "+";
            PlusPassButton.UseVisualStyleBackColor = true;
            PlusPassButton.Click += PlusPassButton_Click;
            // 
            // MinusPassButton
            // 
            MinusPassButton.Location = new Point(376, 122);
            MinusPassButton.Name = "MinusPassButton";
            MinusPassButton.Size = new Size(42, 41);
            MinusPassButton.TabIndex = 6;
            MinusPassButton.Text = "-";
            MinusPassButton.UseVisualStyleBackColor = true;
            MinusPassButton.Click += MinusPassButton_Click;
            // 
            // PassWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 287);
            Controls.Add(MinusPassButton);
            Controls.Add(PlusPassButton);
            Controls.Add(StudentPassesListView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PassWindow";
            Text = "Пропуски студента:";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView StudentPassesListView;
        private Button PlusPassButton;
        private Button MinusPassButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}