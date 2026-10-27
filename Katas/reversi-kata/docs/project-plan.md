# Reversi Kata Project Plan

## Project Overview

Build a small .NET 10 console application that reads an 8x8 Reversi board and the active player from standard input, identifies every empty square where that player can flip at least one opposing counter, and writes the board back with each legal move represented by `0`. The exercise focuses on board parsing, boundary-safe directional scanning, and clear tests around the game rule rather than implementing a complete playable game.

## Data Model

- `Player` enum: `Black`, `White`.
- `Position` record struct: `Row` (`int`), `Column` (`int`) for a square coordinate.
- `Board` class:
  - `Size` (`const int`): `8`.
  - `Squares` (`Player?[,]`): counters on the board; `null` represents an empty square.
  - `IsInside(Position)` (`bool`): determines whether a coordinate is on the board.
  - `GetSquare(Position)` (`Player?`): returns the square content.
  - `ToString()` (`string[]`): returns eight board rows using `.`, `B`, and `W`.
  - `ToString(IReadOnlySet<Position>?)` (`string[]`): returns the board rows with supplied legal positions marked as `0`, without changing the board.
- `GameSnapshot` class:
  - `Board` (`Board`): parsed board state.
  - `ActivePlayer` (`Player`): player whose legal moves are requested.
- `MoveFinder` class:
  - `FindLegalMoves(Board, Player)` (`IReadOnlySet<Position>`): returns all legal destination squares.
- `BoardParser` class:
  - `Parse(IEnumerable<string>)` (`GameSnapshot`): validates and converts the nine input lines.
- `BoardRenderer` class:
  - `Render(GameSnapshot, IReadOnlySet<Position>)` (`IEnumerable<string>`): emits the result board with `0` markers and the active player line.

## Unit Test Pattern

Use NUnit and follow this pattern for all future board-based tests:

1. Declare input as an explicit `string[]` containing eight board rows and a final `B` or `W` player marker. Obtain the snapshot by calling `BoardParser.Parse(lines)` rather than constructing the board with a test helper.
2. Declare a separate, explicit `string[] expectedBoard` containing eight rows. Use `.`, `B`, and `W` for board contents and `0` for every expected legal move. Never generate expected rows from input or implementation results.
3. For plain board assertions, obtain `actualBoard` from `snapshot.Board.ToString()`.
4. For move assertions, obtain `actualMoves` from `MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer)`, then obtain `actualBoard` from `snapshot.Board.ToString(actualMoves)`. Keep marker rendering in `Board`, not in test helpers.
5. Assert `Assert.That(actualBoard, Is.EqualTo(expectedBoard))`. Do not replace the visual expected board with a builder or coordinate list.

Cover no-move cases with an explicit expected board containing no `0` markers. Preserve direct API tests for malformed input, constructor validation, and boundary behavior. Name actual results with the `actual` prefix and keep expected values independent of the implementation.

## File Structure

```text
src/
  ReversiKata/
    Program.cs
    Domain/
      Player.cs
      Position.cs
      Board.cs
      GameSnapshot.cs
    Application/
      BoardParser.cs
      MoveFinder.cs
      BoardRenderer.cs
tests/
  ReversiKata.Tests/
    BoardParserTests.cs
    MoveFinderTests.cs
    BoardRendererTests.cs
```

For the current single-project kata, the production files can initially remain in the existing `reversi-kata/` project directory and be reorganized under `src/` only when setting up a test project. The implementation must keep production code free of external package dependencies; test execution can be added as a separate workshop concern if the exercise introduces a test framework.
