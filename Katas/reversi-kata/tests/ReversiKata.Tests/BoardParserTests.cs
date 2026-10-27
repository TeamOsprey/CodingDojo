using reversi_kata.Application;
using reversi_kata.Domain;
using NUnit.Framework;

namespace ReversiKata.Tests;

public sealed class BoardParserTests
{
    private readonly BoardParser _parser = new();

    [TestCase("B", Player.Black)]
    [TestCase("W", Player.White)]
    [Test]
    public void Parse_AcceptsValidBoardAndMapsEverySquare(string playerMarker, Player expectedPlayer)
    {
        string[] boardRows =
        [
            "........",
            ".B......",
            "..W.....",
            "...B....",
            "....W...",
            ".....B..",
            "......W.",
            ".......B"
        ];
        var lines = boardRows.Append(playerMarker).ToArray();
        string[] expectedBoard =
        [
            "........",
            ".B......",
            "..W.....",
            "...B....",
            "....W...",
            ".....B..",
            "......W.",
            ".......B"
        ];

        var actualSnapshot = _parser.Parse(lines);
        string[] actualBoard = actualSnapshot.Board.ToString();

        Assert.That(actualSnapshot.ActivePlayer, Is.EqualTo(expectedPlayer));
        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }

    [Test]
    public void Parse_RejectsEmptyInput()
    {
        AssertFormatError(Array.Empty<string>(), "exactly");
    }

    [Test]
    public void Parse_RejectsEightLinesWithoutPlayerMarker()
    {
        string[] lines =
        [
            "........",
            "........",
            "........",
            "........",
            "........",
            "........",
            "........",
            "........"
        ];

        AssertFormatError(lines, "exactly");
    }

    [Test]
    public void Parse_RejectsTenLines()
    {
        string[] lines =
        [
            "........",
            "........",
            "........",
            "........",
            "........",
            "........",
            "........",
            "........",
            "B",
            "W"
        ];

        AssertFormatError(lines, "exactly");
    }

    [TestCase(0, "")]
    [TestCase(0, ".")]
    [TestCase(0, ".......")]
    [TestCase(0, ".........")]
    [TestCase(0, "................")]
    [TestCase(7, ".......")]
    [TestCase(7, ".........")]
    [Test]
    public void Parse_RejectsRowsThatAreNotEightCharacters(int rowIndex, string invalidRow)
    {
        var lines = ValidInput();
        lines[rowIndex] = invalidRow;

        AssertFormatError(lines, "row");
    }

    [TestCase(0, 0, 'x')]
    [TestCase(0, 7, 'b')]
    [TestCase(7, 0, '0')]
    [TestCase(7, 7, '\t')]
    [Test]
    public void Parse_RejectsInvalidSquareValuesAtBoardCorners(int rowIndex, int column, char invalidValue)
    {
        var lines = ValidInput();
        var row = lines[rowIndex].ToCharArray();
        row[column] = invalidValue;
        lines[rowIndex] = new string(row);

        AssertFormatError(lines, "invalid square");
    }

    [TestCase("")]
    [TestCase("BB")]
    [TestCase("WW")]
    [TestCase("b")]
    [TestCase("w")]
    [TestCase("X")]
    [TestCase(".")]
    [TestCase(" ")]
    [TestCase("B ")]
    [Test]
    public void Parse_RejectsInvalidPlayerMarkers(string playerMarker)
    {
        var lines = ValidInput();
        lines[Board.Size] = playerMarker;

        AssertFormatError(lines, "final input");
    }

    [Test]
    public void Parse_RejectsNullInputSequence()
    {
        Assert.That(() => _parser.Parse(null!), Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Parse_RejectsNullBoardRowWithFormatError()
    {
        var lines = ValidInput();
        lines[3] = null!;

        AssertFormatError(lines, "row");
    }

    [Test]
    public void Parse_RejectsNullPlayerLineWithFormatError()
    {
        var lines = ValidInput();
        lines[Board.Size] = null!;

        AssertFormatError(lines, "final input");
    }

    private static string[] ValidInput() =>
    [
        "........",
        "........",
        "........",
        "........",
        "........",
        "........",
        "........",
        "........",
        "B"
    ];

    private void AssertFormatError(IEnumerable<string> lines, string messagePart)
    {
        var exception = Assert.Throws<FormatException>(() => _parser.Parse(lines))!;

        Assert.That(exception.Message, Does.Contain(messagePart).IgnoreCase);
    }
}