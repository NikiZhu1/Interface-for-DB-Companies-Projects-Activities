namespace AgainTheseActivities
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            treeView = new TreeView();
            button1 = new Button();
            CompanyContextMenu = new ContextMenuStrip(components);
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            ProjectContextMenu = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem4 = new ToolStripMenuItem();
            ActivityContextMenu = new ContextMenuStrip(components);
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem7 = new ToolStripMenuItem();
            CompanyContextMenu.SuspendLayout();
            ProjectContextMenu.SuspendLayout();
            ActivityContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(2, 2);
            treeView.Name = "treeView";
            treeView.Size = new Size(627, 445);
            treeView.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(635, 401);
            button1.Name = "button1";
            button1.Size = new Size(153, 37);
            button1.TabIndex = 1;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CompanyContextMenu
            // 
            CompanyContextMenu.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, изменитьToolStripMenuItem, toolStripMenuItem1, удалитьToolStripMenuItem });
            CompanyContextMenu.Name = "CompanyContextMenu";
            CompanyContextMenu.Size = new Size(189, 76);
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(188, 22);
            добавитьToolStripMenuItem.Text = "Добавить компанию";
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(188, 22);
            изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(185, 6);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(188, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // ProjectContextMenu
            // 
            ProjectContextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripSeparator1, toolStripMenuItem4 });
            ProjectContextMenu.Name = "CompanyContextMenu";
            ProjectContextMenu.Size = new Size(168, 76);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(167, 22);
            toolStripMenuItem2.Text = "Добавить проект";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(167, 22);
            toolStripMenuItem3.Text = "Изменить";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(164, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(167, 22);
            toolStripMenuItem4.Text = "Удалить";
            // 
            // ActivityContextMenu
            // 
            ActivityContextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6, toolStripSeparator2, toolStripMenuItem7 });
            ActivityContextMenu.Name = "CompanyContextMenu";
            ActivityContextMenu.Size = new Size(191, 98);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(190, 22);
            toolStripMenuItem5.Text = "Добавить активность";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(190, 22);
            toolStripMenuItem6.Text = "Изменить";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(187, 6);
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(190, 22);
            toolStripMenuItem7.Text = "Удалить";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(treeView);
            Name = "MainForm";
            Text = "ИС \"Проектные активности\"";
            CompanyContextMenu.ResumeLayout(false);
            ProjectContextMenu.ResumeLayout(false);
            ActivityContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private Button button1;
        private ContextMenuStrip CompanyContextMenu;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ContextMenuStrip ProjectContextMenu;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ContextMenuStrip ActivityContextMenu;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem7;
    }
}
