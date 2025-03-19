namespace AgainTheseActivities
{
    partial class LogInForm
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
            label1 = new Label();
            loginField = new TextBox();
            label2 = new Label();
            label3 = new Label();
            passwordField = new TextBox();
            buttonLogin = new Button();
            OpenRegister = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(820, 107);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            loginField.Anchor = AnchorStyles.Top;
            loginField.Font = new Font("Segoe UI", 16F);
            loginField.Location = new Point(299, 151);
            loginField.Name = "loginField";
            loginField.Size = new Size(217, 36);
            loginField.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(299, 123);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(299, 215);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.Top;
            passwordField.Font = new Font("Segoe UI", 16F);
            passwordField.Location = new Point(299, 243);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(217, 36);
            passwordField.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Top;
            buttonLogin.Font = new Font("Segoe UI", 14F);
            buttonLogin.Location = new Point(356, 309);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(106, 40);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // OpenRegister
            // 
            OpenRegister.Cursor = Cursors.Hand;
            OpenRegister.Dock = DockStyle.Bottom;
            OpenRegister.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            OpenRegister.ForeColor = SystemColors.ActiveCaptionText;
            OpenRegister.Location = new Point(0, 360);
            OpenRegister.Name = "OpenRegister";
            OpenRegister.Size = new Size(820, 118);
            OpenRegister.TabIndex = 6;
            OpenRegister.Text = "Новый пользователь? Зарегестрироваться";
            OpenRegister.TextAlign = ContentAlignment.MiddleCenter;
            OpenRegister.Click += OpenRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(820, 478);
            Controls.Add(buttonLogin);
            Controls.Add(label3);
            Controls.Add(passwordField);
            Controls.Add(label2);
            Controls.Add(loginField);
            Controls.Add(label1);
            Controls.Add(OpenRegister);
            MinimumSize = new Size(477, 517);
            Name = "Form1";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox loginField;
        private Label label2;
        private Label label3;
        private TextBox passwordField;
        private Button buttonLogin;
        private Label OpenRegister;
    }
}
