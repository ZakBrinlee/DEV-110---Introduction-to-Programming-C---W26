# DEV 110 - Development Environment Setup Guide

## Required Software

### 1. .NET 9.0 SDK

**Download:** https://dotnet.microsoft.com/download/dotnet/9.0

**Verify installation:**

```bash
dotnet --version
```

Should show: `9.0.x`

### 2. Visual Studio Code

**Download:** https://code.visualstudio.com/

### 3. VS Code Extensions

Open VS Code and install these extensions:

-   **C# Dev Kit** (ms-dotnettools.csdevkit)
-   **C#** (ms-dotnettools.csharp)
-   **EditorConfig for VS Code** (editorconfig.editorconfig)

### 4. Git & GitHub

**Git Download:** https://git-scm.com/downloads

**GitHub Account:** https://github.com/signup

**Verify Git installation:**

```bash
git --version
```

---

## Initial Repository Setup

### Step 1: Fork the Repository

1. Go to the course repository on GitHub
2. Click the **Fork** button in the upper right
3. This creates your personal copy of the repository

### Step 2: Enable GitHub Actions

**Important:** GitHub disables Actions in forked repositories by default.

1. Go to your forked repository on GitHub
2. Click on the **Actions** tab at the top
3. Click the green button: **"I understand my workflows, go ahead and enable them"**
4. Your automated tests and code quality checks will now run on pull requests

### Step 3: Clone Your Fork

```bash
git clone https://github.com/<your-username>/DEV-110---Introduction-to-Programming-C---W26.git
cd DEV-110---Introduction-to-Programming-C---W26
```

Replace `<your-username>` with your GitHub username.

### Step 4: Configure Git

```bash
# Set your name and email (if not already configured)
git config --global user.name "Your Name"
git config --global user.email "your-email@example.com"

# Add upstream remote to get future updates
git remote add upstream <your-respository-url>
```

### Step 5: Test Your Setup

```bash
# Mac/Linux:
cd modules/week-01-hello-github/starter

# Windows:
cd modules\week-01-hello-github\starter

dotnet runmain and up to date
git checkout main
git pull origin main

# Get any updates from instructor (if available)
git fetch upstream
git merge upstream/main

# Create a new branch for this week's work
git checkout -b assignment/week-01
# or: git checkout -b lab/week-01
```

### Working on Code

```bash
# Navigate to the module
# Mac/Linux:
cd modules/week-01-hello-github/starter

# Windows:
cd modules\week-01-hello-github\starter

# Open in VS Code
code .

# Run your program
dotnet run
```

### Running Tests

**Option 1: From project root (Recommended)**

From the top-level `DEV-110---Introduction-to-Programming-C---W26/` directory:

```bash
# Mac/Linux:
./test 1           # or ./test week-1 or ./test week-01
./test all         # Test all weeks

# Windows (use dotnet test directly):
dotnet test modules\week-01-hello-github\tests
dotnet test modules\week-02-calculator-lite\tests
# etc.
```

**Option 2: From within a module's starter folder**

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

**Option 3: From within a module folder**

From `modules/week-XX-assignment/`:

```bash
# Mac/Linux - Using the test script:
../../test 1

# Using dotnet directly (works on all platforms):
dotnet test tests
```

**Option 4: In VS Code Terminal**

Open terminal with `` Ctrl+` `` (or `View` → `Terminal`), then navigate to project root:

```bash
# Navigate to project root if not already there
# Mac/Linux:
cd ~/DEV-110---Introduction-to-Programming-C---W26

# Windows:
cd C:\Users\YourUsername\DEV-110---Introduction-to-Programming-C---W26

# Then run tests
# Mac/Linux:
./test 1           # Test Week 1
./test 2           # Test Week 2
./test all         # Test all weeks

# Windows:
dotnet test modules\week-01-hello-github\tests
dotnet test modules\week-02-calculator-lite\tests
# etc.
```

### Submitting Your Work

```bash
# Stage your changes
git add .

# Commit with a descriptive message
git commit -m "Completed Week 1: Hello GitHub assignment"

# Push to your fork on GitHub
git push origin assignment/week-01

# Create Pull Request on GitHub:
# 1. Go to your repository on GitHub
# 2. Click "Compare & pull request"
# 3. Set base: main (your fork) <- compare: assignment/week-01
# 4. Add a description of your work
# 5. Submit the pull request
```

**Important:** Create the pull request to your own `main` branch, not the instructor's repository. The instructor will review your PR in your fork.

```bash
# Stage your changes
git add .

# Commit with a descriptive message
git commit -m "Completed Week X assignment"

# Push to GitHub
git push origin student/<your-name>

# Create Pull Request on GitHub
```

---

## Common Issues

### "dotnet: command not found"

-   Restart your terminal after installing .NET
-   On Mac: Close and reopen Terminal completely
-   On Windows: Restart Command Prompt or PowerShell

### "Unable to find project"

-   Make sure you're in the correct directory
-   Use `pwd` (Mac/Linux) or `cd` (Windows) to check current directory
-   Navigate to the correct folder before running tests

### "Git Push Rejected (Branch Issues)"

```bash
# Make sure you're on the correct branch
git checkout assignment/week-XX

# Or if you need to sync with main first:
git checkout main
git pull origin main
git checkout assignment/week-XX
git merge main

# Then push again
git push origin assignment/week-XX
```

### Tests Won't Run

```bash
# Restore dependencies first
dotnet restore
dotnet build
dotnet test
```

### Format Check Fails

```bash
# Auto-fix formatting
dotnet format
```

### Git Push Rejected

```bash
# Pull latest changes first
git pull origin student/<your-name>

# Then push again
git push origin student/<your-name>
```

---

## Getting Help

1. **Check the FAQ:** `docs/FAQ.md`
2. **Canvas Discussion Board**
3. **Office Hours**
4. **GitHub Issues** (for technical problems)

---

## Tips for Success

✅ **Format your code often:** Press `Shift+Option+F` (Mac) or `Shift+Alt+F` (Windows)

✅ **Save frequently:** Auto-save is enabled, but use `Cmd+S` / `Ctrl+S` often

✅ **Run tests early and often:** Don't wait until you think you're done

✅ **Commit small changes:** Better to have many small commits than one giant one

✅ **Read error messages carefully:** They tell you exactly what's wrong

---

## Keyboard Shortcuts (VS Code)

### Essential Shortcuts

-   **Run Program:** `Ctrl+F5` (Run without debugging)
-   **Format Document:** `Shift+Option+F` (Mac) or `Shift+Alt+F` (Windows)
-   **Save:** `Cmd+S` (Mac) or `Ctrl+S` (Windows)
-   **Toggle Terminal:** `` Ctrl+` ``
-   **Command Palette:** `Cmd+Shift+P` (Mac) or `Ctrl+Shift+P` (Windows)

### Helpful Shortcuts

-   **Go to File:** `Cmd+P` (Mac) or `Ctrl+P` (Windows)
-   **Find in File:** `Cmd+F` (Mac) or `Ctrl+F` (Windows)
-   **Replace:** `Cmd+H` (Mac) or `Ctrl+H` (Windows)
-   **Comment Line:** `Cmd+/` (Mac) or `Ctrl+/` (Windows)
