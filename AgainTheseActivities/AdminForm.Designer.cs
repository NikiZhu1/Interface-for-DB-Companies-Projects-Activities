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
            usersList.Size = new Size(809, 411);
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
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 450);
            Controls.Add(usersList);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView usersList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}