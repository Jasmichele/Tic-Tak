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
            string player1 = "X";
            string player2 = "O";


            Console.WriteLine("Let's play Tic Tac Toe!");
            Console.WriteLine();
            Console.WriteLine();

            string[] grid = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            

            Console.WriteLine("Player 1 is X");
            Console.WriteLine("Player 2 is O");
            Console.WriteLine();
            Console.WriteLine();

         
            Console.WriteLine("Player 1 pick spot");
            Console.WriteLine();
            Console.WriteLine();
            Board(grid);
            Cycle(grid);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Player 2 pick spot");
            Console.WriteLine();
            Console.WriteLine();
            Board(grid);
            Cycle2(grid);
          
            
           Console.ReadLine();
        }
    

        static void Board(string[] table)
        {
            Console.WriteLine(string.Format("{0}|{1}|{2}", table[0], table[1], table[2]));
            Console.WriteLine("-----");
            Console.WriteLine(string.Format("{0}|{1}|{2}", table[3], table[4], table[5]));
            Console.WriteLine("-----");
            Console.WriteLine(string.Format("{0}|{1}|{2}", table[6], table[7], table[8]));
        }

        static void Cycle(string[] p1)
        {
            int intAnswer;
            string answer = Console.ReadLine();
            intAnswer = Convert.ToInt32(answer);
            if (p1[intAnswer] == "X" || p1[intAnswer] == "O")
            {
                Console.WriteLine("oops");
            }
            else
                {
                p1[intAnswer] = "X";
                }
        
        }
        static void Cycle2(string[] p2)
        {
            int intAnswer;
            string answer = Console.ReadLine();
            intAnswer = Convert.ToInt32(answer);
            if (p2[intAnswer] == "X" || p2[intAnswer] == "O")
            {
                Console.WriteLine("oops");
            }
            else
            {
                p2[intAnswer] = "O";
            }

        }
        
        
         
        

         





    }
}
