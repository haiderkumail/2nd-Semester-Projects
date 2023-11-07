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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DSMS_Application
{
    public partial class AddItem : Form
    {
        List<product> productlist = new List<product>();
        public AddItem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadData()
        {

            product s = new product();
            s.productName = textBox1.Text;
            s.price = textBox2.Text;
            s.quantity =textBox3.Text;

            productlist.Add(s);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productlist;
            dataGridView1.Refresh();
        }

        private void AddItem_Load(object sender, EventArgs e)
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
