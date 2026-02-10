/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Tests the Week 6 text menu assignment requirements.
- */

using System;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextMenuApp.Tests;

[TestClass]
public class TextMenuAppTests
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
    public void Test02_MenuRepeatsAndExits()
    {
        ProvideInput(
            "0", "1", "Ada", "Hello!", // invalid option, then greeting card
            "6"                     // exit
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString();
        string outputLower = output.ToLower();

        int menuPromptCount = CountMatches(outputLower, "choose an option");
        bool hasMenuLine = outputLower.Contains("1) greeting card") && outputLower.Contains("6) exit");
        bool hasTitle = outputLower.Contains("text menu studio") && outputLower.Contains("strings + console output patterns");
        bool hasHello = outputLower.Contains("hello, ada");
        bool hasGoodbye = outputLower.Contains("goodbye");

        Assert.IsTrue(
            menuPromptCount >= 2 && hasMenuLine && hasTitle && hasHello && hasGoodbye,
            "❌ Menu loop or exit behavior missing\n" +
            "💡 Tip: Use a while loop for the menu and ReadIntInRange for input");
    }

    [TestMethod]
    public void Test03_MenuOptionsWork()
    {
        ProvideInput(
            "1", "Ada", "Welcome!",  // greeting card
            "2", "Ada", "Lovelace", // name tag
            "3", "hello world",     // phrase analyzer
            "4", "Pen", "2.5", "2", // receipt line
            "5", "Menu", "Today", "30", // banner
            "6", "test"             // exit with closing word
        );

        Program.Main(Array.Empty<string>());
        string outputLower = _output.ToString().ToLower();

        // Option 1: Greeting Card
        bool hasGreeting = outputLower.Contains("hello, ada") || outputLower.Contains("hello ada");
        bool hasMessage = outputLower.Contains("message") && outputLower.Contains("welcome!");

        // Option 2: Name Tag Formatter
        bool hasNameTag = Regex.IsMatch(outputLower, @"(name\s*tag|tag)[:\s]*\[?ada lovelace");
        bool hasInitials = Regex.IsMatch(outputLower, @"(initial|initials)[:\s]*al");
        bool hasLowercase = outputLower.Contains("ada lovelace") && (outputLower.Contains("lowercase") || outputLower.Contains("lower"));

        // Option 3: Phrase Analyzer
        bool hasLength = Regex.IsMatch(outputLower, @"(length|len)[:\s]*\d+");
        bool hasDashed = outputLower.Contains("hello-world");
        bool hasWords = outputLower.Contains("hello") && outputLower.Contains("world");

        // Option 4: Receipt
        bool hasReceiptHeader = outputLower.Contains("item") && outputLower.Contains("total");
        bool hasCurrency = Regex.IsMatch(outputLower, @"\$\s*5\.00");

        // Option 5: Banner
        bool hasBanner = (outputLower.Contains("centered") || outputLower.Contains("center")) &&
                         (outputLower.Contains("left")) &&
                         (outputLower.Contains("right"));

        Assert.IsTrue(
            hasGreeting && hasMessage && hasNameTag && hasInitials && hasLowercase &&
            hasLength && hasDashed && hasWords && hasReceiptHeader && hasCurrency && hasBanner,
            "❌ Menu option output missing or incorrect\n" +
            "💡 Tip: Make sure all options display the required transformed strings");
    }

    [TestMethod]
    public void Test04_ClosingAnalysisBasic()
    {
        ProvideInput(
            "6", "goodbye"  // exit with exact match word
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString().ToLower();

        // Check that Equals comparison works (should match 'goodbye')
        bool hasGoodbyeMatch = Regex.IsMatch(output, @"(is|matches|equals).+'goodbye'.+true");

        // Check that Substring extracts first 3 characters
        bool hasSubstring = output.Contains("goo") && Regex.IsMatch(output, @"(first|preview|start).+3.+'goo'");

        // Check that EndsWith detects no exclamation
        bool hasEndsWith = Regex.IsMatch(output, @"(has|ends).+!.+(false|no)");

        // Check that IndexOf finds no space
        bool hasIndexOf = Regex.IsMatch(output, @"(space|index).+(-1|not found|none)");

        Assert.IsTrue(
            hasGoodbyeMatch && hasSubstring && hasEndsWith && hasIndexOf,
            "❌ Closing analysis missing or incorrect\n" +
            "💡 Tip: Use Equals with StringComparison.OrdinalIgnoreCase, Substring, EndsWith, and IndexOf");
    }

    [TestMethod]
    public void Test05_ClosingAnalysisWithPunctuation()
    {
        ProvideInput(
            "6", "hello world!"  // exit with punctuation and space
        );

        Program.Main(Array.Empty<string>());
        string output = _output.ToString().ToLower();

        // Check that comparison returns false (not 'goodbye')
        bool hasNoMatch = Regex.IsMatch(output, @"(is|matches|equals).+'goodbye'.+(false|no)");

        // Check that Substring extracts first 3 characters from 'hello world!'
        bool hasSubstring = output.Contains("hel") && Regex.IsMatch(output, @"(first|preview|start).+3.+'hel'");

        // Check that EndsWith detects exclamation mark
        bool hasEndsWith = Regex.IsMatch(output, @"(has|ends).+!.+(true|yes)");

        // Check that IndexOf finds space at position 5
        bool hasIndexOf = Regex.IsMatch(output, @"(space|index).+5");

        Assert.IsTrue(
            hasNoMatch && hasSubstring && hasEndsWith && hasIndexOf,
            "❌ Closing analysis with punctuation/spaces incorrect\n" +
            "💡 Tip: Test EndsWith for '!' and IndexOf for ' ' (space character)");
    }

    [TestMethod]
    public void Test06_StudyNotesFileExists()
    {
        string testDir = Path.GetDirectoryName(typeof(TextMenuAppTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);
        bool exists = File.Exists(studyNotesPath);

        Assert.IsTrue(
            exists,
            "\n❌ Missing STUDY_NOTES.md file!\n" +
            "📝 The file should exist in the starter folder\n" +
            "💡 Location: modules/week-06-text-menu-app/starter/STUDY_NOTES.md");
    }

    [TestMethod]
    public void Test07_StudyNotesAllSectionsCompleted()
    {
        string testDir = Path.GetDirectoryName(typeof(TextMenuAppTests).Assembly.Location);
        string starterPath = Path.Combine(testDir, "..", "..", "..", "..", "starter", "STUDY_NOTES.md");
        string studyNotesPath = Path.GetFullPath(starterPath);

        if (File.Exists(studyNotesPath))
        {
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
        else
        {
            Assert.Inconclusive("STUDY_NOTES.md file does not exist yet");
        }
    }
}
