# Week 2: Calculator Lite

## Summary

Build an enhanced calculator that demonstrates C# fundamentals: working with multiple data types (string, bool, int, double), performing arithmetic operations including modulus and percentage calculations, and formatting output based on user preferences.

## Learning Objectives

-   Work with multiple C# data types (string, bool, int, double)
-   Read and convert various types of user input
-   Perform arithmetic operations (+, -, \*, /, %)
-   Create compound expressions (average, percentage)
-   Use boolean logic for conditional formatting
-   Format numeric output based on conditions
-   Handle division by zero gracefully

---

## Assignment Requirements

1. **Collect user information:**

    - Get user's name and display personalized greeting
    - Ask about decimal precision preference (yes/no) and store as boolean

2. **Get two numbers from user:**

    - Use clear prompts for both numbers
    - Accept decimal values

3. **Perform six calculations:**

    - Addition, subtraction, multiplication, division, modulus (remainder), and average
    - Display each result with appropriate labels

4. **Calculate percentage difference:**

    - Show the percentage difference between the two numbers

5. **Conditional formatting:**

    - Format all numbers based on user's decimal preference
    - 2 decimal places if they chose "yes", whole numbers if "no"

6. **Error handling:**

    - Check for division by zero before calculating quotient and percentage
    - Display appropriate error messages instead of crashing

7. **Final summary:**

    - Track and display the number of calculations performed
    - Include user's name in farewell message

8. **Complete study notes:**
    - Fill out all sections in `STUDY_NOTES.md`
    - Reflect on what you learned about data types, arithmetic operations, and user interaction
    - Document your development process and time spent

---

## Example Output

### With Decimal Precision

```
=== Calculator Lite ===

Enter your name: Alice
Hello, Alice! Let's do some calculations.

Use decimal precision? (yes/no): yes
Enter the first number: 50
Enter the second number: 25

Results:
Sum: 50.00 + 25.00 = 75.00
Difference: 50.00 - 25.00 = 25.00
Product: 50.00 * 25.00 = 1250.00
Quotient: 50.00 / 25.00 = 2.00
Remainder: 50.00 % 25.00 = 0.00
Average: (50.00 + 25.00) / 2 = 37.50
Percentage difference: 50.00%

Performed 6 calculations for Alice!

Thank you for using Calculator Lite!
```

### Without Decimal Precision

```
=== Calculator Lite ===

Enter your name: Bob
Hello, Bob! Let's do some calculations.

Use decimal precision? (yes/no): no
Enter the first number: 17
Enter the second number: 5

Results:
Sum: 17 + 5 = 22
Difference: 17 - 5 = 12
Product: 17 * 5 = 85
Quotient: 17 / 5 = 3
Remainder: 17 % 5 = 2
Average: (17 + 5) / 2 = 11
Percentage difference: 71%

Performed 6 calculations for Bob!

Thank you for using Calculator Lite!
```

### Division by Zero

```
=== Calculator Lite ===

Enter your name: Charlie
Hello, Charlie! Let's do some calculations.

Use decimal precision? (yes/no): yes
Enter the first number: 10
Enter the second number: 0

Results:
Sum: 10.00 + 0.00 = 10.00
Difference: 10.00 - 0.00 = 10.00
Product: 10.00 * 0.00 = 0.00
Quotient: Cannot divide by zero
Remainder: Cannot calculate (division by zero)
Average: (10.00 + 0.00) / 2 = 5.00
Percentage difference: Cannot calculate (division by zero)

Performed 5 calculations for Charlie!

Thank you for using Calculator Lite!
```

---

## Getting Started

1. Navigate to the starter folder:

    ```bash
    # Mac/Linux:
    cd modules/week-02-calculator-lite/starter

    # Windows:
    cd modules\week-02-calculator-lite\starter
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

Your assignment will be automatically graded with 11 test cases:

| Test Area                      | Points  | Tests  |
| ------------------------------ | ------- | ------ |
| **Basic Setup**                |         |        |
| Program compiles               | 5       | Test01 |
| **User Interaction**           |         |        |
| All prompts and responses      | 20      | Test02 |
| **Arithmetic Operations**      |         |        |
| Basic operations (+, -, \*, /) | 20      | Test03 |
| Modulus (remainder)            | 10      | Test04 |
| Average calculation            | 10      | Test05 |
| **Error Handling**             |         |        |
| Division by zero               | 10      | Test06 |
| **Advanced Calculations**      |         |        |
| Percentage difference          | 10      | Test07 |
| Uses all 4 data types          | 5       | Test08 |
| **Study Notes**                |         |        |
| STUDY_NOTES.md exists          | 5       | Test09 |
| All sections completed         | 10      | Test10 |
| Required sections present      | 5       | Test11 |
| **Total**                      | **110** |        |

---

## Helpful Tips

### Data Types to Use

-   **string**: For the user's name
-   **bool**: For the decimal preference (true/false)
-   **int**: For counting calculations
-   **double**: For all numeric calculations

### Key Concepts

**Modulus Operator (%)**: Returns the remainder of division

-   Example: `17 % 5 = 2` (17 divided by 5 is 3 with remainder 2)

**Percentage Formula**: `((num1 - num2) / num1) * 100`

**Conditional Formatting**:

-   `:F2` shows 2 decimal places (15.50)
-   `:F0` shows whole numbers (16)

**Division by Zero**: Always check if the divisor is zero before dividing

### Common Mistakes to Avoid

-   Not converting string input to boolean (compare with `== "yes"`)
-   Confusing modulus (%) with percentage calculation
-   Using wrong data types for variables
-   Forgetting to adjust calculation count when skipping operations
-   Not using conditional logic for formatting output

---

## Bonus Challenges

-   Add input validation using `TryParse()` to handle invalid input gracefully
-   Add more operations like exponentiation or square root
-   Accept multiple variations of "yes" (y, Y, YES, yes)
-   Allow multiple rounds of calculations without restarting
-   Add color to output based on positive/negative results

---

## Resources

-   [C# Data Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)
-   [Arithmetic Operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators)
-   [String Formatting](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)
-   [Conditional Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements)
