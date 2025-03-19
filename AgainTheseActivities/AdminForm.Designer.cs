namespace AgainTheseActivities
{
    partial class AdminForm
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
            usersList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // usersList
            // 
            usersList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usersList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            usersList.FullRowSelect = true;
            usersList.GridLines = true;
            usersList.Location = new Point(1, 1);
            usersList.Name = "usersList";
            usersList.Size = new Size(550, 370);
            usersList.TabIndex = 0;
            usersList.UseCompatibleStateImageBehavior = false;
            usersList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Логин";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Админ";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Активен";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Дата регистрации";
            // 
            // button1
            // 
            button1.Location = new Point(12, 377);
            button1.Name = "button1";
            button1.Size = new Size(164, 28);
            button1.TabIndex = 1;
            button1.Text = "Добавить пользователя\r\n";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(193, 377);
            button2.Name = "button2";
            button2.Size = new Size(164, 28);
            button2.TabIndex = 2;
            button2.Text = "Изменить данные...";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(376, 377);
            button3.Name = "button3";
            button3.Size = new Size(164, 28);
            button3.TabIndex = 3;
            button3.Text = "Удалить пользователя\r\n";
            button3.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 414);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(usersList);
            MinimumSize = new Size(568, 0);
            Name = "AdminForm";
            Text = "Админ-панель";
            Load += AdminForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView usersList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}