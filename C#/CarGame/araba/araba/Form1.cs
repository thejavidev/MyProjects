using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
            button1.Visible = false;
        }
        Random r = new Random();
        int x, y;
        private void timer1_Tick(object sender, EventArgs e)
        {
            movieline(gamespeed);
            angry(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();

        }
        int collectedcoin = 0;

        void angry (int speed)
        {
            if (angry1.Top >= 500)
            {
                x = r.Next(0, 200);
                angry1.Location = new Point(x, 0);
            }
            else { angry1.Top += speed; }

            if(angry2.Top >= 500)
            {
                x = r.Next(0, 400);
                angry2.Location = new Point(x, 0);
            }
            else { angry2.Top += speed; }

            if(angry3.Top >= 500)
            {
                x = r.Next(200, 350);
                angry3.Location = new Point(x, 0);
            }
            else { angry3.Top += speed; }
        }

        void coins(int speed)
        {
            if (coin1.Top >=500)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }
        void gameover()
        {
            if (car.Bounds.IntersectsWith(angry1 .Bounds ))
            {
                timer1.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
                
            }
            if (car.Bounds.IntersectsWith(angry2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(angry3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                button1.Visible = true;
            }
        }
        void movieline (int speed)
        { 
            if(pictxbx1.Top >=500)
            {
                pictxbx1.Top = 0;
            }else { pictxbx1.Top += speed; }
            if (pictxbx2.Top >= 500)
            {
                pictxbx2.Top = 0;
            }else { pictxbx2.Top += speed; }
            if (pictxbx3.Top >= 500)
            {
                pictxbx3.Top = 0;
            }
            else { pictxbx3.Top += speed; }
            if (pictxbx4.Top >= 500)
            {
                pictxbx4.Top = 0;
            }
            else { pictxbx4.Top += speed; }

        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Puanlar " + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Puanlar " + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin2.Location = new Point(x, 0);

            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Puanlar " + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Puanlar " + collectedcoin.ToString();
                x = r.Next(50, 300);
                coin4.Location = new Point(x, 0);
            }
        }
        int gamespeed = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Left )
            {
                if(car.Left >2)
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right )
            {
                if (car.Right < 380)
                    car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
           
        }
    }
}
