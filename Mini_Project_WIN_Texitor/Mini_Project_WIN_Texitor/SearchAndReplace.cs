using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texitor
{
    public partial class SearchAndReplace : Form
    {
        string searchtext;
        string replaceText;
        bool ShouldConsiderCase;
        bool ShouldReplaceAll;
        public SearchAndReplace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchtext = textBox1.Text;
            replaceText = textBox2.Text;
            ShouldConsiderCase = checkBox1.Checked;
            ShouldReplaceAll = checkBox2.Checked;
            SearchAndReplace.ActiveForm.Close();
        }
        public string GetKey()
        {
            return searchtext;
        }
        public string GetReplaceKey()
        {
            return replaceText;
        }
        public bool ConsiderMatchCase()
        {
            return ShouldConsiderCase;
        }
        public bool ConsiderReplaceAll()
        {
            return ShouldReplaceAll;
        }
    }
}
