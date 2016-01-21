using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PandoraBoxConsole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process p = Process.GetCurrentProcess();
            int x = p.BasePriority;
            MessageBox.Show("Process " + p.ProcessName + " has priority " + x + " and has ID "+p.Id+" and is of type "+p.GetType().ToString(),"Pandora's Box Running Process Information");
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo psr=new ProcessStartInfo();
            psr.FileName="Texitor.exe";
            Process.Start(psr);
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button2.Select();
            label1.Select();
            label1.BackColor = Color.Blue;
            button2.BackColor = Color.Black;
            label2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Select();
            label1.Select();
            label1.BackColor = Color.Blue;
            button2.BackColor = Color.Black;
            label2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo psr = new ProcessStartInfo();
            psr.FileName = "PANDORA_TRIDENT_SURFER.exe";
            Process.Start(psr);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Blue;
            button1.BackColor = Color.Black;
            label1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Blue;
            label2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Black;
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "wincalc.exe";
            Process.Start(psi);
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "pan.pdfreader.exe";
            Process.Start(psi);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Blue;
            label1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Blue;
            button1.BackColor = Color.Black;
            label1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void label5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.FlatStyle = FlatStyle.Popup;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Select();
            button3.Select();
            label3.BackColor = Color.Blue;
            label2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Black;
            label4.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show(Form1.ActiveForm);
            lf.ShowInTaskbar = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PandoraBoxAbout pba = new PandoraBoxAbout();
            if (pba.ShowDialog() == DialogResult.OK)
            {

            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Blue;
            label1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
        }
    }
}
