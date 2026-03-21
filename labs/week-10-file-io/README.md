# Week 10 Lab - Movie Tracker (Save & Load)

## 🎯 Learning Objectives

In this code-along lab, you will practice:

1. **File.Exists** to check whether a file is present before reading
2. **File.ReadAllLines** to load all lines from a CSV file
3. Parsing CSV lines into **Movie objects** (splitting on comma)
4. **File.WriteAllLines** to save a list of movies back to a file
5. Formatting objects as CSV strings with **LINQ Select**

## 📚 What You'll Build

A **Movie Tracker: Save & Load** program that:

- Checks for a `movies.csv` file at startup — loads it if it exists, or falls back to seed data
- Shows a menu with 6 options
- Lists all movies using `DisplayInfo()`
- Lets the user add a new movie with prompted input
- Lets the user update a movie's rating
- Lets the user delete a movie from the list
- Saves the current list to `movies.csv` so data persists between runs
- Quits cleanly

**Note:** `ParseMovieLine`, `LoadMovies`, `LoadSeedMovies`, `PrintMenu`, and the input helpers are already provided in the starter. A pre-seeded `movies.csv` is also included so you see the file-load path on your very first run. Your main focus is the File I/O methods and the full CRUD menu loop.

## 🚀 Getting Started

### Step 1: Navigate to the Project

```bash
cd labs/week-10-file-io/starter
```

### Step 2: Open Program.cs

Open the file and follow the TODO comments from top to bottom.

### Step 3: Follow Along with Your Instructor

Write the code as you go. Run often!

```bash
dotnet run
```

## 📝 Variable Names to Use

Please use these variable names to match the instructor demo:

- `movies` (List\<Movie\>)
- `filePath` ("movies.csv")
- `running` (bool)
- `choice` (int)
- `lines` (string\[\] — from File.ReadAllLines)
- `csvLines` (string\[\] — passed to File.WriteAllLines)
- `newMovie` (Movie)
- `title`, `year`, `genre`, `rating`, `director`, `runtime`
- `index` (int — 0-based after subtracting 1 from user input)
- `newRating` (double — updated rating, 1.0–5.0)
- `deletedTitle` (string — the title captured before removing a movie)

## 🧪 Test Your Program

Run the program after each TODO section:

```bash
dotnet run
```

### Sample Run (first launch — file loads from pre-seeded CSV)

```
=== Movie Tracker: Save & Load ===

[INFO] Loaded 8 movies from movies.csv.

Menu:
1) List all movies
2) Add a movie
3) Update a movie's rating
4) Delete a movie
5) Save movies to file
6) Quit
Choose an option (1-6): 6

Goodbye!
```

### Sample: Adding a Movie

```
[INFO] Enter new movie details:
Title: Clueless
Year: 1995
Genre: Comedy
Rating (1.0-5.0): 4.2
Director: Amy Heckerling
Runtime (minutes): 97

[INFO] Added: Clueless
```

### Sample: Updating a Movie's Rating

```
[INFO] Select a movie to update:
  1) The Shawshank Redemption (1994)
  2) Inception (2010)
  ...
Enter movie number: 2
New rating (1.0-5.0): 4.8

[INFO] Updated: Inception — rating now 4.8
```

### Sample: Deleting a Movie

```
[INFO] Select a movie to delete:
  1) The Shawshank Redemption (1994)
  2) Inception (2010)
  ...
Enter movie number: 2

[INFO] Deleted: Inception
```

## ✅ Success Criteria

You are done when:

- All TODOs are completed
- Your program runs without errors
- The 6-option menu works correctly for all choices
- Updating a movie changes its rating in the list
- Deleting a movie removes it from the list
- Choosing **Save** writes the current list to `movies.csv`
- Running the program again loads from that file instead of seed data
- Adding, updating, or deleting a movie — then saving — persists the change across runs
