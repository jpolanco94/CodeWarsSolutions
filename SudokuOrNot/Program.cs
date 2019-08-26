using System;

namespace SudokuOrNot
{
    //Write a function done_or_not/DoneOrNot passing a board (list[list_lines]) as 
    //parameter. If the board is valid return 'Finished!', otherwise return 'Try again!'
    class Program
    {
        public static string DoneOrNot(int[][] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int rowTotal = 0;
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    rowTotal += board[i][j];
                }
                if (rowTotal != 45) return "Try again!";
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int rowTotal = 0;
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    rowTotal += board[j][i];
                }
                if (rowTotal != 45) return "Try again!";
            }
            int squareRowTotal = 0;
            for (int i = 0; i < board.GetLength(0) / 3; i++)
            {
                for (int j = 0; j < board.GetLength(0) / 3; j++)
                {
                    squareRowTotal += board[i][j];
                }
            }
            if (squareRowTotal != 45) return "Try again!";
            return "Finished!";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
