# 🧪 Testing Quick Reference

## Run Tests - Simple Command Line

### From Project Root (Recommended) ⭐

From the **top-level project directory** (`DEV-110---Introduction-to-Programming-C---W26/`):

```bash
# Mac/Linux:
./test 1        # Test Week 1
./test 2        # Test Week 2
./test 3        # Test Week 3
./test all      # Test everything

# Windows:
dotnet test modules\week-01-hello-github\tests
dotnet test modules\week-02-calculator-lite\tests
dotnet test modules\week-03-profile-card\tests
# etc.
```

**What you get:**

-   ✅/❌ Clear pass/fail indicators
-   🎨 Color-coded output
-   💡 Helpful tips for fixing failures
-   Clean output with no confusing build messages
-   Blank lines between each test for easy reading

**Flexible syntax:**

```bash
./test 1           # Short form
./test week-1      # With 'week-'
./test week-01     # Padded numbers
```

---

## From Within a Module Directory

### If You're in a Starter Folder

From `modules/week-XX-assignment/starter/`:

```bash
# Mac/Linux - Using the test script:
../../../test 1

# Using dotnet directly (works on all platforms):
# Mac/Linux:
dotnet test ../tests

# Windows:
dotnet test ..\tests
```

### If You're in a Module Folder

From `modules/week-XX-assignment/`:

```bash
# Mac/Linux - Using the test script:
../../test 1

# Using dotnet directly (works on all platforms):
dotnet test tests
```

---

## Using VS Code Terminal

Open the integrated terminal in VS Code:

-   Press `` Ctrl+` `` (backtick) or select `View` → `Terminal`
-   **Make sure you're in the project root directory** (`DEV-110---Introduction-to-Programming-C---W26/`)
-   Run the test commands:

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

**If your terminal opens in a subdirectory:**

```bash
# Navigate to project root first
# Mac/Linux:
cd ~/DEV-110---Introduction-to-Programming-C---W26

# Windows:
cd C:\Users\YourUsername\DEV-110---Introduction-to-Programming-C---W26

# Then run tests
# Mac/Linux:
./test 1

# Windows:
dotnet test modules\week-01-hello-github\tests
```

---

## Understanding Test Output

### ✅ Green Checkmark = PASSED

Your code works correctly for this test!

### ❌ Red X = FAILED

Read the message below it for hints on what to fix:

```
❌ TEST 2: Program Outputs Hello Git Hub
  Error Message:
   ❌ Expected: 'Hello, GitHub!'
   ✏️ Your output: ''
   💡 Tip: Use Console.WriteLine("Hello, GitHub!");
```

**How to fix:**

1. Look at "Your output" - what did your code print?
2. Compare to "Expected" - what should it print?
3. Read the 💡 Tip - specific code to try

---

## Common Test Commands

**From project root (`DEV-110---Introduction-to-Programming-C---W26/`):**

```bash
# Mac/Linux:
./test          # See help and available options
./test 1        # Test your current week's assignment
./test 2        # Test a different week
./test all      # Check all your completed work

# Windows:
dotnet test modules\week-01-hello-github\tests
dotnet test modules\week-02-calculator-lite\tests
# etc.
```

**From a starter folder (`modules/week-XX-assignment/starter/`):**

```bash
# Mac/Linux - Using test script:
../../../test 1

# Using dotnet (works on all platforms):
# Mac/Linux:
dotnet test ../tests

# Windows:
dotnet test ..\tests

# Run your program (without tests) - works on all platforms:
dotnet run
```

**From a module folder (`modules/week-XX-assignment/`):**

```bash
# Mac/Linux - Using test script:
../../test 1

# Using dotnet (works on all platforms):
dotnet test tests
```

---

## Tips for Success

1. **Run tests often** - Don't wait until you think you're done
2. **Read the tips** - They contain actual code you can use
3. **Fix one test at a time** - Start with Test 1, then Test 2, etc.
4. **Check your spelling** - Tests look for exact matches
5. **Watch for capitalization** - "hello" ≠ "Hello"

---

## Still Stuck?

1. Read the error message completely
2. Check [docs/FAQ.md](FAQ.md) for common issues
3. Look at the assignment README in the module folder
4. Ask on Canvas discussion board
5. Come to office hours
