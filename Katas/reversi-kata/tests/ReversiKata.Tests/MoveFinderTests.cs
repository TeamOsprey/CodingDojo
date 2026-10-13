using NUnit.Framework;
using reversi_kata.Application;
using reversi_kata.Domain;

namespace ReversiKata.Tests;

public sealed class MoveFinderTests
{
    [Test]
    public void FindLegalMoves_FindsHorizontalCapturesInBothDirections()
    {
        var board = CreateBoard(
            "........",
            "........",
            "........",
            "BW..WB..",
            "........",
            "........",
            "........",
            "........");

        var actual = MoveFinder.FindLegalMoves(board, Player.Black);

        Assert.That(actual, Is.EquivalentTo(new[]
        {
            new Position(3, 2),
            new Position(3, 3)
        }));
    }

    [Test]
    public void FindLegalMoves_ExcludesEmptySquaresWithoutHorizontalCapture()
    {
        var board = CreateBoard(
            "........",
            "........",
            "........",
            "..W.....",
            "........",
            "........",
            "........",
            "........");

        var actual = MoveFinder.FindLegalMoves(board, Player.Black);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void FindLegalMoves_FindsVerticalCapturesInBothDirections()
    {
        var board = CreateBoard(
            "....B...",
            "....W...",
            "........",
            "........",
            "....W...",
            "....B...",
            "........",
            "........");

        var actual = MoveFinder.FindLegalMoves(board, Player.Black);

        Assert.That(actual, Is.EquivalentTo(new[]
        {
            new Position(2, 4),
            new Position(3, 4)
        }));
    }

    [Test]
    public void FindLegalMoves_FindsDiagonalCapturesInAllFourDirections()
    {
        var board = CreateBoard(
            "........",
            ".B....B.",
            "..W..W..",
            "........",
            "........",
            "..W..W..",
            ".B....B.",
            "........");

        var actual = MoveFinder.FindLegalMoves(board, Player.Black);

        Assert.That(actual, Is.EquivalentTo(new[]
        {
            new Position(3, 3),
            new Position(3, 4),
            new Position(4, 3),
            new Position(4, 4)
        }));
    }

    private static Board CreateBoard(params string[] rows)
    {
        var squares = new Player?[Board.Size, Board.Size];
        for (var row = 0; row < Board.Size; row++)
        {
            for (var column = 0; column < Board.Size; column++)
            {
                squares[row, column] = rows[row][column] switch
                {
                    '.' => null,
                    'B' => Player.Black,
                    'W' => Player.White,
                    _ => throw new ArgumentException("Unexpected board square.", nameof(rows))
                };
            }
        }

        return new Board(squares);
    }
}