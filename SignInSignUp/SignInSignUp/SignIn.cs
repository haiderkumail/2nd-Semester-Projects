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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            label1.Text = "SignIn SignUp Application";
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome wl = new Welcome();
            wl.Show();
            this.Close();
        }
    }
}
