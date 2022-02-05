using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saving_newton
{
    public partial class Splash_screen : Form
    {
        public Splash_screen()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.PaleVioletRed;
            timer1.Enabled = true;
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
        }
    }
}
