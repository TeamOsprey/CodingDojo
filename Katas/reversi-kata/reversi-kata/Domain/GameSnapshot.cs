namespace reversi_kata.Domain;

public sealed class GameSnapshot
{
    public GameSnapshot(Board board, Player activePlayer)
    {
        Board = board ?? throw new ArgumentNullException(nameof(board));
        ActivePlayer = activePlayer;
    }

    public Board Board { get; }

    public Player ActivePlayer { get; }
}
