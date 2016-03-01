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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnu_fileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg_openFile = new System.Windows.Forms.OpenFileDialog();
            this.rtb_fileContent = new System.Windows.Forms.RichTextBox();
            this.dlg_saveFile = new System.Windows.Forms.SaveFileDialog();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlg_print = new System.Windows.Forms.PrintDialog();
            this.dlg_printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnu_fileMenu.Size = new System.Drawing.Size(1361, 42);
            this.mnu_fileMenu.TabIndex = 0;
            this.mnu_fileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
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
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dlg_openFile
            // 
            this.dlg_openFile.FileName = "openFileDialog1";
            // 
            // rtb_fileContent
            // 
            this.rtb_fileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_fileContent.Location = new System.Drawing.Point(0, 42);
            this.rtb_fileContent.Name = "rtb_fileContent";
            this.rtb_fileContent.Size = new System.Drawing.Size(1361, 1096);
            this.rtb_fileContent.TabIndex = 1;
            this.rtb_fileContent.Text = "";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // dlg_print
            // 
            this.dlg_print.UseEXDialog = true;
            // 
            // dlg_printPreview
            // 
            this.dlg_printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlg_printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlg_printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlg_printPreview.Enabled = true;
            this.dlg_printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlg_printPreview.Icon")));
            this.dlg_printPreview.Name = "dlg_printPreview";
            this.dlg_printPreview.Visible = false;
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
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
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.PrintDialog dlg_print;
        private System.Windows.Forms.PrintPreviewDialog dlg_printPreview;
    }
}

