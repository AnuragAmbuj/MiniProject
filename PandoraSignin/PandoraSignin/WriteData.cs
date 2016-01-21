using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PandoraSignin
{
    public partial class WriteData : Form
    {
        public WriteData()
        {
            InitializeComponent();
        }

        private void userLoginTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userLoginTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userInfoDataSet1);

        }

        private void WriteData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userInfoDataSet1.UserLoginTable' table. You can move, or remove it, as needed.
            this.userLoginTableTableAdapter.Fill(this.userInfoDataSet1.UserLoginTable);

        }
    }
}
