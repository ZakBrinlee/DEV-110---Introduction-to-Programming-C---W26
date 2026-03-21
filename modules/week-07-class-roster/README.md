# Week 7: Class Roster Builder (Arrays)

## Summary

Build a menu-driven “Class Roster Builder” console app that stores student data using **parallel arrays**.

You will add multiple students at a time, print the roster, and print a sorted version.

## Learning Objectives

- Store related data using **parallel arrays**
- Use a `count` variable to track how many array slots are “in use”
- Use a `for` loop to read multiple values into arrays
- Use a `foreach` loop to print roster lines
- Sort arrays using `Array.Sort` while keeping data aligned
- Validate input using `int.TryParse`

---

## Resources

- [C# Arrays](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
- [Iteration Statements (for / while)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements)
- [Array.Sort Method](https://learn.microsoft.com/en-us/dotnet/api/system.array.sort)

---

## Assignment Requirements

Update a console program that follows this flow:

1. **Create your parallel arrays and count**
    - Use a fixed capacity of **3**
    - Create:
        - `string[] rosterNames`
        - `int[] rosterCredits`
    - Create an `int count` and set it to `0`

2. **Create the menu loop**
    - Repeat until the user chooses option 4 (Exit)
    - Print this menu each time:
        - `1) Add multiple students`
        - `2) Print class roster`
        - `3) Print roster (sorted)`
        - `4) Exit`
    - Use this exact prompt:
        - `Choose an option: `

3. **Option 1: Add multiple students**

    If the roster is full (`count == 3`), print:
    - `Roster is full. Cannot add more students.`

    Otherwise:
    - Calculate `remainingSlots = 3 - count`
    - Prompt:
        - `How many students do you want to add? (1-X): `
        - (Where `X` is the number of remaining slots)
    - Use a `for` loop to read each student:
        - Prompt for name: `Enter name for student 1: ` (then 2, then 3)
        - Prompt for credits: `Enter credits for NAME (0-200): `
    - After adding, print:
        - `Students added.`

4. **Option 2: Print class roster**

    If `count == 0`, print:
    - `Roster is empty.`

    Otherwise:
    - Print header: `Class Roster:`
    - Print each student using a `foreach` loop
    - Each line must include both name and credits (example format is up to you)

5. **Option 3: Print roster (sorted)**

    If `count == 0`, print:
    - `Roster is empty.`

    Otherwise:
    - Print:
        - `Sort by:`
        - `1) Name`
        - `2) Credits`
    - Use this exact prompt:
        - `Choose an option: `
    - Copy only the used part of the roster into new arrays, then sort:
        - By name: `Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase)`
        - By credits: `Array.Sort(sortedCredits, sortedNames)`
    - Print header: `Class Roster (Sorted):`
    - Print each line using a `foreach` loop

6. **Option 4: Exit**
    - Print: `Goodbye.`

---

## Example Output

Your output does not need to match spacing exactly, but your **prompt text and required messages must match**.

```
=== Class Roster ===
1) Add multiple students
2) Print class roster
3) Print roster (sorted)
4) Exit
Choose an option: 2

Roster is empty.

=== Class Roster ===
1) Add multiple students
2) Print class roster
3) Print roster (sorted)
4) Exit
Choose an option: 1

How many students do you want to add? (1-3): 2

Enter name for student 1: Ada
Enter credits for Ada (0-200): 12
Enter name for student 2: Alan
Enter credits for Alan (0-200): 45
Students added.

=== Class Roster ===
1) Add multiple students
2) Print class roster
3) Print roster (sorted)
4) Exit
Choose an option: 2

Class Roster:
Ada - 12 credits
Alan - 45 credits

=== Class Roster ===
1) Add multiple students
2) Print class roster
3) Print roster (sorted)
4) Exit
Choose an option: 4

Goodbye.
```

---

## Getting Started

1. Navigate to the starter folder:

    ```bash
    # Mac/Linux:
    cd modules/week-07-class-roster/starter

    # Windows:
    cd modules\week-07-class-roster\starter
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

- Menu repeats and exit works
- “Roster is empty.” message appears when appropriate
- Adding multiple students stores **name + credits** correctly
- Capacity of 3 is enforced
- Sorting by name and sorting by credits work and keep names/credits aligned
- `STUDY_NOTES.md` exists (and may be checked for completion)

---

## Helpful Tips / Common Pitfalls

- Always loop from `0` to `count - 1` when printing.
- For sorting, copy only the used data into new arrays (size = `count`).
- Use the `Array.Sort` overloads that keep two arrays aligned.
- Keep your prompt strings exactly as written.

---

## Submission

1. Create a branch:
    - `assignment/week-07`
2. Commit and push your changes.
3. Open a Pull Request (PR) into `main`.
4. Submit your PR link in Canvas.
