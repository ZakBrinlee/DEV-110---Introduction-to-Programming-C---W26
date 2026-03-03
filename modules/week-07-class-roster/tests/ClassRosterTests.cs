/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Tests the Week 7 class roster assignment requirements.
- */

using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassRoster.Tests;

[TestClass]
public class ClassRosterTests
{
    private StringWriter _output;
    private TextWriter _originalOutput;

    [TestInitialize]
    public void Setup()
    {
        _output = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_output);
    }

    [TestCleanup]
    public void Cleanup()
    {
        Console.SetOut(_originalOutput);
        _output.Dispose();
    }

    private void ProvideInput(params string[] inputs)
    {
        var input = new StringReader(string.Join(Environment.NewLine, inputs));
        Console.SetIn(input);
    }

    private static string? FindLineContaining(string text, string token)
    {
        string[] lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].IndexOf(token, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return lines[i];
            }
        }

        return null;
    }

    private static string GetSectionAfter(string text, string marker)
    {
        int index = text.IndexOf(marker, StringComparison.OrdinalIgnoreCase);
        if (index < 0)
        {
            return string.Empty;
        }

        return text.Substring(index + marker.Length);
    }

    private static int CountMatches(string input, string pattern)
    {
        return Regex.Matches(input, pattern, RegexOptions.IgnoreCase).Count;
    }

    [TestMethod]
    public void Test01_ProgramCompiles()
    {
        Assert.IsTrue(true, "✅ Project compiled successfully");
    }

    [TestMethod]
    public void Test02_MenuRepeatsAndExitWorks()
    {
        ProvideInput(
            "2", // print roster (empty)
            "4"  // exit
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString();
        string outputLower = output.ToLower();

        int chooseCount = CountMatches(outputLower, "choose an option");
        bool hasMenu = outputLower.Contains("1) add multiple") &&
                      outputLower.Contains("2) print class roster") &&
                      outputLower.Contains("3) print roster") &&
                      outputLower.Contains("4) exit");
        bool hasGoodbye = outputLower.Contains("goodbye.");

        Assert.IsTrue(
            chooseCount >= 2 && hasMenu && hasGoodbye,
            "❌ Menu loop or exit behavior missing\n" +
            "💡 Tip: Use a while loop and print the menu each time"
        );
    }

    [TestMethod]
    public void Test03_PrintRoster_WhenEmpty_ShowsEmptyMessage()
    {
        ProvideInput(
            "2",
            "4"
        );

        Program.Main(Array.Empty<string>());
        string outputLower = _output.ToString().ToLower();

        bool hasEmpty = outputLower.Contains("roster is empty");

        Assert.IsTrue(
            hasEmpty,
            "❌ Empty roster message missing\n" +
            "💡 Tip: If count is 0, print 'Roster is empty.'"
        );
    }

    [TestMethod]
    public void Test04_AddMultipleStudents_ThenPrintRoster_ShowsNameAndCredits()
    {
        ProvideInput(
            "1", "2",                 // add multiple, choose 2
            "Ada", "12",
            "Alan", "45",
            "2",                    // print roster
            "4"
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString();

        bool hasAdaLine = Regex.IsMatch(output, @"ada[\s\S]*12", RegexOptions.IgnoreCase);
        bool hasAlanLine = Regex.IsMatch(output, @"alan[\s\S]*45", RegexOptions.IgnoreCase);
        bool hasStudentsAdded = output.IndexOf("students added", StringComparison.OrdinalIgnoreCase) >= 0;

        Assert.IsTrue(
            hasAdaLine && hasAlanLine && hasStudentsAdded,
            "❌ Add/Print behavior missing\n" +
            "💡 Tip: Add 1–3 students (name + credits), then print the roster"
        );
    }

    [TestMethod]
    public void Test05_RosterCapacity_IsEnforced()
    {
        ProvideInput(
            "1", "3",          // add multiple, choose 3
            "Ada", "10",
            "Bob", "20",
            "Cara", "30",
            "1",               // attempt to add again
            "4"
        );

        Program.Main(Array.Empty<string>());
        string outputLower = _output.ToString().ToLower();

        bool hasFullMessage = outputLower.Contains("roster is full") && outputLower.Contains("cannot add");

        Assert.IsTrue(
            hasFullMessage,
            "❌ Roster capacity rule missing\n" +
            "💡 Tip: If count == capacity, print 'Roster is full. Cannot add more students.'"
        );
    }

    [TestMethod]
    public void Test06_SortedByName_PrintsInNameOrder_AndKeepsCreditsAligned()
    {
        ProvideInput(
            "1", "3",
            "Zoe", "10",
            "amy", "30",
            "Bob", "20",
            "3", "1",   // sorted, sort by name
            "4"
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString();
        string sortedSection = GetSectionAfter(output, "Class Roster (Sorted):");

        int amyIndex = sortedSection.IndexOf("amy", StringComparison.OrdinalIgnoreCase);
        int bobIndex = sortedSection.IndexOf("bob", StringComparison.OrdinalIgnoreCase);
        int zoeIndex = sortedSection.IndexOf("zoe", StringComparison.OrdinalIgnoreCase);

        bool hasAllNames = amyIndex >= 0 && bobIndex >= 0 && zoeIndex >= 0;
        bool inOrder = amyIndex < bobIndex && bobIndex < zoeIndex;

        string? amyLine = FindLineContaining(sortedSection, "amy");
        string? bobLine = FindLineContaining(sortedSection, "bob");
        string? zoeLine = FindLineContaining(sortedSection, "zoe");

        bool creditsAligned =
            amyLine != null && amyLine.Contains("30") &&
            bobLine != null && bobLine.Contains("20") &&
            zoeLine != null && zoeLine.Contains("10");

        Assert.IsTrue(
            hasAllNames && inOrder && creditsAligned,
            "❌ Sorted-by-name roster output missing or incorrect\n" +
            "💡 Tip: Use Array.Sort(names, credits, StringComparer.OrdinalIgnoreCase) and print name+credits"
        );
    }

    [TestMethod]
    public void Test07_SortedByCredits_PrintsInCreditOrder_AndKeepsNamesAligned()
    {
        ProvideInput(
            "1", "3",
            "Ada", "50",
            "Bob", "10",
            "Cara", "30",
            "3", "2",   // sorted, sort by credits
            "4"
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString();
        string sortedSection = GetSectionAfter(output, "Class Roster (Sorted):");

        int bobIndex = sortedSection.IndexOf("bob", StringComparison.OrdinalIgnoreCase);
        int caraIndex = sortedSection.IndexOf("cara", StringComparison.OrdinalIgnoreCase);
        int adaIndex = sortedSection.IndexOf("ada", StringComparison.OrdinalIgnoreCase);

        bool hasAllNames = bobIndex >= 0 && caraIndex >= 0 && adaIndex >= 0;
        bool inOrder = bobIndex < caraIndex && caraIndex < adaIndex;

        string? bobLine = FindLineContaining(sortedSection, "bob");
        string? caraLine = FindLineContaining(sortedSection, "cara");
        string? adaLine = FindLineContaining(sortedSection, "ada");

        bool namesAligned =
            bobLine != null && bobLine.Contains("10") &&
            caraLine != null && caraLine.Contains("30") &&
            adaLine != null && adaLine.Contains("50");

        Assert.IsTrue(
            hasAllNames && inOrder && namesAligned,
            "❌ Sorted-by-credits roster output missing or incorrect\n" +
            "💡 Tip: Use Array.Sort(credits, names) and print name+credits"
        );
    }

    [TestMethod]
    public void Test08_StudyNotesFileExists()
    {
        string testDir = Path.GetDirectoryName(typeof(ClassRosterTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);
        bool exists = File.Exists(studyNotesPath);

        Assert.IsTrue(
            exists,
            "\n❌ Missing STUDY_NOTES.md file!\n" +
            "📝 The file should exist in the starter folder\n" +
            "💡 Location: modules/week-07-class-roster/starter/STUDY_NOTES.md"
        );
    }

    [TestMethod]
    public void Test09_StudyNotesAllSectionsCompleted()
    {
        string testDir = Path.GetDirectoryName(typeof(ClassRosterTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);

        if (File.Exists(studyNotesPath))
        {
            string content = File.ReadAllText(studyNotesPath);

            Assert.IsFalse(
                string.IsNullOrWhiteSpace(content.Split(new[] { "**Name:**" }, StringSplitOptions.None)[1].Split('\n')[0].Trim()),
                "\n❌ Please fill in your name at the top of STUDY_NOTES.md"
            );

            string[] sections = content.Split("Answer:");
            int totalAnswerSections = sections.Length - 1;
            int filledAnswers = 0;

            for (int i = 1; i < sections.Length; i++)
            {
                string afterAnswer = sections[i].Trim();
                int nextSectionIndex = afterAnswer.IndexOf("**");
                if (nextSectionIndex > 0)
                {
                    afterAnswer = afterAnswer.Substring(0, nextSectionIndex).Trim();
                }

                if (!string.IsNullOrWhiteSpace(afterAnswer) && afterAnswer.Length > 5)
                {
                    filledAnswers++;
                }
            }

            Assert.IsTrue(
                filledAnswers >= totalAnswerSections - 2,
                $"\n❌ STUDY_NOTES.md has incomplete answers! (Completed: {filledAnswers}/{totalAnswerSections})\n" +
                "💡 Tip: Fill in all 'Answer:' sections with thoughtful responses"
            );

            bool hasTakeaway1 = Regex.IsMatch(content, @"1\.\s+\w{3,}");
            bool hasTakeaway2 = Regex.IsMatch(content, @"2\.\s+\w{3,}");
            bool hasTakeaway3 = Regex.IsMatch(content, @"3\.\s+\w{3,}");

            Assert.IsTrue(
                hasTakeaway1 && hasTakeaway2 && hasTakeaway3,
                "\n❌ Please complete the 'Key takeaways' list (items 1, 2, and 3)"
            );

            bool hasTimeTotal = content.Contains("**Total time:**") &&
                               Regex.IsMatch(content, @"\*\*Total time:\*\*\s+\d+");

            Assert.IsTrue(
                hasTimeTotal,
                "\n❌ Please fill in the 'Total time' section\n" +
                "💡 Tip: Example: **Total time:** 3 hours"
            );
        }
        else
        {
            Assert.Inconclusive("STUDY_NOTES.md file does not exist yet");
        }
    }
}
