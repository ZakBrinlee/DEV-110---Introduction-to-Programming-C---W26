# Week 10: Habit Tracker (File I/O)

## Summary

Build a menu-driven **Habit Tracker** that loads habits from a CSV file, lets you view, add, update, and save them. You will practice reading and writing files, working with a class that has multiple properties, and using LINQ to compute grouped statistics.

## Learning Objectives

- Read and write CSV files using `File.ReadAllLines` and `File.WriteAllLines`
- Catch `FileNotFoundException` and display a friendly error message
- Create and use objects with three properties: `Name`, `IsCompleted`, and `Frequency`
- Use LINQ (`Count()` with a predicate) to compute grouped summary statistics
- Build a menu-driven program that runs until the user chooses to quit

---

## Resources

- [File.ReadAllLines](https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalllines)
- [File.WriteAllLines](https://learn.microsoft.com/en-us/dotnet/api/system.io.file.writealllines)
- [LINQ Count with predicate](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count)
- [String.Split](https://learn.microsoft.com/en-us/dotnet/api/system.string.split)
- [CultureInfo.InvariantCulture](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.invariantculture)

---

## Assignment Requirements

The `Habit` class is fully provided with three properties:

- `Name` — the habit name (e.g. `"Exercise"`)
- `IsCompleted` — whether the habit is done (`true`) or pending (`false`)
- `Frequency` — either `"daily"` or `"weekly"`

Implement the **6 TODO methods** in `Program.cs`:

### TODO 1 — `LoadHabits(path)`

Read a CSV file where each line has three columns: `Name,Status,Frequency`

- Create an empty `List<Habit>`
- Inside a `try` block: call `File.ReadAllLines(path)`
- Loop through lines; skip blank ones with `string.IsNullOrWhiteSpace`
- Split each line on `','` → `parts[0]` = name, `parts[1]` = status, `parts[2]` = frequency
- `isCompleted` is `true` when status equals `"done"` (case-insensitive)
- Create `new Habit(name, isCompleted, frequency)` and add to the list
- Catch `FileNotFoundException` and print:
    ```
    Error: File not found — {path}
    ```
    (use `—` which is an em dash, not a hyphen)
- Return the list

### TODO 2 — `PrintHabits(habits)`

Display all habits with a status marker and frequency label:

- Print: `--- Your Habits ---`
- Call `DisplayInfo()` on each habit
- `DisplayInfo()` outputs: `  [x] Exercise (daily)` or `  [ ] Journal (weekly)`

### TODO 3 — `PrintSummary(habits)`

Print completion statistics grouped by frequency using LINQ:

- Print: `--- Summary ---`
- Use `habits.Count(h => h.Frequency == "daily")` to count daily habits
- Use `habits.Count(h => h.Frequency == "daily" && h.IsCompleted)` to count completed daily habits
- Do the same for weekly habits
- Guard against divide-by-zero if a group has 0 habits
- Format each rate with one decimal: `rate.ToString("F1", CultureInfo.InvariantCulture)`

Expected output format:

```
--- Summary ---
Daily:    3/4 completed (75.0%)
Weekly:   1/1 completed (100.0%)
```

### TODO 4 — `AddHabit(habits)`

Prompt for a new habit's name and frequency:

- Print: `--- Add Habit ---`
- Prompt: `Habit name:`
- Prompt: `Frequency ((D)aily or (W)eekly):`
- If the user enters `D` → `"daily"`, otherwise → `"weekly"`
- Create `new Habit(name, false, frequency)` (new habits start as not completed)
- Print: `Added: {name} ({frequency})`

### TODO 5 — `UpdateHabit(habits)`

Show a numbered list, let the user pick one, optionally rename it, and toggle completion:

- If the list is empty: print `No habits to update.` and return
- Print: `--- Update Habit ---`
- Show a 1-based numbered list: `1. Exercise`, `2. Meditate`, etc.
- Prompt: `Enter habit number:` (use `ReadIntInRange(1, habits.Count)`)
- Prompt: `New name (press Enter to keep "{habit.Name}"):`
- If input is non-blank, set `habit.Name = newName`
- Toggle: `habit.IsCompleted = !habit.IsCompleted`
- Print: `Updated: {habit.Name} — now {completed or pending}`

### TODO 6 — `SaveHabits(path, habits)`

Write the habit list back to the CSV file with 3 columns:

- Build a string array using LINQ:
    ```csharp
    habits.Select(h => $"{h.Name},{(h.IsCompleted ? "done" : "pending")},{h.Frequency}").ToArray()
    ```
- Call `File.WriteAllLines(path, lines)`
- Print: `Habits saved to {path}.`

---

## Example Output

```
=== Habit Tracker: File I/O ===

Enter habits file path: habits.csv

--- Menu ---
1. View Habits
2. View Summary
3. Add Habit
4. Update Habit
5. Save & Quit
Choice (1-5): 1

--- Your Habits ---
[x] Exercise (daily)
[ ] Meditate (daily)
[x] Drink Water (daily)
[ ] Journal (weekly)
[x] Read 30 mins (weekly)

--- Menu ---
1. View Habits
2. View Summary
3. Add Habit
4. Update Habit
5. Save & Quit
Choice (1-5): 2

--- Summary ---
Daily:    2/3 completed (66.7%)
Weekly:   1/2 completed (50.0%)

--- Menu ---
1. View Habits
2. View Summary
3. Add Habit
4. Update Habit
5. Save & Quit
Choice (1-5): 3

--- Add Habit ---
Habit name: Morning Walk
Frequency ((D)aily or (W)eekly): D
Added: Morning Walk (daily)

--- Menu ---
1. View Habits
2. View Summary
3. Add Habit
4. Update Habit
5. Save & Quit
Choice (1-5): 5

Habits saved to habits.csv.

Goodbye!
```

---

## Getting Started

1. Navigate to the starter folder:

    ```bash
    # Mac/Linux:
    cd modules/week-10-file-io/starter

    # Windows:
    cd modules\week-10-file-io\starter
    ```

2. Create your assignment branch:

    ```bash
    git checkout main
    git pull
    git checkout -b assignment/week-10
    ```

3. Review the TODO comments in `Program.cs`
4. Run your program:

    ```bash
    dotnet run
    ```

5. Test your work:

    ```bash
    # Mac/Linux:
    dotnet test ../tests

    # Windows:
    dotnet test ..\tests
    ```

---

## Grading Criteria

Your assignment will be automatically graded with 10 test cases:

| Test Area                              | Points  | Tests  |
| -------------------------------------- | ------- | ------ |
| **Basic Setup**                        |         |        |
| Program compiles                       | 5       | Test01 |
| **File I/O**                           |         |        |
| Habits load from CSV and display       | 15      | Test02 |
| FileNotFoundException handled          | 10      | Test03 |
| **Display**                            |         |        |
| `[x]` and `[ ]` markers with frequency | 5       | Test04 |
| **Summary (LINQ)**                     |         |        |
| Daily and Weekly lines appear          | 10      | Test05 |
| Rates formatted to one decimal         | 5       | Test06 |
| **Add Habit**                          |         |        |
| Add prompts for name + frequency       | 15      | Test07 |
| **Update Habit**                       |         |        |
| Rename and toggle completion           | 15      | Test08 |
| **Save**                               |         |        |
| CSV written with 3 columns             | 15      | Test09 |
| **Study Notes**                        |         |        |
| STUDY_NOTES.md completed               | 5       | Test10 |
| **Total**                              | **100** |        |

---

## Helpful Tips / Common Pitfalls

### Reading a CSV Line

After calling `line.Split(',')`, you have an array of parts. Access them by index:

```csharp
string name = parts[0].Trim();
bool isCompleted = parts[1].Trim().Equals("done", StringComparison.OrdinalIgnoreCase);
string frequency = parts[2].Trim();
```

### Using LINQ for Grouped Counts

```csharp
int dailyTotal = habits.Count(h => h.Frequency == "daily");
int dailyDone  = habits.Count(h => h.Frequency == "daily" && h.IsCompleted);
```

### Avoiding Divide-by-Zero

```csharp
double dailyRate = dailyTotal > 0 ? (double)dailyDone / dailyTotal * 100.0 : 0.0;
```

### The Em Dash

The error message uses `—` (an em dash), not a regular hyphen `-`:

```csharp
Console.WriteLine($"Error: File not found — {path}");
```

### Common Mistakes

- **Forgetting `parts[2]`**: The CSV has 3 columns — always read all three
- **Using `==` for case-insensitive comparison**: Use `.Equals("done", StringComparison.OrdinalIgnoreCase)` instead of `== "done"`
- **Wrong frequency casing**: Use `h.Frequency == "daily"` (lowercase) — that is how it is stored when loaded
- **Trim your parts**: `parts[0].Trim()` removes leading/trailing spaces so `" Exercise"` becomes `"Exercise"`

---

## Submission

1. Make sure all tests pass:

    ```bash
    dotnet test ../tests
    ```

2. Complete your `STUDY_NOTES.md` in the starter folder
3. Stage, commit, and push your work:

    ```bash
    git add .
    git commit -m "Complete Week 10: Habit Tracker (File I/O)"
    git push
    ```

4. Open a Pull Request from your `assignment/week-10` branch into `main`
5. Add your instructor as a reviewer
