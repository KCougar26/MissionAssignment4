using System;
using System.Collections.Generic;
using System.Text;

namespace MissionAssignment4
{
    public class SupportTools
    {
        public string Winner(string[] board)
        {
            // Check rows, columns, and diagonals for a win
            string[,] winConditions = new string[,]
            {
                { board[0], board[1], board[2] },
                { board[3], board[4], board[5] },
                { board[6], board[7], board[8] },
                { board[0], board[3], board[6] },
                { board[1], board[4], board[7] },
                { board[2], board[5], board[8] },
                { board[0], board[4], board[8] },
                { board[2], board[4], board[6] }
            };
            for (int i = 0; i < winConditions.GetLength(0); i++)
            {
                if (winConditions[i, 0] == winConditions[i, 1] && winConditions[i, 1] == winConditions[i, 2])
                {
                    return winConditions[i, 0]; // Return the winner ("X" or "O")
                }
            }

            return null; // No winner yet
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
