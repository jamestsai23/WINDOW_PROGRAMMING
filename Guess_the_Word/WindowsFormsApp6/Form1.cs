using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Button[] btn = new Button[26];
        int sec = 0, wrongnum = 0;
        int correctnum;
        string lowanswer, answer;
        List<char> anslist = new List<char>();
        List<char> line = new List<char>();
        List<char> rep = new List<char>();
        bool correct = false;
        bool repeat = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Reset() //重新開始
        {
            wrongnum = 0;
            //gameover = 0;
            sec = 0;
            anslist.Clear();
            line.Clear();
            rep.Clear();
            label2.Text = "猜錯次數：" + wrongnum +"次";
            label1.Text = "時間：" + sec.ToString();


            timer1.Enabled = false; //時間暫停
            timer1.Interval = 1000; //轉成秒

            label1.Visible = false; label2.Visible = false;
            label3.Visible = true; label4.Visible = true;
            label3.Enabled = true; label4.Enabled = true;
            label3.Text = "猜英文單字" + Environment.NewLine + "6次猜錯機會";
            button1.Enabled = false;
            button1.Visible = true;
            label5.Visible = false;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox1.Text = "";
            this.KeyPreview = false;

        }

        private void button1_Click(object sender, EventArgs e) //start
        {
            this.KeyPreview = true;
            lowanswer = textBox1.Text;
            answer = lowanswer.ToUpper();
            correctnum = answer.Length;
            char[] ansarray = answer.ToCharArray();
            label5.Text = "";
            label5.Visible = true;
            for (int i = 0; i < answer.Length; i++)
            {
                anslist.Add(ansarray[i]);
                line.Add('_');
                label5.Text += "_ ";
            }
            label3.Visible = false; label3.Enabled = false;
            label4.Visible = false; label4.Enabled = false;
            textBox1.Visible = false; textBox1.Enabled = false;
            button1.Visible = false; button1.Enabled = false;
            timer1.Enabled = true;
            for (int i = 0; i < 26; i++)
            {
                btn[i].Enabled = true; btn[i].Visible = true;
                btn[i].BackColor = Color.White;
            }
            label1.Visible = true; label2.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if ((e.KeyChar < 'a' || e.KeyChar >'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z'))   //非小寫
            {
                if (e.KeyChar < 'A' || e.KeyChar > 'Z') //非大寫
                {
                    if ((byte)e.KeyChar != 8)
                        e.Handled = true;
                    else
                    {
                        if (textBox1.Text.Length == 0)
                            button1.Enabled = false;
                    }
                        
                }
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = "時間：" + sec;
            sec++;
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < 26; i++) //總共26字母
            {
                if (e.KeyValue == 65 + i || e.KeyValue == 97 + i) //檢查是哪一個字母
                {
                    correct = false;
                    repeat = false;
                    for (int w = 0; w < rep.Count; w++)
                    {
                        if (rep[w] == 65 + i)
                        {
                            repeat = true;
                        }
                    }
                    rep.Add((char)(65 + i));
                    if (repeat == false)
                    {
                        for (int j = 0; j < answer.Length; j++) //檢查此字母是否與單字有重疊
                        {
                            if (anslist[j] == 65 + i)
                            {
                                correct = true;
                                correctnum--;
                                btn[i].BackColor = Color.LightGreen;
                                line[j] = (char)(65 + i);
                            }
                        }
                        if (correct == true) //有重疊
                        {
                            label5.Text = "";
                            for (int k = 0; k < answer.Length; k++)
                            {
                                label5.Text += line[k] + " ";
                            }
                        }

                        if (correctnum == 0)
                        {
                            timer1.Enabled = false;
                            DialogResult result;
                            result = MessageBox.Show("花費時間：" + (sec-1) + Environment.NewLine + "猜錯次數" + wrongnum + "次", "You win!", MessageBoxButtons.OK, MessageBoxIcon.None);
                            
                            if (result == DialogResult.OK)
                            {
                                Reset();
                                for (int l = 0; l < 26; l++)
                                {
                                    btn[l].Visible = false; btn[l].Enabled = false;
                                }
                            }
                        }
                        if (correct == false) //沒有
                        {
                            btn[i].Visible = false; btn[i].Enabled = false;
                            wrongnum++;
                            label2.Text = "猜錯次數：" + wrongnum + "次";
                        }
                        if (wrongnum == 6)
                        {
                            timer1.Enabled = false;
                            DialogResult result;
                            result = MessageBox.Show("You Lose!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            if (result == DialogResult.OK)
                            {
                                Reset();
                                for (int l = 0; l < 26; l++)
                                {
                                    btn[l].Visible = false; btn[l].Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*for (int i =0; i < 26; i++) //總共26字母
            {
                if (e.KeyChar == 65+i || e.KeyChar == 97+i) //檢查是哪一個字母
                {
                    correct = false;
                    repeat = false;
                    for (int w = 0; w < rep.Count; w++)
                    {
                        if(rep[w] == 65+i)
                        {
                            repeat = true;
                        }
                    }
                    rep.Add((char)(65 + i));
                    if (repeat == false)
                    {
                        for (int j = 0; j < answer.Length; j++) //檢查此字母是否與單字有重疊
                        {
                            if (anslist[j] == 65 + i)
                            {
                                correct = true;
                                correctnum--;
                                btn[i].BackColor = Color.LightGreen;
                                line[j] = (char)(65 + i);
                            }
                        }
                        if (correct == true) //有重疊
                        {
                            label5.Text = "";
                            for (int k = 0; k < answer.Length; k++)
                            {
                                label5.Text += line[k] + " ";
                            }
                        }

                        if (correctnum == 0)
                        {
                            DialogResult result;
                            result = MessageBox.Show("花費時間：" + sec + Environment.NewLine + "猜錯次數" + wrongnum + "次", "You win!", MessageBoxButtons.OK, MessageBoxIcon.None);
                            timer1.Enabled = false;
                            if (result == DialogResult.OK)
                            {
                                Reset();
                                for (int l = 0; l < 26; l++)
                                {
                                    btn[l].Visible = false; btn[l].Enabled = false;
                                }
                            }
                        }
                        if (correct == false) //沒有
                        {
                            btn[i].Visible = false; btn[i].Enabled = false;
                            wrongnum++;
                            label2.Text = "猜錯次數：" + wrongnum + "次";
                        }
                        if (wrongnum == 6)
                        {
                            DialogResult result;
                            result = MessageBox.Show("You Lose!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            timer1.Enabled = false;
                            if (result == DialogResult.OK)
                            {
                                Reset();
                                for (int l = 0; l < 26; l++)
                                {
                                    btn[l].Visible = false; btn[l].Enabled = false;
                                }
                            }
                        }
                    }
                }
            }*/
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();

            label1.Visible = false; label2.Visible = false;
            label3.Text = "猜英文單字" + Environment.NewLine + "6次猜錯機會";
            button1.Enabled = false;
            label5.Visible = false;
            

            for (int i = 0; i < 26; i++)
            {
                btn[i] = new Button();
                btn[i].Width = 40;
                btn[i].Height = 40;
                btn[i].Enabled = false; btn[i].Visible = false;
                btn[i].Text = Char.ToString((char)(65+i));
                if (i < 20)
                {
                    btn[i].Location = new Point(130 + (i % 10) * 45, 30 + (i / 10) *45);
                }
                else
                {
                    btn[i].Location = new Point(220 + (i % 10) * 45, 120 );
                }
                Controls.Add(btn[i]);
            }
        }

        
    }
}
