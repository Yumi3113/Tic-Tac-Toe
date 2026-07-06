class Game
{
    private Board board;

    public Game(Board board)
    {
        this.board = board;
    }

    public bool CheckWin(char player)
    {
        // rows
        for (int r = 0; r < 3; r++)
            if (board.GetCell(r, 0) == player &&
                board.GetCell(r, 1) == player &&
                board.GetCell(r, 2) == player)
                return true;

        // columns
        for (int c = 0; c < 3; c++)
            if (board.GetCell(0, c) == player &&
                board.GetCell(1, c) == player &&
                board.GetCell(2, c) == player)
                return true;

        // diagonals
        if (board.GetCell(0, 0) == player &&
            board.GetCell(1, 1) == player &&
            board.GetCell(2, 2) == player)
            return true;

        if (board.GetCell(0, 2) == player &&
            board.GetCell(1, 1) == player &&
            board.GetCell(2, 0) == player)
            return true;

        return false;
    }
}