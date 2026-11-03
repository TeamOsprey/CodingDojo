using NUnit.Framework;
using reversi_kata.Application;
using reversi_kata.Domain;

namespace ReversiKata.Tests;

public sealed class BoardRendererTests
{
    private readonly BoardParser _parser = new();

    [TestCase("B", "B")]
    [TestCase("W", "W")]
    public void Render_AppendsActivePlayerMarkerAfterBoardRows(string playerMarker, string expectedPlayerMarker)
    {
        string[] lines =
        [
            "........",
            "........",
            "........",
            "...BW...",
            "...WB...",
            "........",
            "........",
            "........",
            expectedPlayerMarker
        ];
        string[] expectedOutput =
        [
            "........",
            "........",
            "........",
            "...BW...",
            "...WB...",
            "........",
            "........",
            "........",
            playerMarker
        ];
        var snapshot = _parser.Parse(lines);

        var actualOutput = BoardRenderer.Render(snapshot, new HashSet<Position>());

        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Render_ProducesRequirementsExampleOutput()
    {
        string[] lines =
        [
            "........",
            "........",
            "........",
            "...BW...",
            "...WB...",
            "........",
            "........",
            "........",
            "B"
        ];
        string[] expectedOutput =
        [
            "........",
            "........",
            "....0...",
            "...BW0..",
            "..0WB...",
            "...0....",
            "........",
            "........",
            "B"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualOutput = BoardRenderer.Render(snapshot, actualMoves);

        Assert.That(actualOutput, Is.EqualTo(expectedOutput));
    }
}