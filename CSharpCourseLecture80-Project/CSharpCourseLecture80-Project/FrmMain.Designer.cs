namespace CSharpCourseLecture80_Project
{
    partial class FrmMain
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
            this.lbl_Key = new System.Windows.Forms.Label();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.btn_AddToDictionary = new System.Windows.Forms.Button();
            this.btn_SaveToDisk = new System.Windows.Forms.Button();
            this.btn_OpenInNotepad = new System.Windows.Forms.Button();
            this.lbl_EnterPath = new System.Windows.Forms.Label();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.lbl_SaveToDisk = new System.Windows.Forms.Label();
            this.dlg_browse = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.lbl_Extention = new System.Windows.Forms.Label();
            this.lbl_Warning1 = new System.Windows.Forms.Label();
            this.lbl_actionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Key.Location = new System.Drawing.Point(306, 42);
            this.lbl_Key.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(54, 29);
            this.lbl_Key.TabIndex = 0;
            this.lbl_Key.Text = "Key";
            // 
            // tb_Key
            // 
            this.tb_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Key.Location = new System.Drawing.Point(385, 37);
            this.tb_Key.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.Size = new System.Drawing.Size(114, 35);
            this.tb_Key.TabIndex = 1;
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.Location = new System.Drawing.Point(306, 92);
            this.lbl_Value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(74, 29);
            this.lbl_Value.TabIndex = 2;
            this.lbl_Value.Text = "Value";
            // 
            // tb_Value
            // 
            this.tb_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Value.Location = new System.Drawing.Point(385, 86);
            this.tb_Value.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(114, 35);
            this.tb_Value.TabIndex = 3;
            // 
            // btn_AddToDictionary
            // 
            this.btn_AddToDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToDictionary.Location = new System.Drawing.Point(37, 145);
            this.btn_AddToDictionary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddToDictionary.Name = "btn_AddToDictionary";
            this.btn_AddToDictionary.Size = new System.Drawing.Size(719, 48);
            this.btn_AddToDictionary.TabIndex = 4;
            this.btn_AddToDictionary.Text = "Add To Dictionary";
            this.btn_AddToDictionary.UseVisualStyleBackColor = true;
            this.btn_AddToDictionary.Click += new System.EventHandler(this.btn_addToDictionary_Click);
            // 
            // btn_SaveToDisk
            // 
            this.btn_SaveToDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveToDisk.Location = new System.Drawing.Point(37, 217);
            this.btn_SaveToDisk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveToDisk.Name = "btn_SaveToDisk";
            this.btn_SaveToDisk.Size = new System.Drawing.Size(719, 48);
            this.btn_SaveToDisk.TabIndex = 5;
            this.btn_SaveToDisk.Text = "Save To Disk";
            this.btn_SaveToDisk.UseVisualStyleBackColor = true;
            this.btn_SaveToDisk.Click += new System.EventHandler(this.btn_saveToDisk_Click);
            // 
            // btn_OpenInNotepad
            // 
            this.btn_OpenInNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenInNotepad.Location = new System.Drawing.Point(37, 286);
            this.btn_OpenInNotepad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OpenInNotepad.Name = "btn_OpenInNotepad";
            this.btn_OpenInNotepad.Size = new System.Drawing.Size(719, 48);
            this.btn_OpenInNotepad.TabIndex = 6;
            this.btn_OpenInNotepad.Text = "Open in Notepad";
            this.btn_OpenInNotepad.UseVisualStyleBackColor = true;
            this.btn_OpenInNotepad.Click += new System.EventHandler(this.btn_openInNotepad_Click);
            // 
            // lbl_EnterPath
            // 
            this.lbl_EnterPath.AutoSize = true;
            this.lbl_EnterPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterPath.Location = new System.Drawing.Point(33, 357);
            this.lbl_EnterPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EnterPath.Name = "lbl_EnterPath";
            this.lbl_EnterPath.Size = new System.Drawing.Size(124, 29);
            this.lbl_EnterPath.TabIndex = 7;
            this.lbl_EnterPath.Text = "Enter Path";
            // 
            // tb_Path
            // 
            this.tb_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Path.Location = new System.Drawing.Point(164, 355);
            this.tb_Path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(462, 35);
            this.tb_Path.TabIndex = 8;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(629, 355);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(127, 40);
            this.btn_Browse.TabIndex = 9;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lbl_SaveToDisk
            // 
            this.lbl_SaveToDisk.AutoSize = true;
            this.lbl_SaveToDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SaveToDisk.Location = new System.Drawing.Point(32, 492);
            this.lbl_SaveToDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SaveToDisk.Name = "lbl_SaveToDisk";
            this.lbl_SaveToDisk.Size = new System.Drawing.Size(176, 29);
            this.lbl_SaveToDisk.TabIndex = 10;
            this.lbl_SaveToDisk.Text = "Saved To Disk:";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileName.Location = new System.Drawing.Point(33, 420);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(125, 29);
            this.lbl_FileName.TabIndex = 11;
            this.lbl_FileName.Text = "File Name";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FileName.Location = new System.Drawing.Point(164, 415);
            this.tb_FileName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(248, 35);
            this.tb_FileName.TabIndex = 12;
            // 
            // lbl_Extention
            // 
            this.lbl_Extention.AutoSize = true;
            this.lbl_Extention.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Extention.Location = new System.Drawing.Point(413, 421);
            this.lbl_Extention.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Extention.Name = "lbl_Extention";
            this.lbl_Extention.Size = new System.Drawing.Size(42, 29);
            this.lbl_Extention.TabIndex = 13;
            this.lbl_Extention.Text = ".txt";
            // 
            // lbl_Warning1
            // 
            this.lbl_Warning1.AutoSize = true;
            this.lbl_Warning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Warning1.Location = new System.Drawing.Point(187, 459);
            this.lbl_Warning1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Warning1.Name = "lbl_Warning1";
            this.lbl_Warning1.Size = new System.Drawing.Size(196, 15);
            this.lbl_Warning1.TabIndex = 14;
            this.lbl_Warning1.Text = "DO NOT ENTER FILE EXTENTION";
            // 
            // lbl_actionStatus
            // 
            this.lbl_actionStatus.AutoSize = true;
            this.lbl_actionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actionStatus.Location = new System.Drawing.Point(211, 492);
            this.lbl_actionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_actionStatus.Name = "lbl_actionStatus";
            this.lbl_actionStatus.Size = new System.Drawing.Size(0, 29);
            this.lbl_actionStatus.TabIndex = 15;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 644);
            this.Controls.Add(this.lbl_actionStatus);
            this.Controls.Add(this.lbl_Warning1);
            this.Controls.Add(this.lbl_Extention);
            this.Controls.Add(this.tb_FileName);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.lbl_SaveToDisk);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.lbl_EnterPath);
            this.Controls.Add(this.btn_OpenInNotepad);
            this.Controls.Add(this.btn_SaveToDisk);
            this.Controls.Add(this.btn_AddToDictionary);
            this.Controls.Add(this.tb_Value);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.tb_Key);
            this.Controls.Add(this.lbl_Key);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "CSharp Course Lecture 80 Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.Button btn_AddToDictionary;
        private System.Windows.Forms.Button btn_SaveToDisk;
        private System.Windows.Forms.Button btn_OpenInNotepad;
        private System.Windows.Forms.Label lbl_EnterPath;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label lbl_SaveToDisk;
        private System.Windows.Forms.FolderBrowserDialog dlg_browse;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.Label lbl_Extention;
        private System.Windows.Forms.Label lbl_Warning1;
        private System.Windows.Forms.Label lbl_actionStatus;
    }
}

