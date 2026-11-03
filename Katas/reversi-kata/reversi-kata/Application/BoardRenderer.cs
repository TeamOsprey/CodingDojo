using reversi_kata.Domain;

namespace reversi_kata.Application;

public static class BoardRenderer
{
    public static IEnumerable<string> Render(GameSnapshot snapshot, IReadOnlySet<Position> legalMoves)
    {
        ArgumentNullException.ThrowIfNull(snapshot);
        ArgumentNullException.ThrowIfNull(legalMoves);

        var rows = snapshot.Board.ToString(legalMoves);
        return rows.Append(snapshot.ActivePlayer switch
        {
            Player.Black => "B",
            Player.White => "W",
            _ => throw new InvalidOperationException("The active player is invalid.")
        });
    }
}