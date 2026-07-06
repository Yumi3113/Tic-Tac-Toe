using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a 3x3 board
        char[,] board = new char[3, 3];

        // Fill the board with spaces
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = ' ';
            }
        }

        // Display the board
        PrintBoard(board);
    }

    static void PrintBoard(char[,] board)
    {
        //prints the collumn numbers
        Console.WriteLine("   1   2   3");

        for (int row = 0; row < 3; row++)
        {
            //prints the row numbers
            Console.Write($"{row + 1} ");

            for (int col = 0; col < 3; col++)
            {
                //Print the value stored in the current board cell,
                //with a space before and after it,
                //without moving to the next line
                
                Console.Write($" {board[row, col]} ");

                if (col < 2)
                    Console.Write("|");
            }

            Console.WriteLine();

            if (row < 2)
                Console.WriteLine("  ---+---+---");
        }
    }
}