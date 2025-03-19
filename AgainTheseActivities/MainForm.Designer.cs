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
            treeView = new TreeView();
            button1 = new Button();
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(treeView);
            Name = "Form1";
            Text = "ИС \"Проектные активности\"";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private Button button1;
    }
}
