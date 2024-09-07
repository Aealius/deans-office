namespace WinFormsApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            PwdTextBox = new TextBox();
            LoginTextBox = new TextBox();
            AuthButton = new Button();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(59, 25);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(245, 20);
            textLabel.TabIndex = 0;
            textLabel.Text = "Введите данные для авторизации";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 71);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 120);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // PwdTextBox
            // 
            PwdTextBox.Location = new Point(130, 117);
            PwdTextBox.Name = "PwdTextBox";
            PwdTextBox.Size = new Size(174, 27);
            PwdTextBox.TabIndex = 2;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(130, 71);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(174, 27);
            LoginTextBox.TabIndex = 2;
            // 
            // AuthButton
            // 
            AuthButton.Location = new Point(143, 177);
            AuthButton.Name = "AuthButton";
            AuthButton.Size = new Size(94, 29);
            AuthButton.TabIndex = 3;
            AuthButton.Text = "Войти";
            AuthButton.UseVisualStyleBackColor = true;
            AuthButton.Click += AuthButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 224);
            Controls.Add(AuthButton);
            Controls.Add(LoginTextBox);
            Controls.Add(PwdTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textLabel);
            Name = "LoginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textLabel;
        private Label label2;
        private Label label3;
        private TextBox PwdTextBox;
        private TextBox LoginTextBox;
        private Button AuthButton;
    }
}