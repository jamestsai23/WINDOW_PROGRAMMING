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

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {

        List<string> name = new List<string>();
        string origin = "";
        int newone = 1;
        int num = 0;
        string address = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
            Text = "未命名*-待辦清單";
            button1.Text = "完成事項";
            button2.Text = "新增事項";
            button3.Text = "關閉搜尋"; button3.Visible = false; button3.Enabled = false;
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All File(*.*)|*.*";
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All File(*.*)|*.*";
            saveFileDialog1.DefaultExt = "todo";
        }

        private void munExit_Click(object sender, EventArgs e) //離開
        {
            Application.Exit();
        }

        private void mnuNew_Click(object sender, EventArgs e) // 新增
        {
            textBox1.Text = "";
            newone = 1;
            name.Clear();
            num = 0;
            Text = "未命名*-待辦清單";

        }

        private void munFont_Click(object sender, EventArgs e) //字型大小
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e) //開啟
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    newone = 0;
                    name.Clear();
                    num = 0;
                    textBox1.Text = "";
                    FileInfo finfo = new FileInfo(openFileDialog1.FileName);
                    address = openFileDialog1.FileName;
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string path = Path.GetFileNameWithoutExtension(address);
                    Text = path + "-待辦清單";

                    num = 0;
                    do
                    {
                        name.Add(sr.ReadLine());
                        if (name[num] == null) break;
                        num++;
                    } while (true);

                    name.RemoveAt(name.Count - 1);

                    for (int i = 0; i < num; i++)
                    {
                        if (name[i].Substring(0,1) == "+")
                        {
                            textBox1.Text += " [√] " + name[i].Substring(1) + "\r\n";
                        }
                        else
                        {
                            textBox1.Text += " [ ] " + name[i].Substring(1) + "\r\n";
                        }
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //新增事項
        {
            Form2 f = new Form2();
            f.ShowDialog();
            if (f.ok == 1)
            {
                string a = "-" + f.name;
                name.Add(a);
                textBox1.Text += " [ ] " + f.name + "\r\n";
                num++;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e) //儲存
        {
            if (newone == 0)
            {
                FileInfo finfo = new FileInfo(address);
                StreamWriter sw = finfo.CreateText();
                origin = "";
                for (int i = 0; i< name.Count; i++)
                {
                    origin += name[i] + "\r\n";
                }
                sw.WriteLine(origin);
                sw.Flush();
                sw.Close();
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string address = saveFileDialog1.FileName;
                    FileInfo finfo = new FileInfo(address);
                    StreamWriter sw = finfo.CreateText();
                    origin = "";
                    for (int i = 0; i < name.Count; i++)
                    {
                        origin += name[i] + "\r\n";
                    }
                    sw.WriteLine(origin);
                    sw.Flush();
                    sw.Close();
                    string path = Path.GetFileNameWithoutExtension(address);
                    Text = path + "-代辦清單";
                }
            }
        }

        private void mnuAsave_Click(object sender, EventArgs e) //另存新檔
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string address = saveFileDialog1.FileName;
                FileInfo finfo = new FileInfo(address);
                StreamWriter sw = finfo.CreateText();
                origin = "";
                for (int i = 0; i < name.Count; i++)
                {
                    origin += name[i] + "\r\n";
                }
                sw.WriteLine(origin);
                sw.Flush();
                sw.Close();
                string path = Path.GetFileNameWithoutExtension(address);
                Text = path + "-代辦清單";
            }
        }

        private void button1_Click(object sender, EventArgs e) //完成事項
        {
            Form3 f = new Form3();
            f.ShowDialog();
            if (f.ok == 1)
            {
                int match = -1;
                for(int i = 0; i < num; i++)
                {
                    if (Equals(f.name, name[i].Substring(1)))
                    {
                        match = i;
                    }
                }
                if (match != -1)
                {
                    name[match] = "+" + name[match].Substring(1);
                }
                textBox1.Text = "";
                for (int i = 0; i<name.Count; i++)
                {
                    if (name[i].Substring(0, 1) == "+")
                    {
                        textBox1.Text += " [√] " + name[i].Substring(1) + "\r\n";
                    }
                    else
                    {
                        textBox1.Text += " [ ] " + name[i].Substring(1) + "\r\n";
                    }
                }
            }
        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].Substring(0, 1) == "+")
                {
                    textBox1.Text += " [√] " + name[i].Substring(1) + "\r\n";
                }
                else
                {
                    textBox1.Text += " [ ] " + name[i].Substring(1) + "\r\n";
                }
            }
        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i].Substring(0, 1) == "-")
                {
                    textBox1.Text += " [ ] " + name[i].Substring(1) + "\r\n";
                }
            }
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            if (f.ok == 1)
            {
                int match = -1;
                for (int i = 0; i < num; i++)
                {
                    if (Equals(f.name, name[i].Substring(1)))
                    {
                        match = i;
                    }
                }
                if (match != -1)
                {
                    name.RemoveAt(match);
                    num = name.Count();
                }
                textBox1.Text = "";
                for (int i = 0; i < name.Count; i++)
                {
                    if (name[i].Substring(0, 1) == "+")
                    {
                        textBox1.Text += " [√] " + name[i].Substring(1) + "\r\n";
                    }
                    else
                    {
                        textBox1.Text += " [ ] " + name[i].Substring(1) + "\r\n";
                    }
                }
            }
        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            if (f.ok ==1)
            {
                origin = textBox1.Text;
                textBox1.Text = "";
                for (int i = 0; i < name.Count; i++)
                {
                    if (name[i].Contains(f.name))
                    {
                        if (name[i].Substring(0, 1) == "+")
                        {
                            textBox1.Text += " [√] " + name[i].Substring(1) + "\r\n";
                        }
                        else
                        {
                            textBox1.Text += " [ ] " + name[i].Substring(1) + "\r\n";
                        }
                    }
                }
                menuStrip1.Enabled = false;
                button3.Enabled = true; button3.Visible = true;
                button1.Visible = false; button2.Visible = false;
                button2.Enabled = false; button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) //關閉搜尋
        {
            button1.Enabled = true; button2.Enabled = true; button3.Enabled = false;
            button1.Visible = true; button2.Visible = true; button3.Visible = false;
            menuStrip1.Enabled = true;
            textBox1.Text = origin;
        }
    }
}
