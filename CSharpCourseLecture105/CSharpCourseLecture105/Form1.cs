using System;
using System.Windows.Forms;
using System.IO;

/*
Lecture 105: Using Progress Bars
*/

namespace CSharpCourseLecture105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Create and write file
        private void btn_bigFile_Click(object sender, EventArgs e)
        {
            pb_progressBar.Value = 0;

            using (StreamWriter sw = File.CreateText(@tb_path.Text))
            {
                for (int i = 0; i < 10000; i++)
                {
                    sw.WriteLine(i.ToString());
                    pb_progressBar.PerformStep();
                }
            }
        }
        #endregion

        #region Open and read file
        private void btn_loadBigFile_Click(object sender, EventArgs e)
        {
            pb_progressBar.Value = 0;
            rtb_incomingText.Text = "";

            using(StreamReader sr = File.OpenText(@tb_path.Text))
            {
                for (int i = 0; i < 10000; i++)
                {
                    rtb_incomingText.Text += sr.ReadLine();
                    pb_progressBar.PerformStep();
                }
            }
        }
        #endregion
    }
}
