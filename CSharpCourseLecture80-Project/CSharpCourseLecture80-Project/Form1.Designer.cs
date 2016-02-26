namespace CSharpCourseLecture80_Project
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
            this.lbl_key = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.btn_addToDictionary = new System.Windows.Forms.Button();
            this.btn_saveToDisk = new System.Windows.Forms.Button();
            this.btn_openInNotepad = new System.Windows.Forms.Button();
            this.lbl_enterPath = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_saveToDisk = new System.Windows.Forms.Label();
            this.dlg_browse = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_fileName = new System.Windows.Forms.Label();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.lbl_extention = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_key.Location = new System.Drawing.Point(331, 53);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(54, 29);
            this.lbl_key.TabIndex = 0;
            this.lbl_key.Text = "Key";
            // 
            // tb_key
            // 
            this.tb_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_key.Location = new System.Drawing.Point(421, 47);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(150, 35);
            this.tb_key.TabIndex = 1;
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(331, 106);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(74, 29);
            this.lbl_value.TabIndex = 2;
            this.lbl_value.Text = "Value";
            // 
            // tb_value
            // 
            this.tb_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_value.Location = new System.Drawing.Point(421, 100);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(150, 35);
            this.tb_value.TabIndex = 3;
            // 
            // btn_addToDictionary
            // 
            this.btn_addToDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToDictionary.Location = new System.Drawing.Point(49, 166);
            this.btn_addToDictionary.Name = "btn_addToDictionary";
            this.btn_addToDictionary.Size = new System.Drawing.Size(791, 40);
            this.btn_addToDictionary.TabIndex = 4;
            this.btn_addToDictionary.Text = "Add To Dictionary";
            this.btn_addToDictionary.UseVisualStyleBackColor = true;
            this.btn_addToDictionary.Click += new System.EventHandler(this.btn_addToDictionary_Click);
            // 
            // btn_saveToDisk
            // 
            this.btn_saveToDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveToDisk.Location = new System.Drawing.Point(49, 228);
            this.btn_saveToDisk.Name = "btn_saveToDisk";
            this.btn_saveToDisk.Size = new System.Drawing.Size(791, 40);
            this.btn_saveToDisk.TabIndex = 5;
            this.btn_saveToDisk.Text = "Save To Disk";
            this.btn_saveToDisk.UseVisualStyleBackColor = true;
            this.btn_saveToDisk.Click += new System.EventHandler(this.btn_saveToDisk_Click);
            // 
            // btn_openInNotepad
            // 
            this.btn_openInNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openInNotepad.Location = new System.Drawing.Point(49, 290);
            this.btn_openInNotepad.Name = "btn_openInNotepad";
            this.btn_openInNotepad.Size = new System.Drawing.Size(791, 40);
            this.btn_openInNotepad.TabIndex = 6;
            this.btn_openInNotepad.Text = "Open in Notepad";
            this.btn_openInNotepad.UseVisualStyleBackColor = true;
            // 
            // lbl_enterPath
            // 
            this.lbl_enterPath.AutoSize = true;
            this.lbl_enterPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterPath.Location = new System.Drawing.Point(44, 359);
            this.lbl_enterPath.Name = "lbl_enterPath";
            this.lbl_enterPath.Size = new System.Drawing.Size(124, 29);
            this.lbl_enterPath.TabIndex = 7;
            this.lbl_enterPath.Text = "Enter Path";
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.Location = new System.Drawing.Point(175, 357);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(550, 35);
            this.tb_path.TabIndex = 8;
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(730, 350);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(110, 44);
            this.btn_browse.TabIndex = 9;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lbl_saveToDisk
            // 
            this.lbl_saveToDisk.AutoSize = true;
            this.lbl_saveToDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saveToDisk.Location = new System.Drawing.Point(49, 494);
            this.lbl_saveToDisk.Name = "lbl_saveToDisk";
            this.lbl_saveToDisk.Size = new System.Drawing.Size(176, 29);
            this.lbl_saveToDisk.TabIndex = 10;
            this.lbl_saveToDisk.Text = "Saved To Disk:";
            // 
            // lbl_fileName
            // 
            this.lbl_fileName.AutoSize = true;
            this.lbl_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fileName.Location = new System.Drawing.Point(44, 410);
            this.lbl_fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fileName.Name = "lbl_fileName";
            this.lbl_fileName.Size = new System.Drawing.Size(125, 29);
            this.lbl_fileName.TabIndex = 11;
            this.lbl_fileName.Text = "File Name";
            // 
            // tb_fileName
            // 
            this.tb_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fileName.Location = new System.Drawing.Point(174, 404);
            this.tb_fileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(263, 35);
            this.tb_fileName.TabIndex = 12;
            // 
            // lbl_extention
            // 
            this.lbl_extention.AutoSize = true;
            this.lbl_extention.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_extention.Location = new System.Drawing.Point(440, 410);
            this.lbl_extention.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_extention.Name = "lbl_extention";
            this.lbl_extention.Size = new System.Drawing.Size(42, 29);
            this.lbl_extention.TabIndex = 13;
            this.lbl_extention.Text = ".txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 450);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "DO NOT ENTER FILE EXTENTION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_extention);
            this.Controls.Add(this.tb_fileName);
            this.Controls.Add(this.lbl_fileName);
            this.Controls.Add(this.lbl_saveToDisk);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.lbl_enterPath);
            this.Controls.Add(this.btn_openInNotepad);
            this.Controls.Add(this.btn_saveToDisk);
            this.Controls.Add(this.btn_addToDictionary);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.lbl_key);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Button btn_addToDictionary;
        private System.Windows.Forms.Button btn_saveToDisk;
        private System.Windows.Forms.Button btn_openInNotepad;
        private System.Windows.Forms.Label lbl_enterPath;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lbl_saveToDisk;
        private System.Windows.Forms.FolderBrowserDialog dlg_browse;
        private System.Windows.Forms.Label lbl_fileName;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label lbl_extention;
        private System.Windows.Forms.Label label1;
    }
}

