using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using EZInput;

namespace pang_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pbPlayerShip.Left = pbPlayerShip.Left + 25;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pbPlayerShip.Left = pbPlayerShip.Left - 25;
            }
        }

    }
}
