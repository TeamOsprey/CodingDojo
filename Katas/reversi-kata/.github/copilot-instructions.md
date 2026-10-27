# Project Instructions

## Testing

- Use NUnit for all tests.
- Keep tests readable by expressing expected data explicitly instead of generating it from the input under test.
- Assert against the resulting domain state, with expected values independent of the input and implementation.
- Represent structured test data, such as a board, in a visual, human-readable form.
- For all future board-based tests, define input as an explicit string array containing eight board rows followed by the active player marker, and create the `GameSnapshot` with `BoardParser.Parse`.
- Define expected boards as separate, explicit eight-row string arrays using `.`, `B`, and `W`, with `0` marking every expected legal move. Do not derive expected rows from the input or actual results.
- Compare `snapshot.Board.ToString()` with the expected rows for plain boards. For legal moves, call `MoveFinder.FindLegalMoves(snapshot.Board, snapshot.ActivePlayer)` and compare `snapshot.Board.ToString(actualMoves)` with the expected rows using `Is.EqualTo`.
- Let `Board.ToString(legalMoves)` add the `0` markers; do not duplicate rendering logic, construct expected boards with builders, or use coordinate lists as expected board results.
- Keep direct API tests for validation, constructors, and boundary behavior when parsing a valid snapshot is not the behavior under test.
- Cover relevant edge cases for each user story.
- When comparing a result with an expected value, name the result variable with `actual` (for example, `actualSnapshot`).