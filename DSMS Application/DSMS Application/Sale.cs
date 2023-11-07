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
   
    public partial class Sale : Form
    {
        List<Admin> admin = new List<Admin>();
        List<product> product = new List<product>();
        public Sale()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            sale(product, admin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sale(product, admin);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void sale(List<product> product, List<Admin> admin)
        {
            AdminDL dL = new AdminDL();
            dL.OverallSale(product, admin);
        }
    }
}
