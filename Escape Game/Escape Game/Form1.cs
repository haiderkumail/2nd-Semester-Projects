using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_over.Hide();
        }

        bool left, right;
        int score;
        Random rnd=new Random();

        void Blocks()
        {
            foreach(Control x in this.Controls) 
            {
                if(x is PictureBox && x.Tag=="block")
                {
                    if(x.Top>450)
                    {
                        x.Top = 25;
                        x.Width = rnd.Next(50, 200);
                        score += 1;
                        lbl_score.Text = "Score : " + score;
                    }
                    if(Player.Bounds.IntersectsWith(x.Bounds)) 
                    {
                        lbl_over.Show();
                        timer1.Stop();
                    }
                    x.Top += 5;
                }
            }
        }

        void Player_Move()
        {
            if (right == true)
            {
                if (Player.Left < 280)
                {
                    Player.Left += 5;
                }

            }
            if (left == true)
            {
                if (Player.Right > 20)
                {
                    Player.Left -= 5;

                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Player_Move();
            Blocks();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }
    }
}
