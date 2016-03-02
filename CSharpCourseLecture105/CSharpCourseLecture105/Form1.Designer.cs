namespace CSharpCourseLecture105
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
            this.btn_bigFile = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_loadBigFile = new System.Windows.Forms.Button();
            this.pb_progressBar = new System.Windows.Forms.ProgressBar();
            this.rtb_incomingText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_bigFile
            // 
            this.btn_bigFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bigFile.Location = new System.Drawing.Point(12, 12);
            this.btn_bigFile.Name = "btn_bigFile";
            this.btn_bigFile.Size = new System.Drawing.Size(564, 73);
            this.btn_bigFile.TabIndex = 0;
            this.btn_bigFile.Text = "Make Big FIle";
            this.btn_bigFile.UseVisualStyleBackColor = true;
            this.btn_bigFile.Click += new System.EventHandler(this.btn_bigFile_Click);
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.Location = new System.Drawing.Point(12, 91);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(564, 35);
            this.tb_path.TabIndex = 1;
            // 
            // btn_loadBigFile
            // 
            this.btn_loadBigFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadBigFile.Location = new System.Drawing.Point(12, 132);
            this.btn_loadBigFile.Name = "btn_loadBigFile";
            this.btn_loadBigFile.Size = new System.Drawing.Size(564, 71);
            this.btn_loadBigFile.TabIndex = 2;
            this.btn_loadBigFile.Text = "Load Big FIle";
            this.btn_loadBigFile.UseVisualStyleBackColor = true;
            this.btn_loadBigFile.Click += new System.EventHandler(this.btn_loadBigFile_Click);
            // 
            // pb_progressBar
            // 
            this.pb_progressBar.Location = new System.Drawing.Point(12, 209);
            this.pb_progressBar.Maximum = 9999;
            this.pb_progressBar.Name = "pb_progressBar";
            this.pb_progressBar.Size = new System.Drawing.Size(564, 23);
            this.pb_progressBar.Step = 1;
            this.pb_progressBar.TabIndex = 3;
            // 
            // rtb_incomingText
            // 
            this.rtb_incomingText.Location = new System.Drawing.Point(12, 238);
            this.rtb_incomingText.Name = "rtb_incomingText";
            this.rtb_incomingText.Size = new System.Drawing.Size(564, 736);
            this.rtb_incomingText.TabIndex = 4;
            this.rtb_incomingText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 986);
            this.Controls.Add(this.rtb_incomingText);
            this.Controls.Add(this.pb_progressBar);
            this.Controls.Add(this.btn_loadBigFile);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.btn_bigFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bigFile;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_loadBigFile;
        private System.Windows.Forms.ProgressBar pb_progressBar;
        private System.Windows.Forms.RichTextBox rtb_incomingText;
    }
}

