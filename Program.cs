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

            Sudoku.RemoveNumber(SolvedBoard, 40);

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
            

            Sudoku.SudokuSolver(SolvedBoard, out SolvedBoard);
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
