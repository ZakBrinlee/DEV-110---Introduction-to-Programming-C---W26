# Week 9: Score Stats (Methods + LINQ)

## Summary

Build a small console app that analyzes a set of test scores.

This week focuses on **methods** (breaking a program into small helpers) and **LINQ** (quick stats like Min/Max/Average/Count).

## Learning Objectives

- Break a program into small, focused methods
- Use wrapper methods to coordinate a workflow
- Parse and validate user input with loops and `TryParse`
- Use a small class to organize score analysis
- Use LINQ to calculate statistics and build simple reports
- Format numeric output to match requirements

---

## Resources

- [LINQ (Language Integrated Query)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
- [Enumerable.Min](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min)
- [Enumerable.Max](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max)
- [Enumerable.Average](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average)
- [Enumerable.Count](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count)

---

## Assignment Requirements

Complete the `ScoreReport` class by implementing LINQ-based methods that each handle a specific part of the report.

1. **Read scores from the user (CSV input)** _(provided in starter)_
    - Prompt: `Enter scores (comma-separated 0-100): `
    - The user enters a comma-separated list like: `10, 20, 30`
    - Each score must be an integer from 0 to 100 (inclusive)
    - If _any_ value is invalid, re-prompt for the entire line

2. **Read a passing threshold (0–100)** _(provided in starter)_
    - Prompt: `Enter passing threshold (0-100): `
    - Re-prompt until the value is in range

3. **Implement report methods in ScoreReport class** _(your work)_

    You will implement 7 methods that use LINQ to analyze and print score data:
    - **PrintReport()** - Orchestrates calling all other print methods
    - **PrintBasicStats()** - Uses `Min()`, `Max()`, `Average()` to print stats
    - **PrintPassingFailingCounts()** - Uses `Count()` with predicates to print passing/failing counts
    - **PrintScoresSorted()** - Chains `OrderBy()` to sort and print all scores ascending
    - **PrintTopScores(int)** - Chains `OrderByDescending()` + `Take()` to print top N scores
    - **PrintPassingScores()** - Chains `Where()` + `OrderByDescending()` to filter/sort/print passing scores
    - **PrintFailingScores()** - Chains `Where()` + `OrderByDescending()` to filter/sort/print failing scores

    Output format (exact labels):
    - `Count: X`
    - `Min: X`
    - `Max: X`
    - `Average: X.X`
    - `Passing (>=threshold): X`
    - `Failing (<threshold): X`
    - `Sorted (asc): 10, 20, 30`
    - `Top 3: 30, 20, 10`
    - `Passing scores (desc): 30, 20`
    - `Failing scores (desc): 10`

4. **Ask to analyze another set** _(provided in starter)_
    - Prompt: `Analyze another set? (y/n): `
    - If `y`, repeat the full flow
    - If `n`, end the program

---

## Example Output

```
=== Score Stats: Methods + LINQ ===

Enter scores (comma-separated 0-100): 10, 20, 30
Enter passing threshold (0-100): 20

Count: 3
Min: 10
Max: 30
Average: 20.0
Passing (>=20): 2
Failing (<20): 1
Sorted (asc): 10, 20, 30
Top 3: 30, 20, 10
Passing scores (desc): 30, 20
Failing scores (desc): 10

Analyze another set? (y/n): n
```

---

## Getting Started

1. Navigate to the starter folder:

    ```bash
    # Mac/Linux:
    cd modules/week-09-methods-linq/starter

    # Windows:
    cd modules\week-09-methods-linq\starter
    ```

2. Review the TODO comments in `ScoreReport.cs`
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

- CSV parsing and re-prompting on invalid scores
- Threshold input validation (0–100)
- Correct stats (count/min/max/average/passing/failing)
- Average formatting to 1 decimal place
- A working analyze-again loop
- STUDY_NOTES.md exists and is completed

| Test Area                      | Points  | Tests  |
| ------------------------------ | ------- | ------ |
| **Basic Setup**                |         |        |
| Program compiles               | 10      | Test01 |
| **Input + Stats**              |         |        |
| Summary output correct         | 30      | Test02 |
| Invalid score re-prompt loop   | 15      | Test03 |
| Threshold validation re-prompt | 15      | Test04 |
| Analyze-again loop works       | 10      | Test05 |
| **Study Notes**                |         |        |
| STUDY_NOTES.md exists          | 10      | Test06 |
| All sections completed         | 10      | Test07 |
| **Total**                      | **100** |        |

---

## Helpful Tips / Common Pitfalls

- **Trim your CSV pieces**: users will type spaces (`10, 20, 30`).
- Use `StringSplitOptions.RemoveEmptyEntries` so extra commas don’t create empty items.
- Format the average to 1 decimal place (example: `20.0`).
- If tests fail, compare your prompts to the README character-by-character.

---

## Submission

1. Create a branch:

    ```bash
    git checkout main
    git pull origin main
    git checkout -b assignment/week-09
    ```

2. Commit and push your work:

    ```bash
    git add modules/week-09-methods-linq/starter/Program.cs
    git add modules/week-09-methods-linq/starter/STUDY_NOTES.md
    git commit -m "Complete Week 9: Score Stats"
    git push -u origin assignment/week-09
    ```

3. Open a pull request in your GitHub repo:
    - Base branch: `main`
    - Title: `Week 9: Score Stats (Methods + LINQ)`

4. Submit the pull request URL on Canvas.
