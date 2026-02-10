# Week 6 Lab - Cozy Cafe Sign Maker

## 🎯 Learning Objectives

In this code-along lab, you will practice:

1. Building a text-heavy console menu
2. Using `while` and `do-while` loops for flow and validation
3. Formatting strings with multiple techniques
4. Using string helpers like `Trim`, `ToUpper`, `Contains`, and `Substring`
5. Printing aligned output patterns
6. Reading and converting user input safely

## 📚 What You'll Build

A **Cozy Cafe Sign Maker** program that:

- Prints a title banner
- Shows a boxed menu
- Builds a welcome sign using concatenation and comparison
- Formats a menu line with placeholders and interpolation
- Styles a customer quote with analysis output
- Exits cleanly when the user chooses

## 🚀 Getting Started

### Step 1: Navigate to the Project

```bash
cd labs/week-6-strings-menus/starter
```

### Step 2: Open Program.cs

Open the file and follow the TODO comments from top to bottom.

### Step 3: Follow Along with Your Instructor

Write the code as you go. Test often!

## 📝 Variable Names to Use

Please use these variables to match the instructor demo:

- `title` (string)
- `subtitle` (string)
- `divider` (string)
- `choice` (int)
- `shopName` (string)
- `tagline` (string)
- `trimmedShopName` (string)
- `upperShopName` (string)
- `itemName` (string)
- `price` (double)
- `calories` (int)
- `quote` (string)
- `trimmedQuote` (string)
- `spaced` (string)
- `favoriteName` (string)
- `matchesFavorite` (bool)
- `length` (int)
- `preview` (string)
- `containsCafe` (bool)
- `endsWithPunctuation` (bool)
- `firstSpaceIndex` (int)

## 🧪 Test Your Program

Run the program after each section:

```bash
dotnet run
```

### Sample Run

```
========================================
COZY CAFE SIGN MAKER
Strings + Output Patterns
========================================

+--------------------------------------+
| 1) Welcome Sign                      |
| 2) Menu Line Formatter               |
| 3) Quote Styler                      |
| 4) Exit                              |
+--------------------------------------+
Choose an option (1-4): 1

Enter shop name: Cozy Cup
Enter a short tagline: Fresh daily!
----------------------------------------
| WELCOME TO COZY CUP!                  |
| Fresh daily!                          |
----------------------------------------
```

## ✅ Success Criteria

You are done when:

- All TODOs are completed
- Your program runs without errors
- The menu loops until Exit is chosen
- Each option uses a different string-building style
- Output is aligned and readable
