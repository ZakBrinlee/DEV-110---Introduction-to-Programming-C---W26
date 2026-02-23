/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Tests the Week 8 Mad Libs assignment requirements.
- */

using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MadLibs.Tests;

[TestClass]
public class MadLibsTests
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
    public void Test02_TemplateSelectionAndPromptsAppear()
    {
        ProvideInput(
            "3", "1", // invalid then valid template choice
            "silly", // adjective
            "penguins", // animals
            "dancing", // -ing verb
            "C#", // language
            "breakpoint", // tool
            "3", // number
            "proud", // emotion
            "woohoo", // exclamation
            "n" // play again
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString();
        string outputLower = output.ToLower();

        bool hasTemplateLines = output.Contains("1) Debugging at the Zoo") &&
                                output.Contains("2) The Standup Meeting");

        int choicePromptCount = CountMatches(outputLower, "choose a template");

        Assert.IsTrue(
            hasTemplateLines && choicePromptCount >= 2,
            "❌ Template list or template validation loop missing\n" +
            "💡 Tip: Print both template lines and re-prompt until choice is 1-2"
        );
    }

    [TestMethod]
    public void Test03_StoryIncludesUserWords()
    {
        ProvideInput(
            "1",
            "silly",
            "penguins",
            "dancing",
            "C#",
            "breakpoint",
            "3",
            "proud",
            "woohoo",
            "n"
        );

        Program.Main(Array.Empty<string>());
        string outputLower = _output.ToString().ToLower();

        bool hasWords = outputLower.Contains("silly") &&
                        outputLower.Contains("penguins") &&
                        outputLower.Contains("breakpoint");

        Assert.IsTrue(
            hasWords,
            "❌ Final story does not include the user's words\n" +
            "💡 Tip: Use string.Format with {0}, {1}, ... placeholders"
        );
    }

    [TestMethod]
    public void Test04_PlayAgainLoopWorks()
    {
        ProvideInput(
            "2",
            "Ada",
            "quick",
            "feature",
            "fixed",
            "2",
            "tickets",
            "null reference",
            "chips",
            "y",
            "1",
            "happy",
            "cats",
            "jumping",
            "C#",
            "watch",
            "5",
            "calm",
            "nice",
            "n"
        );

        Program.Main(Array.Empty<string>());
        string outputLower = _output.ToString().ToLower();

        int playAgainPromptCount = CountMatches(outputLower, "play again\\?");
        int templateChoicePromptCount = CountMatches(outputLower, "choose a template");

        Assert.IsTrue(
            playAgainPromptCount >= 2 && templateChoicePromptCount >= 2,
            "❌ Play-again loop missing\n" +
            "💡 Tip: Use a do-while loop and re-run the template flow when user enters y"
        );
    }

    [TestMethod]
    public void Test05_StudyNotesFileExists()
    {
        string testDir = Path.GetDirectoryName(typeof(MadLibsTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);
        bool exists = File.Exists(studyNotesPath);

        Assert.IsTrue(
            exists,
            "\n❌ Missing STUDY_NOTES.md file!\n" +
            "📝 The file should exist in the starter folder\n" +
            "💡 Location: modules/week-08-mad-libs/starter/STUDY_NOTES.md");
    }

    [TestMethod]
    public void Test06_StudyNotesAllSectionsCompleted()
    {
        string testDir = Path.GetDirectoryName(typeof(MadLibsTests).Assembly.Location);
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
            int nextSectionIndex = afterAnswer.IndexOf("**", StringComparison.Ordinal);
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

        bool hasTakeaway1 = Regex.IsMatch(content, @"1\\.\\s+\\w{3,}");
        bool hasTakeaway2 = Regex.IsMatch(content, @"2\\.\\s+\\w{3,}");
        bool hasTakeaway3 = Regex.IsMatch(content, @"3\\.\\s+\\w{3,}");

        Assert.IsTrue(
            hasTakeaway1 && hasTakeaway2 && hasTakeaway3,
            "\n❌ Please complete the 'Key takeaways' list (items 1, 2, and 3)");

        bool hasTimeTotal = content.Contains("**Total time:**") &&
                           Regex.IsMatch(content, @"\\*\\*Total time:\\*\\*\\s+\\d+");

        Assert.IsTrue(
            hasTimeTotal,
            "\n❌ Please fill in the 'Total time' section\n" +
            "💡 Tip: Example: **Total time:** 3 hours");
    }
}
