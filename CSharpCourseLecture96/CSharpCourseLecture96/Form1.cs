using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace CSharpCourseLecture96
{
    public partial class Form1 : Form
    {
        //Initialize an instance of a new PrintDocument
        PrintDocument myDocument = new PrintDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Setting initial directory for file => Open
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
            //Setting initial directory for file => Open
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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_print.PrintToFile = true;
            dlg_print.Document = myDocument;
            DialogResult printDialogResult = dlg_print.ShowDialog();
            if (printDialogResult == DialogResult.OK)
            {
                myDocument.PrintPage += new PrintPageEventHandler(doc_PrintPage);
                myDocument.Print();
            }
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Create font
            System.Drawing.Font writeFont = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Regular);

            //What is to be printed, font, color and x,y position
            e.Graphics.DrawString(rtb_fileContent.Text, writeFont, System.Drawing.Brushes.Blue, 50, 50);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlg_printPreview.Document = myDocument;
            myDocument.PrintPage += new PrintPageEventHandler(doc_PrintPage);
            dlg_printPreview.Show();
        }
    }
}
