# Automated Grading System

## Overview

This repository uses GitHub Actions to automatically test and grade student assignments when Pull Requests are created. The system detects which week's assignment to test, runs the appropriate test suite, and posts detailed feedback as a comment on the PR.

---

## Students Resource

### How to Submit an Assignment

1. **Create a branch for your assignment:**

    ```bash
    git checkout -b assignment/week-02
    ```

    - Use the format: `assignment/week-XX` where XX is the week number (01, 02, 03, etc.)
    - Example: `assignment/week-01`, `assignment/week-02`

2. **Complete your assignment:**

    - Write your code in the `starter/` folder
    - Fill out `STUDY_NOTES.md` with your reflections
    - Test locally using:
        - Mac/Linux: `./test 2`
        - Windows: `dotnet test modules\week-02-calculator-lite\tests`
    - (Replace 2 with your week number)

3. **Commit your changes:**

    ```bash
    git add .
    git commit -m "Completed Week 2: Calculator Lite"
    git push origin assignment/week-02
    ```

4. **Create a Pull Request on GitHub:**

    - Go to your repository on GitHub
    - Click "Pull requests" → "New pull request"
    - Select your branch (`assignment/week-02`) to merge into `main`
    - Title should include the week number (e.g., "Week 2: Calculator Lite")
    - Add a description of what you completed
    - Click "Create pull request"

5. **Automated testing begins:**
    - GitHub Actions will automatically run your tests
    - Wait a few minutes for results
    - Check the "Checks" tab or look for a comment on your PR

### Understanding Your Test Results

The automated grading system will post a comment on your PR that looks like this:

````markdown
## ✅ Test Results - Week 02

**Assignment:** `week-02-calculator-lite`

### 🎉 Score: 85/100

| Status    | Count |
| --------- | ----- |
| ✅ Passed | 10/12 |
| ❌ Failed | 2/12  |

### 📝 Tests that need attention:

-   Failed Test08_HandlesDivisionByZero
-   Failed Test09_FormatsOutputWithDecimals

### 💡 Next Steps:

1. Review the failed tests above
2. Run tests locally to debug:
    ```bash
    ./test 2
    ```
````

3. Make necessary corrections to your code
4. Commit and push your changes
5. Tests will automatically re-run

````

### Grade Interpretation

| Score | Emoji | Meaning |
|-------|-------|---------|
| 90-100 | 🌟 | Excellent! All or nearly all tests passed |
| 80-89 | 🎉 | Great work! Most tests passed |
| 70-79 | 👍 | Good progress! More than half passed |
| 60-69 | 📚 | Making progress, keep working |
| 0-59 | 💪 | Needs more work, don't give up! |

### Making Corrections

If tests fail:

1. **Read the error messages carefully** - They contain hints about what's wrong
2. **Test locally first:**
   ```bash
   # Mac/Linux:
   cd modules/week-XX-assignment/starter
   ../../../test XX  # Run from anywhere in the project

   # Windows:
   cd modules\week-XX-assignment\starter
   dotnet test ..\..\..\modules\week-XX-assignment\tests
````

3. **Make your corrections**
4. **Commit and push:**
    ```bash
    git add .
    git commit -m "Fixed division by zero handling"
    git push
    ```
5. **Tests automatically re-run** - The bot comment will update with new results

### Common Issues

**❓ Tests aren't running**

-   Check your branch name matches `assignment/week-XX`
-   Or ensure your PR title contains "Week X"
-   Check the "Checks" tab for error messages

**❓ Getting "Week not configured" error**

-   Make sure you're working on a week that has been released
-   Check that the week number in your branch/title is correct (01, 02, 03, etc.)

**❓ Bot comment isn't appearing**

-   Wait a few minutes - tests can take 2-5 minutes to run
-   Check the "Checks" tab to see if the workflow is still running
-   If workflow failed, there may be a configuration issue

---

## Helpful Info

### Manual Re-run

To manually re-run tests:

1. Go to the "Actions" tab in GitHub
2. Find the workflow run
3. Click "Re-run jobs"

Or you can push an empty commit:

```bash
git commit --allow-empty -m "Re-run tests"
git push
```

### Viewing Detailed Logs

1. Go to the PR
2. Click "Checks" tab
3. Click "Auto-Grade Student Submissions"
4. View step-by-step execution logs

### Comment Updates

The bot comment is automatically updated when:

-   New commits are pushed to the PR
-   Tests are re-run
-   This prevents cluttering the PR with multiple bot comments

### Grade Calculation

```
grade = (passed_tests / total_tests) × 100
```

Rounded to nearest integer.

---

## Best Practices

1. **Test locally before pushing** - Mac/Linux: `./test XX` / Windows: `dotnet test modules\week-XX-assignment\tests` to catch issues early
2. **Read error messages completely** - They contain specific hints
3. **Commit often** - Small commits are easier to debug
4. **Use descriptive commit messages** - "Fixed calculator bug" not "stuff"
5. **Don't wait until last minute** - Give yourself time to fix failing tests

---

## Examples

### Example Student Workflow

```bash
# Week 2 assignment
git checkout -b assignment/week-02

# Mac/Linux:
cd modules/week-02-calculator-lite/starter

# Windows:
cd modules\week-02-calculator-lite\starter

# Edit Program.cs
code Program.cs

# Test locally
# Mac/Linux:
../../../test 2

# Windows:
dotnet test ..\..\..\modules\week-02-calculator-lite\tests

# Commit
git add .
git commit -m "Implemented calculator operations"
git push origin assignment/week-02

# Create PR on GitHub
# Wait for automated feedback
# Make corrections if needed
# Push again to re-test
```

### Example PR Comment (All Passed)

```markdown
## ✅ Test Results - Week 02

**Assignment:** `week-02-calculator-lite`

### 🌟 Score: 100/100

| Status    | Count |
| --------- | ----- |
| ✅ Passed | 12/12 |
| ❌ Failed | 0/12  |

### 🎉 Excellent work! All tests passed!

Your assignment meets all requirements and is ready for review.

#### Next Steps:

-   Wait for instructor feedback
-   Once approved, your PR will be merged
```

### Example PR Comment (Some Failed)

````markdown
## ❌ Test Results - Week 02

**Assignment:** `week-02-calculator-lite`

### 📚 Score: 67/100

| Status    | Count |
| --------- | ----- |
| ✅ Passed | 8/12  |
| ❌ Failed | 4/12  |

### 📝 Tests that need attention:

-   Failed Test08_HandlesDivisionByZero
-   Failed Test09_FormatsOutputWithDecimals
-   Failed Test10_WorksWithDecimalInputs
-   Failed Test11_WorksWithNegativeNumbers

### 💡 Next Steps:

1. Review the failed tests above
2. Run tests locally to debug:

    ```bash
    # Mac/Linux:
    ./test 2

    # Windows:
    dotnet test modules\week-02-calculator-lite\tests
    ```
````

3. Make necessary corrections to your code
4. Commit and push your changes
5. Tests will automatically re-run

```

---

## FAQ

**Q: Can I test multiple weeks in one PR?**
A: No, each PR should contain work for only one week. The system tests based on branch name/title.

**Q: What if I want to submit early?**
A: That's great! Create your PR anytime. Tests will run immediately.

**Q: Can I see the test code?**
A: Yes, test files are in `modules/week-XX-assignment/tests/` folder.

**Q: Do I need to pass all tests to get credit?**
A: Your grade is based on the percentage of tests passed. Aim for 100%!

**Q: How many times can I resubmit?**
A: Unlimited! Push corrections as many times as needed.

**Q: What if tests fail due to a bug in the test itself?**
A: Contact your instructor. They can review and fix test issues.

**Q: Can I work on multiple weeks at once?**
A: Yes, but create separate branches: `assignment/week-01`, `assignment/week-02`, etc.

**Q: What happens after all tests pass?**
A: Your instructor will review your code and STUDY_NOTES, then merge your PR.

---

## Support

If you encounter issues with the automated grading system:

- Check the troubleshooting section above
- Review your branch name and PR title
- Look at the "Checks" tab for detailed error messages
- Ask on the course discussion board
- Contact your instructor

---
```
