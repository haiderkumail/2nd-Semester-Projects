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
    public partial class SignUp : Form
    {
        public List<Student> studentList = new List<Student>();
        public SignUp()
        {
            InitializeComponent();
            InitializeComponent();
            label1.Text = "SignIn SignUp Application";
            label1.Font = new Font(label1.Font, FontStyle.Italic);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "abced24";
            loadData();
            label2.Text = "gjmgmm";

            //Welcome2 wl = new Welcome2();
            //wl.Show();
            //this.Close();
        }
        public void loadData()
        {
            
            string name = textBox1.Text;
            string password = textBox2.Text;
            string role= textBox3.Text;

            Student s = new Student(name, password, role);
            studentList.Add(s);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentList;
            dataGridView1.Refresh();
        }
        public class Student
        {
            public string name { get; set; }
            public string password { get; set; }
            public string role { get; set; }

            public Student(string n, string p, string r)
            {
                this.name = n;
                this.password = p;
                this.role = r;
            }
           

        }
        

    }
}
