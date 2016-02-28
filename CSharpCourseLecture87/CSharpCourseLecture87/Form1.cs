using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSharpCourseLecture87
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            Split the search string according to blank spaces as the separator
            so we can examine the words individually
            then compare the words to the word in the searh box
            if they are the same, store that word inside occurances
            at the end, display the count of words in occurances.
            */
            var occurences = from word in rtb_searchString.Text.Split(new char[] { ' ' })
                             where word.ToString().ToLower() == tb_searchBox.Text.ToLower()
                             select word;

            //Display number of occurances of the contents of the search box in the search string
            lbl_count.Text = occurences.Count().ToString();
        }
    }
}
