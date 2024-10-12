using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int run, whichlist;
        string stack1 = "", stack2 = "", stack3 = "", stack4 = "";
        string row1 = "1 1 2", row2 = "2 2", row3 = "", row4 = "3 3 3 1";
        string row1b = "1 1 2", row2b = "2 2", row3b = "", row4b = "3 3 3 1";
        int wincheck1 = 0, wincheck2 = 0, wincheck3 = 0, wincheck4 = 0;
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
        List<int> list4 = new List<int>();
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //執行
        {
            row1 = "1 1 2";
            row2 = "2 2";
            row3 = "";
            row4 = "3 3 3 1";
            
            textBox1.Text = row1;
            textBox2.Text = row2;
            textBox3.Text = row3;
            textBox4.Text = row4;

            label6.Visible = false; label6.Enabled = false;
            label7.Visible = false; label7.Enabled = false;
            label8.Visible = false; label8.Enabled = false;
            label9.Visible = false; label9.Enabled = false;
            label10.Visible = false; label10.Enabled = false;
            button2.Visible = false; button2.Enabled = false;
            button3.Visible = false; button3.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button6.Visible = false; button6.Enabled = false;
            button7.Visible = false; button7.Enabled = false;
            button8.Visible = false; button8.Enabled = false;
            button9.Visible = false; button9.Enabled = false;
            button10.Visible = false; button10.Enabled = false;
            label11.Visible = false; label11.Enabled = false;
            label12.Visible = false; label12.Enabled = false;
            label13.Visible = false; label13.Enabled = false;
            label14.Visible = false; label14.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) //選取
        {
            label10.Text = "你選了堆疊1";
            button2.Visible = false; button2.Enabled = false;
            button3.Visible = false; button3.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button7.Visible = true; button7.Enabled = true;
            button8.Visible = true; button8.Enabled = true;
            button9.Visible = true; button9.Enabled = true;
            button10.Visible = true; button10.Enabled = true;

            if (list2.Count == 4) button8.Enabled = false;
            if (list3.Count == 4) button9.Enabled = false;
            if (list4.Count == 4) button10.Enabled = false;

            run = list1[list1.Count - 1];
            whichlist = 1;

        }

        
        private void button3_Click(object sender, EventArgs e) //堆疊
        {
            label10.Text = "你選了堆疊2";
            button2.Visible = false; button2.Enabled = false;
            button3.Visible = false; button3.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button7.Visible = true; button7.Enabled = true;
            button8.Visible = true; button8.Enabled = true;
            button9.Visible = true; button9.Enabled = true;
            button10.Visible = true; button10.Enabled = true;

            if (list1.Count == 4) button7.Enabled = false;
            if (list2.Count == 4) button8.Enabled = false;
            if (list3.Count == 4) button9.Enabled = false;
            if (list4.Count == 4) button10.Enabled = false;

            run = list2[list2.Count - 1];
            whichlist = 2;
        }

        private void button6_Click(object sender, EventArgs e) //回主畫面
        {
            textBox1.Text = row1b;
            textBox2.Text = row2b;
            textBox3.Text = row3b;
            textBox4.Text = row4b;


            label1.Visible = true; label1.Enabled = true;
            label2.Visible = true; label2.Enabled = true;
            label3.Visible = true; label3.Enabled = true;
            label4.Visible = true; label4.Enabled = true;
            label5.Visible = true; label5.Enabled = true;
            textBox1.Visible = true; textBox1.Enabled = true;
            textBox2.Visible = true; textBox2.Enabled = true;
            textBox3.Visible = true; textBox3.Enabled = true;
            textBox4.Visible = true; textBox4.Enabled = true;
            button1.Visible = true; button1.Enabled = true;

            label6.Visible = false; label6.Enabled = false;
            label7.Visible = false; label7.Enabled = false;
            label8.Visible = false; label8.Enabled = false;
            label9.Visible = false; label9.Enabled = false;
            label10.Visible = false; label10.Enabled = false;
            button2.Visible = false; button2.Enabled = false;
            button3.Visible = false; button3.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button6.Visible = false; button6.Enabled = false;
            button7.Visible = false; button7.Enabled = false;
            button8.Visible = false; button8.Enabled = false;
            button9.Visible = false; button9.Enabled = false;
            button10.Visible = false; button10.Enabled = false;
            label11.Visible = false; label11.Enabled = false;
            label12.Visible = false; label12.Enabled = false;
            label13.Visible = false; label13.Enabled = false;
            label14.Visible = false; label14.Enabled = false;
            
        }

        private void button4_Click(object sender, EventArgs e) //推疊3
        {
            label10.Text = "你選了堆疊3";
            button2.Visible = false; button2.Enabled = false;
            button3.Visible = false; button3.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button7.Visible = true; button7.Enabled = true;
            button8.Visible = true; button8.Enabled = true;
            button9.Visible = true; button9.Enabled = true;
            button10.Visible = true; button10.Enabled = true;

            if (list1.Count == 4) button7.Enabled = false;
            if (list2.Count == 4) button8.Enabled = false;
            if (list3.Count == 4) button9.Enabled = false;
            if (list4.Count == 4) button10.Enabled = false;

            run = list3[list3.Count - 1];
            whichlist = 3;
        }

        private void button5_Click(object sender, EventArgs e) //推疊4
        {
            label10.Text = "你選了堆疊4";
            button2.Visible = false; button2.Enabled = false;
            button3.Visible = false; button3.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button7.Visible = true; button7.Enabled = true;
            button8.Visible = true; button8.Enabled = true;
            button9.Visible = true; button9.Enabled = true;
            button10.Visible = true; button10.Enabled = true;

            if (list1.Count == 4) button7.Enabled = false;
            if (list2.Count == 4) button8.Enabled = false;
            if (list3.Count == 4) button9.Enabled = false;
            if (list4.Count == 4) button10.Enabled = false;

            run = list4[list4.Count - 1];
            whichlist = 4;
        }


        private void button7_Click(object sender, EventArgs e) //放置1
        {
            label10.Text = "...";
            button2.Visible = true; button2.Enabled = true;
            button3.Visible = true; button3.Enabled = true;
            button4.Visible = true; button4.Enabled = true;
            button5.Visible = true; button5.Enabled = true;
            button7.Visible = false; button7.Enabled = false;
            button8.Visible = false; button8.Enabled = false;
            button9.Visible = false; button9.Enabled = false;
            button10.Visible = false; button10.Enabled = false;

            if (list1.Count == 0) button2.Enabled = false;
            if (list2.Count == 0) button3.Enabled = false;
            if (list3.Count == 0) button4.Enabled = false;
            if (list4.Count == 0) button5.Enabled = false;

            list1.Add(run);

            stack1 = "";
            stack2 = "";
            stack3 = "";
            stack4 = "";

            if (whichlist == 1) list1.RemoveRange(list1.Count - 1, 1);
            if (whichlist == 2) list2.RemoveRange(list2.Count - 1, 1);
            if (whichlist == 3) list3.RemoveRange(list3.Count - 1, 1);
            if (whichlist == 4) list4.RemoveRange(list4.Count - 1, 1);

            for (int i = list1.Count - 1; i >= 0; i--)
            {
                stack1 += list1[i] + Environment.NewLine;
            }
            for (int i = list2.Count - 1; i >= 0; i--)
            {
                stack2 += list2[i] + Environment.NewLine;
            }
            for (int i = list3.Count - 1; i >= 0; i--)
            {
                stack3 += list3[i] + Environment.NewLine;
            }
            for (int i = list4.Count - 1; i >= 0; i--)
            {
                stack4 += list4[i] + Environment.NewLine;
            }

            label11.Text = stack1;
            label12.Text = stack2;
            label13.Text = stack3;
            label14.Text = stack4;

            wincheck1 = 0; wincheck2 = 0; wincheck3 = 0; wincheck4 = 0;

            if (list1.Count>=3)
            {
                if (list1[0] == list1[1] && list1[1] == list1[2])
                    wincheck1 = 1;
            }
            if (list2.Count >= 3)
            {
                if(list2[0] == list2[1] && list2[1] == list2[2])
                wincheck2 = 1;
            }
            if (list3.Count >= 3)
            {
                if (list3[0] == list3[1] && list3[1] == list3[2])
                    wincheck3 = 1;
            }
            if (list4.Count >= 3)
            {
                if (list4[0] == list4[1] && list4[1] == list4[2])
                    wincheck4 = 1;
            }

            if (wincheck1+wincheck2+wincheck3+wincheck4  == 3)
            {
                button2.Enabled = false; button2.Text = "贏";
                button3.Enabled = false; button3.Text = "贏";
                button4.Enabled = false; button4.Text = "贏";
                button5.Enabled = false; button5.Text = "贏";
                label10.Text = "你贏了";
            }

        }

        private void button8_Click(object sender, EventArgs e) //放置2
        {
            label10.Text = "...";
            button2.Visible = true; button2.Enabled = true;
            button3.Visible = true; button3.Enabled = true;
            button4.Visible = true; button4.Enabled = true;
            button5.Visible = true; button5.Enabled = true;
            button7.Visible = false; button7.Enabled = false;
            button8.Visible = false; button8.Enabled = false;
            button9.Visible = false; button9.Enabled = false;
            button10.Visible = false; button10.Enabled = false;

            if (list1.Count == 0) button2.Enabled = false;
            if (list2.Count == 0) button3.Enabled = false;
            if (list3.Count == 0) button4.Enabled = false;
            if (list4.Count == 0) button5.Enabled = false;

            list2.Add(run);


            stack1 = "";
            stack2 = "";
            stack3 = "";
            stack4 = "";

            if (whichlist == 1) list1.RemoveRange(list1.Count - 1, 1);
            if (whichlist == 2) list2.RemoveRange(list2.Count - 1, 1);
            if (whichlist == 3) list3.RemoveRange(list3.Count - 1, 1);
            if (whichlist == 4) list4.RemoveRange(list4.Count - 1, 1);


            for (int i = list1.Count - 1; i >= 0; i--)
            {
                stack1 += list1[i] + Environment.NewLine;
            }
            for (int i = list2.Count - 1; i >= 0; i--)
            {
                stack2 += list2[i] + Environment.NewLine;
            }
            for (int i = list3.Count - 1; i >= 0; i--)
            {
                stack3 += list3[i] + Environment.NewLine;
            }
            for (int i = list4.Count - 1; i >= 0; i--)
            {
                stack4 += list4[i] + Environment.NewLine;
            }


            label11.Text = stack1;
            label12.Text = stack2;
            label13.Text = stack3;
            label14.Text = stack4;

            wincheck1 = 0; wincheck2 = 0; wincheck3 = 0; wincheck4 = 0;

            if (list1.Count >= 3)
            {
                if (list1[0] == list1[1] && list1[1] == list1[2])
                    wincheck1 = 1;
            }
            if (list2.Count >= 3)
            {
                if (list2[0] == list2[1] && list2[1] == list2[2])
                    wincheck2 = 1;
            }
            if (list3.Count >= 3)
            {
                if (list3[0] == list3[1] && list3[1] == list3[2])
                    wincheck3 = 1;
            }
            if (list4.Count >= 3)
            {
                if (list4[0] == list4[1] && list4[1] == list4[2])
                    wincheck4 = 1;
            }

            if (wincheck1 + wincheck2 + wincheck3 + wincheck4 == 3)
            {
                button2.Enabled = false; button2.Text = "贏";
                button3.Enabled = false; button3.Text = "贏";
                button4.Enabled = false; button4.Text = "贏";
                button5.Enabled = false; button5.Text = "贏";
                label10.Text = "你贏了";
            }

        }

        private void button9_Click(object sender, EventArgs e) //放置3
        {
            label10.Text = "...";
            button2.Visible = true; button2.Enabled = true;
            button3.Visible = true; button3.Enabled = true;
            button4.Visible = true; button4.Enabled = true;
            button5.Visible = true; button5.Enabled = true;
            button7.Visible = false; button7.Enabled = false;
            button8.Visible = false; button8.Enabled = false;
            button9.Visible = false; button9.Enabled = false;
            button10.Visible = false; button10.Enabled = false;

            if (list1.Count == 0) button2.Enabled = false;
            if (list2.Count == 0) button3.Enabled = false;
            if (list3.Count == 0) button4.Enabled = false;
            if (list4.Count == 0) button5.Enabled = false;

            list3.Add(run);

            stack1 = "";
            stack2 = "";
            stack3 = "";
            stack4 = "";

            if (whichlist == 1) list1.RemoveRange(list1.Count - 1, 1);
            if (whichlist == 2) list2.RemoveRange(list2.Count - 1, 1);
            if (whichlist == 3) list3.RemoveRange(list3.Count - 1, 1);
            if (whichlist == 4) list4.RemoveRange(list4.Count - 1, 1);

            for (int i = list1.Count - 1; i >= 0; i--)
            {
                stack1 += list1[i] + Environment.NewLine;
            }
            for (int i = list2.Count - 1; i >= 0; i--)
            {
                stack2 += list2[i] + Environment.NewLine;
            }
            for (int i = list3.Count - 1; i >= 0; i--)
            {
                stack3 += list3[i] + Environment.NewLine;
            }
            for (int i = list4.Count - 1; i >= 0; i--)
            {
                stack4 += list4[i] + Environment.NewLine;
            }

            label11.Text = stack1;
            label12.Text = stack2;
            label13.Text = stack3;
            label14.Text = stack4;

            wincheck1 = 0; wincheck2 = 0; wincheck3 = 0; wincheck4 = 0;

            if (list1.Count >= 3)
            {
                if (list1[0] == list1[1] && list1[1] == list1[2])
                    wincheck1 = 1;
            }
            if (list2.Count >= 3)
            {
                if (list2[0] == list2[1] && list2[1] == list2[2])
                    wincheck2 = 1;
            }
            if (list3.Count >= 3)
            {
                if (list3[0] == list3[1] && list3[1] == list3[2])
                    wincheck3 = 1;
            }
            if (list4.Count >= 3)
            {
                if (list4[0] == list4[1] && list4[1] == list4[2])
                    wincheck4 = 1;
            }

            if (wincheck1 + wincheck2 + wincheck3 + wincheck4 == 3)
            {
                button2.Enabled = false; button2.Text = "贏";
                button3.Enabled = false; button3.Text = "贏";
                button4.Enabled = false; button4.Text = "贏";
                button5.Enabled = false; button5.Text = "贏";
                label10.Text = "你贏了";
            }
        }

        private void button10_Click(object sender, EventArgs e) //放置4
        {
            label10.Text = "...";
            button2.Visible = true; button2.Enabled = true;
            button3.Visible = true; button3.Enabled = true;
            button4.Visible = true; button4.Enabled = true;
            button5.Visible = true; button5.Enabled = true;
            button7.Visible = false; button7.Enabled = false;
            button8.Visible = false; button8.Enabled = false;
            button9.Visible = false; button9.Enabled = false;
            button10.Visible = false; button10.Enabled = false;

            if (list1.Count == 0) button2.Enabled = false;
            if (list2.Count == 0) button3.Enabled = false;
            if (list3.Count == 0) button4.Enabled = false;
            if (list4.Count == 0) button5.Enabled = false;

            list4.Add(run);

            stack1 = "";
            stack2 = "";
            stack3 = "";
            stack4 = "";

            if (whichlist == 1) list1.RemoveRange(list1.Count - 1, 1);
            if (whichlist == 2) list2.RemoveRange(list2.Count - 1, 1);
            if (whichlist == 3) list3.RemoveRange(list3.Count - 1, 1);
            if (whichlist == 4) list4.RemoveRange(list4.Count - 1, 1);

            for (int i = list1.Count - 1; i >= 0; i--)
            {
                stack1 += list1[i] + Environment.NewLine;
            }
            for (int i = list2.Count - 1; i >= 0; i--)
            {
                stack2 += list2[i] + Environment.NewLine;
            }
            for (int i = list3.Count - 1; i >= 0; i--)
            {
                stack3 += list3[i] + Environment.NewLine;
            }
            for (int i = list4.Count - 1; i >= 0; i--)
            {
                stack4 += list4[i] + Environment.NewLine;
            }

            label11.Text = stack1;
            label12.Text = stack2;
            label13.Text = stack3;
            label14.Text = stack4;

            wincheck1 = 0; wincheck2 = 0; wincheck3 = 0; wincheck4 = 0;

            if (list1.Count >= 3)
            {
                if (list1[0] == list1[1] && list1[1] == list1[2])
                    wincheck1 = 1;
            }
            if (list2.Count >= 3)
            {
                if (list2[0] == list2[1] && list2[1] == list2[2])
                    wincheck2 = 1;
            }
            if (list3.Count >= 3)
            {
                if (list3[0] == list3[1] && list3[1] == list3[2])
                    wincheck3 = 1;
            }
            if (list4.Count >= 3)
            {
                if (list4[0] == list4[1] && list4[1] == list4[2])
                    wincheck4 = 1;
            }

            if (wincheck1 + wincheck2 + wincheck3 + wincheck4 == 3)
            {
                button2.Enabled = false; button2.Text = "贏";
                button3.Enabled = false; button3.Text = "贏";
                button4.Enabled = false; button4.Text = "贏";
                button5.Enabled = false; button5.Text = "贏";
                label10.Text = "你贏了";
            }
        }

        private void button1_Click(object sender, EventArgs e) //開始遊戲
        {
            int num1 = 0, num2 = 0, num3 = 0;
            bool haveempty = false, itsnum = true;

            row1 = textBox1.Text;
            row2 = textBox2.Text;
            row3 = textBox3.Text;
            row4 = textBox4.Text;

            stack1 = "";
            stack2 = "";
            stack3 = "";
            stack4 = "";


            if (row1.Length != 0)
            {
                if (row1.IndexOf(" ") == 0)
                    haveempty = true;
                if (row1.LastIndexOf(" ") == row1.Length - 1)
                    haveempty = true;
            }
            if (row2.Length != 0)
            {
                if (row2.IndexOf(" ") == 0)
                    haveempty = true;
                if (row2.LastIndexOf(" ") == row2.Length - 1)
                    haveempty = true;
            }
            if (row3.Length !=0)
            {
                if (row3.IndexOf(" ") == 0)
                    haveempty = true;
                if (row3.LastIndexOf(" ") == row3.Length - 1)
                    haveempty = true;
            }
            if (row4.Length != 0)
            {
                if (row4.IndexOf(" ") == 0)
                    haveempty = true;
                if (row4.LastIndexOf(" ") == row4.Length - 1)
                    haveempty = true;
            }

            string[] stacknum1 = new string[10];
            string[] stacknum2 = new string[10];
            string[] stacknum3 = new string[10];
            string[] stacknum4 = new string[10];

            stacknum1 = row1.Split(' ');
            stacknum2 = row2.Split(' ');
            stacknum3 = row3.Split(' ');
            stacknum4 = row4.Split(' ');

            if (row1.Length != 0)
            {
                for (int i = 0; i < stacknum1.Length; i++)
                {
                    if (stacknum1[i] == "1") num1++;
                    if (stacknum1[i] == "2") num2++;
                    if (stacknum1[i] == "3") num3++;
                    if (stacknum1[i] != "1" && stacknum1[i] != "2" && stacknum1[i] != "3") itsnum = false;
                }
            }
            if (row2.Length != 0)
            {
                for (int i = 0; i < stacknum2.Length; i++)
                {
                    if (stacknum2[i] == "1") num1++;
                    if (stacknum2[i] == "2") num2++;
                    if (stacknum2[i] == "3") num3++;
                    if (stacknum2[i] != "1" && stacknum2[i] != "2" && stacknum2[i] != "3") itsnum = false;
                }
            }
            if (row3.Length != 0)
            {
                for (int i = 0; i < stacknum3.Length; i++)
                {
                    if (stacknum3[i] == "1") num1++;
                    if (stacknum3[i] == "2") num2++;
                    if (stacknum3[i] == "3") num3++;
                    if (stacknum3[i] != "1" && stacknum3[i] != "2" && stacknum2[i] != "3") itsnum = false;
                }
            }
            if (row4.Length != 0)
            {
                for (int i = 0; i < stacknum4.Length; i++)
                {
                    if (stacknum4[i] == "1") num1++;
                    if (stacknum4[i] == "2") num2++;
                    if (stacknum4[i] == "3") num3++;
                    if (stacknum4[i] != "1" && stacknum4[i] != "2" && stacknum4[i] != "3") itsnum = false;
                }
            }

            if (num1!=3 || num2!=3 || num3 != 3 || stacknum1.Length>4 || stacknum2.Length>4 || stacknum3.Length>4 || stacknum4.Length>4 || itsnum ==false)
            {
                label1.Text = "測資錯誤";
            }

            else if (haveempty == true)
            {
                label1.Text = "測資錯誤";
            }

            else
            {
                label6.Visible = true; label6.Enabled = true;
                label7.Visible = true; label7.Enabled = true;
                label8.Visible = true; label8.Enabled = true;
                label9.Visible = true; label9.Enabled = true;
                label10.Visible = true; label10.Enabled = true;
                button2.Visible = true; button2.Enabled = true;
                button3.Visible = true; button3.Enabled = true;
                button4.Visible = true; button4.Enabled = true;
                button5.Visible = true; button5.Enabled = true;
                button6.Visible = true; button6.Enabled = true;
                label11.Visible = true; label11.Enabled = true;
                label12.Visible = true; label12.Enabled = true;
                label13.Visible = true; label13.Enabled = true;
                label14.Visible = true; label14.Enabled = true;

                label1.Visible = false; label1.Enabled = false;
                label2.Visible = false; label2.Enabled = false;
                label3.Visible = false; label3.Enabled = false;
                label4.Visible = false; label4.Enabled = false;
                label5.Visible = false; label5.Enabled = false;
                button1.Visible = false; button1.Enabled = false;
                textBox1.Visible = false; textBox1.Enabled = false;
                textBox2.Visible = false; textBox2.Enabled = false;
                textBox3.Visible = false; textBox3.Enabled = false;
                textBox4.Visible = false; textBox4.Enabled = false;

                if (row1.Length == 0) button2.Enabled = false;
                if (row2.Length == 0) button3.Enabled = false;
                if (row3.Length == 0) button4.Enabled = false;
                if (row4.Length == 0) button5.Enabled = false;

                list1.Clear();
                list2.Clear();
                list3.Clear();
                list4.Clear();

                if (stacknum1.Length > 1 || stacknum1[0] == "1" || stacknum1[0] == "2" || stacknum1[0] == "3")
                {
                    for (int i = 0; i < stacknum1.Length; i++)
                    {
                        list1.Add(int.Parse(stacknum1[i]));
                    }
                }
                if (stacknum2.Length > 1 || stacknum2[0] == "1" || stacknum2[0] == "2" || stacknum2[0] == "3")
                {
                    for (int i = 0; i < stacknum2.Length; i++)
                    {
                        list2.Add(int.Parse(stacknum2[i]));
                    }
                }
                if (stacknum3.Length > 1 || stacknum3[0] == "1" || stacknum3[0] == "2" || stacknum3[0] == "3")
                {
                    for (int i = 0; i < stacknum3.Length; i++)
                    {
                        list3.Add(int.Parse(stacknum3[i]));
                    }
                }
                if (stacknum2.Length > 1 || stacknum2[0] == "1" || stacknum2[0] == "2" || stacknum2[0] == "3")
                {
                    for (int i = 0; i < stacknum4.Length; i++)
                    {
                        list4.Add(int.Parse(stacknum4[i]));
                    }
                }

               

                for (int i = list1.Count-1 ;i >= 0; i--)
                {
                    stack1 += list1[i] + Environment.NewLine;
                }
                for (int i = list2.Count-1; i >=0; i--)
                {
                    stack2 += list2[i] + Environment.NewLine;
                }
                for (int i = list3.Count-1; i >=0; i--)
                {
                    stack3 += list3[i] + Environment.NewLine;
                }
                for (int i = list4.Count-1; i >=0; i--)
                {
                    stack4 += list4[i] + Environment.NewLine;
                }
                
                label11.Text = stack1;
                label12.Text = stack2;
                label13.Text = stack3;
                label14.Text = stack4;
            }
            
        }
    }
}
