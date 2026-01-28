//Drivers
//Chad Laursen and Kathryn Erickson
//Welcome the user to the game
//Create a game board array to store the players’ choices
//Ask each player in turn for their choice and update the game board array
//Print the board by calling the method in the supporting class
//Check for a winner by calling the method in the supporting class, and notify the players
//when a win has occurred and which player won the game

//Welcome

using MissionAssignment4;

Console.WriteLine("Hello, Welcome to a game of Tic-Tac-Toe!");

//Create array
string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

//initialize class
SupportTools st = new SupportTools();

//game logic
bool gameOver = false;
string currentPlayer = "X";

while (!gameOver)
{
  //prints board
  st.PrintBoard(board);
  
  //ask a player for choice
  Console.WriteLine("Please enter a number between 1 and 9 to select your desired square: ");
  int choice = int.Parse(Console.ReadLine()) - 1;
  
  //update array 
  board[choice] = currentPlayer;
  
  //check for winner.
  int result = st.Winner(board);
  
  //0 = no win, 1 = win, 2 = draw
  if (result == 1)
  {
      Console.WriteLine("Congratulations! You won!");
      gameOver = true; 
  }
  else if (result == 2)
  {
      Console.WriteLine("Congratulations! It's a tie!");
      gameOver = true;
  }
  else
  {
      Console.WriteLine("Oh no! You lost... Play again!");
      gameOver = false;
  }
  
  //switch players
  currentPlayer = (currentPlayer == "X") ? "O" : "X";
  
  
  
  
}




