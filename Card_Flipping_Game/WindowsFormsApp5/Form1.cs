using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        int[] repeat = new int[] { 2, 2, 2, 2, 2, 2, 2, 2 };
        int[] pic = new int[16];
        int imgnum;
        int point = 100;
        int finish = 0;
        int clicknum = 2;
        int firstpic, secondpic;
        string record = "";
        string name;
        Button[] bb = new Button[16]; // 背面
        Button[] bf = new Button[16]; //正面
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnstr_Click(object sender, EventArgs e) // 開始遊戲
        {
            name = textBox1.Text;
            if(name == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (name.Length < 3 || name.Length > 10)
            {
                MessageBox.Show("名稱不合格式(>=3 && <=10)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                for (int i = 0; i < 16; i++)
                {
                    bb[i].Visible = true; bb[i].Enabled = true;
                }
                btnstr.Enabled = false;
                textBox1.Enabled = false;
                Randcard();
            }
        }

        private void Randcard() //隨機發牌
        {
            for (int i = 0; i < 16; i++)
            {
                for (; ; ) //檢查次數
                {
                    imgnum = rnd.Next(0, 8);
                    if (repeat[imgnum] != 0)
                    {
                        pic[i] = imgnum;
                        bf[i].ImageIndex = imgnum;
                        repeat[imgnum]--;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //btn1
        {
            clicknum--; //第幾張卡
            bb[0].Visible = false; //背面消失
            bb[0].Enabled = false;
            bf[0].Visible = true; //正面出現
            bf[0].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 0; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 0;
                clicknum = 2;

                if (pic[0] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[0].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數："+point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[1].Visible = false; //背面消失
            bb[1].Enabled = false;
            bf[1].Visible = true; //正面出現
            bf[1].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 1; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 1;
                clicknum = 2;

                if (pic[1] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[1].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[2].Visible = false; //背面消失
            bb[2].Enabled = false;
            bf[2].Visible = true; //正面出現
            bf[2].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 2; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 2;
                clicknum = 2;

                if (pic[2] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[2].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[3].Visible = false; //背面消失
            bb[3].Enabled = false;
            bf[3].Visible = true; //正面出現
            bf[3].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 3; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 3;
                clicknum = 2;

                if (pic[3] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[3].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[4].Visible = false; //背面消失
            bb[4].Enabled = false;
            bf[4].Visible = true; //正面出現
            bf[4].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 4; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 4;
                clicknum = 2;

                if (pic[4] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[4].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[5].Visible = false; //背面消失
            bb[5].Enabled = false;
            bf[5].Visible = true; //正面出現
            bf[5].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 5; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 5;
                clicknum = 2;

                if (pic[5] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[5].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[6].Visible = false; //背面消失
            bb[6].Enabled = false;
            bf[6].Visible = true; //正面出現
            bf[6].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 6; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 6;
                clicknum = 2;

                if (pic[6] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[6].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[7].Visible = false; //背面消失
            bb[7].Enabled = false;
            bf[7].Visible = true; //正面出現
            bf[7].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 7; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 7;
                clicknum = 2;

                if (pic[7] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[7].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[8].Visible = false; //背面消失
            bb[8].Enabled = false;
            bf[8].Visible = true; //正面出現
            bf[8].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 8; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 8;
                clicknum = 2;

                if (pic[8] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[8].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[9].Visible = false; //背面消失
            bb[9].Enabled = false;
            bf[9].Visible = true; //正面出現
            bf[9].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 9; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 9;
                clicknum = 2;

                if (pic[9] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[9].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[10].Visible = false; //背面消失
            bb[10].Enabled = false;
            bf[10].Visible = true; //正面出現
            bf[10].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 10; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 10;
                clicknum = 2;

                if (pic[10] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[10].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[11].Visible = false; //背面消失
            bb[11].Enabled = false;
            bf[11].Visible = true; //正面出現
            bf[11].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 11; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 11;
                clicknum = 2;

                if (pic[11] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[11].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[12].Visible = false; //背面消失
            bb[12].Enabled = false;
            bf[12].Visible = true; //正面出現
            bf[12].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 12; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 12;
                clicknum = 2;

                if (pic[12] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[12].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[13].Visible = false; //背面消失
            bb[13].Enabled = false;
            bf[13].Visible = true; //正面出現
            bf[13].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 13; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 13;
                clicknum = 2;

                if (pic[13] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[13].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[14].Visible = false; //背面消失
            bb[14].Enabled = false;
            bf[14].Visible = true; //正面出現
            bf[14].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 14; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 14;
                clicknum = 2;

                if (pic[14] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[14].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clicknum--; //第幾張卡
            bb[15].Visible = false; //背面消失
            bb[15].Enabled = false;
            bf[15].Visible = true; //正面出現
            bf[15].Enabled = true;

            if (clicknum == 1)
            {
                firstpic = 15; // 紀錄是翻第幾張卡
            }
            else
            {
                secondpic = 15;
                clicknum = 2;

                if (pic[15] == pic[firstpic]) //檢查是否為同張卡
                {
                    bf[15].Enabled = false;
                    bf[firstpic].Enabled = false;
                    finish += 2;
                    point += 10;
                    label2.Text = "分數：" + point;
                    if (finish == 16)
                    {
                        record += textBox1.Text + "得分為：" + point + Environment.NewLine + Environment.NewLine;
                        label4.Text = record;
                        DialogResult result;
                        result = MessageBox.Show("分數：" + point, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Retry)
                        {
                            Reply();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bb[i].Enabled = false;
                    }
                    btncon.Enabled = true;
                }
            }
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            bf[firstpic].Visible = false; bf[firstpic].Enabled = false;
            bf[secondpic].Visible = false; bf[secondpic].Enabled = false;
            bb[firstpic].Visible = true; bb[firstpic].Enabled = true;
            bb[secondpic].Visible = true; bb[secondpic].Enabled = true;

            point -= 5;
            label2.Text = "分數：" + point;
            btncon.Enabled = false;

            for (int i = 0; i < 16; i++)
            {
                bb[i].Enabled = true;
            }
        }

        private void btnre_Click(object sender, EventArgs e) //重新開始
        {
            Reply();
        }

        private void Reply() //重新開始
        {
            btnstr.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "";
            point = 100;
            label2.Text = "分數：100";
            finish = 0;
            clicknum = 2;
            for (int i=0;i<8;i++)
            {
                repeat[i] = 2;
            }
            for (int i = 0; i < 16; i++)
            {
                bb[i].Enabled = false; bb[i].Visible = false;
                bf[i].Enabled = false; bf[i].Visible = false;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("確定要離開遊戲?", "離開遊戲,", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e) // 初始畫面
        {
            bb[0] = button1; bb[4] = button5; bb[8] = button9; bb[12] = button13;
            bb[1] = button2; bb[5] = button6; bb[9] = button10; bb[13] = button14;
            bb[2] = button3; bb[6] = button7; bb[10] = button11; bb[14] = button15;
            bb[3] = button4; bb[7] = button8; bb[11] = button12; bb[15] = button16;

            bf[0] = button21; bf[4] = button25; bf[8] = button29; bf[12] = button33;
            bf[1] = button22; bf[5] = button26; bf[9] = button30; bf[13] = button34;
            bf[2] = button23; bf[6] = button27; bf[10] = button31; bf[14] = button35;
            bf[3] = button24; bf[7] = button28; bf[11] = button32; bf[15] = button36;

            btnstr.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = "";

            for (int i = 0; i < 16; i++)
            {
                bb[i].ImageList = imageList1;
                bf[i].ImageList = imageList1;

                bb[i].ImageIndex = 8;

                bb[i].Enabled = false; bb[i].Visible = false;
                bf[i].Enabled = false; bf[i].Visible = false;
            }
        }
    }
}
