using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0, option, payall = 0, payback = 0, nowmoney = 0;
            int m = 0;
            int twonum = 0, repeatnum = 0;
            string[] payobj = new string[10];
            int[] pay = new int[5];
            float[] payper = new float[5];
            bool repeat = false;

            for (; ; )
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能：");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("輸入金額：");
                    string strmoney;
                    strmoney = Console.ReadLine();
                    nowmoney = 0;
                    bool intmoney = int.TryParse(strmoney, out nowmoney);

                    if (intmoney == false)
                    {
                        Console.WriteLine("請輸入數字");
                    }
                    else
                    {
                        if (nowmoney < 0)
                        {
                            Console.WriteLine("收入不可為負數");
                        }
                        else
                        {
                            money += nowmoney;
                            Console.WriteLine("");
                        }
                    }
                }
                else if (option == 2)
                {
                    if (twonum == 0)
                    {
                        Console.WriteLine("請新增支出項目");
                    }
                    else
                    {
                        for (int i = 0; i < twonum; i++)
                        {
                            Console.Write("({0}){1} ", i + 1, payobj[i]);
                        }
                        Console.WriteLine("");
                        Console.Write("輸入數字選擇支出項目：");
                        int n = int.Parse(Console.ReadLine());

                        if (n > twonum || n <= 0)
                        {
                            Console.WriteLine("此數字不在範圍中");
                        }
                        else
                        {
                            Console.Write("輸入支出金額：");
                            payback = int.Parse(Console.ReadLine());
                            if (payback > money)
                            {
                                Console.WriteLine("存款不足");
                            }
                            else
                            {
                                payall += payback;
                                money -= payback;
                                if (n == 1)
                                {
                                    pay[0] += payback;
                                }
                                else if (n == 2)
                                {
                                    pay[1] += payback;
                                }
                                else if (n == 3)
                                {
                                    pay[2] += payback;
                                }
                                else if (n == 4)
                                {
                                    pay[3] += payback;
                                }
                                else if (n == 5)
                                {
                                    pay[4] += payback;
                                }
                            }
                        }
                    }
                }

                else if (option == 3)
                {
                    if (twonum >= 5)
                    {
                        Console.WriteLine("已無法再新增支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱：");
                        string payobjname = Console.ReadLine();
                        repeat = false;
                        for (int i = 0; i < twonum; i++)
                        {
                            if (payobjname == payobj[i])
                            {
                                repeat = true;
                                Console.WriteLine("支出項目已存在");
                            }
                        }

                        if (repeat == false)
                        {
                            payobj[twonum++] = payobjname;
                        }
                    }
                }

                else if (option == 4)
                {
                    if (twonum == 0)
                    {
                        Console.WriteLine("已無法再刪除支出項目");
                    }
                    else
                    {
                        Console.Write("輸入項目名稱：");
                        string objname = Console.ReadLine();
                        repeat = false;
                        for (int i = 0; i < twonum; i++)
                        {
                            if (objname == payobj[i])
                            {
                                repeat = true;
                                repeatnum = i;
                            }
                        }
                        if (repeat == false)
                        {
                            Console.WriteLine("此項目不存在");
                        }
                        else
                        {
                            payall -= pay[repeatnum];
                            for (int i = repeatnum; i < twonum - 1; i++)
                            {
                                payobj[i] = payobj[i + 1];
                                pay[i] = pay[i + 1];
                            }
                            payobj[--twonum] = null;
                        }
                    }
                }

                else if (option == 7)
                {
                    Console.WriteLine("剩餘金額為：{0}", money);
                }
                else if (option == 8)
                {
                    break;
                }
                else if (option == 5)
                {
                    if (payall != 0)
                    {
                        payper[0] = ((float)pay[0] / payall) * 100;
                        payper[1] = ((float)pay[1] / payall) * 100;
                        payper[2] = ((float)pay[2] / payall) * 100;
                        payper[3] = ((float)pay[3] / payall) * 100;
                        payper[4] = ((float)pay[4] / payall) * 100;

                        for (int i = 0; i < twonum - 1; i++)
                        {
                            Console.WriteLine("({0}){1}：{2}%", i + 1, payobj[i], payper[i]);
                        }
                        Console.WriteLine("({0}){1}：{2}%", twonum, payobj[twonum - 1], payper[twonum - 1]);

                    }
                    else
                    {
                        for (int i = 0; i < twonum; i++)
                        {
                            Console.WriteLine("({0}){1}：0%", i + 1, payobj[i]);
                        }
                    }
                }

                else if (option == 6)
                {
                    Console.WriteLine("目前總支出：{0}", payall);
                    string objname;
                    Console.Write("輸入要查詢的項目：");
                    objname = Console.ReadLine();

                    repeat = false;

                    for (int i = 0; i < twonum; i++)
                    {
                        if (objname == payobj[i])
                        {
                            repeat = true;
                            m = i;
                        }
                    }
                    if (repeat == false)
                    {
                        Console.WriteLine("此項目不存在");
                    }
                    else
                    {
                        Console.WriteLine("{0}：{1}", payobj[m], pay[m]);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}