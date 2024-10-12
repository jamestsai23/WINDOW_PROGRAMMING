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
            int opoint = 0, xpoint = 0;
            int row, column;
            int leftrepeatnum = 0, rightrepeatnum = 0, uprepeatnum = 0, downrepeatnum = 0;
            bool checkup, checkdown, checkleft, checkright;
            string rowchar;
            string location;
            string[,] table = new string[8, 8];

            for(int i=0;i<8;i++) {
                for(int j=0;j<8;j++) {
                    table[i, j] = "-";
                }
            }

            for (int round = 0;;) {

                checkleft = false;
                checkright = false;
                checkup = false;
                checkdown = false;

                Console.WriteLine("  A B C D E F G H");
                for (int i=0;i<8;i++) {
                    Console.Write("{0} ", i+1);
                    for (int j=0;j<8;j++) {
                        Console.Write("{0} ", table[i, j]);
                    }
                    Console.WriteLine("");
                }

                if (round % 2 == 0) {
                    Console.WriteLine("輪到玩家O 請輸入要下的位置：");
                    location = Console.ReadLine();
                    row = int.Parse(location.Substring(1, 1)) - 1;
                    rowchar = location.Substring(0, 1);
                    column = Convert.ToChar(rowchar) - 65;

                    if (table[row,column] != "-") {
                        Console.WriteLine("此位置已有棋子!按任意鍵繼續遊戲");
                        Console.Read();
                    }
                    else {
                        table[row, column] = "O";
                        round++;

                        for (int i = column - 1; i>= 0; i--)
                        {
                            if (table[row,i] == "O")
                            {
                                checkleft = true;
                                leftrepeatnum = i;
                            }
                        }
                        if (checkleft == true)
                        {
                            for(int i=column - 1; i > leftrepeatnum; i--)
                            {
                                if (table[row, i] == "X")
                                {
                                    table[row, i] = "O";
                                }
                            }
                        }

                        for (int i=column+1;i<8;i++) {
                            if (table[row,i] == "O") {
                                checkright = true;
                                rightrepeatnum = i;
                            }
                        }
                        if (checkright == true) {
                            for(int i=column+1;i<rightrepeatnum;i++) {
                                if (table[row, i] == "X") {
                                    table[row, i] = "O";
                                }
                            }
                        }

                        for (int i=row-1;i>=0;i--) {
                            if(table[i,column] == "O") {
                                checkup = true;
                                uprepeatnum = i;
                            }
                        }
                        if (checkup == true) {
                            for(int i=row-1;i>uprepeatnum;i--) {
                                if (table[i, column] == "X")
                                    table[i, column] = "O";
                            }
                        }

                        for (int i = row + 1; i < 8; i++)
                        {
                            if (table[i, column] == "O")
                            {
                                checkdown = true;
                                downrepeatnum = i;
                            }
                        }
                        if (checkdown == true)
                        {
                            for (int i = row + 1; i < downrepeatnum; i++)
                            {
                                if (table[i, column] == "X")
                                    table[i, column] = "O";
                            }
                        }
                    }
                }
                else {
                    Console.WriteLine("輪到玩家X 請輸入要下的位置：");
                    location = Console.ReadLine();
                    row = int.Parse(location.Substring(1, 1)) - 1;
                    rowchar = location.Substring(0, 1);
                    column = Convert.ToChar(rowchar) - 65;
                    if (table[row, column] != "-")
                    {
                        Console.WriteLine("此位置已有棋子!按任意鍵繼續遊戲");
                        Console.ReadLine();
                    }
                    else
                    {
                        table[row, column] = "X";
                        round++;

                        for (int i = column - 1; i >= 0; i--)
                        {
                            if (table[row, i] == "X")
                            {
                                checkleft = true;
                                leftrepeatnum = i;
                            }
                        }
                        if (checkleft == true)
                        {
                            for (int i = column - 1; i > leftrepeatnum; i--)
                            {
                                if (table[row, i] == "O")
                                {
                                    table[row, i] = "X";
                                }
                            }
                        }

                        for (int i = column + 1; i < 8; i++)
                        {
                            if (table[row, i] == "X")
                            {
                                checkright = true;
                                rightrepeatnum = i;
                            }
                        }
                        if (checkright == true)
                        {
                            for (int i = column + 1; i < rightrepeatnum; i++)
                            {
                                if (table[row, i] == "O")
                                {
                                    table[row, i] = "X";
                                }
                            }
                        }

                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (table[i, column] == "X")
                            {
                                checkup = true;
                                uprepeatnum = i;
                            }
                        }
                        if (checkup == true)
                        {
                            for (int i = row - 1; i > uprepeatnum; i--)
                            {
                                if (table[i, column] == "O")
                                    table[i, column] = "X";
                            }
                        }

                        for (int i = row + 1; i < 8; i++)
                        {
                            if (table[i, column] == "X")
                            {
                                checkdown = true;
                                downrepeatnum = i;
                            }
                        }
                        if (checkdown == true)
                        {
                            for (int i = row + 1; i < downrepeatnum; i++)
                            {
                                if (table[i, column] == "O")
                                    table[i, column] = "X";
                            }
                        }
                    }
                }
                if (round == 64) {
                    Console.Clear();
                    break;
                }
                Console.Clear();
            }

            Console.WriteLine("  A B C D E F G H");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0} ", i + 1);
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} ", table[i, j]);
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (table[i, j] == "O") opoint++;
                    else if (table[i, j] == "X") xpoint++;
                }
            }
            if (opoint > xpoint)
            {
                Console.WriteLine("遊戲結束 玩家O獲勝!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("遊戲結束 玩家X獲勝!");
                Console.ReadLine();
            }

        }
    }
}
