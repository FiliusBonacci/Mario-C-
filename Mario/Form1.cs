using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario
{
    public partial class Form1 : Form
    {
        bool right;
        bool left;
        bool jump;
        int gravity = 30;
        int Force;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // kolizja boczna
            if (player.Right > block.Left && player.Left < block.Right - player.Width
                && player.Bottom >block.Top)
                right = false;
            if (player.Left < block.Right && player.Right > block.Left + player.Width
                && player.Bottom > block.Top)
                left = false;



            // ruch
            if (right) player.Left += 5;
            if (left) player.Left -= 5;
            if (jump) // jezeli byl skok
            {
                player.Top -= Force;
                Force--;
            }
            if (player.Top + player.Height >= scene.Height)
            {
                player.Top = scene.Height - player.Height; // zatrzymaj spadanie na podlodze
                jump = false;
            }
            else
            {
                player.Top += 5; 
            }

            // kolizja gorna
            if(player.Left + player.Width - 1 > block.Left  && player.Left + player.Width + 5 < block.Left + block.Width
                 + player.Width
                && player.Top + player.Height >= block.Top && player.Top < block.Top)
            {
                player.Top = scene.Height - block.Height - player.Height;
                jump = false;
                Force = 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Escape) this.Close();

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = gravity;
                }
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) right = false;
            if (e.KeyCode == Keys.Left) left = false;
        }
    }
}
