//Drivers
//Chad Laursen and Kathryn Erickson
//Welcome the user to the game
//Create a game board array to store the players’ choices
//Ask each player in turn for their choice and update the game board array
//Print the board by calling the method in the supporting class
//Check for a winner by calling the method in the supporting class, and notify the players
//when a win has occurred and which player won the game

//Welcome

using System;
using MissionAssignment4;

Console.WriteLine("Hello! Welcome to a game of Tic-Tac-Toe!");
Console.WriteLine("Players take turns choosing a square 1-9. X goes first.\n");

SupportTools st = new SupportTools();

bool playAgain = true;

while (playAgain)
{
    // Reset the board for a new game
    string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    bool gameOver = false;
    string currentPlayer = "X";

    while (!gameOver)
    {
        st.PrintBoard(board);

        int choiceIndex = GetValidMove(board, currentPlayer);
        board[choiceIndex] = currentPlayer;

        // 0 = no win yet, 1 = win, 2 = draw
        int result = st.Winner(board);

        if (result == 1)
        {
            st.PrintBoard(board);
            Console.WriteLine($"Player {currentPlayer} wins!");
            gameOver = true;
        }
        else if (result == 2)
        {
            st.PrintBoard(board);
            Console.WriteLine("It's a draw!");
            gameOver = true;
        }
        else
        {
            // Switch players and continue
            currentPlayer = (currentPlayer == "X") ? "O" : "X";
        }
    }

    Console.Write("\nPlay again? (y/n): ");
    string? again = Console.ReadLine();
    playAgain = !string.IsNullOrWhiteSpace(again)
                && again.Trim().StartsWith("y", StringComparison.OrdinalIgnoreCase);

    Console.WriteLine();
}

static int GetValidMove(string[] board, string currentPlayer)
{
    while (true)
    {
        Console.Write($"Player {currentPlayer}, choose a square (1-9): ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int choice) || choice < 1 || choice > 9)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.\n");
            continue;
        }

        int index = choice - 1;

        // Prevent overwriting an existing move
        if (board[index] == "X" || board[index] == "O")
        {
            Console.WriteLine("That square is already taken. Please choose another.\n");
            continue;
        }

        return index;
    }
}

