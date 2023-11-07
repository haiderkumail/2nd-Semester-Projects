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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UpdateItem updateItem = new UpdateItem();
            updateItem.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DeleteItem deleteItem = new DeleteItem();
            deleteItem.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
        }
    }
}
