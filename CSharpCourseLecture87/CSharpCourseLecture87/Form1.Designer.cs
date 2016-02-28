namespace CSharpCourseLecture87
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
            this.rtb_searchString = new System.Windows.Forms.RichTextBox();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_searchString
            // 
            this.rtb_searchString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_searchString.Location = new System.Drawing.Point(13, 13);
            this.rtb_searchString.Name = "rtb_searchString";
            this.rtb_searchString.Size = new System.Drawing.Size(614, 886);
            this.rtb_searchString.TabIndex = 0;
            this.rtb_searchString.Text = "";
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(634, 13);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(283, 44);
            this.tb_searchBox.TabIndex = 1;
            this.tb_searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_searchBox_KeyDown);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(634, 74);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(35, 37);
            this.lbl_count.TabIndex = 2;
            this.lbl_count.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 928);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.tb_searchBox);
            this.Controls.Add(this.rtb_searchString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_searchString;
        private System.Windows.Forms.TextBox tb_searchBox;
        private System.Windows.Forms.Label lbl_count;
    }
}

