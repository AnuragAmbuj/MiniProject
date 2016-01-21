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
    public partial class SearchDialog : Form
    {
        public string text;
        public bool IsSelected;
        public SearchDialog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            IsSelected = checkBox1.Checked;
            SearchDialog.ActiveForm.Close();
        }
        public string GetKey()
        {
            return textBox1.Text;
        }
        public bool IsCheckBoxSelected()
        {
            return checkBox1.Checked;
        }
    }
}
