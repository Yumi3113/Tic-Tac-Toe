// Responsible for rules and states of the game this includes:
// initialise/ reset the board (reset())
// mark the board? (PlaceMark())
class Board
{
    private char[,] grid = new char[3, 3];

    public Board()
    {
        Reset();
    }

    public void Reset()
    {
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                grid[r, c] = ' ';
            }
        }
    }

    public bool PlaceMove(int row, int col, char player)
    {
        if (grid[row, col] != ' ')
            return false;

        grid[row, col] = player;
        return true;
    }

    public bool IsCellEmpty(int row, int col)
    {
        return grid[row, col] == ' ';
    }

    public void Display()
    {
        Console.WriteLine();

        // Column numbers
        Console.WriteLine("   1   2   3");

        for (int r = 0; r < 3; r++)
        {
            // Row numbers
            Console.Write($"{r + 1} ");

            // Display the row with separators
            Console.WriteLine(" {0} | {1} | {2} ", grid[r, 0], grid[r, 1], grid[r, 2]);

            // Print the separator line between rows, except after the last row
            if (r < 2)
                Console.WriteLine("  ---+---+---");
        }
        Console.WriteLine();
    }

    public bool IsFull()
    {
        for (int r = 0; r < 3; r++)
            for (int c = 0; c < 3; c++)
                if (grid[r, c] == ' ')
                    return false;

        return true;
    }

    public char GetCell(int row, int col)
    {
        return grid[row, col];
    }
}