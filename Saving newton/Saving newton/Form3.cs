using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Saving_newton
{ 
    public partial class Form3 : Form
    {

        int score = 0;
        int speed = 20;
        public Form3()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            
      

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pictureBox3.Left > 0)
                    pictureBox3.Left += -15;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox3.Left < 950)
                    pictureBox3.Left += 15;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            check();
            if (score == 50)
            {
                speed += 5;
            }
            if (score == 100)
            {
                speed += 5;
            }
            if (score == 150)
            {
                speed += 5;
            }
            if (score == 200)
            {
                speed += 5;
            }
            enemy(speed);  
        }

        Random r = new Random();
        int x, y;

    
        void enemy(int speed)
        {
            if (pictureBox1.Top >= 885)
            { 
                score += 1;
                label1.Text = "Score = "+score;
                x = r.Next(50, 300);
                pictureBox1.Location = new Point(x, 300);
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 885)
            {
                score += 1;
                label1.Text = "Score = " + score;
                x = r.Next(850, 1000);
                pictureBox2.Location = new Point(x, 300);
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox4.Top >= 885)
            {
                score += 1;
                label1.Text = "Score = " + score;
                x = r.Next(650, 800);
                pictureBox4.Location = new Point(x, 300);
            }
            else
            {
                pictureBox4.Top += speed;
            }


           if (pictureBox5.Top >= 885)
            {
                score += 1;
                label1.Text = "Score = " + score;
                x = r.Next(350, 600);
                pictureBox5.Location = new Point(x, 300);
            }
            else
            {
                pictureBox5.Top += speed;
             }
        }
        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==10)
            {
                string str = File.ReadAllText(@"C:\Users\umera\Documents\Visual Studio 2017\Projects\Saving newton\Saving newton\bin\x64\Debug\score.txt");
                if (score >= Convert.ToInt16(str))
                {
                    File.WriteAllText(@"score.txt", score.ToString());
                }

                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
        }

        void check()
        {
            if (pictureBox3.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                timer1.Enabled = false;
                label2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                timer2.Enabled = true;
            }

            else if (pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                timer1.Enabled = false;
                label2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                timer2.Enabled = true;
            }

            else if (pictureBox3.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                timer1.Enabled = false;
                label2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                timer2.Enabled = true;
            }

            else if (pictureBox3.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                timer1.Enabled = false;
                label2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                timer2.Enabled = true;
            }



        }

    }
}
