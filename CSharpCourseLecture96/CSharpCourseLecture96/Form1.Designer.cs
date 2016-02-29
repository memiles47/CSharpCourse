namespace CSharpCourseLecture96
{
    partial class Form1
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
            this.mnu_fileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg_openFile = new System.Windows.Forms.OpenFileDialog();
            this.rtb_fileContent = new System.Windows.Forms.RichTextBox();
            this.dlg_saveFile = new System.Windows.Forms.SaveFileDialog();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_fileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_fileMenu
            // 
            this.mnu_fileMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnu_fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnu_fileMenu.Location = new System.Drawing.Point(0, 0);
            this.mnu_fileMenu.Name = "mnu_fileMenu";
            this.mnu_fileMenu.Size = new System.Drawing.Size(1361, 40);
            this.mnu_fileMenu.TabIndex = 0;
            this.mnu_fileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 38);
            this.toolStripMenuItem2.Text = "Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dlg_openFile
            // 
            this.dlg_openFile.FileName = "openFileDialog1";
            // 
            // rtb_fileContent
            // 
            this.rtb_fileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_fileContent.Location = new System.Drawing.Point(0, 40);
            this.rtb_fileContent.Name = "rtb_fileContent";
            this.rtb_fileContent.Size = new System.Drawing.Size(1361, 1098);
            this.rtb_fileContent.TabIndex = 1;
            this.rtb_fileContent.Text = "";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 1138);
            this.Controls.Add(this.rtb_fileContent);
            this.Controls.Add(this.mnu_fileMenu);
            this.MainMenuStrip = this.mnu_fileMenu;
            this.Name = "Form1";
            this.Text = "CSharp Course Lecture 96, 97 and 98";
            this.mnu_fileMenu.ResumeLayout(false);
            this.mnu_fileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog dlg_openFile;
        private System.Windows.Forms.RichTextBox rtb_fileContent;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlg_saveFile;
    }
}

