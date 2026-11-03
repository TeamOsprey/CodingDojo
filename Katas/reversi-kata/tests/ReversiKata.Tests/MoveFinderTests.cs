using NUnit.Framework;
using reversi_kata.Application;

namespace ReversiKata.Tests;

public sealed class MoveFinderTests
{
    private readonly BoardParser _parser = new();

    [Test]
    public void FindLegalMoves_FindsHorizontalCapturesInBothDirections()
    {
        string[] lines =
        [
            "........",
            "........",
            "........",
            "BW..WB..",
            "........",
            "........",
            "........",
            "........",
            "B"
        ];
        string[] expectedBoard =
        [
            "........",
            "........",
            "........",
            "BW00WB..",
            "........",
            "........",
            "........",
            "........"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualBoard = snapshot.Board.ToString(actualMoves);

        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }

    [Test]
    public void FindLegalMoves_CapturesMultipleContiguousOpponentCounters()
    {
        string[] lines =
        [
            "........",
            "........",
            "........",
            ".WWB....",
            "........",
            "........",
            "........",
            "........",
            "B"
        ];
        string[] expectedBoard =
        [
            "........",
            "........",
            "........",
            "0WWB....",
            "........",
            "........",
            "........",
            "........"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualBoard = snapshot.Board.ToString(actualMoves);

        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }

    [Test]
    public void FindLegalMoves_ExcludesEmptySquaresWithoutHorizontalCapture()
    {
        string[] lines =
        [
            "........",
            "........",
            "........",
            "..W.....",
            "........",
            "........",
            "........",
            "........",
            "B"
        ];
        string[] expectedBoard =
        [
            "........",
            "........",
            "........",
            "..W.....",
            "........",
            "........",
            "........",
            "........"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualBoard = snapshot.Board.ToString(actualMoves);

        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }

    [Test]
    public void FindLegalMoves_FindsCapturesAtBoardCorners()
    {
        string[] lines =
        [
            ".WB.....",
            "........",
            "........",
            "........",
            "........",
            ".....B..",
            "......W.",
            "........",
            "B"
        ];
        string[] expectedBoard =
        [
            "0WB.....",
            "........",
            "........",
            "........",
            "........",
            ".....B..",
            "......W.",
            ".......0"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualBoard = snapshot.Board.ToString(actualMoves);

        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }

    [Test]
    public void FindLegalMoves_ExcludesEdgeSquaresWithoutBracketedOpponent()
    {
        string[] lines =
        [
            "W......W",
            "........",
            "........",
            "....W...",
            "........",
            "........",
            "........",
            "W......W",
            "B"
        ];
        string[] expectedBoard =
        [
            "W......W",
            "........",
            "........",
            "....W...",
            "........",
            "........",
            "........",
            "W......W"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualBoard = snapshot.Board.ToString(actualMoves);

        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }

    [Test]
    public void FindLegalMoves_FindsVerticalCapturesInBothDirections()
    {
        string[] lines =
        [
            "....B...",
            "....W...",
            "........",
            "........",
            "....W...",
            "....B...",
            "........",
            "........",
            "B"
        ];
        string[] expectedBoard =
        [
            "....B...",
            "....W...",
            "....0...",
            "....0...",
            "....W...",
            "....B...",
            "........",
            "........"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualBoard = snapshot.Board.ToString(actualMoves);

        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }

    [Test]
    public void FindLegalMoves_FindsDiagonalCapturesInAllFourDirections()
    {
        string[] lines =
        [
            "........",
            ".B....B.",
            "..W..W..",
            "........",
            "........",
            "..W..W..",
            ".B....B.",
            "........",
            "B"
        ];
        string[] expectedBoard =
        [
            "........",
            ".B....B.",
            "..W..W..",
            "...00...",
            "...00...",
            "..W..W..",
            ".B....B.",
            "........"
        ];
        var snapshot = _parser.Parse(lines);

        var actualMoves = MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer);
        var actualBoard = snapshot.Board.ToString(actualMoves);

        Assert.That(actualBoard, Is.EqualTo(expectedBoard));
    }
}