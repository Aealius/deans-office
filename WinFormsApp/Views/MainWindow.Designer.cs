namespace WinFormsApp.Views
{
    partial class MainWindow
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
            GroupListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            StudentListView = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            PlusGroupButton = new Button();
            MinusGroupButton = new Button();
            MinusStudentButton = new Button();
            PlusStudentButton = new Button();
            EditGroupButton = new Button();
            EditStudentButton = new Button();
            PassButton = new Button();
            StatusButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // GroupListView
            // 
            GroupListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            GroupListView.FullRowSelect = true;
            GroupListView.GridLines = true;
            GroupListView.Location = new Point(12, 36);
            GroupListView.Name = "GroupListView";
            GroupListView.Size = new Size(410, 479);
            GroupListView.TabIndex = 0;
            GroupListView.UseCompatibleStateImageBehavior = false;
            GroupListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Имя группы";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Специальность";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Год создания";
            columnHeader3.Width = 100;
            // 
            // StudentListView
            // 
            StudentListView.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader4, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            StudentListView.FullRowSelect = true;
            StudentListView.GridLines = true;
            StudentListView.Location = new Point(518, 36);
            StudentListView.Name = "StudentListView";
            StudentListView.Size = new Size(747, 479);
            StudentListView.TabIndex = 0;
            StudentListView.UseCompatibleStateImageBehavior = false;
            StudentListView.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 1;
            columnHeader5.Text = "Фамилия";
            columnHeader5.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 0;
            columnHeader4.Text = "Имя";
            columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Отчество";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Дата рождения";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Адрес";
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Номер з/к";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Группа";
            // 
            // PlusGroupButton
            // 
            PlusGroupButton.Location = new Point(428, 36);
            PlusGroupButton.Name = "PlusGroupButton";
            PlusGroupButton.Size = new Size(45, 41);
            PlusGroupButton.TabIndex = 1;
            PlusGroupButton.Text = "+";
            PlusGroupButton.UseVisualStyleBackColor = true;
            PlusGroupButton.Click += PlusGroupButton_Click;
            // 
            // MinusGroupButton
            // 
            MinusGroupButton.Location = new Point(428, 83);
            MinusGroupButton.Name = "MinusGroupButton";
            MinusGroupButton.Size = new Size(45, 41);
            MinusGroupButton.TabIndex = 1;
            MinusGroupButton.Text = "-";
            MinusGroupButton.UseVisualStyleBackColor = true;
            MinusGroupButton.Click += MinusGroupButton_Click;
            // 
            // MinusStudentButton
            // 
            MinusStudentButton.Location = new Point(1271, 97);
            MinusStudentButton.Name = "MinusStudentButton";
            MinusStudentButton.Size = new Size(51, 47);
            MinusStudentButton.TabIndex = 2;
            MinusStudentButton.Text = "-";
            MinusStudentButton.UseVisualStyleBackColor = true;
            MinusStudentButton.Click += MinusStudentButton_Click;
            // 
            // PlusStudentButton
            // 
            PlusStudentButton.Location = new Point(1271, 36);
            PlusStudentButton.Name = "PlusStudentButton";
            PlusStudentButton.Size = new Size(51, 44);
            PlusStudentButton.TabIndex = 3;
            PlusStudentButton.Text = "+";
            PlusStudentButton.UseVisualStyleBackColor = true;
            PlusStudentButton.Click += PlusStudentButton_Click;
            // 
            // EditGroupButton
            // 
            EditGroupButton.Location = new Point(214, 524);
            EditGroupButton.Name = "EditGroupButton";
            EditGroupButton.Size = new Size(208, 29);
            EditGroupButton.TabIndex = 4;
            EditGroupButton.Text = "Редактировать группу";
            EditGroupButton.UseVisualStyleBackColor = true;
            EditGroupButton.Click += EditGroupButton_Click;
            // 
            // EditStudentButton
            // 
            EditStudentButton.Location = new Point(1081, 523);
            EditStudentButton.Name = "EditStudentButton";
            EditStudentButton.Size = new Size(184, 30);
            EditStudentButton.TabIndex = 5;
            EditStudentButton.Text = "Редактировать студента";
            EditStudentButton.UseVisualStyleBackColor = true;
            EditStudentButton.Click += EditStudentButton_Click;
            // 
            // PassButton
            // 
            PassButton.Location = new Point(891, 523);
            PassButton.Name = "PassButton";
            PassButton.Size = new Size(184, 30);
            PassButton.TabIndex = 6;
            PassButton.Text = "Пропуски студента";
            PassButton.UseVisualStyleBackColor = true;
            PassButton.Click += PassButton_Click;
            // 
            // StatusButton
            // 
            StatusButton.Location = new Point(691, 524);
            StatusButton.Name = "StatusButton";
            StatusButton.Size = new Size(194, 29);
            StatusButton.TabIndex = 7;
            StatusButton.Text = "Статусы студента";
            StatusButton.UseVisualStyleBackColor = true;
            StatusButton.Click += StatusButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 13);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 8;
            label1.Text = "Список групп";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(821, 13);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 9;
            label2.Text = "Список студентов";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 603);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StatusButton);
            Controls.Add(PassButton);
            Controls.Add(EditStudentButton);
            Controls.Add(EditGroupButton);
            Controls.Add(MinusStudentButton);
            Controls.Add(PlusStudentButton);
            Controls.Add(MinusGroupButton);
            Controls.Add(PlusGroupButton);
            Controls.Add(StudentListView);
            Controls.Add(GroupListView);
            Name = "MainWindow";
            Text = "Деканат (студенты факультета)";
            FormClosed += MainWindow_FormClosed;
            Load += MainWindow_OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListView GroupListView;
        public ListView StudentListView;
        private Button PlusGroupButton;
        private Button MinusGroupButton;
        private Button MinusStudentButton;
        private Button PlusStudentButton;
        private Button EditGroupButton;
        private Button EditStudentButton;
        private Button PassButton;
        private Button StatusButton;
        private Label label1;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}