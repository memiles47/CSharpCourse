using System;
using System.Windows.Forms;
using System.IO;

namespace CSharpCourseLecture96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Seting initial directory for file => Open
            dlg_openFile.InitialDirectory = @"c:\users\michael\data";

            //Setting filters for open file dialog
            dlg_openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            //Set which filter shows up first
            dlg_openFile.FilterIndex = 1;

            //Set restores to the original postion every time
            dlg_openFile.RestoreDirectory = true;

            //Check if OK button was pressed
            if (dlg_openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sreader = new StreamReader(dlg_openFile.FileName);
                try
                {
                    rtb_fileContent.Text = sreader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Oops...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Seting initial directory for file => Open
            dlg_saveFile.InitialDirectory = @"c:\users\michael\data";

            //Setting filters for open file dialog
            dlg_saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            //Set which filter shows up first
            dlg_saveFile.FilterIndex = 2;

            //Set restores to the original postion every time
            dlg_saveFile.RestoreDirectory = true;

            if (dlg_saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dlg_saveFile.FileName))
                {
                    try
                    {
                        writer.Write(rtb_fileContent.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Oops...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
