using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            loadData();

        }
        public void loadData()
        {
            Student s = new Student();
            s.ID = textBox1.Text;
            s.Password=textBox2.Text;
            s.Rollno = textBox3.Text;
            studentList.Add(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentList;
            dataGridView1.Refresh();
        }
        class Student
        {
            public string ID { get; set; }
            public string Password { get; set; }
            public string Rollno { get; set; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome wl = new welcome();
            wl.Show();
        }
    }
}
