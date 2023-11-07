using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_over.Hide();
            restart.Hide();
            exit.Hide();
            
        }

        bool right, left,space;
        int score;
        void Game_Result()
        {
            foreach(Control j in this.Controls) 
            {
                foreach(Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if(i is PictureBox && i.Tag =="enemy")
                        {
                            if(j.Bounds.IntersectsWith(i.Bounds))
                            {
                                i.Top = -300;
                                ((PictureBox)j).Image = Properties.Resources.explotion;
                                score++;
                                lbl_score.Text = "Score : " + score;
                            }
                        }
                    }
                }
            }
            if(Player.Bounds.IntersectsWith(ship.Bounds)||Player.Bounds.IntersectsWith(alien.Bounds))
            {
                timer1.Stop();
                lbl_over.Show();
                lbl_over.BringToFront();
                restart.Show();
                restart.BringToFront();
                exit.Show();
                exit.BringToFront();


            }

        }
        void Stars()
        {
            foreach(Control j in this.Controls) 
            {
                if(j is PictureBox && j.Tag=="stars")
                {
                    j.Top += 10;
                    if(j.Top>400)
                    {
                        j.Top = 0;
                    }
                }
            }
        }
        void Add_Bullet()
        {
            PictureBox bullet= new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image=Properties.Resources.image;
            bullet.BackColor=System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = Player.Left + 15;
            bullet.Top=Player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        void Bullet_Movement()
        {
            foreach(Control x in this.Controls) 
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if(x.Top<100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }
        void Enemy_Movement()
        {
            Random rnd=new Random();
            int x, y;
            if(alien.Top>=500)
            {
                x=rnd.Next(0,300);
                alien.Location = new System.Drawing.Point(x,0);
            }
            if(ship.Top>=500)
            {
                y = rnd.Next(0, 300);
                ship.Location = new System.Drawing.Point(y,0);
            }
            else
            {
                alien.Top += 15;
                ship.Top += 10;
            }
        }
        void Arrow_Key_Movement()
        {
            if(right==true) 
            {
                if(Player.Left<425)
                {
                    Player.Left += 20;
                }
                
            }
            if(left==true) 
            {
                if(Player.Right>10)
                {
                    Player.Left -= 20;
                    
                }
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_Key_Movement();
            Enemy_Movement();
            Bullet_Movement();
            Stars();
            Game_Result();
        }

        public void restart_Click(object sender, EventArgs e)
        {
            score = 0;
            restartGame(sender,e);
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            exit.Show(); 
            exit.BringToFront();
            this.Close();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Right)
            {
                right = true;
            }
            if(e.KeyCode==Keys.Left)
            {
                left = true;
            }
            if(e.KeyCode==Keys.Space)
            {
                space = true;
                Add_Bullet();
            }
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
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }
        public void restartGame(object sender, EventArgs e)
        {
            lbl_over.Hide();
            restart.Hide();
            exit.Hide();
            timer1.Start();
            timer1_Tick(sender, e);
        }

        
    }
}
