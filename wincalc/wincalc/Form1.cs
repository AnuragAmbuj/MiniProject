using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wincalc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        Double res = 0, sub = 0;
        Double mul = 1;
        bool isfirstoperation = true;
        String operation = "";
        bool operation_pressed = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button_click(object sender, EventArgs e) //for buttons 1-9 & . 
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();
            operation_pressed = false;
            
            
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
            
        }

        private void button12_Click(object sender, EventArgs e)
        { 
            equation.Text="0";
            result.Text = "0";
            res = 0;
            sub = 0;
            value = 0;
            mul = 1;
            isfirstoperation = true;
            
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text = (int.Parse(result.Text)/10).ToString() ;     
            
        }

        private void operator_click(object sender, EventArgs e) //for operators +,-,*,/
        {
            Button b = (Button)sender;
            operation = b.Text; 
            value = Double.Parse(result.Text);
            operation_pressed = true;
            
            

            switch (operation)
            {
                case "+": 
                          res = value + res;
                          result.Text = (res).ToString();
                           break;
                case "-":
                    if (isfirstoperation)
                    {
                        sub= value - sub;
                        isfirstoperation = false;
                        break;
                    }
                    sub = (-1) * (value - sub);
                    result.Text = (sub).ToString();

                    break;
                case "*":
                    mul = (value * mul);
                    result.Text = (mul).ToString();
                    break;
                case "/":
                    if (b.Text == "+" || b.Text == "-")
                    {
                        res = res / value;
                        result.Text = (res).ToString();
                    }
                    else if (b.Text == "*")
                    {
                        mul = mul * value;
                        result.Text = (mul).ToString();
                    }


                    break;


                default: break;
            }           
             equation.Text = result.Text + " " + operation;
             
        }

        private void button18_Click(object sender, EventArgs e) //for = operator
        {
            equation.Text = value + " " + operation+" "+result.Text+" "+"=";
            switch(operation)
            {
                case "+": 
                    
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default: break;
            }
           
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
