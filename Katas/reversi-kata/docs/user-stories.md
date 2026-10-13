# Reversi Legal Moves User Stories


1. [x] As a kata participant, I can provide an 8x8 board and an active player so the program can evaluate a position.
   - Acceptance criteria: The input consists of eight rows containing `.`, `B`, or `W`, followed by a ninth line containing `B` or `W`.
   - Acceptance criteria: Invalid row counts, row widths, square values, or player markers produce a clear error rather than an incorrect result.

2. [x] As a player, I can see every legal move for the active colour.
   - [x] Chunk 1: Find legal moves that capture horizontally.
       - Acceptance criteria: A move is legal only on an empty square where placing the active colour encloses one or more contiguous opponent counters between the new counter and an existing active counter to the left or right.
   - [x] Chunk 2: Extend legal-move detection to vertical captures.
       - Acceptance criteria: The evaluator detects captures upward and downward using the same enclosure rule, while retaining horizontal detection.
   - [x] Chunk 3: Extend legal-move detection to diagonal captures.
       - Acceptance criteria: The evaluator detects captures along all four diagonal directions using the same enclosure rule, while retaining horizontal and vertical detection.

3. As a player, I receive output in the same board format as the input.
   - Acceptance criteria: Legal moves are written as `0`; existing board counters and empty squares remain unchanged.
   - Acceptance criteria: The final output line repeats the active player marker.
   - Acceptance criteria: The board from the requirements produces the four marked Black moves in the example output.

4. As a kata participant, I can evolve the rule implementation with confidence.
   - Acceptance criteria: Tests cover the example, all eight directions, edge and corner bounds, empty squares with no capture, and positions where one move captures along multiple directions.
   - Acceptance criteria: Production code has no external package dependencies.