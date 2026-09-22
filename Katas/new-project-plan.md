# Reversi Legal Moves Kata - Project Plan

## Project Overview

Build a .NET 10 console application that reads an 8x8 Reversi board position and the active player's color, then returns the same board with every legal move for that player marked with `0`. A move is legal only when placing the active player's counter on an empty square would bracket at least one contiguous opponent counter in one of the eight directions and terminate at the active player's counter. The implementation should use only the .NET 10 standard library and remain small enough for a workshop exercise.

## Scope

Included:

- Parse eight board rows followed by the active player (`B` or `W`).
- Represent empty, Black, and White squares.
- Examine all eight directions from each empty square.
- Identify and mark every legal move with `0`.
- Preserve existing counters, empty non-move squares, and the active-player line in the output.
- Keep move evaluation independent from console input/output so it can be unit tested.

Out of scope:

- Applying a selected move or flipping counters in the returned board.
- Turn management, scoring, game history, or an interactive game loop.
- A graphical interface, persistence, networking, or external packages.

## Functional Design

1. The console boundary reads exactly eight board rows and one player line.
2. Input parsing validates board dimensions, supported square characters (`.`, `B`, `W`), and the active player.
3. The domain evaluator scans each empty square in all eight directions.
4. A direction qualifies when it contains one or more opponent counters followed immediately by the active player's counter before leaving the board.
5. A square is legal if at least one direction qualifies.
6. The formatter replaces legal empty squares with `0` and leaves all other output characters unchanged.

## Data Model

- `Player`
  - Type: enum
  - Values: `Black`, `White`
  - Behavior: exposes the opponent color.

- `Cell`
  - Type: enum
  - Values: `Empty`, `Black`, `White`, `LegalMove`
  - Purpose: represents a board square and its display state.

- `Position`
  - Type: readonly record struct
  - Properties: `Row: int`, `Column: int`
  - Invariant: row and column are within the 0-7 board bounds.

- `Board`
  - Type: class
  - Properties: `Cells: Cell[,]`
  - Invariant: dimensions are exactly 8 by 8.
  - Behavior: reads and writes cells, checks bounds, and produces formatted rows.

- `MoveEvaluator`
  - Type: class or static service
  - Input: `Board`, `Player`
  - Output: collection of legal `Position` values or a board with legal cells marked.
  - Behavior: evaluates all eight direction vectors without mutating the original counters.

## File Structure

```text
src/
  ReversiKata/
    ReversiKata.csproj
    Program.cs
    Domain/
      Board.cs
      Cell.cs
      Player.cs
      Position.cs
      MoveEvaluator.cs
    InputOutput/
      BoardParser.cs
      BoardFormatter.cs

tests/
  ReversiKata.Tests/
    ReversiKata.Tests.csproj
    MoveEvaluatorTests.cs
    BoardParserTests.cs
```

The current repository may keep the existing project location while the kata is developed. The `src/` layout above is the target organization if the workshop introduces a test project and separates application code from tests.

## Implementation Sequence

1. Define `Player`, `Cell`, and `Position` primitives.
2. Implement board parsing and validation.
3. Implement directional move detection and legal-position aggregation.
4. Format legal positions as `0` without changing counters.
5. Connect the console program to the parser, evaluator, and formatter.
6. Add focused tests for the supplied example and edge cases.

## Acceptance Checks

- The supplied example produces `0` in exactly the four legal Black positions.
- No occupied square is reported as a legal move.
- A line with opponent counters but no terminating active-player counter does not produce a move.
- All eight directions are considered, including diagonals and board edges.
- White moves use the same rules with colors reversed.
- Invalid dimensions, characters, or player input produce a clear validation error rather than an incorrect result.
- The solution builds with the .NET 10 SDK and has no external package dependencies.

## Assumptions and Decisions

- Input uses one character per square: `.` for empty, `B` for Black, and `W` for White.
- Output uses `0` only for legal moves, matching the supplied example.
- Invalid input handling is included as a small robustness boundary even though the example specifies only valid input.
- The plan does not require a full game engine; legal move discovery is the complete feature.
