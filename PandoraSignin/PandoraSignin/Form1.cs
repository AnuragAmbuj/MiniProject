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
using System.Data.SqlTypes;
using System.Diagnostics;

namespace PandoraSignin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string password=textBox2.Text;
            string query="select * from UserLoginTable where username="+"\'"+username+"\'"+" and password="+"\'"+password+"\';";
            UserInfoDataSet1 ui = new UserInfoDataSet1();
            if ((username.Equals("Anurag") && password.Equals("ambuj")) || (username.Equals("Avinash") && password.Equals("kumar")) || (username.Equals("ShubhaMadam") && password.Equals(""))|| (username.Equals("Ravi") && password.Equals("kant")))
            {
                ProcessStartInfo psi = new ProcessStartInfo("PandoraBoxConsole.exe");
                Process.Start(psi);
                Form1.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteData wd = new WriteData();
            wd.Show();
        }
    }
}
