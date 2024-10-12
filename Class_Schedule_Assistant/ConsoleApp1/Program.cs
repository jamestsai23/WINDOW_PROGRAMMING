using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, point = 0, classnum = 0, repeatnum = 0, temp;
            bool repeat = false;
            string onefirst;
            string twodel;
            string[] onedel = new string[4];
            string[,] classrepeat = new string[100,5];
            string[,] classtable = new string[8, 7];

            for (; ; )
            {

                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式");
                Console.Write("請輸入數字選擇功能：");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
                    onefirst = Console.ReadLine();
                    repeat = false;

                    onedel = onefirst.Split(' ');
                    for (int i = 0; i < classnum; i++)
                    {
                        if (onedel[0] == classrepeat[i,0])
                        {
                            Console.WriteLine("課程重複!");
                            repeat = true;
                        }
                        else
                        {
                            for (int j = 0; j < int.Parse(onedel[3]) - int.Parse(onedel[2]) + 1; j++)
                            {
                                if (classtable[int.Parse(onedel[2])-1+j, int.Parse(onedel[1])-1] != null)
                                {
                                    Console.WriteLine("課堂衝堂!");
                                    repeat = true;
                                }
                            }
                        }
                    }

                    if (repeat == false) {
                        temp = int.Parse(onedel[3]) - int.Parse(onedel[2]) + 1;
                        classrepeat[classnum,4] = temp.ToString();
                        point += int.Parse(classrepeat[classnum,4]);
                        for (int i = 0; i < 4; i++) {
                            classrepeat[classnum,i] = onedel[i];
                        }
                        for (int i=0; i<(int.Parse(classrepeat[classnum,4])); i++) {
                            classtable[int.Parse(onedel[2]) - 1 + i, int.Parse(onedel[1]) - 1] = onedel[0];
                        }
                        classnum++;
                        Console.WriteLine("成功加入課程!");
                    }
                }

                else if (option == 2)
                {
                    Console.Write("請輸入要刪除的課程代號：");
                    twodel = Console.ReadLine();
                    repeat = false;

                    for (int i=0;i<classnum;i++) {
                        if (classrepeat[i,0] == twodel) {
                            repeat = true;
                            repeatnum = i;
                        }
                    }
                    if (repeat == false) {
                        Console.WriteLine("課程 {0} 不在課表裡", twodel);
                    }
                    if (repeat == true) {
                        Console.WriteLine("成功刪除課程：{0}",twodel);
                        point -= int.Parse(classrepeat[repeatnum, 4]);
                        for (int i=repeatnum;i<classnum-1;i++) {
                            classrepeat[i, 0] = classrepeat[i + 1, 0];
                            classrepeat[i, 1] = classrepeat[i + 1, 1];
                            classrepeat[i, 2] = classrepeat[i + 1, 2];
                            classrepeat[i, 3] = classrepeat[i + 1, 3];
                        }
                        for (int i = 0; i < int.Parse(classrepeat[repeatnum,4]);i++)
                        {
                            classtable[int.Parse(classrepeat[repeatnum,2]) - 1 + i, int.Parse(classrepeat[repeatnum,1]) - 1] = null;
                        }
                        classnum--;
                    }
                }

                if (option ==3) {
                    string s = String.Format("{0,-6}{1,-6}{2,-6}{3,-6}{4,-6}{5,-6}{6,-6}{7,-6}", "", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat");
                    Console.WriteLine("{0}", s);
                    for (int i = 0; i < 8; i++)
                    {
                        s = String.Format("{0,-6}{1,-6}{2,-6}{3,-6}{4,-6}{5,-6}{6,-6}{7,-6}", i+1, classtable[i, 6], classtable[i, 0], classtable[i, 1], classtable[i, 2], classtable[i, 3], classtable[i, 4], classtable[i, 5]);
                        Console.WriteLine("{0}", s);
                    }
                }

                if (option == 4)
                    Console.WriteLine("{0}", point);
                if (option == 5)
                    break;
                Console.WriteLine("");
            }
        }
    }
}
