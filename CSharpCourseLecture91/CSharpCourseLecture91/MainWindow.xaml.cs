using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpCourseLecture91
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

        private void cbo_ops_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double xOut;
            double yOut;

            double x = double.TryParse(tb_value1.Text, out xOut) ? xOut : 0;
            double y = double.TryParse(tb_value2.Text, out yOut) ? yOut : 0;

            switch (cbo_ops.SelectedIndex)
            {
                case 0:
                    lbl_result.Content = y != 0 ? (x / y).ToString() : "Err: Div by zero";
                    break;

                case 1:
                    lbl_result.Content = (x * y).ToString();
                    break;

                case 2:
                    lbl_result.Content = (x + y).ToString();
                    break;

                case 3:
                    lbl_result.Content = (x - y).ToString();
                    break;

                case 4:
                    lbl_result.Content = (x % y).ToString();
                    break;
            }
        }
    }
}
