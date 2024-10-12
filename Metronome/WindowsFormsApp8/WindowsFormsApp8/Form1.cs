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
using System.Media;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int mode = 1;
        int box = 4;
        int sec = 0;
        int run = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString() + " BPM";
            timer1.Interval = 1000 / (240 / 60);
            timer1.Enabled = true;
            label5.Text = ""; label6.Text = ""; label7.Text = ""; label8.Text = ""; label9.Text = ""; label10.Text = ""; label11.Text = ""; label12.Text = "";
            label9.Visible = false; label10.Visible = false; label11.Visible = false; label12.Visible = false;
            label5.BackColor = Color.Gray; label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int f = trackBar1.Value;
            label3.Text = trackBar1.Value.ToString() + " BPM";
            timer1.Interval = (1000 / (f / 60)) / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int f = trackBar1.Value;
            String filename_ding = @"ding.wav";
            String filename_dong = @"dong.wav";
            String filename_doo = @"doo.wav";
            SoundPlayer playerding = new SoundPlayer(filename_ding);
            SoundPlayer playerdong = new SoundPlayer(filename_dong);
            SoundPlayer playerdoo = new SoundPlayer(filename_doo);
            timer1.Interval = (1000 / (f / 60)) / 2 ;
            sec++;
            if(mode == 1)
            {
                if (box == 4)
                {
                    if (sec % 8 == 2)
                    {
                        label5.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;

                        playerding.Play();
                    }
                    else if (sec % 8 == 4)
                    {
                        label6.BackColor = Color.LightGreen;
                        label5.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 8 == 6)
                    {
                        label7.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label5.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 8 == 0)
                    {
                        label8.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label5.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                }
                else
                {
                    label9.Visible = true; label10.Visible = true; label11.Visible = true; label12.Visible = true;
                    
                    if (sec % 16 == 2)
                    {
                        label5.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerding.Play();
                    }
                    else if (sec % 16 == 4)
                    {
                        label9.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label5.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 6)
                    {
                        label6.BackColor = Color.LightGreen;
                        label5.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 8)
                    {
                        label10.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label5.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 10)
                    {
                        label7.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label5.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 12)
                    {
                        label11.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label5.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 14)
                    {
                        label8.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label5.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 0)
                    {
                        label12.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label5.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                }
            }
            else
            {
                if (box == 4)
                {
                    if (sec % 8 == 2)
                    {
                        label5.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;

                        playerding.Play();
                    }
                    else if (sec % 8 == 4)
                    {
                        label6.BackColor = Color.LightGreen;
                        label5.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 8 == 5)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 8 == 6)
                    {
                        label7.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label5.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 8 == 7)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 8 == 0)
                    {
                        label8.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label5.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 8 == 1)
                    {
                        playerdoo.Play();
                    }
                }
                else
                {
                    label9.Visible = true; label10.Visible = true; label11.Visible = true; label12.Visible = true;

                    if (sec % 16 == 2)
                    {
                        label5.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerding.Play();
                    }
                    else if (sec % 16 == 4)
                    {
                        label9.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label5.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 5)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 16 == 6)
                    {
                        label6.BackColor = Color.LightGreen;
                        label5.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 7)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 16 == 8)
                    {
                        label10.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label5.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 9)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 16 == 10)
                    {
                        label7.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label5.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 11)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 16 == 12)
                    {
                        label11.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label5.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 13)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 16 == 14)
                    {
                        label8.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label5.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label12.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 15)
                    {
                        playerdoo.Play();
                    }
                    else if (sec % 16 == 0)
                    {
                        label12.BackColor = Color.LightGreen;
                        label6.BackColor = Color.Gray; label7.BackColor = Color.Gray; label8.BackColor = Color.Gray; label9.BackColor = Color.Gray; label10.BackColor = Color.Gray; label11.BackColor = Color.Gray; label5.BackColor = Color.Gray;
                        playerdong.Play();
                    }
                    else if (sec % 16 == 1)
                    {
                        playerdoo.Play();
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //一拍一音
        {
            mode = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //一拍二音
        {
            mode = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "4")
            {
                box = 4;
                label9.Visible = false; label10.Visible = false; label11.Visible = false; label12.Visible = false;
            }
            else
            {
                box = 8;
                label9.Visible = true; label10.Visible = true; label11.Visible = true; label12.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (run == 1)
            {
                button1.Text = "Start";
                timer1.Enabled = false;
                sec = 0;
                run = 0;
            }
            else
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
                sec = 0;
                run = 1;
            }
        }
    }
}
