# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Ujwal Garine

## Program Structure

**What helper methods did you create (and what does each one do)?**

Answer:
- CollectWords collects user input into an array.
- ReadNonEmptyString ensures input is not empty.
- ReadYesNo validates yes or no input.
- ReadIntInRange validates numeric range input.
- GenerateStory replaces placeholders and prints the story.

**Why is it helpful to move code out of `Main` and into helper methods?**

Answer:
It keeps Main clean and easier to read. Each method has one clear job, which makes debugging and testing easier.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**

Answer:
The StoryTemplate class stores the story text and the prompts. It separates data from logic.

**How did using a template make it easier to support two different stories?**

Answer:
The same logic works for both stories. Only the template data changes.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program?**

Answer:
I set a breakpoint at the start of CollectWords and inside ReadYesNo.

**What did you learn from stepping through your code line by line?**

Answer:
I saw how input was stored and how the loop processed each prompt step by step.

**What bug or logic mistake did you encounter and how did you fix it?**

Answer:
Empty input was accepted at first. I fixed it by trimming input and looping until valid text was entered.

## What I Learned

**Key takeaways from this week:**

1\. Methods improve structure.
2\. Validation prevents errors.
3\. Debugging improves understanding.

**What part of this assignment helped you understand program structure the most?**

Answer:
Breaking the program into smaller helper methods helped the most.

## Time Spent

**Total time:** 5

**Breakdown:**
- Planning structure: 1 hour
- Input validation: 1 hour
- Story templates: 1 hour
- Testing and debugging: 1.5 hours
- Writing documentation: 0.5 hours

**Most time-consuming part:**

Answer:
Testing and debugging took the longest because I had to carefully verify input handling.

## Reflection

**What would you improve if you had more time?**

Answer:
I would add more templates and stronger input validation.

**How did breaking your program into smaller parts help you debug?**

Answer:
It allowed me to isolate issues quickly instead of searching through the entire file.
