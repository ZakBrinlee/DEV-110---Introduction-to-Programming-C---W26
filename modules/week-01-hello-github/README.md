# Week 1: Hello GitHub

## Learning Objectives

-   Set up your development environment (VS Code, .NET SDK, Git)
-   Create and run your first C# program
-   Understand the Git workflow: clone, commit, push
-   Write a basic README documenting your setup experience

---

## Assignment: "Hello, GitHub"

### Requirements

1. **Install Required Software**

    - .NET 8.0 SDK
    - Visual Studio Code
    - Git
    - Required VS Code extensions (see `docs/SETUP.md`)

2. **Complete the Program**

    - Modify `Program.cs` to output "Hello, GitHub!" to the console
    - Run the program and verify it works

3. **Complete the STUDY_NOTES.md**

    - Fill out all sections in `STUDY_NOTES.md`
    - Document what you installed and any issues encountered
    - Reflect on what you learned
    - Include time spent on each part

4. **Submit via Git (Week 1 Only: Push to `main`)**
    - **Note:** This is the ONLY week you'll push directly to `main`
    - Starting Week 2, you'll create branches and pull requests
    - Commit your changes with a descriptive message
    - Push directly to the `main` branch on GitHub

---

## Getting Started

### Step 1: Navigate to This Module

```bash
# Mac/Linux:
cd modules/week-01-hello-github/starter

# Windows:
cd modules\week-01-hello-github\starter
```

### Step 2: Run the Starter Code

```bash
dotnet run
```

**Expected Output:** (Initially nothing, you'll add the code)

### Step 3: Complete the TODO

Open `Program.cs` and add code to print "Hello, GitHub!"

**Hint:** Use `Console.WriteLine("your message here");`

### Step 4: Test Your Work

```bash
# Run the program
dotnet run

# Run the automated tests
# Mac/Linux:
dotnet test ../tests

# Windows:
dotnet test ..\tests
```

### Step 5: Complete STUDY_NOTES.md

Open `STUDY_NOTES.md` in the `starter/` folder and fill out:

-   **Development Environment Setup:** Software installed and versions
-   **Challenges and Solutions:** Problems encountered and how you solved them
-   **Understanding C# Basics:** Answer questions about `Console.WriteLine()`, `Program.cs`, and `dotnet run`
-   **Git Workflow Understanding:** Explain basic Git commands
-   **What I Learned:** Key takeaways and time breakdown

---

## Grading Criteria

| Criteria                                   | Points  |
| ------------------------------------------ | ------- |
| Program outputs "Hello, GitHub!" exactly   | 40      |
| STUDY_NOTES.md completed with all sections | 30      |
| Code committed with descriptive message    | 15      |
| Changes pushed to main branch on GitHub    | 15      |
| **Total**                                  | **100** |

---

## Completing STUDY_NOTES.md

The `STUDY_NOTES.md` file contains prompts to help you reflect on your learning. Be thorough and honest:

**Development Environment Setup:**

-   List exact versions (e.g., .NET SDK 9.0.100)
-   Include your operating system

**Challenges and Solutions:**

-   Don't just say "no issues" - everyone encounters something!
-   Common issues: terminal not recognizing commands, installation paths, VS Code extensions

**Understanding C# Basics:**

-   Answer in your own words - this shows you understand, not just copy
-   Examples are helpful!

**Time Tracking:**

-   Be realistic about time spent
-   This helps you (and me) understand the learning curve

---

## Resources

-   [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
-   [Git Basics](https://git-scm.com/book/en/v2/Getting-Started-Git-Basics)
-   [VS Code Keyboard Shortcuts](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf)

---

## Next Steps

After completing this assignment:

1. Review the feedback from GitHub Actions
2. Make any requested changes
3. **Begin Week 2: Calculator Lite**
    - Starting Week 2, you'll use a branch workflow
    - Create a branch named `assignment/week-02`
    - Submit via Pull Request (not direct push)

```

```
