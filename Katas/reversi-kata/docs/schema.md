# Reversi Kata Schema

## 1. Data models

### Player
- Type: enum
- Values:
  - `Black`
  - `White`
- Required: yes for all parsed input and move evaluation.
- Validation rules:
  - Only the defined enum values are accepted.
  - The active player in the final input line must be either `B` or `W` when parsed from text.

### Position
- Type: `record struct`
- Properties:
  - `Row`: `int` — required.
  - `Column`: `int` — required.
- Validation rules:
  - `Row` must be in the range `0..Board.Size - 1`.
  - `Column` must be in the range `0..Board.Size - 1`.
  - Any coordinate outside the board is invalid and must fail fast with an out-of-range error.

### Board
- Type: class
- Properties:
  - `Size`: `const int` — fixed at `8`.
  - `Squares`: `Player?[,]` — required.
- Validation rules:
  - `Squares` must represent an 8x8 grid.
  - `null` indicates an empty square.
  - Only `Black`, `White`, or `null` are valid square contents.
  - Board checks must be boundary-safe before indexing.
- Public API:
  - `IsInside(Position position) -> bool`: returns true when the coordinate is in range.
  - `GetSquare(Position position) -> Player?`: returns the occupant of a square, or `null` for empty.

### GameSnapshot
- Type: class
- Properties:
  - `Board`: `Board` — required.
  - `ActivePlayer`: `Player` — required.
- Validation rules:
  - `Board` must be a valid 8x8 board.
  - `ActivePlayer` must be `Black` or `White`.
  - The snapshot represents a single parsed game state, not a square coordinate.

### MoveFinder
- Type: static helper class or class with static method
- Public API:
  - `FindLegalMoves(Board board, Player activePlayer) -> IReadOnlySet<Position>`
- Validation rules:
  - Only empty squares are candidates.
  - A square is legal only if placing the active player flips at least one contiguous line of opponent discs and ends at an active disc.
  - The algorithm scans the eight directions: horizontal, vertical, and both diagonals in both directions.

### BoardParser
- Type: class
- Public API:
  - `Parse(IEnumerable<string> lines) -> GameSnapshot`
- Validation rules:
  - Input must contain exactly nine lines.
  - The first eight lines must each contain exactly eight characters.
  - Each character must be one of `.`, `B`, or `W`.
  - The final line must contain a single valid player marker (`B` or `W`).
  - Parsing fails with a clear error for malformed board dimensions or invalid values.

### BoardRenderer
- Type: class
- Public API:
  - `Render(GameSnapshot snapshot, IReadOnlySet<Position> legalMoves) -> IEnumerable<string>`
- Validation rules:
  - Existing board counters and empty positions are preserved.
  - Each legal move is rendered as `0`.
  - The final line repeats the active player marker.
  - The output matches the input board format, with the same 8x8 width and trailing active-player line.

---

## 2. File structure

```text
reversi-kata/
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

### File responsibilities
- `Program.cs`: reads input, calls parsing and move evaluation, and prints the rendered result.
- `Domain/Player.cs`: defines the `Player` enum.
- `Domain/Position.cs`: defines the board coordinate value object.
- `Domain/Board.cs`: owns the 8x8 board grid and boundary checks.
- `Domain/GameSnapshot.cs`: holds the parsed board and active player together.
- `Application/BoardParser.cs`: converts text input into a `GameSnapshot` and validates all rules.
- `Application/MoveFinder.cs`: determines all legal destination squares for a player.
- `Application/BoardRenderer.cs`: converts a board snapshot and legal moves into output rows.
- `tests/ReversiKata.Tests/BoardParserTests.cs`: verifies parsing and validation scenarios.
- `tests/ReversiKata.Tests/MoveFinderTests.cs`: verifies legal move detection across directions and edge cases.
- `tests/ReversiKata.Tests/BoardRendererTests.cs`: verifies board output and marker placement.

---

## 3. Module responsibilities

### Domain layer
Exports the pure game objects and their invariants.
- `Player` defines the two legal colors.
- `Position` is a value object for a single square coordinate.
- `Board` encapsulates the grid and all board-boundary logic.
- `GameSnapshot` captures a stable game state for parsing and rendering.

Dependencies:
- `Board` depends on `Position` and `Player`.
- `GameSnapshot` depends on `Board` and `Player`.
- No module in the domain layer depends on input parsing, rendering, or console code.

### Application layer
Exports the operations that transform the domain state.
- `BoardParser.Parse` creates a `GameSnapshot` from raw text.
- `MoveFinder.FindLegalMoves` evaluates legal moves for a given player.
- `BoardRenderer.Render` prints the board with legal moves marked as `0`.

Dependencies:
- `BoardParser` depends on `Board`, `GameSnapshot`, and `Player`.
- `MoveFinder` depends on `Board`, `Position`, and `Player`.
- `BoardRenderer` depends on `GameSnapshot`, `Position`, and `Board`.

### Entry point
- `Program` orchestrates the flow: read input, parse, search legal moves, render output, and write to standard output.
- `Program` depends on the application layer and not on test code.

---

## 4. Error handling strategy

### Input validation errors
Thrown by `BoardParser.Parse` when the input does not match the required format.
- `InvalidInputException` or equivalent custom exception
  - Triggered when row count is not 9.
  - Triggered when a row is not exactly 8 cells wide.
  - Triggered when a cell contains something other than `.`, `B`, or `W`.
  - Triggered when the final line is not a valid player symbol.

### Boundary and domain errors
Thrown when code attempts to work with coordinates or board cells outside the valid board range.
- `ArgumentOutOfRangeException`
  - Triggered when a `Position` is created outside the 8x8 board.
  - Triggered when a board lookup is performed for an invalid square.

### Design principle
- Validation failures should be explicit and deterministic.
- The parser should reject malformed input before move generation begins.
- Board access should never silently accept out-of-range coordinates.
- The design intentionally keeps errors local to the domain/application boundaries and avoids external dependencies or framework-specific error handling.
