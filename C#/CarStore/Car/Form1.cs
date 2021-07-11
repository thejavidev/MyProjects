using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
            gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
        }

        private void gunaTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            gunaLabel_prix.Text = gunaTrackBar1.Value.ToString() + "$";
        }

        private void gunaTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            gunaLabel_ann.Text = gunaTrackBar2.Value.ToString();
        }

        private void gunaTrackBar3_ValueChanged(object sender, EventArgs e)
        {
            gunaLabel_km.Text = gunaTrackBar3.Value.ToString() + "mk";
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox1.Image;
            gunaPictureBox_car1.Load("car picture\\11.png");
            gunaPictureBox_car2.Load("car picture\\111.png");
            gunaPictureBox_car3.Load("car picture\\1.png");

            gunaLabel_pp.Text = gunaLabel11.Text;
        }

        private void gunaPictureBox_car1_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox_car1.Image;
        }

        private void gunaPictureBox_car2_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox_car2.Image;
        }

        private void gunaPictureBox_car3_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox_car3.Image;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox2.Image;
            gunaPictureBox_car1.Load("car picture\\22.png");
            gunaPictureBox_car2.Load("car picture\\222.png");
            gunaPictureBox_car3.Load("car picture\\2.png");

            gunaLabel_pp.Text = gunaLabel12.Text;
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox4.Image;
            gunaPictureBox_car1.Load("car picture\\77.png");
            gunaPictureBox_car2.Load("car picture\\777.png");
            gunaPictureBox_car3.Load("car picture\\7.png");

            gunaLabel_pp.Text = gunaLabel18.Text;
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox3.Image;
            gunaPictureBox_car1.Load("car picture\\5.png");
            gunaPictureBox_car2.Load("car picture\\555.png");
            gunaPictureBox_car3.Load("car picture\\5.png");

            gunaLabel_pp.Text = gunaLabel15.Text;
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox6.Image;
            gunaPictureBox_car1.Load("car picture\\6.png");
            gunaPictureBox_car2.Load("car picture\\666.png");
            gunaPictureBox_car3.Load("car picture\\66.png");

            gunaLabel_pp.Text = gunaLabel24.Text;
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox5.Image;
            gunaPictureBox_car1.Load("car picture\\4.png");
            gunaPictureBox_car2.Load("car picture\\444.png");
            gunaPictureBox_car3.Load("car picture\\44.png");

            gunaLabel_pp.Text = gunaLabel21.Text;
        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            gunaPictureBox_car.Image = gunaPictureBox7.Image;
            gunaPictureBox_car1.Load("car picture\\rolls_royce_PNG18.png");
            gunaPictureBox_car2.Load("car picture\\rolls_royce_PNG18.png");
            gunaPictureBox_car3.Load("car picture\\rolls_royce_PNG18.png");

            gunaLabel_pp.Text = gunaLabel27.Text;
        }

        private void gunaLabel30_Click(object sender, EventArgs e)
        {

        }
    }
}
