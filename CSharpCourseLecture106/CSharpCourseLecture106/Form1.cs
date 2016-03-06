using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

/*
Lecture 106: Saving and restoring
Control Values
*/

namespace CSharpCourseLecture106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btn_Save_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = File.AppendText(tb_Path.Text))
            {
                sw.Write($"{tb_NameBox.Text},");
                sw.Write($"{dtp_DateTimePicker.Value.ToShortDateString()},");
                sw.WriteLine($"{cb_Smoker.Checked}");
            }

            using(StreamReader sr = File.OpenText(tb_Path.Text))
            {
                List<string> ls = new List<string>();
                string s;
                while((s=sr.ReadLine()) != null)
                {
                    ls.Add(s.Split(',')[0]);
                }

                cbo_Names.DataSource = ls;
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", tb_Path.Text);
        }

        private void cbo_Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(StreamReader sr = File.OpenText(tb_Path.Text))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] fields = s.Split(',');
                    if (s.Contains(cbo_Names.SelectedValue.ToString()))
                    {
                        dtp_DateTimePicker.Value = DateTime.Parse(fields[1]);
                        tb_NameBox.Text = fields[0];
                        cb_Smoker.Checked = bool.Parse(fields[2]);
                    }
                }
            }
        }
    }
}
