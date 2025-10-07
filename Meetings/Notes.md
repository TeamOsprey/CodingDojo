# Coding Dojo Meeting Notes

## 2025-10-07
- Participants: Saeed, Tasneem, Mark, Joel
- We continued with Strangler Pattern: https://cyber-dojo.org/kata/edit/JjWSJd
- We ended in Green. We think for the next session we will start with renaming and polishing Count method in YahtzeeNew class.
  
## 2025-09-23
- Participants: Saeed, Tasneem, Mark, Joel, Richard
- We started working on refactoring Yahtzee, using Strangler Pattern
- Mark brought this up that to follow the Strangler Pattern we need to build the facade first and update the code to use Facade class for all methods
- We need to find a way to stay on track to keep the tests updated, making sure they are using the facade class
  
## 2025-09-16
- Participants: Saeed, Tasneem, Mark, Joel
- We completed refactoring of Gilded Rose kata
- We compared our solution with Emily Bache's and the main difference seems to be that Item was set as an abtract while we created a new interface called IProduct.
- We talked about default accessibility level in C#
- Next week:
  - We will choose a new challenge to work on
  - Tasneem suggested working on once of challenges in leetcode 

## 2025-09-09
- Participants: Saeed, Tasneem, Mark, Richard, Joel
- We continued with refacroring and following factory design pattern.
- We ended in red which seems to be related to original Items list not being updated.
- We talked about Strangler Pattern and how we could have followed that to stay in green while refactoring the code to implement Factory Pattern.
  
## 2025-09-02
- Participants: Saeed, Tasneem, Mark
- We worked on refacroring and following factory design pattern.
- We ended the session with a bug caused by the changes we made to Item class. Next week we will start by looking into this issue.

## 2025-08-05
- Participants: Saeed, Tasneem, Richard
- We finishded lifting up all conditions.
- Next session: we will continue with refactoring the code to move the logic to seperate classes for each item type.
  
## 2025-07-29
- Participants: Saeed, Tasneem, Richard
- We watched Emily Bache's vido (link under 2025-06-17) and found our mistake
- We started from the original code again and lifted two conditions
- We left the code at the phase where clean ups need to be done based on the result of the code coverage tool
  
## 2025-07-15
- Participants: Saeed, Tasneem, Mark, Richard
- We reviewed the article from our previous session and identified a key insight: the importance of selecting a condition that can be isolated.
- We extracted one such condition and refactored the code accordingly. However, we're still uncertain about the next steps. To gain further clarity, we’ve decided to rewatch Emily Bache’s video for guidance.
  
## 2025-06-24
- Participants: Saeed, Tasneem, Mark, Richard
- We watched the lift up condition section of Emily Bache video and tried to follow the same method during our practice.
- We ran into an issue which seems to be related to picking the wrong condition to lift up.
- The condition we selected was "Quality < 50" and since Quality changes within the code, lifting up this condition broke the code.
- Next session:
  - We need to discuss and research on how to choose the right condition to lift up 
  - Mark shared [this link](https://sammancoaching.org/learning_hours/refactoring/lift_up_conditional.html) which might have the answer.
    
## 2025-06-17
- Participants: Saeed, Tasneem, Mark
- We started working on Gilded Rose kata, this time with Approval Test.
- Next session
  - We can start by watching Emily Bache's explanation of [lift up conditional](https://youtu.be/OdnV8hc9L7I?si=yp-q0WSZ3OUmZA9a&t=814) method for refactoring.
## 2025-06-10
- Participants: Saeed, Tasneem, Mark
- We started working on Gilded Rose kata, this time with Approval Test.
- Most of our time was spent on configuring and understanding the new method of collaborative development, using VS' Live, and FCC tools, and also figuring out how to use Approval Test.
- Next session:
  - We will continue the exercise and will try Emily Bache's method of elevating the if condition
  - We also agreed to watch Emily Bache's video about Kent Beck's Desiderata
    
## 2025-05-13
- Participants: Saeed, Tasneem, Mark
- We watched Gilded Rose Kata video and discussed Approval Test: https://youtu.be/vMww6pV6P7s
- We decided to try Approval Test next week and found a free Test Coverage tool to use: Free Code Coverage
- If we will be able to configure our visual studios by next week, we can do a kata on Approval Test
  
## 2025-04-08
- Participants: Saeed, Tasneem
- Continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY), and added Conjured item.
- We discussed the posibility of removing IProduct and moving the logic to Item. That way the subclasses will implement Item, instead of IProduct.
- We talked about Approval Testing and finding a way to try it in one of our future sessions.
- Next session:
  - We will start a new kata
    
## 2025-04-08
- Participants: Saeed, Tasneem, Mark
- Continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY), and finished refactoring.
- Next session:
  - Add a subclass for Conjured item
  - Discuss a posibility for more refactoring (maybe redusing the number of classes)
  - Watch Gilded Rose kata's video by Emily Bache
 
## 2025-04-01
- Participants: Saeed, Tasneem, Mark
- Continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY), and added more subclasses.
- Next session:
  - We might add a new factory class that create an instance of a subclass based on the name of the item then returns an IProduct object
  - We can create UpdateQuality in IProduct and move the calls to the three methods into it
    
## 2025-03-25
- Participants: Saeed, Tasneem, Nir
- Continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY), and strted adding subclasses.
- We had some challenges defining and using an abstract calss in C#
- We added IProduct abstract class and AgedBrie subclass
- Next session:
  - We should start with fixing the failing unit tests
  - We should implement the rest of subclasses
    
## 2025-03-11
- Participants: Saeed, Tasneem, Mark, Nir
- Continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY), and cleaned up the main class.The main method (UpdateQuality) is now free of any if clauses.
- We also cleaned up DecreaseQuality method, preparing it for polymorphism by making it ready to be overridden in subclasses.
- Next session
  - Apply a similar approach to the IncreaseQuality method, preparing it for extraction and overriding in new subclasses. 

## 2025-02-25
- Participants: Saeed, Tasneem, Mark, Richard
- Continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY), identified missing edge cases, and addressed false positives in tests.
- Made improvements to the main class and added more test cases.
- Next session
  - Mark suggested flipping the first condition to check when to increase the quality instead of decreasing it.
  - Consider pushing the conditions for SellIn < 0 and Aged Brie to the DecreaseQuality method.
    
## 2025-02-18
- Participants: Saeed, Tasneem, Nir
- We continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY)
- Did more refactoring on the main class.
- Now the challenge is how to move the SellIn < 0 condition to private methods without breaking the rule for double decrease of quality after SellIn < 0.
- Next session:
   - We reverted to the last green and we are going to continue with simplifying the conditions.
   - Tasneem suggested that in the decrease quality method, we can consider double decrease for SellIn < 0.
    
## 2025-02-11
- Participants: Saeed, Tasneem, Nir
- We continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY)
- We refactored the unit tests, now we have only one with all the test cases.
- We refactored the main class and moved several conditions to private methods.
- Next session
  - We will continue with this kata.
  - We try to clean up the conditions more and move more of them to the private methods
  - We thought IncreaseQuality and DecreaseQuality can eventually become one method

## 2025-02-04
- Participants: Saeed, Tasneem, Mark
- We continued working on [Gilded Rose](https://cyber-dojo.org/kata/edit/ZY7fJY)
- We refactored the unit tests and made a one to one mapping of test cases with the requirements
- Next session
  - We can refactor unoit tests, moving all Quality test cases to the first test, and include SellIns
  - Revisiting our approach. Shall we continue with implementing new methods based on the rules, or simplify the conditions step by step
  - Rename methods to verb instead of noun
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

