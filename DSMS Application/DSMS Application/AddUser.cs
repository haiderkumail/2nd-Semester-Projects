using DSMS_Application.DL;
using DSMS_Application.BL;
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
    public partial class AddUser : Form
    {
        List<Admin> list = new List<Admin>();
        public AddUser()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void AddUser_Load(object sender, EventArgs e)
        {
            loadData();
            
        }
        public void loadData()
        {
           
            Admin s=new Admin();
            s.name = textBox1.Text;
            s.password = textBox2.Text;
            s.role = textBox3.Text;
            s.email = textBox4.Text;
            s.address = textBox5.Text;
           
            list.Add(s);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        
    }
}
