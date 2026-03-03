/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }
}
