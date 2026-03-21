/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: YourName
 * Assignment: Week 10: Habit Tracker (File I/O)
 *
 * What does this program do?:
 * Tests the Week 10 Habit Tracker assignment requirements.
 * ******************************************************************************/

using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HabitTracker.Tests;

[TestClass]
public class HabitTrackerTests
{
    private StringWriter _output;
    private TextWriter _originalOutput;

    // Temp file created fresh for each test
    private string _tempPath;

    [TestInitialize]
    public void Setup()
    {
        _output = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_output);

        // GetTempFileName creates an empty file in the system temp folder
        _tempPath = Path.GetTempFileName();
    }

    [TestCleanup]
    public void Cleanup()
    {
        Console.SetOut(_originalOutput);
        _output.Dispose();

        if (File.Exists(_tempPath)) File.Delete(_tempPath);
    }

    /// <summary>
    /// Injects all the given strings as simulated console input,
    /// each on its own line (as if the user pressed Enter after each).
    /// </summary>
    private void ProvideInput(params string[] inputs)
    {
        StringReader input = new StringReader(string.Join(Environment.NewLine, inputs));
        Console.SetIn(input);
    }

    // ───────────────────────────────────────────────────────────────────
    // Test01 — Compilation (5 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test01_ProgramCompiles()
    {
        Assert.IsTrue(true, "✅ Project compiled successfully");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test02 — Habits load from CSV and display (15 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test02_HabitsLoadAndDisplay()
    {
        File.WriteAllText(_tempPath, "Exercise,done,daily\nMeditate,pending,daily\nDrink Water,done,weekly\n");

        // Sequence: file path → menu 1 (View Habits) → menu 5 (Save & Quit)
        ProvideInput(_tempPath, "1", "5");

        Program.Main(Array.Empty<string>());

        string output = _output.ToString();

        bool hasHeader = output.Contains("=== Habit Tracker: File I/O ===");
        bool hasPathPrompt = output.ToLower().Contains("enter habits file path");
        bool hasHabitsHeader = output.Contains("--- Your Habits ---");
        bool hasHabits = output.Contains("Exercise") && output.Contains("Meditate") && output.Contains("Drink Water");
        bool hasFrequency = output.Contains("(daily)") || output.Contains("(weekly)");

        Assert.IsTrue(
            hasHeader && hasPathPrompt && hasHabitsHeader && hasHabits && hasFrequency,
            "❌ Missing expected output sections\n" +
            "💡 Tip: Make sure LoadHabits reads the file and PrintHabits shows '--- Your Habits ---'\n" +
            "   Habits should display with their frequency, e.g. '[x] Exercise (daily)'\n" +
            $"Actual output:\n{output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test03 — FileNotFoundException handled gracefully (10 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test03_FileNotFoundHandledGracefully()
    {
        string fakePath = Path.Combine(Path.GetTempPath(), "does_not_exist_ht_w10.csv");
        if (File.Exists(fakePath)) File.Delete(fakePath);

        ProvideInput(fakePath, "5");

        // Should NOT throw — exception must be caught inside LoadHabits
        Program.Main(Array.Empty<string>());

        // Save & Quit will create the file (empty habits list); clean it up
        if (File.Exists(fakePath)) File.Delete(fakePath);

        string output = _output.ToString();

        Assert.IsTrue(
            output.Contains("Error: File not found"),
            "❌ Missing error message for missing file\n" +
            "💡 Tip: Catch FileNotFoundException and print: Error: File not found — {path}\n" +
            $"Actual output:\n{output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test04 — Display format: [x] and [ ] markers (5 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test04_DisplayMarkersAreCorrect()
    {
        File.WriteAllText(_tempPath, "Run,done,daily\nJournal,pending,weekly\nStretch,done,daily\n");

        ProvideInput(_tempPath, "1", "5");

        Program.Main(Array.Empty<string>());

        string output = _output.ToString();

        bool doneMarkers = output.Contains("[x] Run") && output.Contains("[x] Stretch");
        bool pendingMarker = output.Contains("[ ] Journal");
        bool hasFrequency = output.Contains("(daily)") && output.Contains("(weekly)");

        Assert.IsTrue(
            doneMarkers && pendingMarker && hasFrequency,
            "❌ Display markers or frequency labels are incorrect\n" +
            "💡 Tip: DisplayInfo() should print '[x] Name (frequency)' for completed\n" +
            "   and '[ ] Name (frequency)' for pending habits\n" +
            $"Actual output:\n{output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test05 — Summary LINQ values (10 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test05_SummaryValuesCorrect()
    {
        // 4 daily habits (3 done, 1 pending) + 1 weekly habit (1 done)
        // Daily: 3/4 completed (75.0%),  Weekly: 1/1 completed (100.0%)
        File.WriteAllText(
            _tempPath,
            "Exercise,done,daily\nMeditate,pending,daily\nRead,done,daily\nJournal,done,daily\nDrink Water,done,weekly\n");

        ProvideInput(_tempPath, "2", "5");

        Program.Main(Array.Empty<string>());

        string output = _output.ToString();

        bool hasSummaryHeader = output.Contains("--- Summary ---");
        bool hasDailyLine = output.Contains("Daily:");
        bool hasWeeklyLine = output.Contains("Weekly:");

        Assert.IsTrue(
            hasSummaryHeader && hasDailyLine && hasWeeklyLine,
            "❌ Summary is missing expected sections\n" +
            "💡 Tip: PrintSummary should print a 'Daily:' line and a 'Weekly:' line\n" +
            "   Use habits.Count(h => h.Frequency == \"daily\") to count per group\n" +
            $"Actual output:\n{output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test06 — Completion rate formatted to one decimal place (5 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test06_SummaryRateFormattedCorrectly()
    {
        // 3 daily done out of 4 daily total → daily rate must appear as "75.0%"
        // 1 weekly done out of 1 weekly total → weekly rate must appear as "100.0%"
        File.WriteAllText(
            _tempPath,
            "Exercise,done,daily\nMeditate,pending,daily\nRead,done,daily\nJournal,done,daily\nDrink Water,done,weekly\n");

        ProvideInput(_tempPath, "2", "5");

        Program.Main(Array.Empty<string>());

        string output = _output.ToString();

        Assert.IsTrue(
            output.Contains("75.0%") && output.Contains("100.0%"),
            "❌ Rates are not formatted to one decimal place\n" +
            "💡 Tip: Format rates with rate.ToString(\"F1\", CultureInfo.InvariantCulture)\n" +
            "   Daily (3/4) should show '75.0%' and Weekly (1/1) should show '100.0%'\n" +
            $"Actual output:\n{output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test07 — Add a new habit (15 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test07_AddHabit()
    {
        File.WriteAllText(_tempPath, "Exercise,done,daily\n");

        // Menu: 3 (Add Habit), "Morning Walk", "D" (daily), 1 (View Habits to confirm), 5 (Save & Quit)
        ProvideInput(_tempPath, "3", "Morning Walk", "D", "1", "5");

        Program.Main(Array.Empty<string>());

        string output = _output.ToString();

        bool hasAddedMsg = output.Contains("Added: Morning Walk (daily)");
        bool appearsInView = output.Contains("[ ] Morning Walk (daily)");

        Assert.IsTrue(
            hasAddedMsg && appearsInView,
            "❌ Habit was not added or not displayed correctly\n" +
            "💡 Tip: After reading the name, prompt for frequency: 'D' → \"daily\", 'W' → \"weekly\"\n" +
            "   Create new Habit(name, false, frequency) and print 'Added: {name} ({frequency})'\n" +
            "   New habits start incomplete, so the marker should be '[ ]'\n" +
            $"Actual output:\n{output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test08 — Update a habit: rename and toggle (15 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test08_UpdateHabit_RenameAndToggle()
    {
        // Exercise starts as done (IsCompleted = true)
        File.WriteAllText(_tempPath, "Exercise,done,daily\nMeditate,pending,weekly\n");

        // Menu: 4 (Update Habit), pick 1 (Exercise), rename to "Morning Run",
        //       1 (View to confirm), 5 (Save & Quit)
        ProvideInput(_tempPath, "4", "1", "Morning Run", "1", "5");

        Program.Main(Array.Empty<string>());

        string output = _output.ToString();

        // After rename + toggle: was done (true) → now pending (false)
        bool hasUpdateMsg = output.Contains("Updated: Morning Run") && output.Contains("now pending");
        bool appearsInView = output.Contains("[ ] Morning Run");

        Assert.IsTrue(
            hasUpdateMsg && appearsInView,
            "❌ Habit was not updated correctly\n" +
            "💡 Tip: Set habit.Name = newName (if non-empty), then toggle habit.IsCompleted = !habit.IsCompleted\n" +
            "   A habit that was 'done' (true) should become 'pending' (false) after toggling\n" +
            $"Actual output:\n{output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test09 — Save writes correct CSV content (15 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test09_SaveWritesCorrectCsvContent()
    {
        File.WriteAllText(_tempPath, "Exercise,done,daily\nMeditate,pending,weekly\n");

        // Add a new habit, then save and quit
        // Menu: 3 (Add Habit), "Yoga", "D" (daily), 5 (Save & Quit)
        ProvideInput(_tempPath, "3", "Yoga", "D", "5");

        Program.Main(Array.Empty<string>());

        string savedContent = File.ReadAllText(_tempPath);

        bool hasSaveMsg = _output.ToString().Contains($"Habits saved to {_tempPath}");
        bool hasExercise = savedContent.Contains("Exercise,done,daily");
        bool hasMeditate = savedContent.Contains("Meditate,pending,weekly");
        bool hasYoga = savedContent.Contains("Yoga,pending,daily");

        Assert.IsTrue(
            hasSaveMsg && hasExercise && hasMeditate && hasYoga,
            "❌ SaveHabits did not write the correct CSV content\n" +
            "💡 Tip: Each CSV line should be 'Name,Status,Frequency' (3 columns)\n" +
            "   Use: habits.Select(h => $\"{h.Name},{(h.IsCompleted ? \"done\" : \"pending\")},{h.Frequency}\").ToArray()\n" +
            $"File content:\n{savedContent}\n" +
            $"Program output:\n{_output}");
    }

    // ───────────────────────────────────────────────────────────────────
    // Test10 — STUDY_NOTES.md exists and is completed (5 pts)
    // ───────────────────────────────────────────────────────────────────

    [TestMethod]
    public void Test10_StudyNotesExistsAndIsCompleted()
    {
        string testDir = Path.GetDirectoryName(typeof(HabitTrackerTests).Assembly.Location);
        string studyNotesPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        studyNotesPath = Path.GetFullPath(studyNotesPath);

        bool fileExists = File.Exists(studyNotesPath);

        Assert.IsTrue(
            fileExists,
            "\n❌ STUDY_NOTES.md not found!\n" +
            "📝 The file should exist in the starter folder\n" +
            $"💡 Location: modules/week-10-file-io/starter/STUDY_NOTES.md\n" +
            $"Looked here: {studyNotesPath}");

        string content = File.ReadAllText(studyNotesPath);

        bool hasName = Regex.IsMatch(content, @"\*\*Name:\*\*\s+\S");
        bool hasAnswers = Regex.Matches(content, @"Answer:\s*\S").Count >= 4;

        Assert.IsTrue(
            hasName && hasAnswers,
            "❌ STUDY_NOTES.md appears incomplete\n" +
            "💡 Tip: Fill in your name after '**Name:**' and answer at least 4 of the prompts\n" +
            $"File path: {studyNotesPath}");
    }
}

