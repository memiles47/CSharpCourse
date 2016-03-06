using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourseLecture108
{
    public partial class Form1 : Form
    {
        Graphics gr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = this.CreateGraphics();
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rect = new Rectangle(e.Location, new Size(50, 50));
            gr.DrawEllipse(Pens.Blue, rect);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.LightGray);
        }
    }
}
