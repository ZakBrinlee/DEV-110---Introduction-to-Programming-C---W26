# Week 9 Lab - Movie Tracker (LINQ Reports)

## 🎯 Learning Objectives

In this code-along lab, you will practice:

1. **Methods** to organize your program
2. **Menu loops** to repeat a console flow
3. LINQ **sorting** with `OrderBy` / `OrderByDescending`
4. LINQ **stats** with `Min`, `Max`, and `Average`
5. LINQ **filtering** with `Where`
6. Clean formatted output (like the Week 8 Movie Tracker)

## 📚 What You'll Build

A **Movie Tracker: LINQ Reports** program that:

- Loads a **pre-seeded** list of movies (no adding movies this week)
- Shows a menu with report options
- Lists movies **sorted by title**
- Prints the **top 3** highest-rated movies
- Generates a **genre report** (sorted by rating)
- Prints **overall stats** using Min/Max/Average

**Note:** The menu and input helper methods (`PrintMenu`, `ReadIntInRange`, `ReadNonEmptyString`) are already completed for you in Week 9.
Your main focus is the LINQ report methods.

## 🚀 Getting Started

### Step 1: Navigate to the Project

```bash
cd labs/week-9-methods-linq/starter
```

### Step 2: Open Program.cs

Open the file and follow the TODO comments from top to bottom.

### Step 3: Follow Along with Your Instructor

Write the code as you go. Run often!

## 📝 Variable Names to Use

Please use these variable names to match the instructor demo:

- `movies` (List<Movie>)
- `running` (bool)
- `choice` (int)
- `genre` (string)
- `matches` (List<Movie>)
- `minRating` (double)
- `maxRating` (double)
- `averageRating` (double)
- `minRuntime` (int)
- `maxRuntime` (int)
- `averageRuntime` (double)

## 🧪 Test Your Program

Run the program after each section:

```bash
dotnet run
```

### Sample Run

```
=== Movie Tracker: LINQ Reports ===

[INFO] Loaded 8 movies.

Menu:
1) List all movies (sorted by title)
2) Show top 3 highest-rated movies
3) Genre report (sorted by rating)
4) Overall stats (Min/Max/Average)
5) Quit
Choose an option (1-5): 4

[INFO] Overall stats:
Movies: 8
Rating (min/max/avg): 4.3 / 5.0 / 4.7
Runtime (min/max/avg): 81 / 169 / 131.0

Goodbye!
```

## ✅ Success Criteria

You are done when:

- All TODOs are completed
- Your program runs without errors
- Your reports use LINQ (`Min`, `Max`, `Average`, `OrderBy`)
- The menu loop works until the user chooses Quit
