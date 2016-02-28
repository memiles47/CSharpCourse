using System.Windows;
using System.IO;

namespace CSharpCourseLecture90
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string[] files = Directory.GetFiles(tb_filesBox.Text);
            foreach (string f in files)
            {
                rtb_displayBox.AppendText($"{f.ToString()} \n");
            }
        }
    }
}
