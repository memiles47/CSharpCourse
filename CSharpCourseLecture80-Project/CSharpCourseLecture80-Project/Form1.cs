﻿using System;                       //Console
using System.Collections.Generic;   //Dictionaries, Lists, IEnumerable
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;                  //Queries
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourseLecture80_Project
{
    public partial class Form1 : Form
    {
        //Create dictionary
        Dictionary<string, string> dict = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            //The line below gets path to MyComputer
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);

            //Sets the path of the browser dialog box
            dlg_browse.SelectedPath = path;

        }

        private void SaveDictionary(Dictionary<string, string> entries)
        {
            if (tb_path.Text != "")
            {
                string correctedPath = tb_path.Text.Replace("\\\\", "\\");
                using (StreamWriter writer = File.CreateText($"{correctedPath}\\family.txt"))
                {
                    foreach (var pair in entries)
                    {
                        writer.WriteLine($"{pair.Key}, {pair.Value}");
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select a path for saving to disk");
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            DialogResult result = dlg_browse.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_path.Text = dlg_browse.SelectedPath;
            }
        }

        private void btn_addToDictionary_Click(object sender, EventArgs e)
        {
            dict.Add(tb_key.Text, tb_value.Text);
            tb_key.Text = "";
            tb_value.Text = "";
        }

        private void btn_saveToDisk_Click(object sender, EventArgs e)
        {
            SaveDictionary(dict);
        }
    }
}
