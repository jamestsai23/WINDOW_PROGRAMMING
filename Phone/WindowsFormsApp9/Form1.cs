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
using System.IO;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        bool isKeydown = false;
        int press = 0;
        int call = 0;
        String num = "";
        String log = "";
        String s1209 = @"1209.wav";
        String s1336 = @"1336.wav";
        String s1477 = @"1477.wav";
        String s697 = @"697.wav";
        String s770 = @"770.wav";
        String s852 = @"852.wav";
        String s941 = @"941.wav";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            label1.Text = "Telephone";
            label2.Text = "Save";
            label3.Text = "";
            button16.Text = "Save";
            button14.ImageList = imageList1;
            button14.ImageIndex = 0 ;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer2.settings.setMode("loop", true);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            label1.Text = "";

            this.KeyPreview = true;

            if (b.Text == "1") //1
            {
                num += "1";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1209;
                axWindowsMediaPlayer2.URL = s697;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "2")
            {
                num += "2";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1336;
                axWindowsMediaPlayer2.URL = s697;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "3")
            {
                num += "3";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1477;
                axWindowsMediaPlayer2.URL = s697;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "4")
            {
                num += "4";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1209;
                axWindowsMediaPlayer2.URL = s770;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "5")
            {
                num += "5";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1336;
                axWindowsMediaPlayer2.URL = s770;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "6")
            {
                num += "6";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1477;
                axWindowsMediaPlayer2.URL = s770;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "7")
            {
                num += "7";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1209;
                axWindowsMediaPlayer2.URL = s852;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "8")
            {
                num += "8";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1336;
                axWindowsMediaPlayer2.URL = s852;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "9")
            {
                num += "9";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1477;
                axWindowsMediaPlayer2.URL = s852;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "0")
            {
                num += "0";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1336;
                axWindowsMediaPlayer2.URL = s941;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "*")
            {
                num += "*";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1209;
                axWindowsMediaPlayer2.URL = s941;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (b.Text == "#")
            {
                num += "#";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1477;
                axWindowsMediaPlayer2.URL = s941;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            label1.Focus();
            this.KeyPreview = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            label1.Focus();
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e) //鍵盤輸入
        {
            this.KeyPreview = true;

            if (isKeydown)
                return;
            isKeydown = true;
            if (e.KeyValue == 49 || e.KeyValue == 97)
            {
                num += "1";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1209;
                axWindowsMediaPlayer2.URL = s697;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (e.KeyValue == 50 || e.KeyValue == 98)
            {
                num += "2";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1336;
                axWindowsMediaPlayer2.URL = s697;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (e.KeyValue == 51 || e.KeyValue == 99)
            {
                if (e.Shift == true)
                {
                    num += "#";
                    label1.Text = num;
                    axWindowsMediaPlayer1.URL = s1477;
                    axWindowsMediaPlayer2.URL = s941;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                }
                else
                {
                    num += "3";
                    label1.Text = num;
                    axWindowsMediaPlayer1.URL = s1477;
                    axWindowsMediaPlayer2.URL = s697;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                }
            }
            else if (e.KeyValue == 52 || e.KeyValue == 100)
            {
                num += "4";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1209;
                axWindowsMediaPlayer2.URL = s770;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (e.KeyValue == 53 || e.KeyValue == 101)
            {
                num += "5";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1336;
                axWindowsMediaPlayer2.URL = s770;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (e.KeyValue == 54 || e.KeyValue == 102)
            {
                num += "6";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1477;
                axWindowsMediaPlayer2.URL = s770;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play(); ;
            }
            else if (e.KeyValue == 55 || e.KeyValue == 103)
            {
                num += "7";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1209;
                axWindowsMediaPlayer2.URL = s852;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (e.KeyValue == 56 || e.KeyValue == 104)
            {
                if (e.Shift != true)
                {
                    num += "8";
                    label1.Text = num;
                    axWindowsMediaPlayer1.URL = s1336;
                    axWindowsMediaPlayer2.URL = s852;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                }
                else
                {
                    num += "*";
                    label1.Text = num;
                    axWindowsMediaPlayer1.URL = s1209;
                    axWindowsMediaPlayer2.URL = s941;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                }
            }
            else if (e.KeyValue == 57 || e.KeyValue == 105)
            {
                num += "9";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1477;
                axWindowsMediaPlayer2.URL = s852;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (e.KeyValue == 48 || e.KeyValue == 96)
            {
                num += "0";
                label1.Text = num;
                axWindowsMediaPlayer1.URL = s1336;
                axWindowsMediaPlayer2.URL = s941;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else if (e.KeyValue == 8) //back
            {
                if (label1.Text != "Telephone")
                {
                    int length = label1.Text.Length;
                    num = num.Remove(length - 1);
                    label1.Text = num;
                }
            }
            else if (e.KeyValue == 13) //enter
            {
                if (call == 0)
                {
                    call = 1;
                    button14.ImageIndex = 1;
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    button10.Enabled = false; button11.Enabled = false; button12.Enabled = false;
                    button13.Enabled = false; button15.Enabled = false;
                }
                else if (call == 1)
                {
                    call = 0;
                    button14.ImageIndex = 0;
                    button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
                    button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
                    button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
                    button10.Enabled = true; button11.Enabled = true; button12.Enabled = true;
                    button13.Enabled = true; button15.Enabled = true;
                    log += num + Environment.NewLine;
                    num = "";
                    label1.Text = "Telephone";
                    label3.Text = log;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Empty String", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                String address = textBox1.Text;
                FileInfo finfo = new FileInfo(address);
                if (finfo.Exists == false )
                {
                    MessageBox.Show("Directory Not Found","",MessageBoxButtons.OK,MessageBoxIcon.None);
                }
                else
                {
                    StreamWriter sw = finfo.CreateText();
                    sw.Write(label3.Text);
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("Done" + Environment.NewLine + finfo.FullName, "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            num = "";
            label1.Text = num;
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            if (call == 0)
            {
                call = 1;
                button14.ImageIndex = 1;
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                button10.Enabled = false; button11.Enabled = false; button12.Enabled = false;
                button13.Enabled = false; button15.Enabled = false;
            }
            else if (call == 1)
            {
                call = 0;
                button14.ImageIndex = 0;
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
                button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
                button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
                button10.Enabled = true; button11.Enabled = true; button12.Enabled = true;
                button13.Enabled = true; button15.Enabled = true;
                if (num.Equals("") != true)
                {
                    log += num + Environment.NewLine;
                    num = "";
                    label1.Text = "Telephone";
                    label3.Text = log;
                }
            }
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            if (label1.Text != "Telephone")
            {
                int length = label1.Text.Length;
                num = num.Remove(length - 1);
                label1.Text = num;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isKeydown = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        /*private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                num += "1";
                label1.Text = num;
            }
            else if (e.KeyChar == '2')
            {
                num += "2";
                label1.Text = num;
            }
            else if (e.KeyChar == '3')
            {
                num += "3";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '4')
            {
                num += "4";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '5')
            {
                num += "5";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '6')
            {
                num += "6";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '7')
            {
                num += "7";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '8')
            {
                num += "8";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '9')
            {
                num += "9";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '0')
            {
                num += "0";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '#')
            {
                num += "#";
                label1.Text = num;
                press = 0;
            }
            else if (e.KeyChar == '*')
            {
                num += "*";
                label1.Text = num;
                press = 0;
            }
        }*/

        private void button14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (call == 0)
                {
                    call = 1;
                    button14.ImageIndex = 1;
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    button10.Enabled = false; button11.Enabled = false; button12.Enabled = false;
                    button13.Enabled = false; button15.Enabled = false;
                }
                else if (call == 1)
                {
                    call = 0;
                    button14.ImageIndex = 0;
                    button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
                    button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
                    button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
                    button10.Enabled = true; button11.Enabled = true; button12.Enabled = true;
                    button13.Enabled = true; button15.Enabled = true;
                    if (num.Equals("") != true)
                    {
                        log += num + Environment.NewLine;
                        num = "";
                        label1.Text = "Telephone";
                        label3.Text = log;
                    }
                }
            }
        }

        /*private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "button14")
            {
                if (call == 0)
                {
                    call = 1;
                    button14.ImageIndex = 1;
                    button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                    button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                    button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                    button10.Enabled = false; button11.Enabled = false; button12.Enabled = false;
                    button13.Enabled = false; button15.Enabled = false;
                }
                else if (call == 1)
                {
                    call = 0;
                    button14.ImageIndex = 0;
                    button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
                    button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
                    button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
                    button10.Enabled = true; button11.Enabled = true; button12.Enabled = true;
                    button13.Enabled = true; button15.Enabled = true;
                    if (num.Equals("") != true)
                    {
                        log += num + Environment.NewLine;
                        num = "";
                        label1.Text = "Telephone";
                        label3.Text = log;
                    }
                }
            }
        }*/
    }
}
