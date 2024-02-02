class Driver
{ 

static void Main()
{
    bool gameOver = false;

    TicTacToes ttt = new TicTacToes();

    // Welcome the user to the game
    Console.WriteLine("Welcome to Tic-Tac-Toe!");

    // Create a game board array to store the players’ choices
    char[,] gameBoard = new char[3, 3];

    do
    {
        // Ask each player in turn for their choice
        Console.WriteLine("Player O, make your selection");
        string PlayerOPick = Console.ReadLine();

        // Convert the player's input to row and column indices

        // Assuming the first character represents the row (1, 2, 3)
        int row = (PlayerOPick[0] - '1'); 
        // The second character is the column (1, 2, 3)
        int col = int.Parse(PlayerOPick[1] - '1'); 

        // Update the game board array
        gameBoard[row, col] = 'O'; 

        // Check for a winner by calling the method in the supporting class,
        // and notify the players when a win has occurred and which player won the game
        WinnerInfo winnerCheck = ttt.CheckWinner(gameBoard);

        if (winnerCheck.win == 1)
        {
            Console.WriteLine($"Player {winnerCheck.player} won!");
            gameOver = true;
        }
        else if (winnerCheck.win == 2)
        {
            Console.WriteLine("Draw");
            gameOver = true;
        }

        // Print the board by calling the method in the supporting class
        ttt.PrintBoard(gameBoard);

        // Player X's turn
        Console.WriteLine("Player X, make your selection");
        string PlayerXPick = Console.ReadLine();

        // Convert the player's input to row and column indices

        // Assuming the first character represents the row (1, 2, 3)
        row = int.Parse(PlayerXPick[0] - '1');
        // The second character is the column (1, 2, 3)
        col = int.Parse(PlayerXPick[1] - '1');

        // Update the game board array
        gameBoard[row, col] = 'X';

            // Check for a winner by calling the method in the supporting class,
            // and notify the players when a win has occurred and which player won the game
        char? winner = ttt.CheckWinner(gameBoard);

        if (winner.HasValue)
        {
            Console.WriteLine($"Player {winner} won!");
            gameOver = true;
        }

        // Print the board by calling the method in the supporting class
        ttt.PrintBoard(gameBoard);

    } while (!gameOver);
}
}
}
