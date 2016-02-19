using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMakerAndViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                using(FileStream fstream = File.Create(tb_Save.Text))
                {
                    byte[] text = new UTF8Encoding(true).GetBytes(rtb_Save.Text);
                    fstream.Write(text, 0, text.Length);
                }
            }
            catch (Exception ex)
            {
                lbl.Text = ex.Message;
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader sreader = File.OpenText(tb_Open.Text))
                {
                    string linesToPrint;
                    while((linesToPrint = sreader.ReadLine()) != null)
                    {
                        rtb_Open.Text += linesToPrint + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                lbl.Text = ex.Message;
            }
        }
    }
}
