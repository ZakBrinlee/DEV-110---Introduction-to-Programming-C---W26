# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Cleciane Oliveira Silva

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: ChooseTemplate() - shows the two template options, asks the user to choose 1 or 2, validates user input using readintingange and returns whichever template the user has chosen.
CollectWords(StoryTemplate template) – asks the user to enter the words for the selected template, validates it, stores it in an array and returns a complete array.
ReadYesNo(string prompt) – asks the user to answear yes or no, making sure the input is y or n.
ReadIntInRange(string prompt, int min, int max) – asks the user for a number and then uses int.TryParse to make sure that the input is a valid number within the range 1-2.
ReadNonEmptyString(string prompt) – aks the user for text, then trims the input, and repeats the prompt until they enter a no empty value.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: It avoids having to write over and over the same methods or commands. Helper methods can be easily called anytime and make the code easier to read, debug and adjust.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: To represent Mad Libs story template, storing its title, as well as the template text containing placeholders that will be replaced with the user's inputs.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: becase the same program logic can work with different prompts and words, creating unique stories, but keeping the structure to make the story make sense.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I set a breakpoint at the beginning, at collectwords method, allowing me to pause the program anytime the word collection started, so i could inspect the template, checking if template.prompts had the right prompts.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: it helped me to understand how the program works and how data flows from method to method, it also helped me to see if the right template and prompts were being used and that the values were passed correctly to GenerateStory.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: the story was not formating correctly because the string.Format was not receiving the right type of arguments. First I tried to pass the string[] words, but it caused the placeholders not work correctly. I ended up fixing it by converting the string[] into an object[] before calling string.Format.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. helper methods make the code easier to read and change when needed
2. classes are very helful to organize data and behavior
3. debugging tools help to understand how a program runs

**What part of this assignment helped you understand program structure the most?**
Breaking into methods, using public/private methods, separating concerns, etc.

Answer: certainly breaking it into methods.

## Time Spent

**Total time:** [8 hours]

**Breakdown:**

- Planning structure (methods/classes): [3 hours]
- Input validation: [1 hours]
- Story templates + formatting: [2 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: planning structure of methods and classes because the logic part usually takes me longes to get done, I have the need to understand the structure, even if partial, of what i am about to build, somehow it has to make sense in my head first.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: i would add more forms of validating data. i feel like the way it is right now, there are still inputs that would make the stories non sense.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: It was easier to find out exacly what was wrong and even easier to locate the issue and work on it. I didn't have to spend time looking throught the whole code to guess what was making the program crash.
