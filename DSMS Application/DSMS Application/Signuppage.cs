using DSMS_Application.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DSMS_Application.DL;

namespace DSMS_Application
{
    public partial class SignupMenu : Form
    {
        public SignupMenu()
        {
            InitializeComponent();
        }

        private void Signuppage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("User Created Successfully","SIGN UP",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("User Already Exist");
            }
        }
    }
}
