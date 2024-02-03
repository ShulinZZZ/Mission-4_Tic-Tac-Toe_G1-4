using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mission4_G1_4_Tic_Tac_Toe
{
    internal class TicTacToes
    {
        // Print board with lines and bars
        public void PrintBoard(char[,] gameBoard)
        {
            Console.WriteLine("   0    1    2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j] + " ");
                    if (j < 2)
                        Console.Write("  | "); // Separate columns with a vertical bar
                }
                Console.WriteLine();
                if (i < 2)
                    Console.WriteLine("  -----------"); // Separate rows with dashes
            }
        }

        public void MakeMove(char player, char[,] gameBoard)
         {
             bool validMove = false;

             do
             {
                 Console.WriteLine($"Enter row and column (e.g., '1 2'):");
                 string[] input = Console.ReadLine().Split(' ');
                
                // checks if the users input array is exactly two elements, then checks if the two elements are integers
                // and check to see if the integars are within the 0-2 range which is the rang of the board, 
                // then checks if the selected cell on the game board is empty
                 if (input.Length == 2 && int.TryParse(input[0], out int row) && int.TryParse(input[1], out int col)
                     && row >= 0 && row < 3 && col >= 0 && col < 3 && gameBoard[row, col] == 0)
                 {
                    // if true, updates the game board with the player's symbol
                     gameBoard[row, col] = player;
                     validMove = true;
                 }
                 else
                 {
                    // if not true, asks user to input a valid move
                     Console.WriteLine("Invalid move. Please try again.");
                 }

             } while (!validMove);
         } 

        public char? CheckWinner(char[,] gameBoard)
        {
            // Check to see if there are 3 in a row in the rows
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2] && gameBoard[i, 0] != 0)
                {
                    return gameBoard[i, 0];
                }
            }

            // Check to see if there are 3 in a row in the columns
            for (int j = 0; j < 3; j++)
            {
                if (gameBoard[0, j] == gameBoard[1, j] && gameBoard[1, j] == gameBoard[2, j] && gameBoard[0, j] != 0)
                {
                    return gameBoard[0, j];
                }
            }

            // Check to see if there are 3 in a row in the diagonals
            if ((gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2] && gameBoard[0, 0] != 0) ||
                (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0] && gameBoard[0, 2] != 0))
            {
                return gameBoard[1, 1];
            }

            // Check to see if there is a draw
            bool isBoardFull = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i, j] == 0)
                    {
                        isBoardFull = false;
                        break;
                    }
                }
            }

            if (isBoardFull)
            {
                return 'D'; // 'D' represents a draw
            }

            return null;
        }
    }
}

