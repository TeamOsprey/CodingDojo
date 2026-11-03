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
   - [x] Chunk 1: Render the board rows in the input format.
      - Acceptance criteria: Existing board counters and empty squares remain unchanged.
   - [x] Chunk 2: Mark every legal move in the rendered board.
      - Acceptance criteria: Legal moves are written as `0`.
   - [x] Chunk 3: Include the active player marker in the output.
      - Acceptance criteria: The final output line repeats the active player marker.
   - [x] Chunk 4: Match the example output from the requirements.
      - Acceptance criteria: The board from the requirements produces the four marked Black moves in the example output.

4. As a kata participant, I can evolve the rule implementation with confidence.
   - [x] Chunk 1: Test the example position.
      - Acceptance criteria: Tests verify the four legal Black moves shown in the requirements example.
   - [x] Chunk 2: Test captures in every direction.
      - Acceptance criteria: Tests cover all eight directions.
   - [x] Chunk 3: Test board bounds and positions with no capture.
      - Acceptance criteria: Tests cover edge and corner bounds and empty squares with no capture.
   - [ ] Chunk 4: Test capture of multiple contiguous opponent counters.
      - Acceptance criteria: A move is marked legal when it brackets two or more contiguous opponent counters in one direction.
   - [ ] Chunk 5: Test moves that capture along multiple directions.
      - Acceptance criteria: Tests cover positions where one move captures along multiple directions.
   - Acceptance criteria: Production code has no external package dependencies.