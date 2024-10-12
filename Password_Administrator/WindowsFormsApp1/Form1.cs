using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string web;
        string nl = Environment.NewLine;

        Class1 user = new Class1();
        List<Class1> list1 = new List<Class1>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //搜尋
        {
            string contain = "";
            web = textBox1.Text;
            if (web == null)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    contain += "連結：" + list1[i].userweb + Environment.NewLine + "使用者：" + list1[i].username + Environment.NewLine + "密碼：" + list1[i].usercode + Environment.NewLine + "====================" + Environment.NewLine;
                }
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[i].userweb.Contains(web))
                    {
                        contain += "連結：" + list1[i].userweb + Environment.NewLine + "使用者：" + list1[i].username + Environment.NewLine + "密碼：" + list1[i].usercode + Environment.NewLine + "====================" + Environment.NewLine;
                    }
                }
            }
            textBox2.Text = contain;
    
            
        }

        private void button2_Click(object sender, EventArgs e) //風險帳號
        {
            string contain="";
            for (int i=0;i<list1.Count;i++)
            {
                for(int j=i+1;j<list1.Count;j++)
                {
                    if (list1[i].usercode == list1[j].usercode)
                    {
                        list1[i].recode = true;
                        list1[j].recode = true;
                    }
                }
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if(list1[i].recode == true)
                {
                    contain += "連結：" + list1[i].userweb + Environment.NewLine + "使用者：" + list1[i].username + Environment.NewLine + "密碼：" + list1[i].usercode + Environment.NewLine + "====================" + Environment.NewLine;
                }
            }

            textBox2.Text = contain;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false; label4.Enabled = false;
            label5.Visible = false; label5.Enabled = false;
            label6.Visible = false; label6.Enabled = false;
            label7.Visible = false; label7.Enabled = false;
            textBox3.Visible = false; textBox3.Enabled = false;
            textBox4.Visible = false; textBox4.Enabled = false;
            textBox5.Visible = false; textBox5.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button6.Visible = false; button6.Enabled = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //新增
        {
            string newweb, newcode, newname;
            bool reweb = false, rename = false;
            newweb = textBox3.Text;
            newname = textBox4.Text;
            newcode = textBox5.Text;
            for (int i=0;i<list1.Count;i++)
            {
                if (list1[i].userweb == newweb) {
                    reweb = true;

                    if (list1[i].username == newname)
                    {
                        rename = true;
                    }
                } 
            }

            if (reweb == true && rename == true) {
                label4.Text = "帳號已存在";
            }
            else {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                label4.Text = "新增成功";

                list1.Add(new Class1() { userweb = newweb, username = newname, usercode = newcode });
            }

        }

        private void button3_Click(object sender, EventArgs e) //新增或刪除
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Enabled = false;
            textBox2.Visible = false; textBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false; button3.Visible = false;

            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "我是狀態列";

            label4.Visible = true; label4.Enabled = true;
            label5.Visible = true; label5.Enabled = true;
            label6.Visible = true; label6.Enabled = true;
            label7.Visible = true; label7.Enabled = true;
            textBox3.Visible = true; textBox3.Enabled = true;
            textBox4.Visible = true; textBox4.Enabled = true;
            textBox5.Visible = true; textBox5.Enabled = true;
            button4.Visible = true; button4.Enabled = true;
            button5.Visible = true; button5.Enabled = true;
            button6.Visible = true; button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e) //回主選單
        {
            label3.Visible = true;
            label3.Visible = true;
            textBox1.Enabled = true;
            textBox2.Visible = true; textBox2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true; button3.Visible = true;

            label4.Visible = false; label4.Enabled = false;
            label5.Visible = false; label5.Enabled = false;
            label6.Visible = false; label6.Enabled = false;
            label7.Visible = false; label7.Enabled = false;
            textBox3.Visible = false; textBox3.Enabled = false;
            textBox4.Visible = false; textBox4.Enabled = false;
            textBox5.Visible = false; textBox5.Enabled = false;
            button4.Visible = false; button4.Enabled = false;
            button5.Visible = false; button5.Enabled = false;
            button6.Visible = false; button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e) //刪除
        {
            int renum = 0;
            string newweb, newcode, newname;
            bool reweb = false, rename = false, recode = false;
            newweb = textBox3.Text;
            newname = textBox4.Text;
            newcode = textBox5.Text;

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].userweb == newweb)
                {
                    reweb = true;

                    if (list1[i].username == newname)
                    {
                        rename = true;

                        if (list1[i].usercode == newcode)
                        {
                            recode = true;
                            renum = i;
                        }
                    }
                }
            }

            if (reweb == true && rename == true && recode == true)
            {
                label4.Text = "刪除成功";
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                list1.RemoveAt(renum);
            }
            else
            {
                label4.Text = "帳號不存在或密碼錯誤";
            }
        }

        
    }
}
