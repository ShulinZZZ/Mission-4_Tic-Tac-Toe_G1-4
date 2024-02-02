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
            /**
             * dont need to create a game board becuase we are recieving it from the front end
            char[,] gameBoard;
           // gameBoard = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = ' ';
                }
            }
            */
            Console.WriteLine(" 0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(gameBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public char? CheckWinner(char[,] gameBoard)
        {

            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2] && gameBoard[i, 0] != ' ')
                {
                    return gameBoard[i, 0];
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (gameBoard[0, j] == gameBoard[1, j] && gameBoard[1, j] == gameBoard[2, j] && gameBoard[0, j] != ' ')
                {
                    return gameBoard[0, j];
                }
            }

            // Check diagonals
            if ((gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2] && gameBoard[0, 0] != ' ') ||
                (gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 0] && gameBoard[0, 2] != ' '))
            {
                return gameBoard[1, 1];
            }

            return ' ';
        }
    }
}

