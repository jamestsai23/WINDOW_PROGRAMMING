using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{

    public partial class Form1 : Form
    {
        Button[,] btn = new Button[7,6];
        bool[,] have = new bool[7, 6];
        int ch = 1;
        int oneput = 3, twoput = 3;
        int p1 = 1, p2 = 1;
        int sec = 10;
        int mode;
        int lx, ly;
        int clx, cly;
        int p1dead = 0, p2dead = 0;
        bool fight1dead = false, magic1dead = false, ranger1dead = false;
        bool fight2dead = false, magic2dead = false, ranger2dead = false;
        Fighter fighterobj1 = new Fighter();
        Fighter fighterobj2 = new Fighter();
        Magic magicobj1 = new Magic();
        Magic magicobj2 = new Magic();
        Ranger rangerobj1 = new Ranger();
        Ranger rangerobj2 = new Ranger();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void endgame()
        {
            if (p1dead == 3)
            {
                MessageBox.Show("P2贏了", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (p2dead == 3)
            {
                MessageBox.Show("P1贏了", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void check()
        {
            if (fighterobj1.hp <= 0)
            {
                if (fight1dead == false) p1dead++;
                fighterobj1.hp++;
                fight1dead = true;
                for(int i = 0; i < 7; i++)
                {
                    for(int j = 0; j < 6; j++)
                    {
                        if(btn[i,j].BackColor == Color.LightBlue && btn[i,j].Text == "戰士")
                        {
                            btn[i, j].BackColor = Color.White;
                            btn[i, j].Text = "";
                        }
                    }
                }
            }
            if (magicobj1.hp <= 0)
            {
                if (magic1dead == false) p1dead++;
                magicobj1.hp++;
                magic1dead = true;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (btn[i, j].BackColor == Color.LightBlue && btn[i, j].Text == "法師")
                        {
                            btn[i, j].BackColor = Color.White;
                            btn[i, j].Text = "";
                        }
                    }
                }
            }
            if (rangerobj1.hp <= 0)
            {
                if(ranger1dead == false)  p1dead++;
                rangerobj1.hp++;
                ranger1dead = true;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (btn[i, j].BackColor == Color.LightBlue && btn[i, j].Text == "遊俠")
                        {
                            btn[i, j].BackColor = Color.White;
                            btn[i, j].Text = "";
                        }
                    }
                }
            }
            if (fighterobj2.hp <= 0)
            {
                if(fight2dead == false)  p2dead++;
                fighterobj2.hp++;
                fight2dead = true;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (btn[i, j].BackColor == Color.LightPink && btn[i, j].Text == "戰士")
                        {
                            btn[i, j].BackColor = Color.White;
                            btn[i, j].Text = "";
                        }
                    }
                }
            }
            if (magicobj2.hp <= 0)
            {
                if(magic2dead == false) p2dead++;
                magicobj2.hp++;
                magic2dead = true;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (btn[i, j].BackColor == Color.LightPink && btn[i, j].Text == "法師")
                        {
                            btn[i, j].BackColor = Color.White;
                            btn[i, j].Text = "";
                        }
                    }
                }
            }
            if (rangerobj2.hp <= 0)
            {
                if(ranger2dead == false) p2dead++;
                rangerobj2.hp++;
                ranger2dead = true;
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (btn[i, j].BackColor == Color.LightPink && btn[i, j].Text == "遊俠")
                        {
                            btn[i, j].BackColor = Color.White;
                            btn[i, j].Text = "";
                        }
                    }
                }
            }
            endgame();
        }

        private void turnplayer()
        {
            if (ch == 4)
            {
                btn_end1.Enabled = true;
                btn_atk1.Enabled = false; btn_move1.Enabled = false; btn_skill1.Enabled = false; btn_stay1.Enabled = false;
            }
        }
        private void turnplayer2()
        {
            if (ch == 4)
            {
                btn_end2.Enabled = true;
                btn_atk2.Enabled = false; btn_move2.Enabled = false; btn_skill2.Enabled = false; btn_stay2.Enabled = false;
            }
        }

        private void Event_Click2(object sender, EventArgs e) //戰鬥按格子
        {
            Button b = (Button)sender;
            
            b.Enabled = false;
            if (p2 == 2)
            {
                for (int i = 0; i < 7; i++) //找按的格子
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (btn[i, j].Enabled == false)
                        {
                            btn[i, j].Enabled = true; cly = i; clx = j;
                        }
                    }
                }
            }
            if (p1==2 && p2 == 2)
            {
                if (b.Text == "待機")
                {
                    ch++;
                    btn_stay1.Enabled = true;
                    mode = 4;
                }
                /*if (fight1dead == true)
                {
                    ch++;
                    fightpanel1();
                }*/
                if (ch==1)
                {
                    if (fight1dead == true) ch++;
                    else
                    {
                        fightpanel1();
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (btn[i, j].Text == "戰士" && btn[i, j].BackColor == Color.LightBlue)
                                {
                                    lx = j; ly = i;
                                }

                            }
                        }
                        if (mode == 1)
                        {
                            if (((clx - lx == 1) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                            {
                                if (btn[cly, clx].BackColor == Color.LightPink)
                                {
                                    if (btn[cly, clx].Text == "戰士") fighterobj2.hp -= 30;
                                    else if (btn[cly, clx].Text == "法師") magicobj2.hp -= 30;
                                    else if (btn[cly, clx].Text == "遊俠") rangerobj2.hp -= 30;
                                    ch++;
                                    check();
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else if (mode == 2)
                        {
                            if (btn[cly, clx].BackColor != Color.LightPink && btn[cly, clx].BackColor != Color.LightBlue)
                            {
                                if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    btn[ly, lx].BackColor = Color.White; btn[ly, lx].Text = "";
                                    btn[cly, clx].BackColor = Color.LightBlue; btn[cly, clx].Text = "戰士";
                                    ch++;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        else if (mode == 3)
                        {
                            if (fighterobj1.mp - 10 >= 0)
                            {
                                if (((clx - lx == 1) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    if (btn[cly, clx].BackColor == Color.LightPink)
                                    {
                                        if (btn[cly, clx].Text == "戰士") fighterobj2.hp -= 30;
                                        else if (btn[cly, clx].Text == "法師") magicobj2.hp -= 30;
                                        else if (btn[cly, clx].Text == "遊俠") rangerobj2.hp -= 30;
                                        ch++;
                                        fighterobj1.hp += 15;
                                        fighterobj1.mp -= 10;
                                        check();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        if(magic1dead == true)
                        {
                            if (ranger1dead == true)
                                ch += 2;
                            else
                            {
                                ch++;
                                fightpanel1();
                            }
                        }
                    }
                    if (magic1dead == false) fightpanel1();
                }
                

                else if (ch == 2)
                {
                    if (magic1dead == true) ch++;
                    else
                    {
                        fightpanel1();
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (btn[i, j].Text == "法師" && btn[i, j].BackColor == Color.LightBlue)
                                {
                                    lx = j; ly = i;
                                }

                            }
                        }
                        if (mode == 1)
                        {
                            if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                            {
                                if (btn[cly, clx].BackColor == Color.LightPink)
                                {
                                    if (btn[cly, clx].Text == "戰士") fighterobj2.hp -= 20;
                                    else if (btn[cly, clx].Text == "法師") magicobj2.hp -= 20;
                                    else if (btn[cly, clx].Text == "遊俠") rangerobj2.hp -= 20;
                                    ch++;
                                    check();
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else if (mode == 2)
                        {
                            if (btn[cly, clx].BackColor != Color.LightPink && btn[cly, clx].BackColor != Color.LightBlue)
                            {
                                if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    btn[ly, lx].BackColor = Color.White; btn[ly, lx].Text = "";
                                    btn[cly, clx].BackColor = Color.LightBlue; btn[cly, clx].Text = "法師";
                                    ch++;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        else if (mode == 3)
                        {
                            if (magicobj1.mp - 10 >= 0)
                            {
                                if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    if (btn[cly, clx].BackColor == Color.LightPink)
                                    {
                                        if (btn[cly, clx].Text == "戰士") fighterobj2.hp -= 40;
                                        else if (btn[cly, clx].Text == "法師") magicobj2.hp -= 40;
                                        else if (btn[cly, clx].Text == "遊俠") rangerobj2.hp -= 40;
                                        ch++;
                                        magicobj1.mp -= 10;
                                        check();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        if (ranger1dead == true) ch++;
                    }
                    if (ranger1dead == false) fightpanel1();
                }
                

                else if (ch == 3)
                {
                    if (ranger1dead == true) ch++;
                    else
                    {
                        fightpanel1();
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (btn[i, j].Text == "遊俠" && btn[i, j].BackColor == Color.LightBlue)
                                {
                                    lx = j; ly = i;
                                }

                            }
                        }
                        if (mode == 1)
                        {
                            if (((clx - lx == 3) && (cly == ly)) || ((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -3) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 3) && (clx == lx)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -3) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                            {
                                if (btn[cly, clx].BackColor == Color.LightPink)
                                {
                                    if (btn[cly, clx].Text == "戰士") fighterobj2.hp -= 30;
                                    else if (btn[cly, clx].Text == "法師") magicobj2.hp -= 30;
                                    else if (btn[cly, clx].Text == "遊俠") rangerobj2.hp -= 30;
                                    ch++;
                                    check();
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else if (mode == 2)
                        {
                            if (btn[cly, clx].BackColor != Color.LightPink && btn[cly, clx].BackColor != Color.LightBlue)
                            {
                                if (((clx - lx == 1) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    btn[ly, lx].BackColor = Color.White; btn[ly, lx].Text = "";
                                    btn[cly, clx].BackColor = Color.LightBlue; btn[cly, clx].Text = "遊俠";
                                    ch++;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        else if (mode == 3)
                        {
                            if (rangerobj1.mp - 10 >= 0)
                            {
                                if (((clx - lx == 4) && (cly == ly)) || ((clx - lx == 3) && (cly == ly)) || ((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -4) && (cly == ly)) || ((clx - lx == -3) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 4) && (clx == lx)) || ((cly - ly == 3) && (clx == lx)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -4) && (clx == lx)) || ((cly - ly == -3) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    if (btn[cly, clx].BackColor == Color.LightPink)
                                    {
                                        if (btn[cly, clx].Text == "戰士") fighterobj2.hp -= 30;
                                        else if (btn[cly, clx].Text == "法師") magicobj2.hp -= 30;
                                        else if (btn[cly, clx].Text == "遊俠") rangerobj2.hp -= 30;
                                        rangerobj1.mp -= 10;
                                        ch++;
                                        check();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                    }
                    //換人
                }
                turnplayer();
            }
            if (p1 == 3 && p2 == 2)
            {
                if (b.Text == "待機")
                {
                    ch++;
                    btn_stay2.Enabled = true;
                    mode = 4;
                }
                /*if (fight2dead == true)
                {
                    if (ranger2dead == false && ch == 3) ch = 3;
                    else ch++;
                }*/
                if (ch == 1)
                {
                    if (fight2dead == true) ch++;
                    else
                    {
                        fightpanel1();
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (btn[i, j].Text == "戰士" && btn[i, j].BackColor == Color.LightPink)
                                {
                                    lx = j; ly = i;
                                }

                            }
                        }
                        if (mode == 1)
                        {
                            if (((clx - lx == 1) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                            {
                                if (btn[cly, clx].BackColor == Color.LightBlue)
                                {
                                    if (btn[cly, clx].Text == "戰士") fighterobj1.hp -= 30;
                                    else if (btn[cly, clx].Text == "法師") magicobj1.hp -= 30;
                                    else if (btn[cly, clx].Text == "遊俠") rangerobj1.hp -= 30;
                                    ch++;
                                    check();
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else if (mode == 2)
                        {
                            if (btn[cly, clx].BackColor != Color.LightPink && btn[cly, clx].BackColor != Color.LightBlue)
                            {
                                if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    btn[ly, lx].BackColor = Color.White; btn[ly, lx].Text = "";
                                    btn[cly, clx].BackColor = Color.LightPink; btn[cly, clx].Text = "戰士";
                                    ch++;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        else if (mode == 3)
                        {
                            if (fighterobj2.mp - 10 >= 0)
                            {
                                if (((clx - lx == 1) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    if (btn[cly, clx].BackColor == Color.LightBlue)
                                    {
                                        if (btn[cly, clx].Text == "戰士") fighterobj1.hp -= 30;
                                        else if (btn[cly, clx].Text == "法師") magicobj1.hp -= 30;
                                        else if (btn[cly, clx].Text == "遊俠") rangerobj1.hp -= 30;
                                        ch++;
                                        fighterobj2.hp += 15;
                                        fighterobj2.mp -= 10;
                                        check();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        if(magic2dead == true)
                        {
                            if (ranger2dead == true) ch += 2;
                            else
                            {
                                ch++;
                                fightpanel1();
                            }
                        }
                    }
                    if (magic2dead == false) fightpanel1();
                }
                
                else if (ch == 2)
                {
                    if (magic2dead == true) ch++;
                    else
                    {
                        fightpanel1();
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (btn[i, j].Text == "法師" && btn[i, j].BackColor == Color.LightPink)
                                {
                                    lx = j; ly = i;
                                }

                            }
                        }
                        if (mode == 1)
                        {
                            if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                            {
                                if (btn[cly, clx].BackColor == Color.LightBlue)
                                {
                                    if (btn[cly, clx].Text == "戰士") fighterobj1.hp -= 20;
                                    else if (btn[cly, clx].Text == "法師") magicobj1.hp -= 20;
                                    else if (btn[cly, clx].Text == "遊俠") rangerobj1.hp -= 20;
                                    ch++;
                                    check();
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else if (mode == 2)
                        {
                            if (btn[cly, clx].BackColor != Color.LightPink && btn[cly, clx].BackColor != Color.LightBlue)
                            {
                                if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    btn[ly, lx].BackColor = Color.White; btn[ly, lx].Text = "";
                                    btn[cly, clx].BackColor = Color.LightPink; btn[cly, clx].Text = "法師";
                                    ch++;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        else if (mode == 3)
                        {
                            if (magicobj2.mp - 10 >= 0)
                            {
                                if (((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    if (btn[cly, clx].BackColor == Color.LightBlue)
                                    {
                                        if (btn[cly, clx].Text == "戰士") fighterobj1.hp -= 40;
                                        else if (btn[cly, clx].Text == "法師") magicobj1.hp -= 40;
                                        else if (btn[cly, clx].Text == "遊俠") rangerobj1.hp -= 40;
                                        ch++;
                                        magicobj2.mp -= 10;
                                        check();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        if (ranger2dead == true) ch++;
                    }
                    if (ranger2dead == false) fightpanel1();
                }
                
                else if (ch == 3)
                {
                    if (ranger2dead == true) ch++;
                    else
                    {
                        fightpanel1();
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (btn[i, j].Text == "遊俠" && btn[i, j].BackColor == Color.LightPink)
                                {
                                    lx = j; ly = i;
                                }

                            }
                        }
                        if (mode == 1)
                        {
                            if (((clx - lx == 3) && (cly == ly)) || ((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -3) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 3) && (clx == lx)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -3) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                            {
                                if (btn[cly, clx].BackColor == Color.LightBlue)
                                {
                                    if (btn[cly, clx].Text == "戰士") fighterobj1.hp -= 30;
                                    else if (btn[cly, clx].Text == "法師") magicobj1.hp -= 30;
                                    else if (btn[cly, clx].Text == "遊俠") rangerobj1.hp -= 30;
                                    ch++;
                                    check();
                                }
                            }
                            else
                            {
                                MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else if (mode == 2)
                        {
                            if (btn[cly, clx].BackColor != Color.LightPink && btn[cly, clx].BackColor != Color.LightBlue)
                            {
                                if (((clx - lx == 1) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    btn[ly, lx].BackColor = Color.White; btn[ly, lx].Text = "";
                                    btn[cly, clx].BackColor = Color.LightPink; btn[cly, clx].Text = "遊俠";
                                    ch++;
                                }
                                else
                                {
                                    MessageBox.Show("超出移動範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        else if (mode == 3)
                        {
                            if (rangerobj2.mp - 10 >= 0)
                            {
                                if (((clx - lx == 4) && (cly == ly)) || ((clx - lx == 3) && (cly == ly)) || ((clx - lx == 2) && (cly == ly)) || ((clx - lx == 1) && (cly == ly)) || ((clx - lx == -4) && (cly == ly)) || ((clx - lx == -3) && (cly == ly)) || ((clx - lx == -2) && (cly == ly)) || ((clx - lx == -1) && (cly == ly)) || ((cly - ly == 4) && (clx == lx)) || ((cly - ly == 3) && (clx == lx)) || ((cly - ly == 2) && (clx == lx)) || ((cly - ly == 1) && (clx == lx)) || ((cly - ly == -4) && (clx == lx)) || ((cly - ly == -3) && (clx == lx)) || ((cly - ly == -2) && (clx == lx)) || ((cly - ly == -1) && (clx == lx)))
                                {
                                    if (btn[cly, clx].BackColor == Color.LightBlue)
                                    {
                                        if (btn[cly, clx].Text == "戰士") fighterobj1.hp -= 30;
                                        else if (btn[cly, clx].Text == "法師") magicobj1.hp -= 30;
                                        else if (btn[cly, clx].Text == "遊俠") rangerobj1.hp -= 30;
                                        rangerobj2.mp -= 10;
                                        ch++;
                                        check();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("超出攻擊範圍", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                    }
                    //換人
                }
                turnplayer2();
            }
        }

        private void Event_Click1(object sender, EventArgs e) //放棋按棋盤
        {
            Button b = (Button)sender;
            if (p1 == 1 && p2 == 1)
            {
                if (ch == 1)
                {
                    b.Text = "戰士";
                    btn_fight1.Enabled = false;
                }
                else if (ch == 2) b.Text = "法師";
                else if (ch == 3) b.Text = "遊俠";
                b.BackColor = Color.LightBlue;
                b.Enabled = false;
                oneput--; //下棋數
                if (oneput == 0) //換邊
                {
                    p1 = 0; //p1下完
                    sec = 10;
                    btn_fight2.Enabled = true; btn_magic2.Enabled = true; btn_ranger2.Enabled = true; //p2 button可以按
                    for (int i = 0; i < 7; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            btn[i, j].Enabled = false;
                        }
                        for (int j = 3; j < 6; j++)
                        {
                            btn[i, j].Enabled = true;
                        }
                    }
                }
            }
            else if (p1 == 0 && p2 == 1)
            {
                if (ch == 1)
                {
                    b.Text = "戰士";
                    btn_fight2.Enabled = false;
                }
                else if (ch == 2) b.Text = "法師";
                else if (ch == 3) b.Text = "遊俠";
                b.BackColor = Color.LightPink;
                b.Enabled = false;
                twoput--; //下棋數
                if (twoput == 0) //結束放旗子
                {
                    endstep1();
                }
            }
        }

        private void fightpanel1() //戰鬥面板
        {
            if (p1 == 2 && p2 == 2)
            {
                if (ch == 1)
                {
                    if (fight1dead == false)
                    {
                        label13.Text = fighterobj1.character;
                        label12.Text = "HP:" + fighterobj1.hp;
                        label11.Text = "MP:" + fighterobj1.mp;
                        label10.Text = "ATK:" + fighterobj1.atk;
                        label9.Text = "ATK Range:" + fighterobj1.atkRange;
                        label8.Text = "MOVE Range:" + fighterobj1.moveRange;
                    }
                    else
                    {
                        label13.Text = magicobj1.character;
                        label12.Text = "HP:" + magicobj1.hp;
                        label11.Text = "MP:" + magicobj1.mp;
                        label10.Text = "ATK:" + magicobj1.atk;
                        label9.Text = "ATK Range:" + magicobj1.atkRange;
                        label8.Text = "MOVE Range:" + magicobj1.moveRange;
                    }
                }
                else if (ch == 2)
                {
                    label13.Text = magicobj1.character;
                    label12.Text = "HP:" + magicobj1.hp;
                    label11.Text = "MP:" + magicobj1.mp;
                    label10.Text = "ATK:" + magicobj1.atk;
                    label9.Text = "ATK Range:" + magicobj1.atkRange;
                    label8.Text = "MOVE Range:" + magicobj1.moveRange;
                }
                else
                {
                    label13.Text = rangerobj1.character;
                    label12.Text = "HP:" + rangerobj1.hp;
                    label11.Text = "MP:" + rangerobj1.mp;
                    label10.Text = "ATK:" + rangerobj1.atk;
                    label9.Text = "ATK Range:" + rangerobj1.atkRange;
                    label8.Text = "MOVE Range:" + rangerobj1.moveRange;
                }
            }
            else if (p1==3 && p2 == 2)
            {
                if (ch == 1)
                {
                    if (fight2dead == false)
                    {
                        label25.Text = fighterobj2.character;
                        label24.Text = "HP:" + fighterobj2.hp;
                        label23.Text = "MP:" + fighterobj2.mp;
                        label22.Text = "ATK:" + fighterobj2.atk;
                        label21.Text = "ATK Range:" + fighterobj2.atkRange;
                        label20.Text = "MOVE Range:" + fighterobj2.moveRange;
                    }
                    else
                    {
                        label25.Text = magicobj2.character;
                        label24.Text = "HP:" + magicobj2.hp;
                        label23.Text = "MP:" + magicobj2.mp;
                        label22.Text = "ATK:" + magicobj2.atk;
                        label21.Text = "ATK Range:" + magicobj2.atkRange;
                        label20.Text = "MOVE Range:" + magicobj2.moveRange;
                    }
                }
                else if (ch == 2)
                {
                    label25.Text = magicobj2.character;
                    label24.Text = "HP:" + magicobj2.hp;
                    label23.Text = "MP:" + magicobj2.mp;
                    label22.Text = "ATK:" + magicobj2.atk;
                    label21.Text = "ATK Range:" + magicobj2.atkRange;
                    label20.Text = "MOVE Range:" + magicobj2.moveRange;
                }
                else
                {
                    label25.Text = rangerobj2.character;
                    label24.Text = "HP:" + rangerobj2.hp;
                    label23.Text = "MP:" + rangerobj2.mp;
                    label22.Text = "ATK:" + rangerobj2.atk;
                    label21.Text = "ATK Range:" + rangerobj2.atkRange;
                    label20.Text = "MOVE Range:" + rangerobj2.moveRange;
                }
            }
        }
        

        private void endstep1() //結束放旗子
        {
            ch = 1; p1 = 2; p2 = 2;
            fightpanel1();
            timer1.Enabled = false;
            p2 = 2; p1 = 2;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                    btn[i, j].Enabled = true;
            }
            label39.Text = "P1 Turn";
            btn_fight2.Visible = false; btn_magic2.Visible = false; btn_ranger2.Visible = false;
            label_fight2.Visible = false; label_magic2.Visible = false; label_ranger2.Visible = false;
            panel3.Visible = true;
            panel1.Visible = true; panel2.Visible = true;
            btn_end1.Enabled = false; btn_end2.Enabled = false;
            btn_atk2.Enabled = false; btn_move2.Enabled = false; btn_stay2.Enabled = false; btn_skill2.Enabled = false;
            
        }
        private void Form1_Load(object sender, EventArgs e) //初始
        {

            label1.Visible = false; label38.Visible = false; //P1P2
            label_fight1.Visible = false; label_magic1.Visible = false; label_ranger1.Visible = false;
            label_fight2.Visible = false; label_magic2.Visible = false; label_ranger2.Visible = false;
            btn_fight1.Visible = false; btn_magic1.Visible = false; btn_ranger1.Visible = false;
            btn_fight2.Visible = false; btn_magic2.Visible = false; btn_ranger2.Visible = false;
            panel1.Visible = false; panel2.Visible = false; panel3.Visible = false; panel4.Visible = false;

            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Width = 50;
                    btn[i, j].Height = 50;
                    btn[i, j].Location = new Point(200 + j * 50, 100 + i * 50);
                    btn[i, j].Visible = false;
                    btn[i, j].Click += Event_Click1;
                    btn[i, j].Click += Event_Click2;
                    Controls.Add(btn[i, j]);
                }
            }
        }


        private void btn_start_Click(object sender, EventArgs e) //開始遊戲
        {
            btn_start.Visible = false;
            timer1.Enabled = true;
            label1.Visible = true; label38.Visible = true; //P1P2
            btn_fight1.Visible = true; btn_magic1.Visible = true; btn_ranger1.Visible = true;
            btn_fight2.Visible = true; btn_magic2.Visible = true; btn_ranger2.Visible = true;
            btn_fight2.Enabled = false; btn_magic2.Enabled = false; btn_ranger2.Enabled = false;
            label39.Visible = true;
            label39.Text = "準備階段" + Environment.NewLine + sec;
            

            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 6 ; j++)
                {
                    btn[i, j].Visible = true;
                }
                for(int j = 3; j < 6; j++)
                {
                    btn[i, j].Enabled = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //timer
        {
            sec--;
            label39.Text = "準備階段" + Environment.NewLine + sec;
            if (p1 == 1 && sec == 0)
            {
                sec = 10;
                if (p1 == 1) //p1沒放完
                {
                    p1 = 0;

                    if (btn_fight1.Enabled == true)
                    {
                        btn_fight1.Enabled = false;
                        if (btn[0, 0].Enabled == true)
                        {
                            btn[0, 0].BackColor = Color.LightBlue;
                            btn[0, 0].Text = "戰士";
                            btn[0, 0].Enabled = false;
                        }
                        else if (btn[1, 0].Enabled == true)
                        {
                            btn[1, 0].BackColor = Color.LightBlue;
                            btn[1, 0].Text = "戰士";
                            btn[1, 0].Enabled = false;
                        }
                        else
                        {
                            btn[2, 0].BackColor = Color.LightBlue;
                            btn[2, 0].Text = "戰士";
                            btn[2, 0].Enabled = false;
                        }
                    }
                    if (btn_magic1.Enabled == true)
                    {
                        btn_magic1.Enabled = false;
                        if (btn[0, 0].Enabled == true)
                        {
                            btn[0, 0].BackColor = Color.LightBlue;
                            btn[0, 0].Text = "法師";
                            btn[0, 0].Enabled = false;
                        }
                        else if (btn[1, 0].Enabled == true)
                        {
                            btn[1, 0].BackColor = Color.LightBlue;
                            btn[1, 0].Text = "法師";
                            btn[1, 0].Enabled = false;
                        }
                        else
                        {
                            btn[2, 0].BackColor = Color.LightBlue;
                            btn[2, 0].Text = "法師";
                            btn[2, 0].Enabled = false;
                        }
                    }
                    if (btn_ranger1.Enabled == true)
                    {
                        btn_ranger1.Enabled = false;
                        if (btn[0, 0].Enabled == true)
                        {
                            btn[0, 0].BackColor = Color.LightBlue;
                            btn[0, 0].Text = "遊俠";
                            btn[0, 0].Enabled = false;
                        }
                        else if (btn[1, 0].Enabled == true)
                        {
                            btn[1, 0].BackColor = Color.LightBlue;
                            btn[1, 0].Text = "遊俠";
                            btn[1, 0].Enabled = false;
                        }
                        else
                        {
                            btn[2, 0].BackColor = Color.LightBlue;
                            btn[2, 0].Text = "遊俠";
                            btn[2, 0].Enabled = false;
                        }
                        btn_fight2.Enabled = true; btn_magic2.Enabled = true; btn_ranger2.Enabled = true; //p2 button可以按
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                btn[i, j].Enabled = false;
                            }
                            for (int j = 3; j < 6; j++)
                            {
                                btn[i, j].Enabled = true;
                            }
                        }
                    }
                }
            }
            if (p1 == 0 && sec == 0)
            {
                if (p2 == 1) //p2沒放完
                {
                    p2 = 2; p1 = 2; 
                    timer1.Enabled = false; //暫停時間
                    p2 = 0;
                    if (btn_fight2.Enabled == true)
                    {
                        btn_fight2.Enabled = false;
                        if (btn[0, 5].Enabled == true)
                        {
                            btn[0, 5].BackColor = Color.LightPink;
                            btn[0, 5].Text = "戰士";
                            btn[0, 5].Enabled = false;
                        }
                        else if (btn[1, 5].Enabled == true)
                        {
                            btn[1, 5].BackColor = Color.LightPink;
                            btn[1, 5].Text = "戰士";
                            btn[1, 5].Enabled = false;
                        }
                        else
                        {
                            btn[2, 5].BackColor = Color.LightPink;
                            btn[2, 5].Text = "戰士";
                            btn[2, 5].Enabled = false;
                        }
                    }
                    if (btn_magic2.Enabled == true)
                    {
                        btn_magic2.Enabled = false;
                        if (btn[0, 5].Enabled == true)
                        {
                            btn[0, 5].BackColor = Color.LightPink;
                            btn[0, 5].Text = "法師";
                            btn[0, 5].Enabled = false;
                        }
                        else if (btn[1, 5].Enabled == true)
                        {
                            btn[1, 5].BackColor = Color.LightPink;
                            btn[1, 5].Text = "法師";
                            btn[1, 5].Enabled = false;
                        }
                        else
                        {
                            btn[2, 5].BackColor = Color.LightPink;
                            btn[2, 5].Text = "法師";
                            btn[2, 5].Enabled = false;
                        }
                    }
                    if (btn_ranger2.Enabled == true)
                    {
                        btn_ranger2.Enabled = false;
                        if (btn[0, 5].Enabled == true)
                        {
                            btn[0, 5].BackColor = Color.LightPink;
                            btn[0, 5].Text = "遊俠";
                            btn[0, 5].Enabled = false;
                        }
                        else if (btn[1, 5].Enabled == true)
                        {
                            btn[1, 5].BackColor = Color.LightPink;
                            btn[1, 5].Text = "遊俠";
                            btn[1, 5].Enabled = false;
                        }
                        else
                        {
                            btn[2, 5].BackColor = Color.LightPink;
                            btn[2, 5].Text = "遊俠";
                            btn[2, 5].Enabled = false;
                        }
                    }
                }
                endstep1();
            }
        
        }

        private void btn_magic1_Click(object sender, EventArgs e) //擺放法師1
        {
            btn_magic1.Enabled = false;
            label_fight1.Visible = false; label_magic1.Visible = true; label_ranger1.Visible = false;
            ch = 2;        }

        private void btn_fight2_Click(object sender, EventArgs e) //擺放戰士2
        {
            btn_fight2.Enabled = false;
            label_fight2.Visible = true; label_magic2.Visible = false; label_ranger2.Visible = false;
            ch = 1;
        }

        private void btn_magic2_Click(object sender, EventArgs e) //擺放法師2
        {
            btn_magic2.Enabled = false;
            label_fight2.Visible = false; label_magic2.Visible = true; label_ranger2.Visible = false;
            ch = 2;
        }

        private void btn_ranger2_Click(object sender, EventArgs e) //擺放遊俠2
        {
            btn_ranger2.Enabled = false;
            label_fight2.Visible = false; label_magic2.Visible = false; label_ranger2.Visible = true;
            ch = 3;
        }

        private void btn_move1_Click(object sender, EventArgs e) //移動
        {
            mode = 2;
        }

        private void btn_skill1_Click(object sender, EventArgs e) //技能
        {
            mode = 3;
        }

        private void btn_end1_Click(object sender, EventArgs e) //p1換p2
        {
            ch = 1;
            p1 = 3;
            fightpanel1();
            label39.Text = "P2 Turn"; panel4.Visible = true;
            btn_end1.Enabled = false; btn_end2.Enabled = false;
            btn_atk1.Enabled = false; btn_move1.Enabled = false; btn_skill1.Enabled = false; btn_stay1.Enabled = false;
            btn_atk2.Enabled = true; btn_move2.Enabled = true; btn_skill2.Enabled = true; btn_stay2.Enabled = true;
        }

        private void btn_end2_Click(object sender, EventArgs e) //p2換p1
        {
            ch = 1;
            p1 = 2;
            fightpanel1();
            label39.Text = "P1 Turn";
            btn_end1.Enabled = false; btn_end2.Enabled = false;
            btn_atk2.Enabled = false; btn_move2.Enabled = false; btn_skill2.Enabled = false; btn_stay2.Enabled = false;
            btn_atk1.Enabled = true; btn_move1.Enabled = true; btn_skill1.Enabled = true; btn_stay1.Enabled = true;
        }

        private void btn_atk1_Click(object sender, EventArgs e) //攻擊
        {
            mode = 1;
        }

        private void btn_ranger1_Click(object sender, EventArgs e) //擺放遊俠1
        {
            btn_ranger1.Enabled = false;
            label_fight1.Visible = false; label_magic1.Visible = false; label_ranger1.Visible = true;
            ch = 3;
        }

        private void btn_fight1_Click(object sender, EventArgs e) //擺放戰士1
        {
            btn_fight1.Enabled = false;
            label_fight1.Visible = true; label_magic1.Visible = false; label_ranger1.Visible = false;
            ch = 1;
        }


    }
}
