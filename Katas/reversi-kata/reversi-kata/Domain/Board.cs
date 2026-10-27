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

    public new string[] ToString() => ToString(null);

    public string[] ToString(IReadOnlySet<Position>? legalMoves)
    {
        var rows = new string[Size];
        for (var row = 0; row < Size; row++)
        {
            var squares = new char[Size];
            for (var column = 0; column < Size; column++)
            {
                squares[column] = legalMoves?.Contains(new Position(row, column)) == true
                    ? '0'
                    : Squares[row, column] switch
                    {
                        Player.Black => 'B',
                        Player.White => 'W',
                        null => '.',
                        _ => throw new InvalidOperationException("The board contains an invalid player.")
                    };
            }

            rows[row] = new string(squares);
        }

        return rows;
    }

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
