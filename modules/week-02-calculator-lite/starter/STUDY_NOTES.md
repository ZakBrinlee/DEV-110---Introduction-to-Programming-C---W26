# Week 2: Calculator Lite - Study Notes

**Name:**
Ujwal Garine

## Understanding Data Types

**What are the four data types you used in this assignment?**

- **string**: Stores text such as the user’s name and yes/no input
- **bool**: Stores true or false values, used for the decimal precision choice
- **int**: Stores whole numbers, used for counting calculations
- **double**: Stores numbers with decimals, used for all mathematical operations

**Why did we use `double` instead of `int` for the calculations?**

`int` only stores whole numbers, which would remove decimal values. `double` allows decimal precision, which is important for division, averages, and percentage calculations.

**How do you convert a string to a boolean?**

I compared the user’s input to the string `"yes"`. If it matched, the boolean was set to `true`; otherwise, it was set to `false`.

## Challenges and Solutions

**Biggest challenge with this assignment:**

Handling division by zero without crashing the program.

**How you solved it:**

I used conditional `if` statements to check if a number was zero before performing division, modulus, or percentage calculations.

**Most confusing concept:**

Conditional formatting using `:F2` and `:F0`.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**

Division (`/`) returns the quotient, while modulus (`%`) returns the remainder.
Example: `17 / 5 = 3`, `17 % 5 = 2`.

**How do you calculate the average of two numbers?**

Add the two numbers together and divide the result by 2.

**What is the formula for percentage difference?**

Subtract the second number from the first, divide by the first number, then multiply by 100.

## Input and Output

**How do you read user input in C#?**

`Console.ReadLine()` reads input entered by the user and returns it as a string.

**How do you convert string input to a number?**

I used `double.Parse()` or `int.Parse()` to convert the string input into a numeric value.

**What is string interpolation and how did you use it?**

String interpolation uses the `$` symbol and `{}` to insert variables directly into strings when printing output.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**

I used `:F2` to display two decimal places and `:F0` to display whole numbers.

**Why is it important to check for division by zero?**

Dividing by zero causes a runtime error, so checking prevents the program from crashing.

**How did you use the boolean variable to control formatting?**

I used an `if/else` statement to select the correct format based on the user’s decimal preference.

## What I Learned

**Key takeaways from this week:**

1. How to work with multiple data types
2. How to safely handle user input
3. How to prevent runtime errors
4. How conditional logic controls program behavior
5. How formatting improves output clarity

**Which data type concept was most useful?**

`double`, because it allows accurate calculations with decimals.

**How does conditional formatting improve user experience?**

It lets users choose how detailed the output is, making the program more flexible and readable.

## Testing and Debugging

**What test cases did you use to verify your program works?**

- Positive numbers
- Negative numbers
- Decimal values
- Zero as the second number
- Both `"yes"` and `"no"` for decimal precision

**What bugs or errors did you encounter and fix?**

I initially performed division before checking for zero, which caused errors. I fixed it by adding conditional checks.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Understanding data types: 0.5 hours
- Reading and parsing user input: 0.5 hours
- Implementing arithmetic operations: 0.75 hours
- Adding conditional formatting: 0.5 hours
- Handling division by zero: 0.25 hours
- Testing and debugging: 0.25 hours
- Writing documentation: 0.25 hours

**Most time-consuming part:**

Handling edge cases like division by zero and formatting correctly.

## Reflection

**What would you do differently next time?**

I would plan edge cases earlier before writing the main logic.

**How does this assignment prepare you for more complex programs?**

It builds a strong foundation in input handling, error checking, and conditional logic, which are essential for larger programs.
