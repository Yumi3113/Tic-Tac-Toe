using System;

class Program
{
    static void Main(string[] args){
        bool playAgain = true;

        while (playAgain)
        {
            Board board = new Board();
            Game game = new Game(board);

            char currentPlayer = 'X';

            while (true)
            {
                board.Display();

                Console.WriteLine($"Player {currentPlayer}, enter row (1-3):");

                if (!int.TryParse(Console.ReadLine(), out int row))
                {
                    Console.WriteLine("Please enter a number.");
                    continue;
                }

                Console.WriteLine($"Player {currentPlayer}, enter column (1-3):");

                if (!int.TryParse(Console.ReadLine(), out int col))
                {
                    Console.WriteLine("Please enter a number.");
                    continue;
                }

                row--;
                col--;

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

                if (game.CheckDraw())
                {
                    board.Display();
                    Console.WriteLine("It's a draw!");
                    break;
                }

                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }

            Console.WriteLine("Do you want to play again? Y/N");
            char answer = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            while (answer != 'Y' && answer != 'N')
            {
                Console.WriteLine("Invalid input. Please enter 'Y' to play again or 'N' to quit:");
                answer = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }

            playAgain = (answer == 'Y');

            if (answer == 'N')
            {
                Console.WriteLine("Thanks for playing!");
            }
    }
}
}