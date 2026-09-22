namespace reversi_kata.Domain;

public readonly record struct Position
{
    public Position(int row, int column)
    {
        if (row is < 0 or >= Board.Size)
        {
            throw new ArgumentOutOfRangeException(nameof(row), row, "Row must be between 0 and 7.");
        }

        if (column is < 0 or >= Board.Size)
        {
            throw new ArgumentOutOfRangeException(nameof(column), column, "Column must be between 0 and 7.");
        }

        Row = row;
        Column = column;
    }

    public int Row { get; }

    public int Column { get; }
}
