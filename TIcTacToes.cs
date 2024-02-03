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

        public void PrintBoard(char[,] gameBoard)
        {
            Console.WriteLine(" 0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MakeMove(char player, char[,] gameBoard)
        {
            bool validMove = false;

            do
            {
                Console.WriteLine($"Enter row and column (e.g., '1 2'):");
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length == 2 && int.TryParse(input[0], out int row) && int.TryParse(input[1], out int col)
                    && row >= 0 && row < 3 && col >= 0 && col < 3 && gameBoard[row, col] == 0)
                {
                    gameBoard[row, col] = player;
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }

            } while (!validMove);
        }

        public char? CheckWinner(char[,] gameBoard)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2] && gameBoard[i, 0] != 0)
                {
                    return gameBoard[i, 0];
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (gameBoard[0, j] == gameBoard[1, j] && gameBoard[1, j] == gameBoard[2, j] && gameBoard[0, j] != 0)
                {
                    return gameBoard[0, j];
                }
            }

            // Check diagonals
            if ((gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2] && gameBoard[0, 0] != 0) ||
                (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0] && gameBoard[0, 2] != 0))
            {
                return gameBoard[1, 1];
            }

            // Check for a draw
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

