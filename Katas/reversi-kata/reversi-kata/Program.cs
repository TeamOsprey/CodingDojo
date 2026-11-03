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
	var legalMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
	foreach (var outputLine in BoardRenderer.Render(snapshot, legalMoves))
	{
		Console.WriteLine(outputLine);
	}
}
catch (FormatException exception)
{
	Console.Error.WriteLine($"Invalid input: {exception.Message}");
	return 1;
}

return 0;
