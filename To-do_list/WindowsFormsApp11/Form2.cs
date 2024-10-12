using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        public string name = "";
        public int ok = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Text = "確定";
            button1.Text = "取消";
        }

        private void button1_Click(object sender, EventArgs e) // 取消
        {
            ok = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (name == "")
            {
                MessageBox.Show("請輸入事項", "", MessageBoxButtons.OK);
            }
            else
            {
                ok = 1;
                this.Close();
            }
        }
    }
}
