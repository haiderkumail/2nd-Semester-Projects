using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            label1.Text = "SignIn SignUp Application";
            label1.Font = new Font(label1.Font, FontStyle.Italic);

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIn s = new SignIn();
            SignUp s1 = new SignUp();

            if (checkBox1.Checked == true)
            {
                s.Show();
            }
            else if(checkBox2.Checked == true)
            {
                s1.Show();
            }
        }
    }
}
