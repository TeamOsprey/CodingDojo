using reversi_kata.Application;
using reversi_kata.Domain;

var lines = new List<string>();
string? line;
while ((line = Console.ReadLine()) is not null)
{
	lines.Add(line);
}

try
{
	var snapshot = new BoardParser().Parse(lines);
	Console.WriteLine($"Parsed {Board.Size}x{Board.Size} board for {snapshot.ActivePlayer}.");
	var legalMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
	var formattedMoves = legalMoves
		.OrderBy(position => position.Row)
		.ThenBy(position => position.Column)
		.Select(position => $"({position.Row},{position.Column})");
	Console.WriteLine($"Legal moves (row, column; zero-based): {string.Join(", ", formattedMoves)}");
}
catch (FormatException exception)
{
	Console.Error.WriteLine($"Invalid input: {exception.Message}");
	return 1;
}

return 0;
