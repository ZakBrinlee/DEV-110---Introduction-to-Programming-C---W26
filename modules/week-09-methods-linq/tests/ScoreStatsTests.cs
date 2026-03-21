/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 9: Score Stats (Methods + LINQ)
-
- What does this program do?:
- Tests the Week 9 Score Stats assignment requirements.
- */

using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScoreStats.Tests;

[TestClass]
public class ScoreStatsTests
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
        StringReader input = new StringReader(string.Join(Environment.NewLine, inputs));
        Console.SetIn(input);
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
    public void Test02_SummaryStatsPrintedCorrectly()
    {
        ProvideInput(
            "10, 20, 30",
            "20",
            "n"
        );

        Program.Main(Array.Empty<string>());

        string output = _output.ToString();
        string outputLower = output.ToLower();

        bool hasHeader = output.Contains("=== Score Stats: Methods + LINQ ===");
        bool hasPromptScores = outputLower.Contains("enter scores");
        bool hasPromptThreshold = outputLower.Contains("passing threshold");
        bool hasAnalyzeAgain = outputLower.Contains("analyze another set");

        bool hasSummary = output.Contains("Count: 3") &&
                  output.Contains("Min: 10") &&
                  output.Contains("Max: 30") &&
                  output.Contains("Average: 20.0") &&
                  output.Contains("Passing (>=20): 2") &&
                  output.Contains("Failing (<20): 1") &&
                  output.Contains("Sorted (asc): 10, 20, 30") &&
                  output.Contains("Top 3: 30, 20, 10") &&
                  output.Contains("Passing scores (desc): 30, 20") &&
                  output.Contains("Failing scores (desc): 10");

        Assert.IsTrue(
            hasHeader && hasPromptScores && hasPromptThreshold && hasAnalyzeAgain && hasSummary,
            "❌ Missing prompts or incorrect summary output\n" +
            "💡 Tip: Match the README prompts exactly and format Average to 1 decimal place"
        );
    }

    [TestMethod]
    public void Test03_InvalidScoresRePrompt()
    {
        ProvideInput(
            "10, 200", // invalid (out of range)
            "10, 20", // valid
            "10", // threshold
            "n"
        );

        Program.Main(Array.Empty<string>());

        string outputLower = _output.ToString().ToLower();
        int scorePromptCount = CountMatches(outputLower, "enter scores");

        Assert.IsTrue(
            scorePromptCount >= 2,
            "❌ Score input validation loop missing\n" +
            "💡 Tip: If any score is invalid, re-prompt for the full CSV line"
        );
    }

    [TestMethod]
    public void Test04_InvalidThresholdRePrompt()
    {
        ProvideInput(
            "10, 20", // scores
            "-1", // invalid
            "101", // invalid
            "10", // valid
            "n"
        );

        Program.Main(Array.Empty<string>());

        string outputLower = _output.ToString().ToLower();
        int thresholdPromptCount = CountMatches(outputLower, "passing threshold");

        Assert.IsTrue(
            thresholdPromptCount >= 3,
            "❌ Threshold input validation loop missing\n" +
            "💡 Tip: Use ReadIntInRange(prompt, 0, 100) and re-prompt until valid"
        );
    }

    [TestMethod]
    public void Test05_AnalyzeAgainLoopRunsTwice()
    {
        ProvideInput(
            "1, 2, 3",
            "2",
            "y",
            "50, 50",
            "50",
            "n"
        );

        Program.Main(Array.Empty<string>());

        string outputLower = _output.ToString().ToLower();
        int analyzeAgainPromptCount = CountMatches(outputLower, "analyze another set");
        int countLineCount = CountMatches(outputLower, @"count:\s*\d+");

        Assert.IsTrue(
            analyzeAgainPromptCount >= 2 && countLineCount >= 2,
            "❌ Analyze-again loop missing\n" +
            "💡 Tip: Use a do-while loop and re-run the analysis when user enters y"
        );
    }

    [TestMethod]
    public void Test06_StudyNotesFileExists()
    {
        string testDir = Path.GetDirectoryName(typeof(ScoreStatsTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);
        bool exists = File.Exists(studyNotesPath);

        Assert.IsTrue(
            exists,
            "\n❌ Missing STUDY_NOTES.md file!\n" +
            "📝 The file should exist in the starter folder\n" +
            "💡 Location: modules/week-09-methods-linq/starter/STUDY_NOTES.md");
    }

    [TestMethod]
    public void Test07_StudyNotesAllSectionsCompleted()
    {
        string testDir = Path.GetDirectoryName(typeof(ScoreStatsTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);

        if (!File.Exists(studyNotesPath))
        {
            Assert.Inconclusive("STUDY_NOTES.md file does not exist yet");
            return;
        }

        string content = File.ReadAllText(studyNotesPath);

        Assert.IsFalse(
            string.IsNullOrWhiteSpace(content.Split(new[] { "**Name:**" }, StringSplitOptions.None)[1].Split('\n')[0].Trim()),
            "\n❌ Please fill in your name at the top of STUDY_NOTES.md");

        string[] sections = content.Split("Answer:");
        int totalAnswerSections = sections.Length - 1;
        int filledAnswers = 0;

        for (int i = 1; i < sections.Length; i++)
        {
            string afterAnswer = sections[i].Trim();
            int nextSectionIndex = afterAnswer.IndexOf("## ", StringComparison.Ordinal);
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
            "💡 Tip: Fill in all 'Answer:' sections with thoughtful responses");

        bool hasTakeaway1 = Regex.IsMatch(content, @"1\.\s+\w{3,}");
        bool hasTakeaway2 = Regex.IsMatch(content, @"2\.\s+\w{3,}");
        bool hasTakeaway3 = Regex.IsMatch(content, @"3\.\s+\w{3,}");

        Assert.IsTrue(
            hasTakeaway1 && hasTakeaway2 && hasTakeaway3,
            "\n❌ Please complete the 'Key takeaways' list (items 1, 2, and 3)");

        bool hasTimeTotal = content.Contains("**Total time:**") &&
                           Regex.IsMatch(content, @"\*\*Total time:\*\*\s+\d+");

        Assert.IsTrue(
            hasTimeTotal,
            "\n❌ Please fill in the 'Total time' section\n" +
            "💡 Tip: Example: **Total time:** 3 hours");
    }
}
