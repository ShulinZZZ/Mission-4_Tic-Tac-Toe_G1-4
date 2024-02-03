using System;

namespace Mission4_G1_4_Tic_Tac_Toe
{
    class Program
    {

        static void Main()
        {
            bool gameOver = false;

            // Create an instance of the supporting class
            TicTacToes ttt = new TicTacToes();

            // Welcome the user to the game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            // Create a game board array to store the players’ choices
            char[,] gameBoard = new char[3, 3];

            do
            {
                // Ask each player in turn for their choice
                Console.WriteLine("Player X, make your selection");
                ttt.MakeMove('X', gameBoard);

                // Print the board by calling the method in the supporting class
                ttt.PrintBoard(gameBoard);

                // Check for a winner
                char? winner = ttt.CheckWinner(gameBoard);

                if (winner.HasValue)
                {
                    Console.WriteLine($"Player {winner} won!");
                    gameOver = true;
                    break;
                }

                // Ask the next player for their choice
                Console.WriteLine("Player O, make your selection");
                ttt.MakeMove('O', gameBoard);

                // Print the board by calling the method in the supporting class
                ttt.PrintBoard(gameBoard);

                // Check for a winner
                winner = ttt.CheckWinner(gameBoard);

                if (winner.HasValue)
                {
                    Console.WriteLine($"Player {winner} won!");
                    gameOver = true;
                }

            } while (!gameOver);
        }
    }
}

