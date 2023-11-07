using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void AddValues()
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {

            }
            else
            {
                string value1 = textBox1.Text;
                string value2 = textBox2.Text;

                double result = double.Parse(value1) + double.Parse(value2);
                button2.Text = "Result: " + result;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddValues();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            AddValues();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            AddValues();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            AddValues();
        }

    }
}
