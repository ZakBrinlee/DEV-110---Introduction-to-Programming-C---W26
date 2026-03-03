/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Ujwal Garine
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?: Lets the user play a Mad Libs game with two different templates.
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        // TODO 1: Implement the main game loop
        // The loop should:
        // - Let player choose a template
        // - Collect words for the template
        // - Generate and display the story using template.GenerateStory()
        // - Ask if the player wants to play again
        // - Repeat if they answer 'y'
        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    // TODO 2: Implement ChooseTemplate
    // This method should:
    // - Print the two template options:
    //   1) Debugging at the Zoo
    //   2) The Standup Meeting
    // - Use ReadIntInRange to get user's choice (1-2)
    // - Return the appropriate StoryTemplate (see template details in README)
    private static StoryTemplate ChooseTemplate()
    {
        // keep asking until the user enters 1 or 2
        while (true)
        {
            Console.WriteLine("Choose a template:");
            Console.WriteLine("1) Debugging at the Zoo");
            Console.WriteLine("2) The Standup Meeting");

            Console.Write("Enter your choice (1-2): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input.Trim(), out int choice))
            {
                if (choice == 1)
                {
                    return new StoryTemplate(
                        "Debugging at the Zoo",
                        new string[]
                        {
                            "adjective",
                            "animal",
                            "verb ending in -ing",
                            "place",
                            "plural noun",
                        },
                        "Today I went to the zoo and saw a(n) {0} {1} {2} in the {3}. It was surrounded by {4}!"
                    );
                }

                if (choice == 2)
                {
                    return new StoryTemplate(
                        "The Standup Meeting",
                        new string[]
                        {
                            "adjective",
                            "job title",
                            "verb ending in -ing",
                            "project name",
                            "tool or software",
                        },
                        "As a {0} {1}, I spent the day {2} on the {3} project using {4}. It was quite an adventure!"
                    );
                }
            }

            Logger.Warn("Please enter a number between 1 and 2.");
            // loop will repeat and templates get printed again
        }
    }

    // TODO 3: Implement CollectWords
    // This method should:
    // - Use Logger.Info to log that word collection is starting
    // - Create a string array the same length as template.Prompts
    // - Loop through each prompt and use ReadNonEmptyString
    // - Print a blank line after collection
    // - Return the array of collected words
    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info("Starting word collection...");
        string[] words = new string[template.Prompts.Length];
        for (int i = 0; i < template.Prompts.Length; i++)
        {
            words[i] = ReadNonEmptyString($"Enter a {template.Prompts[i]}: ");
        }
        Console.WriteLine();
        return words;
    }

    // TODO 4: Implement ReadYesNo
    // This method should:
    // - Show the prompt
    // - Read input (handle null with ?? string.Empty)
    // - Trim the input
    // - Accept "y" or "n" (case-insensitive)
    // - Keep asking until valid input is provided
    // - Return true for "y", false for "n"
    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
                return true;

            if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
                return false;

            Logger.Warn("Please enter y or n.");
        }
    }

    // TODO 5: Implement ReadIntInRange
    // This method should:
    // - Use a do-while loop
    // - Show the prompt
    // - Read input and use int.TryParse
    // - Validate the number is between min and max (inclusive)
    // - Keep asking until valid
    // - Return the valid integer
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool valid;

        do
        {
            Console.Write(prompt);

            string input = Console.ReadLine() ?? string.Empty;

            valid = int.TryParse(input.Trim(), out value) && value >= min && value <= max;

            if (!valid)
                Logger.Warn($"Please enter a number between {min} and {max}.");
        }
        while (!valid);

        return value;
    }

    // TODO 6: Implement ReadNonEmptyString
    // This method should:
    // - Show the prompt
    // - Read input (handle null with ?? string.Empty)
    // - Trim the input
    // - Keep asking if input is empty or whitespace
    // - Return the valid non-empty string
    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrWhiteSpace(input))
                return input;

            Logger.Warn("Input cannot be empty. Please try again.");
        }
    }
}
