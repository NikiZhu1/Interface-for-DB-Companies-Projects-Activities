namespace AgainTheseActivities
{
    partial class RegistrationForm
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
            buttonSignIn = new Button();
            label3 = new Label();
            passwordField = new TextBox();
            label2 = new Label();
            loginField = new TextBox();
            OpenSignIn = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonSignIn
            // 
            buttonSignIn.Anchor = AnchorStyles.Top;
            buttonSignIn.Font = new Font("Segoe UI", 14F);
            buttonSignIn.Location = new Point(365, 294);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(217, 40);
            buttonSignIn.TabIndex = 11;
            buttonSignIn.Text = "Зарегестрироваться";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(365, 203);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 10;
            label3.Text = "Пароль";
            // 
            // passwordField
            // 
            passwordField.Anchor = AnchorStyles.Top;
            passwordField.Font = new Font("Segoe UI", 16F);
            passwordField.Location = new Point(365, 231);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(217, 36);
            passwordField.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(365, 124);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 8;
            label2.Text = "Логин";
            // 
            // loginField
            // 
            loginField.Anchor = AnchorStyles.Top;
            loginField.Font = new Font("Segoe UI", 16F);
            loginField.Location = new Point(365, 152);
            loginField.Name = "loginField";
            loginField.Size = new Size(217, 36);
            loginField.TabIndex = 7;
            // 
            // OpenSignIn
            // 
            OpenSignIn.Cursor = Cursors.Hand;
            OpenSignIn.Dock = DockStyle.Bottom;
            OpenSignIn.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            OpenSignIn.ForeColor = SystemColors.ActiveCaptionText;
            OpenSignIn.Location = new Point(0, 400);
            OpenSignIn.Name = "OpenSignIn";
            OpenSignIn.Size = new Size(946, 118);
            OpenSignIn.TabIndex = 12;
            OpenSignIn.Text = "Уже есть аккаунт? Войти";
            OpenSignIn.TextAlign = ContentAlignment.MiddleCenter;
            OpenSignIn.Click += OpenSignIn_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(946, 88);
            label4.TabIndex = 15;
            label4.Text = "Регистрация";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(946, 518);
            Controls.Add(label4);
            Controls.Add(buttonSignIn);
            Controls.Add(label3);
            Controls.Add(passwordField);
            Controls.Add(label2);
            Controls.Add(loginField);
            Controls.Add(OpenSignIn);
            MinimumSize = new Size(0, 517);
            Name = "Registration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSignIn;
        private Label label3;
        private TextBox passwordField;
        private Label label2;
        private TextBox loginField;
        private Label OpenSignIn;
        private Label label4;
    }
}