# Coding Dojo Meeting Notes

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

