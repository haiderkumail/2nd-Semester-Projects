using DSMS_Application.BL;
using DSMS_Application.DL;
using DSMS_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMS_Application
{
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        public Signup takeInputWithoutRole()
        {
            if (textBox1 != null && textBox2 != null)
            {
                Signup user = new Signup(textBox1.Text, textBox2.Text);
                return user;
            }
            return null;

        }
        
        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(textBox1 == null && textBox2==null)
            //{
            //    if (MessageBox.Show("Enter the ID and Password", "LOGIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            //    {
            //        this.Show();
            //    }
            //}
            Role();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignupMenu s=new SignupMenu();
            s.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void Role()
        {
            if (checkBox1.Checked)
            {
                AdminMenu a = new AdminMenu();
                a.Show();
            }
            else
            {
                CustomerMenu a = new CustomerMenu();
                a.Show();
                
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
