using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Tic Tac Toe!");
            Console.WriteLine();
            Console.WriteLine();
            string[] grid = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            bool gameOver = false;
            bool validChoice = false;

            Console.WriteLine("Player 1 is X");
            Console.WriteLine("Player 2 is O");
            Console.WriteLine();
            Console.WriteLine();

            while (!gameOver)
            {
                Board(grid);
                while (!validChoice)
                {
                    validChoice = Cycle(grid);
                    Winner(grid);
                    Tie(grid);
                    gameOver = Cycle(grid);
                    Board(grid);
                    validchoice = Cycle2(grid);
                    Winner(grid);
                    Tie(grid);
                    gameOver = Cycle2(grid);
                    Board(grid);
                }
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void Board(string[] table)
        {
            Console.WriteLine(string.Format("{0}|{1}|{2}", table[0], table[1], table[2]));
            Console.WriteLine("-----");
            Console.WriteLine(string.Format("{0}|{1}|{2}", table[3], table[4], table[5]));
            Console.WriteLine("-----");
            Console.WriteLine(string.Format("{0}|{1}|{2}", table[6], table[7], table[8]));

        }

        static bool Cycle(string[] p1)
        {
            Console.WriteLine("Player 1 pick spot");

            int intAnswer;
            string answer = Console.ReadLine();
            intAnswer = Convert.ToInt32(answer);
            while (p1[intAnswer] == "X" || p1[intAnswer] == "O")
            {
                Console.WriteLine("oops spot taken");
                Console.WriteLine("Player 1 pick spot");
                answer = Console.ReadLine();
                intAnswer = Convert.ToInt32(answer);
            }
            p1[intAnswer] = "X";
            return false;
        }

        static bool Cycle2(string[] p2)
        {
            Console.WriteLine("Player 2 pick spot");
            int intAnswer;
            string answer = Console.ReadLine();
            intAnswer = Convert.ToInt32(answer);
            while (p2[intAnswer] == "X" || p2[intAnswer] == "O")
            {
                Console.WriteLine("oops spot taken");
                Console.WriteLine("Player 2 pick spot");
                answer = Console.ReadLine();
                intAnswer = Convert.ToInt32(answer);
            }
            {
                p2[intAnswer] = "O";
                return false;
            }
        }

        static bool Winner(string[] array)
        {
            if (array[0] == array[1] && array[1] == array[2])
            {
                Console.WriteLine("Winner Winner!!");
            }
            else if (array[3] == array[4] && array[4] == array[5])
            {
                Console.WriteLine("Winner Winner!!");
            }
            else if (array[6] == array[7] && array[7] == array[8])
            {
                Console.WriteLine("Winner Winner!!");
            }
            else if (array[0] == array[3] && array[3] == array[6])
            {
                Console.WriteLine("Winner Winner!!");
            }
            else if (array[1] == array[4] && array[4] == array[7])
            {
                Console.WriteLine("Winner Winner!!");
            }
            else if (array[2] == array[5] && array[5] == array[8])
            {
                Console.WriteLine("Winner Winner!!");
            }
            else if (array[0] == array[4] && array[4] == array[8])
            {
                Console.WriteLine("Winner Winner!!");
            }
            else if (array[2] == array[4] && array[4] == array[6])
            {
                Console.WriteLine("Winner Winner!!");
            }
            return false;
        }

        static bool Tie(string[] array2)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] != "X" && array2[i] != "O")
                {
                    return false;
                }
            }
            Console.WriteLine("Tie Game");
            return true;
        }
    }
}
