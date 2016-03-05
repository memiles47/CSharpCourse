namespace CSharpCourseLecture106
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
            this.tb_NameBox = new System.Windows.Forms.TextBox();
            this.dtp_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cb_Smoker = new System.Windows.Forms.CheckBox();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.cbo_Names = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_NameBox
            // 
            this.tb_NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameBox.Location = new System.Drawing.Point(16, 15);
            this.tb_NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_NameBox.Name = "tb_NameBox";
            this.tb_NameBox.Size = new System.Drawing.Size(532, 50);
            this.tb_NameBox.TabIndex = 0;
            // 
            // dtp_DateTimePicker
            // 
            this.dtp_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateTimePicker.Location = new System.Drawing.Point(16, 89);
            this.dtp_DateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_DateTimePicker.Name = "dtp_DateTimePicker";
            this.dtp_DateTimePicker.Size = new System.Drawing.Size(803, 50);
            this.dtp_DateTimePicker.TabIndex = 1;
            // 
            // cb_Smoker
            // 
            this.cb_Smoker.AutoSize = true;
            this.cb_Smoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Smoker.Location = new System.Drawing.Point(16, 161);
            this.cb_Smoker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Smoker.Name = "cb_Smoker";
            this.cb_Smoker.Size = new System.Drawing.Size(184, 48);
            this.cb_Smoker.TabIndex = 2;
            this.cb_Smoker.Text = "Smoker";
            this.cb_Smoker.UseVisualStyleBackColor = true;
            // 
            // tb_Path
            // 
            this.tb_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Path.Location = new System.Drawing.Point(16, 231);
            this.tb_Path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(803, 50);
            this.tb_Path.TabIndex = 3;
            // 
            // cbo_Names
            // 
            this.cbo_Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Names.FormattingEnabled = true;
            this.cbo_Names.Location = new System.Drawing.Point(17, 410);
            this.cbo_Names.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_Names.Name = "cbo_Names";
            this.cbo_Names.Size = new System.Drawing.Size(803, 50);
            this.cbo_Names.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(16, 312);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(804, 75);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 489);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cbo_Names);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.cb_Smoker);
            this.Controls.Add(this.dtp_DateTimePicker);
            this.Controls.Add(this.tb_NameBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CSharp Course Lecture 106";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NameBox;
        private System.Windows.Forms.DateTimePicker dtp_DateTimePicker;
        private System.Windows.Forms.CheckBox cb_Smoker;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.ComboBox cbo_Names;
        private System.Windows.Forms.Button btn_Save;
    }
}

