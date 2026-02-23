# Week 8: Mad Libs (Structure + Debugging)

## Summary

Build a two-template **Mad Libs** console app.

This week focuses on **program structure** (breaking code into small methods, using a simple data model with public/private methods) and **debugging** (using breakpoints, stepping through code, and watching variables).

## Learning Objectives

- Decompose a program into small, focused methods
- Create and use a simple class (`StoryTemplate`) in a separate file
- Validate input using loops and `TryParse`
- Practice basic debugging (breakpoints, step over, watch variables)

---

## Resources

- [C# While and Do-While Loops](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement)
- [Debugging in Visual Studio Code](https://code.visualstudio.com/docs/editor/debugging)
- [string.Format](https://learn.microsoft.com/en-us/dotnet/api/system.string.format)

---

## Assignment Requirements

Update a console program that follows this flow:

1. **Print the two story template options**
    - Print these exact lines:
        - `1) Debugging at the Zoo`
        - `2) The Standup Meeting`

2. **Let the user choose a template (1–2)**
    - Prompt: `Choose a template (1-2): `
    - Validate using a loop (keep asking until the choice is 1 or 2)

3. **Prompt the user for the required words (non-empty)**
    - Each template has 8 prompts.
    - For each prompt:
        - Print the prompt
        - Read input
        - Use `Trim()`
        - If the result is empty, ask again

4. **Build and print the final story**
    - Use `template.GenerateStory(words)` to build the story
    - The `StoryTemplate` class should have a public `GenerateStory` method and a private `FormatStory` helper
    - The output must include the user’s words in the final story

5. **Ask to play again**
    - Prompt: `Play again? (y/n): `
    - If `y`, repeat the template selection + word prompts
    - If `n`, end the program

### Template Details (Exact Prompts)

**Template 1: Debugging at the Zoo**

1. `Enter an adjective: `
2. `Enter an animal (plural): `
3. `Enter a verb ending in -ing: `
4. `Enter a programming language: `
5. `Enter a debugging tool (example: breakpoint): `
6. `Enter a number: `
7. `Enter an emotion: `
8. `Enter an exclamation: `

**Template 2: The Standup Meeting**

1. `Enter a name: `
2. `Enter an adjective: `
3. `Enter a noun: `
4. `Enter a verb (past tense): `
5. `Enter a number: `
6. `Enter a plural noun: `
7. `Enter a type of bug (example: null reference): `
8. `Enter a snack: `

---

## Example Output

```
=== Mad Libs: Structure + Debugging ===

1) Debugging at the Zoo
2) The Standup Meeting
Choose a template (1-2): 1

[INFO] Collecting 8 words for: Debugging at the Zoo
Enter an adjective: silly
Enter an animal (plural): penguins
Enter a verb ending in -ing: dancing
Enter a programming language: C#
Enter a debugging tool (example: breakpoint): breakpoint
Enter a number: 3
Enter an emotion: proud
Enter an exclamation: woohoo

Today I visited the silly zoo. I saw penguins dancing while writing C#. I used a breakpoint 3 times until the bug disappeared. I felt proud and yelled, "woohoo!"

Play again? (y/n): n
```

---

## Getting Started

1. Navigate to the starter folder:

    ```bash
    # Mac/Linux:
    cd modules/week-08-mad-libs/starter

    # Windows:
    cd modules\week-08-mad-libs\starter
    ```

2. Review the TODO comments in `Program.cs`
3. Run your program:

    ```bash
    dotnet run
    ```

4. Test your work:

    ```bash
    # Mac/Linux:
    dotnet test ../tests

    # Windows:
    dotnet test ..\tests
    ```

---

## Grading Criteria

Your assignment will be automatically graded with tests that verify:

- Template selection and input validation loops
- Prompts match the required strings
- The final story includes user-provided words
- A working play-again loop
- STUDY_NOTES.md exists and is completed

---

## Helpful Tips / Common Pitfalls

- Use small methods like `ReadYesNo`, `ReadIntInRange`, and `ReadNonEmptyString`.
- Put your `StoryTemplate` class in a separate file (that is part of this week’s “structure” focus).
- The `StoryTemplate` class should have:
    - A public `GenerateStory(string[] words)` method (called by Main)
    - A private `FormatStory(string[] words)` helper (called internally)
    - This demonstrates **public** (external interface) vs **private** (internal implementation) methods
- If your story prints placeholders like `{0}`, your `string.Format` arguments are not being passed correctly.
- **Debugging practice**:
    - Set a breakpoint in `GenerateStory` or `FormatStory`
    - Press F5 to run with debugging
    - Use Step Over (F10) to watch the code execute line by line
    - Use the Variables panel to inspect `words`, `template`, and other values
    - Try setting a conditional breakpoint that only triggers when `words.Length != 8`
- **Logging utility**: The `Logger` class is available for informational messages (use `Logger.Info()` to demonstrate logging in `CollectWords`).

---

## Submission

1. Create a branch:

    ```bash
    git checkout main
    git pull origin main
    git checkout -b assignment/week-08
    ```

2. Commit and push your work:

    ```bash
    git add modules/week-08-mad-libs/starter/Program.cs
    git add modules/week-08-mad-libs/starter/StoryTemplate.cs
    git add modules/week-08-mad-libs/starter/STUDY_NOTES.md
    git commit -m "Complete Week 8: Mad Libs"
    git push -u origin assignment/week-08
    ```

3. Open a pull request in your GitHub repo:
    - Base branch: `main`
    - Title: `Week 8: Mad Libs (Structure + Debugging)`

4. Submit the pull request URL on Canvas.
