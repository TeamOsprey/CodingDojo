using reversi_kata.Domain;

namespace reversi_kata.Application;

public sealed class BoardParser
{
    public GameSnapshot Parse(IEnumerable<string> lines)
    {
        ArgumentNullException.ThrowIfNull(lines);

        var input = lines.ToArray();
        if (input.Length != Board.Size + 1)
        {
            throw new FormatException("Input must contain exactly eight board rows followed by one player marker.");
        }

        var squares = new Player?[Board.Size, Board.Size];
        for (var row = 0; row < Board.Size; row++)
        {
            var boardRow = input[row];
            if (boardRow.Length != Board.Size)
            {
                throw new FormatException($"Board row {row + 1} must contain exactly eight characters.");
            }

            for (var column = 0; column < Board.Size; column++)
            {
                squares[row, column] = boardRow[column] switch
                {
                    '.' => null,
                    'B' => Player.Black,
                    'W' => Player.White,
                    _ => throw new FormatException(
                        $"Board row {row + 1}, column {column + 1} contains an invalid square.")
                };
            }
        }

        var activePlayer = input[Board.Size] switch
        {
            "B" => Player.Black,
            "W" => Player.White,
            _ => throw new FormatException("The final input line must contain exactly B or W.")
        };

        return new GameSnapshot(new Board(squares), activePlayer);
    }
}
