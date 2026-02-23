# Week 7 Lab - Study Group Sign-Up (Arrays)

## 🎯 Learning Objectives

In this code-along lab, you will practice:

1. **Parallel arrays** (two arrays that stay lined up)
2. A **fixed capacity** array design (no resizing)
3. A **count** variable to track used slots
4. Using a **`for` loop** to read multiple values into arrays
5. Using a **`foreach` loop** to print roster lines
6. Sorting aligned arrays with **`Array.Sort()`**

## 📚 What You'll Build

A menu-driven program that:

- Stores up to **3 students** using parallel arrays
- Lets the user **add multiple students** at a time (limited by remaining space)
- Prints the roster (or prints an empty message)
- Prints a sorted roster (sorted by name or by section number)
- Exits cleanly with a goodbye message

## 🚀 Getting Started

### Step 1: Navigate to the Project

```bash
cd labs/week-7-arrays/starter
```

### Step 2: Open Program.cs

Open the file and follow the TODO comments from top to bottom.

### Step 3: Follow Along with Your Instructor

Write the code as you go. Run the program often.

It is OK if your starter program is incomplete at first &mdash; this is a code-along lab and you will build it step-by-step.

## 📝 Variable Names to Use

Please use these variables to match the instructor demo:

- `rosterCapacity` (int)
- `rosterNames` (string[])
- `rosterSectionNumbers` (int[])
- `count` (int)
- `choice` (int)
- `remainingSlots` (int)
- `howManyToAdd` (int)
- `sortChoice` (int)
- `sortedNames` (string[])
- `sortedSectionNumbers` (int[])

## 🧪 Test Your Program

Run the program after each section:

```bash
dotnet run
```

Note: early in the lab, you may have compile errors until you complete the first few TODOs.

### Sample Run

(After completing the TODOs, your program should behave like this.)

```
=== Study Group Sign-Up (Arrays) ===

1) Add multiple students
2) Print class roster
3) Print roster (sorted)
4) Exit
Choose an option: 2
Roster is empty.

1) Add multiple students
2) Print class roster
3) Print roster (sorted)
4) Exit
Choose an option: 4
Goodbye.
```

## ✅ Success Criteria

You are done when:

- All TODOs are completed
- Your program runs without errors
- You can add up to 3 students (name + section number)
- You print the roster using a `foreach` loop
- You print a sorted roster using `Array.Sort()` while keeping names and numbers aligned
