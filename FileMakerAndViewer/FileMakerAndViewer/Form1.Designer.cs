namespace FileMakerAndViewer
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
            this.tb_Save = new System.Windows.Forms.TextBox();
            this.tb_Open = new System.Windows.Forms.TextBox();
            this.rtb_Save = new System.Windows.Forms.RichTextBox();
            this.rtb_Open = new System.Windows.Forms.RichTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Save
            // 
            this.tb_Save.Location = new System.Drawing.Point(12, 12);
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(598, 31);
            this.tb_Save.TabIndex = 0;
            // 
            // tb_Open
            // 
            this.tb_Open.Location = new System.Drawing.Point(661, 13);
            this.tb_Open.Name = "tb_Open";
            this.tb_Open.Size = new System.Drawing.Size(593, 31);
            this.tb_Open.TabIndex = 1;
            // 
            // rtb_Save
            // 
            this.rtb_Save.Location = new System.Drawing.Point(12, 50);
            this.rtb_Save.Name = "rtb_Save";
            this.rtb_Save.Size = new System.Drawing.Size(598, 450);
            this.rtb_Save.TabIndex = 2;
            this.rtb_Save.Text = "";
            // 
            // rtb_Open
            // 
            this.rtb_Open.Location = new System.Drawing.Point(661, 50);
            this.rtb_Open.Name = "rtb_Open";
            this.rtb_Open.Size = new System.Drawing.Size(593, 450);
            this.rtb_Open.TabIndex = 3;
            this.rtb_Open.Text = "";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 516);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(598, 49);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(661, 516);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(593, 49);
            this.btn_Open.TabIndex = 5;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 612);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 25);
            this.lbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 949);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.rtb_Open);
            this.Controls.Add(this.rtb_Save);
            this.Controls.Add(this.tb_Open);
            this.Controls.Add(this.tb_Save);
            this.Name = "Form1";
            this.Text = "Files Maker and Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Save;
        private System.Windows.Forms.TextBox tb_Open;
        private System.Windows.Forms.RichTextBox rtb_Save;
        private System.Windows.Forms.RichTextBox rtb_Open;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Label lbl;
    }
}

