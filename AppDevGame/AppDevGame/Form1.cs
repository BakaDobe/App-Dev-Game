using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool left, right, jump;
        int force, speed;
        int frame = 1;


        void Enemys()
        {
            if(en1.Left > 600)
            {
                speed -= 1;
            }
            if(en1.Left < 200)
            {
                speed = 1;
            }
            en1.Left += speed;
            en2.Left += speed;
            en3.Left += speed;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Enemys();
            if (right == true)
            {
                if (astronaut.Left < 615)
                {
                    astronaut.Left += 2;
                }
            }

            if (left == true)
            {
                if (astronaut.Left > 10)
                {
                    astronaut.Left -= 2;
                }
            }

            if (jump == true)
            {
                astronaut.Top -= 3;
                force = 3;
                
            }

            if(jump == false)
            {
                astronaut.Top += force;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag=="base")
                {
                    if(astronaut.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        astronaut.Top = x.Top - astronaut.Height;
                        force = 0;
                    }

                    if (astronaut.Bounds.IntersectsWith(x.Bounds) && right || left)
                    {
                        force = 3;
                    }

                    if(astronaut.Bounds.IntersectsWith(x.Bounds)&& jump)
                    {
                        astronaut.Top = x.Top + astronaut.Height;
                        jump = false;
                    }

                    if(astronaut.Top + astronaut.Height < 50)
                    {
                        astronaut.Top += 3;
                    }
                }
            }
        }

        public void animate()
        {
            if (frame == 1)
            {
                astronaut.Image = Properties.Resources.RightRun;
            }
            else if(frame == 2)
            {
                astronaut.Image = Properties.Resources.LeftRun;
                frame = 1;
                return;
            }
            frame++;
        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            if (right == true)
            {
                animate();
            }

            if (left == true)
            {
                animate();
            }

            if (jump == true)
            {
                astronaut.Image = Properties.Resources.Jump;
            }
        }


        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = true;
                    break;
                case Keys.Left:
                    left = true;
                    break;
                case Keys.Up:
                    jump = true;
                    break;
            }
        }

        private void IsKeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = false;
                    astronaut.Image = Properties.Resources.Idle;
                    break;
                case Keys.Left:
                    left = false;
                    astronaut.Image = Properties.Resources.Idle;
                    break;
                case Keys.Up:
                    jump = false;
                    break;
            }
        }
    }
}
