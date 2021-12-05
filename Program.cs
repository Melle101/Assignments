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
            

            int?[,] unsolved_board = Sudoku.SudokuFillTest();

            Sudoku.RemoveNumber(unsolved_board, 40);

            int?[,] unsolvedClone = (int?[,]) unsolved_board.Clone();

            for (int i = 0; i < 9; i++) //Print board with removed cells
            {
                for (int j = 0; j < 9; j++)
                {
                    if (unsolved_board[i, j] == null) Console.Write(".");
                    else Console.Write(unsolved_board[i, j].ToString());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n \n \n \n");
            

            Sudoku.SudokuSolver(unsolved_board, out int?[,] SolvedBoard);
            for (int i = 0; i < 9; i++) //Print final board
            {
                for (int j = 0; j < 9; j++)
                {
                    if (unsolved_board[i, j] == null) Console.Write(".");
                    else Console.Write(unsolved_board[i, j].ToString());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n \n \n \n");

            Sudoku.SudokuSolver(unsolvedClone, out int?[,] SolvedBoard2);
            for (int i = 0; i < 9; i++) //Print final board
            {
                for (int j = 0; j < 9; j++)
                {
                    if (unsolvedClone[i, j] == null) Console.Write(".");
                    else Console.Write(unsolvedClone[i, j].ToString());
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }  
    }
}
