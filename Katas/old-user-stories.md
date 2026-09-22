# Reversi Legal Moves Kata - User Stories

1. **Identify legal moves for Black**

   As a Reversi player, I want the program to mark every legal Black move on the supplied board so that I can see where Black may play.

   Acceptance criteria:
   - The program reads eight board rows and a final `B` player line.
   - An empty square is marked `0` when at least one direction contains one or more contiguous White counters followed by a Black counter.
   - Existing `B`, `W`, and non-legal `.` squares are unchanged.
   - The supplied example returns the four expected legal positions.

2. **Identify legal moves for White**

   As a Reversi player, I want the same calculation to work for White so that move discovery is independent of which color is active.

   Acceptance criteria:
   - A final `W` player line selects White as the active player.
   - The evaluator treats Black as the opponent.
   - Horizontal, vertical, and diagonal bracketed lines are recognized.
   - The output preserves the `W` player line.

3. **Reject non-bracketing moves**

   As a player, I want only valid Reversi moves marked so that empty squares without a capturable line are not presented as options.

   Acceptance criteria:
   - An empty square with no adjacent opponent counter is not marked.
   - A run of opponent counters that reaches the board edge without an active-player counter is not marked.
   - A run of opponent counters followed by an empty square is not marked.
   - Occupied squares are never marked.

4. **Handle board edges and corners**

   As a player, I want moves near corners and edges evaluated correctly so that the board boundary does not create false moves or omit valid ones.

   Acceptance criteria:
   - All eight directions are checked where they remain inside the 8x8 board.
   - Out-of-bounds positions terminate a directional scan safely.
   - Valid bracketed lines ending at a corner or edge are recognized.

5. **Validate the input position**

   As a user, I want malformed input to produce a clear error so that I can correct the board instead of receiving misleading move results.

   Acceptance criteria:
   - The input contains exactly eight board rows of eight characters each.
   - Only `.`, `B`, and `W` are accepted in board rows.
   - The active player is exactly `B` or `W`.
   - Invalid input does not produce a normal move board.

6. **Use the move evaluator independently**

   As a developer, I want move calculation separated from console I/O so that the rules can be tested with small board fixtures.

   Acceptance criteria:
   - The evaluator accepts a board and active player as inputs.
   - The evaluator returns legal positions or a marked board without depending on console input/output.
   - Tests cover the supplied example, both colors, all direction families, and invalid non-moves.
   - The application builds on .NET 10 without external dependencies.
