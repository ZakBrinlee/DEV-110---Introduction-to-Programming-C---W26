# Understanding Tests in DEV 110

## What Are Unit Tests?

Unit tests are small programs that automatically check if your code works correctly. Think of them as a robot teaching assistant that grades your work instantly.

---

## Running Tests

### From Project Root (Recommended) ⭐

From the **top-level project directory** (`DEV-110---Introduction-to-Programming-C---W26/`):

```bash
# Mac/Linux:
./test 1        # Test Week 1
./test 2        # Test Week 2
./test all      # Test all weeks

# Windows:
dotnet test modules\week-01-hello-github\tests
dotnet test modules\week-02-calculator-lite\tests
# etc.
```

### From Within a Module

**If you're in a starter folder** (`modules/week-XX-assignment/starter/`):

```bash
# Mac/Linux - Using the test script:
../../../test 1

# Using dotnet directly (works on all platforms):
# Mac/Linux:
dotnet test ../tests

# Windows:
dotnet test ..\tests
```

**If you're in a module folder** (`modules/week-XX-assignment/`):

```bash
# Mac/Linux - Using the test script:
../../test 1

# Using dotnet directly (works on all platforms):
dotnet test tests
```

---

## Reading Test Results

### ✅ Test Passed

```
Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5
```

**Meaning:** All 5 tests passed! Your code works correctly.

### ❌ Test Failed

```
Failed!  - Failed:     2, Passed:     3, Skipped:     0, Total:     5

Failed TestAddition [45 ms]
  Expected: 10
  Actual:   11
```

**Meaning:** 2 tests failed. The `TestAddition` test expected your method to return 10, but it returned 11 instead.

### ⚠️ Test Inconclusive

```
Inconclusive!  - Failed:     0, Passed:     4, Skipped:     0, Inconclusive:     1
```

**Meaning:** One test couldn't run completely, usually because a required file is missing (like SUBMISSION.md).

---

## Understanding Test Names

Tests are named to tell you what they're checking:

```csharp
[TestMethod]
public void Test04_CalculateAverage_WithThreeScores_ReturnsCorrectAverage()
```

**Reading this name:**

-   `Test04` - Test number (helps with ordering)
-   `CalculateAverage` - Testing the CalculateAverage method
-   `WithThreeScores` - When given three scores as input
-   `ReturnsCorrectAverage` - Should return the correct average

---

## Common Test Errors

### "Could not load file or assembly"

**Fix:**

```bash
dotnet clean
dotnet build
dotnet test
```

### "No test is available"

**Possible causes:**

1. You're in the wrong directory
2. The test project isn't built yet
3. Tests are in a different folder

**Fix from starter folder:**

```bash
# Mac/Linux:
cd modules/week-01-hello-github/starter
dotnet restore
dotnet build
dotnet test ../tests

# Windows:
cd modules\week-01-hello-github\starter
dotnet restore
dotnet build
dotnet test ..\tests
```

**Or use the quick command from anywhere:**

```bash
# Mac/Linux:
./test 1

# Windows:
dotnet test modules\week-01-hello-github\tests
```

### Tests Pass Locally But Fail on GitHub

**Possible causes:**

1. Hard-coded values specific to your computer
2. Files not committed to Git
3. Timing-dependent code
4. Line ending differences (Windows vs Mac/Linux)

**Fix:**

```bash
# Make sure all your code is committed
git status
git add .
git commit -m "Fix failing tests"
git push
```

---

## Test-Driven Development (TDD) Tips

### 1. Read the Test First

Before writing code, look at what the test expects:

```csharp
[TestMethod]
public void Test04_CalculatesAdditionCorrectly()
{
    ProvideInput("10", "5");
    Program.Main(new string[] { });
    string output = _output.ToString();

    Assert.IsTrue(output.Contains("15"),
        "Program should display the sum of 10 and 5 (15)");
}
```

**This tells you:**

-   Your program will receive inputs "10" and "5"
-   It should output something containing "15"
-   This is testing addition functionality

### 2. Run Tests Often

Don't wait until you're "done" to run tests. Run them after every small change:

```bash
# Make a small code change
# Save the file
dotnet test ../tests

# Make another small change
# Save the file
dotnet test ../tests
```

### 3. Fix One Test at a Time

If multiple tests fail, focus on fixing one at a time. Start with the lowest-numbered test (Test01, Test02, etc.).

---

## GitHub Actions Auto-Grading

When you push your code to GitHub, tests run automatically.

### Viewing Results

1. Go to your GitHub repository
2. Click on "Actions" tab
3. Click on the latest workflow run
4. Look for ✅ or ❌ next to each test

### Understanding the Summary

GitHub Actions will post results in your PR:

```
## Test Results Summary
- Total Tests: 8
- Passed: ✅ 6
- Failed: ❌ 2

Failed Tests:
- TestCalculateAverage: Expected 85.0 but got 84.0
- TestValidateInput: Expected true but got false
```

---

## Types of Tests in This Course

### Compilation Tests

```csharp
[TestMethod]
public void Test01_ProgramCompiles()
{
    Assert.IsTrue(true, "Project compiled successfully");
}
```

**What it checks:** Your code compiles without errors.

### Output Tests

```csharp
[TestMethod]
public void Test02_ProgramOutputsHelloGitHub()
{
    Program.Main(new string[] { });
    string output = _output.ToString().Trim();
    Assert.AreEqual("Hello, GitHub!", output);
}
```

**What it checks:** Your program outputs the exact expected text.

### Logic Tests

```csharp
[TestMethod]
public void Test04_CalculatesAdditionCorrectly()
{
    ProvideInput("10", "5");
    Program.Main(new string[] { });
    Assert.IsTrue(output.Contains("15"));
}
```

**What it checks:** Your calculations are correct.

### Format Tests

```csharp
[TestMethod]
public void Test09_FormatsOutputWithDecimals()
{
    ProvideInput("10", "3");
    Program.Main(new string[] { });
    bool hasDecimalFormatting = output.Contains(".00") ||
                               output.Contains(".33");
    Assert.IsTrue(hasDecimalFormatting);
}
```

**What it checks:** Your output is properly formatted.

### File Tests

```csharp
[TestMethod]
public void Test06_SubmissionFileExists()
{
    string submissionPath = Path.Combine("..", "..", "..", "SUBMISSION.md");
    bool exists = File.Exists(submissionPath);
    Assert.IsTrue(exists);
}
```

**What it checks:** Required files exist in the correct location.

---

## Debugging Failed Tests

### Step 1: Read the Error Message

```
Failed TestCalculateAverage [12 ms]
  Expected: 85.0
  Actual:   84.0
  Message: Program should calculate the correct average
```

This tells you:

-   Which test failed: `TestCalculateAverage`
-   What was expected: `85.0`
-   What your code returned: `84.0`
-   Why it matters: "should calculate the correct average"

### Step 2: Find the Test Code

Open the test file (in `tests/` folder) and find the test method to see exactly what it's testing.

### Step 3: Reproduce Locally

Run the same inputs that the test uses:

```bash
dotnet run
# Then enter the same values the test uses
```

### Step 4: Use Debugging

1. Set a breakpoint in your code (click left of line number)
2. Press F5 to start debugging
3. Step through line by line (F10)
4. Watch variable values change

### Step 5: Fix and Retest

Make your fix, then run tests again:

```bash
# Mac/Linux:
dotnet test ../tests

# Windows:
dotnet test ..\tests
```

---

## Tips for Test Success

### ✅ DO:

-   Run tests frequently as you code
-   Read test names to understand what's being tested
-   Fix tests in order (Test01, Test02, etc.)
-   Use test error messages as debugging hints
-   Commit code that passes tests

### ❌ DON'T:

-   Wait until the end to run tests
-   Ignore test failures ("it works on my machine")
-   Modify test files (you'll lose points!)
-   Hard-code values to make tests pass
-   Skip reading error messages

---

## Getting Help with Tests

### If a test keeps failing:

1. **Read the error message carefully** - It usually tells you exactly what's wrong
2. **Check the test code** - Look in the `tests/` folder to see what it expects
3. **Use the debugger** - Set a breakpoint and step through your code
4. **Compare with assignment README** - Make sure you understand the requirements
5. **Ask for help** - Post on Canvas with:
    - The test name that's failing
    - The error message
    - What you've tried so far
    - Your code (if appropriate)

### Remember:

-   **Tests failing ≠ You failing** - It's feedback to help you learn!
-   **Tests are your friends** - They catch mistakes before your instructor does
-   **Green lights feel amazing** - Keep working until all tests pass!

---

## Example: Debugging a Failed Test

Let's say this test fails:

```csharp
[TestMethod]
public void Test04_CalculatesAdditionCorrectly()
{
    ProvideInput("10", "5");
    Program.Main(new string[] { });
    Assert.IsTrue(output.Contains("15"),
        "Program should display the sum of 10 and 5 (15)");
}
```

**Error message:**

```
Failed Test04_CalculatesAdditionCorrectly
  Expected: True
  Actual:   False
  Message: Program should display the sum of 10 and 5 (15)
```

**Debugging steps:**

1. The test inputs "10" and "5"
2. It expects the output to contain "15"
3. Run your program: `dotnet run`
4. Enter "10" and "5"
5. Check if "15" appears in your output
6. If not, check your addition logic
7. Make sure you're displaying the result

**Possible issues:**

-   Not reading input correctly
-   Not converting strings to numbers
-   Not performing addition
-   Not displaying the result
-   Displaying in the wrong format

---

## Test Coverage

Each assignment tests different aspects:

| Test Type   | What It Checks        | Example                      |
| ----------- | --------------------- | ---------------------------- |
| Compilation | Code compiles         | Test01_ProgramCompiles       |
| Output      | Console output        | Test02_OutputsCorrectText    |
| Input       | Reading user input    | Test03_PromptsForInput       |
| Logic       | Calculations work     | Test04_CalculatesCorrectly   |
| Edge Cases  | Handles special cases | Test08_HandlesDivisionByZero |
| Format      | Proper formatting     | Test09_FormatsWithDecimals   |
| Files       | Required files exist  | Test06_SubmissionFileExists  |

All tests must pass for full credit!
