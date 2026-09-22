# Reversi Legal Moves User Stories


1. [x] As a kata participant, I can provide an 8x8 board and an active player so the program can evaluate a position.
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