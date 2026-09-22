namespace reversi_kata.Domain;

public sealed class Board
{
    public const int Size = 8;

    public Board(Player?[,] squares)
    {
        if (squares.GetLength(0) != Size || squares.GetLength(1) != Size)
        {
            throw new ArgumentException("The board must contain exactly 8 rows and 8 columns.", nameof(squares));
        }

        Squares = (Player?[,])squares.Clone();
    }

    public Player?[,] Squares { get; }

    public bool IsInside(Position position) =>
        position.Row >= 0 && position.Row < Size &&
        position.Column >= 0 && position.Column < Size;

    public Player? GetSquare(Position position)
    {
        if (!IsInside(position))
        {
            throw new ArgumentOutOfRangeException(nameof(position), "Position must be inside the board.");
        }

        return Squares[position.Row, position.Column];
    }
}
