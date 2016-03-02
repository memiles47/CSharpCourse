using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

            //Connection String
            string connString = @"Data Source=MEM_SURFACE\SQLEXPRESS;Initial Catalog=Sample;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //Make a resource, use it and dispose of it
            using(SqlConnection sqlconn = new SqlConnection(connString))
            {
                //Open Connection
                sqlconn.Open();

                //Get list of table inside of database
                DataTable tables = sqlconn.GetSchema("Tables");

                foreach (DataRow row in tables.Rows)
                {
                    //Look at first column in row.
                    cbo_tableList.Items.Add(row[2].ToString());
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            tableTableAdapter2.Update(sampleDataSet2);
            chart1.DataBind();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }
    }
}
