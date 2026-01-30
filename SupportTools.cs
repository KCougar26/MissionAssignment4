// Carson Oliver and George Martinez

using System;

namespace MissionAssignment4
{
    public class SupportTools
    {
        // Returns:
        // 0 = no winner yet (game continues)
        // 1 = someone has won
        // 2 = draw (board full, no winner)
        public int Winner(string[] board)
        {
            // Winning combinations by index
            int[,] winCombos = new int[,]
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // rows
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // columns
                { 0, 4, 8 }, { 2, 4, 6 }               // diagonals
            };

            for (int i = 0; i < winCombos.GetLength(0); i++)
            {
                int a = winCombos[i, 0];
                int b = winCombos[i, 1];
                int c = winCombos[i, 2];

                string mark = board[a];

                // Only count a win if the line is X or O (not the initial numbers)
                if ((mark == "X" || mark == "O") &&
                    mark == board[b] &&
                    mark == board[c])
                {
                    return 1;
                }
            }

            // If there is no winner and the board is full -> draw
            bool boardFull = true;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] != "X" && board[i] != "O")
                {
                    boardFull = false;
                    break;
                }
            }

            return boardFull ? 2 : 0;
        }

        public void PrintBoard(string[] board)
        {
            Console.WriteLine();

            for (int row = 0; row < 3; row++)
            {
                Console.Write(" ");

                for (int col = 0; col < 3; col++)
                {
                    int index = row * 3 + col;
                    Console.Write(board[index]);

                    if (col < 2)
                    {
                        Console.Write(" | ");
                    }
                }

                Console.WriteLine();

                if (row < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }

            Console.WriteLine();
        }
    }
}
