using reversi_kata.Domain;

namespace reversi_kata.Application;

public static class MoveFinder
{
    private static readonly (int Row, int Column)[] Directions =
    [
        (0, -1),
        (0, 1),
        (-1, 0),
        (1, 0),
        (-1, -1),
        (-1, 1),
        (1, -1),
        (1, 1)
    ];

    public static IReadOnlySet<Position> FindLegalMoves(Board board, Player activePlayer)
    {
        ArgumentNullException.ThrowIfNull(board);

        var opponent = activePlayer == Player.Black ? Player.White : Player.Black;
        var legalMoves = new HashSet<Position>();

        for (var row = 0; row < Board.Size; row++)
        {
            for (var column = 0; column < Board.Size; column++)
            {
                var position = new Position(row, column);
                if (board.GetSquare(position) is not null)
                {
                    continue;
                }

                foreach (var direction in Directions)
                {
                    var nextRow = row + direction.Row;
                    var nextColumn = column + direction.Column;
                    var foundOpponent = false;

                    while (nextRow >= 0 && nextRow < Board.Size &&
                           nextColumn >= 0 && nextColumn < Board.Size)
                    {
                        var square = board.GetSquare(new Position(nextRow, nextColumn));
                        if (square == opponent)
                        {
                            foundOpponent = true;
                            nextRow += direction.Row;
                            nextColumn += direction.Column;
                            continue;
                        }

                        if (foundOpponent && square == activePlayer)
                        {
                            legalMoves.Add(position);
                        }

                        break;
                    }
                }
            }
        }

        return legalMoves;
    }
}