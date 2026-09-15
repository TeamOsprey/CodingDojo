# Reversi Kata Project Plan

## Project Overview

Build a small .NET 10 console application that reads an 8x8 Reversi board and the active player from standard input, identifies every empty square where that player can flip at least one opposing counter, and writes the board back with each legal move represented by `0`. The exercise focuses on board parsing, boundary-safe directional scanning, and clear tests around the game rule rather than implementing a complete playable game.

## User Stories

1. As a kata participant, I can provide an 8x8 board and an active player so the program can evaluate a position.
   - Acceptance criteria: The input consists of eight rows containing `.`, `B`, or `W`, followed by a ninth line containing `B` or `W`.
   - Acceptance criteria: Invalid row counts, row widths, square values, or player markers produce a clear error rather than an incorrect result.

2. As a player, I can see every legal move for the active colour.
   - Acceptance criteria: A legal move is placed only on an empty square.
   - Acceptance criteria: A move is legal only when placing the active colour would enclose one or more contiguous opponent counters between the new counter and an existing active counter in at least one direction.
   - Acceptance criteria: The evaluator checks horizontal, vertical, and both diagonal axes in both directions.

3. As a player, I receive output in the same board format as the input.
   - Acceptance criteria: Legal moves are written as `0`; existing board counters and empty squares remain unchanged.
   - Acceptance criteria: The final output line repeats the active player marker.
   - Acceptance criteria: The board from the requirements produces the four marked Black moves in the example output.

4. As a kata participant, I can evolve the rule implementation with confidence.
   - Acceptance criteria: Tests cover the example, all eight directions, edge and corner bounds, empty squares with no capture, and positions where one move captures along multiple directions.
   - Acceptance criteria: Production code has no external package dependencies.

## Data Model

- `Player` enum: `Black`, `White`.
- `Position` record struct: `Row` (`int`), `Column` (`int`) for a square coordinate.
- `Board` class:
  - `Size` (`const int`): `8`.
  - `Squares` (`Player?[,]`): counters on the board; `null` represents an empty square.
  - `IsInside(Position)` (`bool`): determines whether a coordinate is on the board.
  - `GetSquare(Position)` (`Player?`): returns the square content.
- `GameSnapshot` class:
  - `Board` (`Board`): parsed board state.
  - `ActivePlayer` (`Player`): player whose legal moves are requested.
- `MoveFinder` class:
  - `FindLegalMoves(Board, Player)` (`IReadOnlySet<Position>`): returns all legal destination squares.
- `BoardParser` class:
  - `Parse(IEnumerable<string>)` (`GameSnapshot`): validates and converts the nine input lines.
- `BoardRenderer` class:
  - `Render(GameSnapshot, IReadOnlySet<Position>)` (`IEnumerable<string>`): emits the result board with `0` markers and the active player line.

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

For the current single-project kata, the production files can initially remain in the existing `reversi-kata/` project directory and be reorganized under `src/` only when setting up the test project. Tests can use the built-in .NET testing framework facilities available in the SDK, keeping the exercise free of third-party dependencies.

## Implementation Phases

1. Establish input and domain primitives.
   - Replace the starter output in `Program.cs` with standard-input orchestration.
   - Add `Player`, `Position`, `Board`, and `GameSnapshot` with explicit board-boundary checks.
   - Implement and test parsing and validation of the nine-line input format.

2. Implement the legal-move rule.
   - Define the eight row/column direction offsets in `MoveFinder`.
   - For each empty square, scan each direction: require at least one adjacent opponent counter, then continue until an active counter or a boundary/empty square is reached.
   - Mark the square legal when any direction ends at an active counter after one or more opponent counters.
   - Test every direction, corners, edges, no-capture candidates, and multi-direction captures.

3. Render and integrate the result.
   - Add `BoardRenderer` to retain original counters and empties while substituting `0` for legal moves.
   - Print the rendered rows followed by the active player marker.
   - Add an end-to-end test using the requirements example as the acceptance fixture.

4. Finish the kata.
   - Run formatting, build, and the full test suite.
   - Review naming and error messages for clarity.
   - Optionally add a second fixture for White to demonstrate that the same rule is colour-agnostic.