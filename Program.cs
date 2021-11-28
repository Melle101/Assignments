using System;

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
            

            int?[,] SolvedBoard = Sudoku.SudokuFillTest();

            for (int s = 0; s < 40; s++) //Remove upto 40 random numbers, might overlap remove
            {
                int i = new Random().Next(0, 9);
                int j = new Random().Next(0, 9);
                SolvedBoard[i, j] = null;
            }

            for (int i = 0; i < 9; i++) //Print board with removed cells
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SolvedBoard[i, j] == null) Console.Write(".");
                    else Console.Write(SolvedBoard[i, j].ToString());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n \n \n \n");
            

            SolvedBoard = Sudoku.SudokuSolver(SolvedBoard);
            for (int i = 0; i < 9; i++) //Print final board
            {
                for (int j = 0; j < 9; j++)
                {
                    if (SolvedBoard[i, j] == null) Console.Write(".");
                    else Console.Write(SolvedBoard[i, j].ToString());
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }  
    }
}
