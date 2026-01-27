# DEV 110 - Introduction to Programming with C#

Welcome to DEV 110! This repository contains all course materials, assignments, and resources for learning C# programming.

## 📚 Course Structure

This course is organized into 12 weekly modules, each building on the previous week's concepts:

| Week | Topic                              | Assignment                                              |
| ---- | ---------------------------------- | ------------------------------------------------------- |
| 1    | Dev Workflow + Git/GitHub          | [Hello, GitHub](modules/week-01-hello-github/)          |
| 2    | C# Basics: Types, Expressions, I/O | [Calculator Lite](modules/week-02-calculator-lite/)     |
| 3    | Variables + Data Modeling          | [Profile Card Generator](modules/week-03-profile-card/) |
| 4    | Decisions: If/Else Logic           | Grade/Budget Tracker _(Coming Soon)_                    |
| 5    | Loops: Repetition + Validation     | Choose-Your-Path _(Coming Soon)_                        |
| 6    | Strings + Console Output Patterns  | Guess the Number _(Coming Soon)_                        |
| 7    | Arrays: Collections + Indexing     | Text Menu App _(Coming Soon)_                           |
| 8    | Program Structure + Debugging      | Class Roster Stats _(Coming Soon)_                      |
| 9    | Methods: Decomposition + Reuse     | Methods Refactor _(Coming Soon)_                        |
| 10   | Windows Forms: Events + UI         | First GUI App _(Coming Soon)_                           |
| 11   | Methods + Validation               | GUI Upgrade _(Coming Soon)_                             |
| 12   | Final Project                      | TBD                                                     |

---

## 🚀 Getting Started

### First-Time Setup

1. **Install Required Software** (see [Setup Guide](docs/SETUP.md))

    - .NET 9.0 SDK
    - Visual Studio Code
    - Git
    - Required VS Code extensions

2. **Fork and Clone This Repository**

    ```bash
    # Fork on GitHub, then clone your fork
    git clone https://github.com/<your-username>/DEV-110---Introduction-to-Programming-C---W26.git
    cd DEV-110---Introduction-to-Programming-C---W26
    ```

3. **Test Your Setup**

    ```bash
    # Quick test
    # Mac/Linux:
    ./test 1

    # Windows:
    dotnet test modules\week-01-hello-github\tests

    # Or navigate to a module
    # Mac/Linux:
    cd modules/week-01-hello-github/starter

    # Windows:
    cd modules\week-01-hello-github\starter

    dotnet run
    ```

---

## 📖 Weekly Workflow

### Starting an Assignment

1. Navigate to the week's module folder
2. Read the `README.md` for instructions
3. Work in the `starter/` folder
4. Run tests often:
    - Mac/Linux: `dotnet test ../tests`
    - Windows: `dotnet test ..\tests`

### Submitting Your Work

1. Commit your changes: `git add . && git commit -m "Completed Week X"`
2. Push to GitHub: `git push origin student/<your-name>`
3. Create a Pull Request on GitHub
4. Check automated test results

---

## 🧪 Testing Your Code

Each assignment includes automated tests that run:

-   **Locally:** When you run `./test <week>`
-   **On GitHub:** Automatically when you push code

### Quick Test Commands

```bash
# Test any week (from project root)
# Mac/Linux:
./test 1        # Test Week 1
./test 2        # Test Week 2
./test all      # Test all weeks

# Windows:
dotnet test modules\week-01-hello-github\tests
dotnet test modules\week-02-calculator-lite\tests
# etc.

# Or from within a module
# Mac/Linux:
cd modules/week-01-hello-github/starter
bash ../../run-tests.sh ../tests

# Windows:
cd modules\week-01-hello-github\starter
dotnet test ..\tests
```

**Features:**

-   ✅/❌ Clear visual indicators
-   💡 Helpful tips for fixing failures
-   🎨 Color-coded output
-   Filters out confusing build messages

See [Testing Quick Reference](docs/TESTING_QUICK_REFERENCE.md) for more details.

---

## 📝 Code Style & Formatting

This repository uses automated code formatting and linting:

### Auto-Format Your Code

```bash
# Format all files
dotnet format

# Check formatting without changing files
dotnet format --verify-no-changes
```

### In VS Code

-   **Format on Save** is enabled automatically
-   **Manual Format:** `Shift+Option+F` (Mac) or `Shift+Alt+F` (Windows)

See [Style Guide](docs/STYLE_GUIDE.md) for detailed style rules.

---

## 📁 Repository Structure

```
DEV-110---Introduction-to-Programming-C---W26/
├── .github/workflows/     # Automated grading & CI/CD
├── .vscode/              # VS Code settings
├── docs/                 # Course documentation
│   ├── SETUP.md         # Setup instructions
│   ├── STYLE_GUIDE.md   # Code style guidelines
│   ├── TESTING_GUIDE.md # Testing documentation
│   └── FAQ.md           # Frequently asked questions
├── modules/             # Weekly assignments
│   ├── week-01-hello-github/
│   │   ├── starter/    # Your code goes here
│   │   ├── tests/      # Automated tests
│   │   ├── solution/   # Instructor solution (reference)
│   │   └── README.md   # Assignment instructions
│   ├── week-02-profile-card/
│   └── ...
├── .editorconfig        # Code formatting rules
├── .gitignore          # Files to ignore in Git
├── Directory.Build.props # Project-wide settings
└── README.md           # This file
```

---

## 🆘 Getting Help

### Resources

-   **[Setup Guide](docs/SETUP.md)** - Installation and configuration
-   **[Style Guide](docs/STYLE_GUIDE.md)** - Code formatting standards
-   **[Testing Guide](docs/TESTING_GUIDE.md)** - Understanding and running tests
-   **[FAQ](docs/FAQ.md)** - Common questions and solutions

### Support Channels

1. **Canvas Discussion Board** - Ask questions, help classmates
2. **Office Hours** - Get live help from instructor/TAs
3. **GitHub Issues** - Report technical problems with the repository
4. **Email** - Private questions or concerns

---

## ✅ Quick Tips

-   💾 **Commit often** - Small, frequent commits are better than large ones
-   🧪 **Test early** - Run tests as you code, not just at the end
-   📝 **Read errors** - Error messages tell you exactly what's wrong
-   🎨 **Format code** - Run `dotnet format` before committing
-   🔍 **Use the debugger** - Step through code to understand what's happening
-   📖 **Read docs** - Assignment READMEs have everything you need
-   🤝 **Ask for help** - Don't struggle alone - use discussion boards!

---

## 🎯 Grading

Assignments are graded automatically based on:

1. **Functionality (70-80%)** - Does your code work correctly?
2. **Code Quality (10-20%)** - Is your code well-formatted and readable?
3. **Testing (10%)** - Do all tests pass?

View your results in:

-   GitHub Actions (click the ✅ or ❌ on your commit)
-   Your Pull Request page
-   The "Actions" tab in your repository

---

## 🏆 Course Goals

By the end of this course, you will be able to:

-   ✅ Write, compile, and debug C# programs
-   ✅ Use variables, data types, and operators
-   ✅ Implement decision-making and loops
-   ✅ Work with arrays and collections
-   ✅ Create and use methods
-   ✅ Build simple GUI applications
-   ✅ Use Git for version control
-   ✅ Read and write clean, maintainable code

---

## 📜 License & Academic Integrity

-   **Code:** Your code is your own. Follow the academic integrity policy in the syllabus.
-   **Repository Structure:** Course materials are provided for educational purposes.
-   **Collaboration:** Discuss ideas, but write your own code.

---

## 🎓 About This Course

**Course:** DEV 110 - Introduction to Programming with C#

**Instructor:** Zak Brinlee

**Term:** Winter 2026

**Questions?** Check the [FAQ](docs/FAQ.md) or post on Canvas!
