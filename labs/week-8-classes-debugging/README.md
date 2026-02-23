# Week 8 Lab - Movie Tracker

## 🎯 Learning Objectives

In this code-along lab, you will practice:

1. Creating and using **custom classes** in separate files
2. Understanding **public** vs. **private** methods
3. Working with **properties** and **constructors**
4. Using **static utility classes** (Logger)
5. Debugging with **breakpoints** and the VS Code debugger
6. Stepping through code with **F10** and inspecting variables

## 📚 What You'll Build

A **Movie Tracker** program that:

- Defines a Movie class with properties (Title, Year, Genre, Rating, Director)
- Creates multiple Movie objects using a constructor
- Displays movie information with formatted output
- Converts numeric ratings to star displays (★★★★☆)
- Updates movie ratings with validation
- Uses the Logger utility for informational messages and warnings
- Demonstrates debugging with breakpoints, stepping, and variable inspection

## 🚀 Getting Started

### Step 1: Navigate to the Project

```bash
cd labs/week-8-classes-debugging/starter
```

### Step 2: Open the Files

Open these files in VS Code:

- **Movie.cs** - The Movie class definition
- **Program.cs** - The main program
- **Logger.cs** - The logging utility (already complete)

### Step 3: Follow Along with Your Instructor

**This lab is designed to be completed DURING the lecture.** Watch the recording, pause often, and type the code as demonstrated.

The TODOs are numbered in the order you'll complete them:

- TODO 1-5 are in Movie.cs
- TODO 6-15 are in Program.cs

## 📝 Variable Names to Use

Follow these naming conventions to match the instructor demo:

### In Movie.cs:

- Properties: `Title`, `Year`, `Genre`, `Rating`, `Director`
- Constructor parameters: `title`, `year`, `genre`, `rating`, `director`
- In GetStarDisplay(): `filledStars`, `emptyStars`, `stars`
- In UpdateRating(): `newRating` (parameter), `oldRating`

### In Program.cs:

- Movie objects: `movie1`, `movie2`, `movie3`

## 🧪 Test Your Program

Run the program after completing sections:

```bash
dotnet run
```

### Sample Output (Partial)

```
=== Movie Tracker Lab ===

[INFO] Creating first movie...
[INFO] Displaying movie 1 details:
╔════════════════════════════════════════╗
  📽️  The Shawshank Redemption (1994)
  🎬 Director: Frank Darabont
  🎭 Genre: Drama
  ⭐ Rating: ★★★★★ (4.8/5.0)
╚════════════════════════════════════════╝

[INFO] Updating movie 1 rating...
[INFO] Rating updated from 4.8 to 5.0

[INFO] Displaying movie 1 details:
╔════════════════════════════════════════╗
  📽️  The Shawshank Redemption (1994)
  🎬 Director: Frank Darabont
  🎭 Genre: Drama
  ⭐ Rating: ★★★★★ (5.0/5.0)
╚════════════════════════════════════════╝

[INFO] Creating second movie...
[INFO] Displaying movie 2 details:
╔════════════════════════════════════════╗
  📽️  Inception (2010)
  🎬 Director: Christopher Nolan
  🎭 Genre: Sci-Fi
  ⭐ Rating: ★★★★☆ (4.3/5.0)
╚════════════════════════════════════════╝

[INFO] Attempting invalid rating update...
[WARN] Rating must be between 0.0 and 5.0!
```

## ✅ Success Criteria

By the end of the lab, you should have:

1. ✅ A program that compiles and runs without errors
2. ✅ A Movie class with 5 properties (Title, Year, Genre, Rating, Director)
3. ✅ A constructor that initializes all properties
4. ✅ A public DisplayInfo() method that shows formatted movie details
5. ✅ A private GetStarDisplay() helper that converts ratings to stars
6. ✅ A public UpdateRating() method with validation (0.0 to 5.0)
7. ✅ Three Movie objects created in Program.cs
8. ✅ All movies displayed correctly
9. ✅ Rating updates working with validation
10. ✅ Logger.Info() showing yellow text
11. ✅ Logger.Warn() showing red text for invalid ratings

## 🔧 Debugging Practice (Required)

**Before finishing the lab, practice these debugging skills:**

### Set Breakpoints

1. Click in the gutter (left of line numbers) to set a breakpoint
2. Set a breakpoint on the first line of DisplayInfo() in Movie.cs
3. Set a breakpoint on the first line of UpdateRating() in Movie.cs

### Start Debugging

1. Press **F5** (or click "Start Debugging" in the Debug panel)
2. The program will pause at your first breakpoint

### Step Through Code

1. Press **F10** (Step Over) to execute one line at a time
2. Watch the yellow highlight move down the code
3. Observe the Console output appearing line by line

### Inspect Variables

1. Look at the **Variables panel** on the left
2. Expand **this** to see all movie properties
3. See how the values match what you passed to the constructor

### Add Watch Expressions

1. In the Debug sidebar → Watch section
2. Click the + icon
3. Add: `Title.ToUpper()`
4. Add: `Rating`
5. Watch them evaluate while debugging

### Conditional Breakpoints

1. Right-click on a breakpoint in the gutter
2. Select "Edit Breakpoint"
3. Enter condition: `Rating > 4.5`
4. The breakpoint only pauses when the condition is true

### Continue Execution

1. Press **F5** (Continue) to run until the next breakpoint or program end

## 🎓 Helpful Tips / Common Pitfalls

### Understanding Classes and Objects

- **Class** = blueprint (Movie is the template)
- **Object** = instance (movie1 is a specific movie created from the template)
- Use `new Movie(...)` to create objects from the Movie class

### Public vs. Private

- **Public methods** can be called from anywhere (Program.cs can call `movie1.DisplayInfo()`)
- **Private methods** can ONLY be called from within the same class
- Try typing `movie1.` in Program.cs - you'll see DisplayInfo() and UpdateRating() but NOT GetStarDisplay()

### Static Classes (Logger)

- Static classes don't need `new` - call methods directly
- `Logger.Info("message")` not `new Logger().Info("message")`
- Logger is a utility - one version for the whole program

### Debugging is Better than Console.WriteLine

- Breakpoints pause execution at a specific line
- You can see ALL variables at once
- Step through code to understand the flow
- No need to add/remove Console.WriteLine statements

### Common Mistakes

1. **Forgetting the namespace** - Both Movie.cs and Program.cs must use `namespace MovieTracker;`
2. **Trying to call private methods externally** - `movie1.GetStarDisplay()` won't work (it's private!)
3. **Forgetting 'new' when creating objects** - Must write `Movie movie1 = new Movie(...);`
4. **Not starting in Debug mode** - Click "Start Debugging" or press F5 for breakpoints to work
5. **Confusing F10 and F11** - F10 = Step Over (most common), F11 = Step Into (goes inside method calls)

## 📋 Debugging Shortcuts Reference

- **F5** - Start Debugging / Continue
- **F10** - Step Over (execute current line)
- **F11** - Step Into (go inside method call)
- **Shift+F11** - Step Out (finish current method)
- **Shift+F5** - Stop Debugging
- **Click in gutter** - Set/remove breakpoint
- **Right-click breakpoint** - Edit condition

## 📤 Submission

**This is a practice lab - no formal submission required.**

However, complete all TODOs and practice the debugging skills. These concepts are CRITICAL for the Week 8 assignment (Mad Libs).

## 🆘 Need Help?

- Rewatch the lecture recording and pause to type along
- Check the **solution folder** if you get stuck
- Review the **INSTRUCTOR_NOTES.md** file for detailed steps
- Post questions in the Discussion board
- Attend office hours

---

**Remember:** This is your FIRST time working with classes in separate files. Take your time, follow the TODOs in order, and ask questions if confused!
