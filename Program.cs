using System;
using System.Threading;
using System.Threading.Tasks;

/*
Uppgifter i Assignments.cs använd t.ex KaggVariabler.Uppgift1(); för att köra uppgift.
Nuvarande klasser: 
'KaggVariabler' med uppgifter 1-8
'KaggInmatningUtskrift' med uppgifter 1-13
'ProgSharpK2' 
*/
namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {

            int?[,] board = Sudoku.generateBoard();
            Console.WriteLine("Valid board!:");
            for (int i = 0; i < 9; i++) //Print final board
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == null) Console.Write(".");
                    else Console.Write(board[i, j].ToString());
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }  
    }
}
