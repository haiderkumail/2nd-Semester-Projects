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
    public partial class UpdateItem : Form
    {
        List<product> productlist = new List<product>();
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void loadData()
        {

            product s = new product();
            s.productName = textBox1.Text;
            s.price = textBox2.Text;
            s.quantity = textBox3.Text;

            productlist.Add(s);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productlist;
            dataGridView1.Refresh();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
