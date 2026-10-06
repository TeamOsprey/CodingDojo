# Project Instructions

## Testing

- Use NUnit for all tests.
- Keep tests readable by expressing expected data explicitly instead of generating it from the input under test.
- Assert against the resulting domain state, with expected values independent of the input and implementation.
- Represent structured test data, such as a board, in a visual, human-readable form.
- Cover relevant edge cases for each user story.
- When comparing a result with an expected value, name the result variable with `actual` (for example, `actualSnapshot`).