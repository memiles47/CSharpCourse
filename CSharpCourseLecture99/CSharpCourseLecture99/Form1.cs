using System;
using System.Windows.Forms;

namespace CSharpCourseLecture99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.sampleDataSet.People);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            peopleTableAdapter.Update(sampleDataSet);
        }
    }
}
