using System;

class Program
{
    static void Main(string[] args)
    {
        Board board = new Board();
        Game game = new Game(board);

        char currentPlayer = 'X';

        while (true)
        {
            board.Display();

            Console.WriteLine($"Player {currentPlayer}, enter row 1-3:");
            int row = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine($"Player {currentPlayer}, enter column 1-3:");
            int col = int.Parse(Console.ReadLine()) - 1;

            if (row < 0 || row > 2 || col < 0 || col > 2)
            {
                Console.WriteLine("Invalid position. Try again.");
                continue;
            }

            if (!board.PlaceMove(row, col, currentPlayer))
            {
                Console.WriteLine("That cell is already taken. Try again.");
                continue;
            }

            if (game.CheckWin(currentPlayer))
            {
                board.Display();
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            if (board.IsFull())
            {
                board.Display();
                Console.WriteLine("It's a draw!");
                break;
            }

            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
}