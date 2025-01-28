# Coding Dojo Meeting Notes

## 2025-01-28
- Participants: Saeed, Tasneem, Richard, Nir
- We started working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY)
- We used this repository for this kata: https://github.com/emilybache/GildedRose-Refactoring-Kata/blob/main/GildedRoseRequirements.md
- We talked about the approach, first writing tests to cover all requirements, then refactoring the code, then implement the new requirement.
- Next week:
  - We will continue with Gilded Rose kata
    
## 2025-01-21
- Participants: Saeed, Mark, Tasneem, Richard, Nir
- We continued working on this kata: https://cyber-dojo.org/kata/edit/bu88YG
- We found it challenging to come up with small steps to take us to the right solution. We mostly tried to solve it with algorithm challenge approach. We tried ChatGPT and its given solution was similar to what we discussed but failed to compile.
- Next session:
  - We will try a new kata
    
## 2025-01-14
- Participants: Saeed, Mark, Tasneem
- We worked on this kata: https://cyber-dojo.org/kata/edit/bu88YG
- Tests passed after using string sort but failed after we added new test cases from Readme
- The problem we are dealing with now is [5, 50] returns 505 instead of 550. We think by writing a custom comparer, and padding the last digit of smaller numbers with the same first digit and size of the lengthier number we can fix this copare issue.
- Next session:
  - We will decide to either continue with this kata or start a new one, depends on if a new member joins us

## 2025-01-07
- Participants: Saeed, Mark, Tasneem, Richard
- We worked on this kata: https://cyber-dojo.org/kata/edit/bu88YG
- Tasneem suggested to review our tests, to find out if we could choose better tests that would have led us to the right path
- Next session:
  - Discussing what we could do better to stay in right path when following TDD rules
  - Continue this session's kata
    
## 2024-12-17
- Participants: Saeed, Mark, Tasneem, Richard
- We talked about how Coding Dojo meetings are run
- We reviewed the [three rules of TDD by Robert Martin](https://jhall.io/archive/2021/03/01/the-3-rules-of-tdd-plus-bonus-rule/https://jhall.io/archive/2021/03/01/the-3-rules-of-tdd-plus-bonus-rule/)
- We worked on [FizzBuzz](https://cyber-dojo.org/kata/edit/ub1Kvs) kata to demo TDD and our meeting structure to Richard
- Next session:
  - If Richard or any other new members join us we will choose a simpla kata
  - Otherwise we will continue with Game Of Life kata

## 2024-12-10
- Participants: Saeed, Mark, Tasneem
- We continued with [Game of Life](https://cyber-dojo.org/kata/edit/fd0u7Y) kata
- We read about arrays in C#. We realized jagged array, which we used in our code, is not the best choice for this kata mainly because wedon't need rows of different lengths. If we are going to redo this kata it's better to go with multidimensional array.
- __Jagged Arrays__
   - __Variable Row Lengths:__ Use jagged arrays when you need rows of different lengths. For example, if you are storing data where each row can have a different number of elements, a jagged array is more efficient.
   - __Memory Efficiency:__ They can be more memory-efficient if the data structure is sparse or if rows vary significantly in size.
   - __Flexibility:__ Jagged arrays offer more flexibility in terms of structure since each row is an independent array.
- __Multidimensional Arrays__
   - __Fixed Size:__ Use multidimensional arrays when you need a grid-like structure with a fixed number of rows and columns. This is useful for matrices, game boards, or any scenario where the data structure is uniform.
   - __Performance:__ They can offer better performance for certain operations due to their contiguous memory allocation, which can improve cache performance.
   - __Simplicity:__ They are simpler to declare and use when the structure is uniform, making the code easier to read and maintain.

- Next session:
  - We need to fix the failing test, by supporting more than 2 rows.
  - Discuss how to refactor GetAdjacentCells
  - Watch video of TDD solution for this kata, or Mars Rover kata

## 2024-11-26
- Participants: Saeed, Mark, Tasneem
- We continued with [Game of Life](https://cyber-dojo.org/kata/edit/fd0u7Y) kata
- We spent most of our time trying to fix the issues related to two dimensional array
- We talked about how to implement GetAdjacentCells method for multi rows grid. We talked about either doing it in one shot or splitting it to top, bottom, and current rows.
- Next session
  - Start with reviewing multi dimensional array in .NET (read a document or watch a video)
  - Change i and j to col and row in GetAdjacentCells

## 2024-11-19
- Participants: Saeed, Mark, Tasneem
- We continued with [Game of Life](https://cyber-dojo.org/kata/edit/fd0u7Y) kata
- we talked about watching a video of other people's approach to solve this kata in TDD (after we are done with it).
- Next session
  - Discuss how to modify GetAdjacentCells, to support the second row of the grid, incrementally
  - We are red now, first we need to go to green, which will cover the implementation of the second rule
  
## 2024-11-12
- Participants: Saeed, Mark, Tasneem
- We continued with [Game of Life](https://cyber-dojo.org/kata/edit/fd0u7Y) kata
- Next session
    - Test situation where at least one Cell survives.
    - Test Single row with all live cells.
    - Expand to two rows for testing, implementation.
    - Consider our previous approach and look for options to stay more in line with TDD.
  
## 2024-11-05
- Participants: Saeed, Mark, Tasneem
- We continued with [Game of Life](https://cyber-dojo.org/kata/edit/fd0u7Y) kata
- Next session
  - We will try to build rules one at a time.
  - We can create a method to return all adjacent cells in a string, then based on the number of live cells create the output
  - We can go incrementaly by working on the adjacent cells of one row

## 2024-10-29
- Participants: Saeed, Mark, Tasneem
- We started working on a new kata: [Game of Life](https://cyber-dojo.org/kata/edit/fd0u7Y)
- Next session:
  - Try a 3 by 3 grid
  - Go incerementally, start with all dead cells, then only one alive cell and so on
    
## 2024-10-22
- Participants: Saeed, Mark, Tasneem
- We conducted a Coding Dojo orientation for the new member of our team, Tasneem
- We practiced TDD using the FizzBuzz kata
  
## 2024-10-01
- Participants: Saeed, Joel
- We continued compared last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
  with a fork of what GPT created, where we added some todo comments: [Fork](https://cyber-dojo.org/kata/edit/h4AcpH)
- Next session:
  - See TODO comment(s), especially in the fork, i.e., [Fork](https://cyber-dojo.org/kata/edit/h4AcpH)
  - Consider whether we want to continue with this kata, or do something new.
  
## 2024-09-24
- Participants: Saeed, Joel, Mark
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Tests are passing for cases through XXX thousand; not yet testing millions, etc.
- We moved many methods to a static Triplets class
- Next session:
  - See TODO comment(s)
  - Consider whether we want to continue with this kata, or do something new.

## 2024-09-17
- Participants: Saeed, Joel
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Tests are passing for cases through XX thousand; not yet testing XXX thousand or millions, etc.
- We renamed readme.txt as docs.readme.txt, so it sorts to the bottom of the file list, and when
  the navigator and driver switch roles, the driver sees the desired code file right away.
- Next session:
  - See TODO comment(s)
  - See 2024-09-10 notes about GetTriplets function (review code, etc.)

## 2024-09-10
- Participants: Saeed, Joel
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- We introduced the idea of triplets, i.e., 3-digit chunks. (We used GPT to generate the GetTriplets function for us.)
- We also learned that cyber-dojo uses Mono rather than .NET Core (and an older version of Mono), so we think the switch
  expression syntax won't work (so we have to use the switch statement instead).
- Next session:
  - Get failing test to pass: [TestCase(2000, "two thousand")]
  - Rename GetNameOfTriplet as GetNameOfElementOfTriplet or similar
  - Extract inner loop that gets the name of the entire triplet
  - Move triplet index variable into for loop (instead of separate variable outside foreach)
  - Ask GPT if we can simplify and make more readable the GetTriplets function. (Or at least we should read and try to understand
    the code better, even if all tests are passing.)

## 2024-09-03
- Participants: Saeed, Mark, Joel
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- We talked about whether we want to use a logic in GetSpacer that covers the future positions, such as hundred thousands
- Next session:
  - Considering using const instead of enum to avoid the need for casting
  - Add millions to test
  - Maybe checking on how to use dotnet core in cyber-dojo, as we realized new syntax for switch is not accepted
    
## 2024-08-20
- Participants: Nir, Mark, Joel
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Next session:
  - Refactoring:
    - Rename all pos variables to position
    - Use switch instead of if in GetName
    - Consider an enum for values of position Ones=0, Tens=1, Hundreds=2
  - More test cases:
    - Thousands
    - Millions

## 2024-08-13
- Participants: Nir, Saeed, Mark, Joel
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Next session:
  - Introduce a new methos, GetSpacer, to return the spacer based on the position and take that responsibility out of GetName
  - Introduce a new method to exttact the code we have in Ones, Tens,... then we will be ready to add the loop
## 2024-08-06
- Participants: Nir, Saeed, Mark, Joel
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Nir believes that use of TDD helped us to stay focused on smaller issues and move faster
- Next session:
  - Focus on replacing the redundant code with call of GetName method
## 2024-07-30
- Participants: Nir, Saeed, Marc
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- We tried loop which seems to be the right way to go. However, we agreed that was a big changes and we have to step back and build the logic for first three positions before jumping to loop solution. We decided to make the existing tests work without loop then during refactoring change the logic to use loop.
- We ended in RED with index out of bound error.
- Next session:
  - We will need to fix the index out of bound error first, maybe by focusing on tens tests first. And check for the length of the string before processing the next positions.
    
## 2024-07-16
- Participants: Nir, Saeed, Mark
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Next session:
   - a long term solution for spacer
     - Mark suggested that starting from ones going up could be a solution to check if the result is an empty string before adding a spacer

## 2024-07-09
- Participants: Nir, Saeed, Mark
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Next session:
   - We are going to brain storm on the algorithm, continue with our conversation about using position
   - We agreed to convert the received number to string and reverse it to get the positions right
   - We decided to focus on the first 3 positions (ones, tens, hundreds)
   - So far this is what we think would be the way to go:
    ```
     423 = [4,2,3] ==revers==> [3,2,4]
     - pos 0: 3 = three
     - pos 1: 2*10 = twenty  
     - pos 2: 4 four + hundred

## 2024-06-25
- Participants: Nir, Saeed, Mark
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- We tried to find an algorithm that covers the larger numbers without making the dictionary gets too large or introduce new variables for every positions of digits
- Next session we will continue with Number Names kata and try to find the answers.

## 2024-06-18
- Participants: Nir, Saeed
- We continued working on the previous session's exercise: [Fizz Buzz Plus](https://cyber-dojo.org/kata/edit/fRZ2ZZ)
- We started a new kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Next session we will continue with Number Names kata.

## 2024-06-11
- Participants: Nir , Mark P, Saeed
- We decided to work on a new exercise: [Fizz Buzz Plus](https://cyber-dojo.org/kata/edit/fRZ2ZZ)
- We didn't finish it but we got close
- What went well:
  - Nir is happy with the experience. He sees a benefit in explaining what he is thinking about to the driver. To him this is similar to when you teach some one and you learn from it yourself.
  - Mark pointed out how following TDD incremental steps helps to avoid complex code.
- Next session we will decide to finish this exercise, start a new one, or continue the one from past session.

## 2024-06-04
- Participants: Marc L, Mark P, Saeed
- What went well:
  - Helping with learning C# syntax
  - Good use of Test Cases to make unit tests cleaner
- Suggestions:
  - Starting with a discussion on what we want to do in more detail
  - Start the session as long as at least two people joined
- Next session we will continue with LCD Digit kata to refactor it

## 2024-05-28
- Participants: Marc L, Mark P, Ning, Saeed
- We worked on this kata LCD Digits: https://cyber-dojo.org/kata/edit/1uvVdJ
- We agreed to leave time at the end of the sessions for retrospective (5 mins)
- We decided to continue the same kata next week, and focus on refactoring it

