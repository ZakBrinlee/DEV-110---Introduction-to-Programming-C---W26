# Week 4 Lab - Logic Lounge

## 🎯 Learning Objectives

In this code-along lab, you will practice:

1. **`if` statements** (single condition)
2. **`if/else` statements** (two paths)
3. **Nested `if` statements** (decisions inside decisions)
4. **`switch` statements** (multiple choices)
5. **`goto` inside a `switch`** (redirect a case)
6. **User input** with `Console.ReadLine()`
7. **Type conversion** with `int.Parse()`

## 📚 What You'll Build

A **Logic Lounge** program that:

- Greets the user
- Applies simple rules with `if`
- Uses `if/else` to decide prices
- Uses a nested `if` to assign membership levels
- Uses a `switch` to choose an activity
- Demonstrates a `goto` that jumps to another case
- Prints a summary of choices and costs

## 🚀 Getting Started

### Step 1: Navigate to the Project

```bash
cd labs/week-4-decisions/starter
```

### Step 2: Open Program.cs

Open the file and follow the TODO comments from top to bottom.

### Step 3: Follow Along with Your Instructor

Write the code as you go. Test often!

## 📝 Variable Names to Use

Please use these variables to match the instructor demo:

- `userName` (string)
- `age` (int)
- `snackChoice` (string)
- `snackPrice` (double)
- `isMember` (bool)
- `membershipLevel` (string)
- `activityChoice` (int)
- `activityName` (string)
- `activityCost` (double)

## 🧪 Test Your Program

Run the program after each section:

```bash
dotnet run
```

### Sample Run

```
Enter your name: Casey
Enter your age: 19
Choose a snack size (S/L): L
Are you a club member? (yes/no): y

Choose an activity:
1) Movie
2) Arcade
3) Study Lounge
Enter 1, 2, or 3: 2
```

## ✅ Success Criteria

You are done when:

- All TODOs are completed
- Your program runs without errors
- All four decision types are used (`if`, `if/else`, nested `if`, `switch`)
- A summary is displayed at the end
