using System;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (tb_AddressBox.Text == "")
            {
                MessageBox.Show("You must enter an address");
            }
            else
            {
                webBrowser1.Navigate(new Uri(tb_AddressBox.Text));
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
