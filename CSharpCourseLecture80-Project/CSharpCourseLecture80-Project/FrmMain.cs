using System;                       //Console
using System.Collections.Generic;   //Dictionaries, Lists, IEnumerable
using System.IO;                    //Disk read/write access
using System.Windows.Forms;         //Windows Forms
using System.Diagnostics;

namespace CSharpCourseLecture80_Project
{
    public partial class FrmMain : Form
    {
        //Create dictionary
        Dictionary<string, string> dict = new Dictionary<string, string>();

        public FrmMain()
        {
            InitializeComponent();

            //The line below gets path to MyComputer
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            //Sets the path of the browser dialog box
            dlg_browse.SelectedPath = path;
        }

        private void SaveDictionary(Dictionary<string, string> entries)
        {
            try
            {
                if (tb_Path.Text != "" && tb_FileName.Text != "")
                {
                    using (StreamWriter writer = File.AppendText(tb_Path.Text + @"\" + tb_FileName.Text + ".txt"))
                    {
                        foreach (var pair in entries)
                        {
                            writer.WriteLine($"{pair.Key}, {pair.Value}");
                        }
                    }
                    //Write status of action to form
                    lbl_actionStatus.Text = $"Save Complete";
                }
                else
                {
                    MessageBox.Show($"You must enter a path AND file name for saving to disk");
                }

            }
            catch (Exception ex)
            {
                lbl_actionStatus.Text = ex.Message;
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            DialogResult result = dlg_browse.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_Path.Text = dlg_browse.SelectedPath;
            }
        }

        private void btn_addToDictionary_Click(object sender, EventArgs e)
        {
            if (tb_Key.Text != "" & tb_Value.Text != "")
            {
                dict.Add(tb_Key.Text, tb_Value.Text);
                tb_Key.Text = "";
                tb_Value.Text = "";
            }
            else
            {
                MessageBox.Show($"You must enter a Key and Value before adding to the dictionary");
            }
        }

        private void btn_saveToDisk_Click(object sender, EventArgs e)
        {
            SaveDictionary(dict);
        }

        private void btn_openInNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", tb_Path.Text + @"\" + tb_FileName.Text + ".txt");
        }
    }
}
