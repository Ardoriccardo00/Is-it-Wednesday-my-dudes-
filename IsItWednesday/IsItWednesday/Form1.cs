using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace IsItWednesday
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(@"C:\Users\richi\source\repos\Is-it-Wednesday-my-dudes-\IsItWednesday\IsItWednesday\Resources\wed.wav");
        string ris;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            ris = Convert.ToString(d.DayOfWeek);
            if (ris == "Wednesday") {
                Res.Text = "";
                timer1.Enabled = true;
                yes.Visible = true;
                player.Play();

                } else { Res.Text = "No :("; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true && pictureBox4.Visible == true && pictureBox5.Visible == true && pictureBox6.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else {
                pictureBox1.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }
    }
}
