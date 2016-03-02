using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourseLecture101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDataSet2.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter2.Fill(this.sampleDataSet2.Table);
            // TODO: This line of code loads data into the 'sampleDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.sampleDataSet1.Table);
            // TODO: This line of code loads data into the 'sampleDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.sampleDataSet.Table);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            tableTableAdapter1.Update(sampleDataSet1);
            chart1.DataBind();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }
    }
}
