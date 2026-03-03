/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Ujwal Garine
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?: it is a class that represents a Mad Libs story template, containing the title, prompts,
 and template text. It also has a method to generate the final story based on user input.
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    // TODO 1: Implement GenerateStory method
    // This method should:
    // - Validate that words.Length equals Prompts.Length
    // - Call FormatStory to build the final story string
    // - Return the formatted story
    public string GenerateStory(string[] words)
    {
        bool valid = words.Length == Prompts.Length;
        if (valid)
        {
            return FormatStory(words);
        }
        else
        {
            throw new ArgumentException($"Prompts length ({Prompts.Length}) does not match words length ({words.Length}).");
        }
    }

    // TODO 2: Implement FormatStory method (private helper)
    // This method should:
    // - Convert string[] words to object[] (required for string.Format)
    // - Call string.Format with TemplateText and the object array
    // - Return the formatted story
    private string FormatStory(string[] words)
    {
        object[] wordObjects = new object[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
            wordObjects[i] = words[i];
        }
        return string.Format(TemplateText, wordObjects);
    }
}
