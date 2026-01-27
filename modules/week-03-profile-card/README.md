# Week 3: Personal Profile Card Generator

## Summary

Build a program that collects various types of personal information and displays it as a formatted digital profile card - demonstrating proper variable usage, data type selection, and data modeling fundamentals.

## Learning Objectives

-   Choose appropriate data types for different kinds of information
-   Store and organize multiple pieces of related data
-   Perform calculations with stored data
-   Convert between data types
-   Create well-formatted, structured output
-   Model real-world information in code

---

## Assignment Requirements

Create a console program that collects personal information and generates a formatted profile card:

1. **Collect 10+ pieces of information using appropriate data types:**

    **Personal Information (strings):**

    - Full name
    - Hometown (city, state)
    - Favorite color
    - Dream job

    **Academic Information:**

    - Major/field of study (string)
    - Current GPA (double, 0.0-4.0)
    - Graduation year (int)
    - Is full-time student? (bool)

    **Additional Details:**

    - Age (int)
    - Height in inches (double)
    - Favorite number (int)

2. **Calculate derived information:**

    - Birth year (current year - age)
    - Years until graduation
    - Height in feet and inches (convert from total inches)
    - Is honor student? (GPA >= 3.5)
    - Age in months (age × 12)

3. **Display formatted profile card with sections:**

    - Header with decorative border
    - Personal Information section
    - Academic Details section
    - Additional Info section
    - Calculated statistics
    - Use proper alignment and spacing

4. **Complete study notes:**
    - Fill out all sections in `STUDY_NOTES.md`
    - Reflect on variable selection and data type choices
    - Document your data modeling decisions

---

## Example Output

```
╔════════════════════════════════════════════╗
║         STUDENT PROFILE CARD               ║
╚════════════════════════════════════════════╝

PERSONAL INFORMATION
━━━━━━━━━━━━━━━━━━━━
Name:           Alex Johnson
Age:            20 years old
Hometown:       Seattle, WA
Favorite Color: Blue
Dream Job:      Software Engineer
Height:         5 feet 9 inches (69.0 inches)

ACADEMIC DETAILS
━━━━━━━━━━━━━━━━
Major:              Computer Science
GPA:                3.85 / 4.00
Expected Graduation: 2026
Status:             Full-Time Student
Honor Student:      Yes ⭐

CALCULATED STATISTICS
━━━━━━━━━━━━━━━━━━━━━
Birth Year:         2004
Years to Graduation: 2 years
Age in Months:      240 months
Favorite Number:    42

═══════════════════════════════════════════
Profile complete! Good luck with your studies!
```

---

## Getting Started

1. Navigate to the starter folder:

    ```bash
    # Mac/Linux:
    cd modules/week-03-profile-card/starter

    # Windows:
    cd modules\week-03-profile-card\starter
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

| Test Area                    | Points  | Tests     |
| ---------------------------- | ------- | --------- |
| **Basic Setup**              |         |           |
| Program compiles             | 5       | Test01    |
| **Data Collection**          |         |           |
| Collects all required inputs | 20      | Test02    |
| Uses appropriate data types  | 15      | Test03    |
| **Calculations**             |         |           |
| Birth year calculation       | 10      | Test04    |
| Years to graduation          | 10      | Test05    |
| Height conversion (ft/in)    | 10      | Test06    |
| Honor student determination  | 10      | Test07    |
| **Output Formatting**        |         |           |
| Displays all information     | 15      | Test08    |
| Proper sections and labels   | 10      | Test09    |
| **Study Notes**              |         |           |
| STUDY_NOTES.md completed     | 15      | Test10-11 |
| **Total**                    | **120** |           |

---

## Helpful Tips

### Choosing Data Types

-   **string**: Names, places, text descriptions
-   **int**: Whole numbers (age, year, count)
-   **double**: Decimals (GPA, height, measurements)
-   **bool**: Yes/no, true/false values (is student, is honor)

### Type Conversion

```csharp
// String to number
int age = int.Parse(Console.ReadLine());
double gpa = double.Parse(Console.ReadLine());

// Number to string (for display)
string ageText = age.ToString();

// Boolean from comparison
bool isHonorStudent = gpa >= 3.5;
```

### Calculations

```csharp
// Birth year
int currentYear = 2026;
int birthYear = currentYear - age;

// Years remaining
int yearsToGrad = graduationYear - currentYear;

// Height conversion
int feet = (int)(heightInches / 12);
double remainingInches = heightInches % 12;
```

### Formatting Output

```csharp
// Aligned text
Console.WriteLine($"Name:     {name}");
Console.WriteLine($"Age:      {age} years old");

// Decimal places
Console.WriteLine($"GPA:      {gpa:F2}");  // 2 decimals

// Conditional display
string status = isFullTime ? "Full-Time" : "Part-Time";
string honorBadge = isHonor ? "⭐" : "";
```

### Common Mistakes to Avoid

-   Using string for numbers that need calculations
-   Forgetting to convert string input to correct type
-   Not validating that GPA is in valid range (0.0-4.0)
-   Integer division losing decimal precision
-   Missing type casting when dividing integers

---

## Key Concepts

### Data Modeling

Think of your program as organizing information like a real form:

-   Group related information together
-   Choose the right "container" (data type) for each piece
-   Calculate values from existing data when possible
-   Present information in a logical, readable way

### Variable Naming

Use descriptive names that indicate what data they store:

-   `fullName` not just `name`
-   `graduationYear` not just `year`
-   `isFullTimeStudent` not just `status`

### Type Safety

C# requires you to be explicit about data types - this helps prevent errors:

-   Can't accidentally add a name to a number
-   Compiler catches type mismatches before runtime
-   Forces you to think about what kind of data you're working with

---

## Bonus Challenges

-   Add more personal details (phone number format, email validation)
-   Calculate BMI if they provide weight
-   Add multiple favorite items (colors, foods, hobbies)
-   Create ASCII art border decoration
-   Add emoji/symbols based on data (🎓 for students, ⭐ for honors)
-   Color code sections using Console.ForegroundColor

---

## Resources

-   [C# Data Types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types)
-   [Type Conversion](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
-   [String Formatting](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)
-   [Boolean Logic](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool)
