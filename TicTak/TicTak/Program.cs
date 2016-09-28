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
            string p1 = "X";
            string p2 = "O";

            Console.WriteLine("Let's play Tic Tac Toe!");
            Console.WriteLine();
        
            string[] grid = new string[9];



            Board(grid);

            Console.ReadLine();



        }

        string[] grid = new string[9];

        static void Board(string[] table)
        {
            Console.WriteLine("{0}|{1}|{2}");
            Console.WriteLine("-----------");
            Console.WriteLine("{4}|{5}|{6}");
            Console.WriteLine("-----------");
            Console.WriteLine("{7}|{8}|{9}");
        }
        
            





    }
}
