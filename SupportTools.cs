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

        public string PrintBoard(string[,] board)
        {
            string boardDisplay = "";

            //Loops through each row and adds a space 
            for (int row = 0; row < 3; row++)
            {
                boardDisplay += " ";

                //Loops through the columns and prints the value thats there
                for (int col = 0; col < 3; col++)
                {
                    boardDisplay += board[row, col];

                    if (col < 2)
                    {
                        boardDisplay += " | ";
                    }
                }

                //Creates a new line
                boardDisplay += "\n";

                //Adds dividers in between the rows but not the last one
                if (row < 2)
                {
                    boardDisplay += "---+---+---\n";
                }
            }

            return boardDisplay;
        }
    }
}
