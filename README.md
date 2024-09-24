# Coding Dojo Meeting Notes

## 2024-09-24
- Participants: Saeed, Joel, Mark
- We continued with last session's kata: [Number Names](https://cyber-dojo.org/kata/edit/7mlMzJ)
- Tests are passing for cases through XXX thousand; not yet testing millions, etc.
- We moved many methods to a static Triplets class
- Next session:
  - See TODO comment(s)

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

