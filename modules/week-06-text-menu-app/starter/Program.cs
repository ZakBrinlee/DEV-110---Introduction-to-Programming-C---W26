/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Conner Walker
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

using System.Diagnostics;

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);
        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider
        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        while (choice != 6)
        {
            Console.WriteLine(divider);
            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");
            Console.WriteLine(divider);

            // TODO 3: Print the menu box
            // Required menu option texts (tests check for these):
            // - 1) Greeting Card
            // - 2) Name Tag Formatter
            // - 3) Phrase Analyzer
            // - 4) Fancy Receipt Line
            // - 5) Menu Banner Builder
            // - 6) Exit

            // TODO 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            // TODO 5: Use a switch statement to handle each menu option
            switch (choice)
            {
                case 1:
                    // Call method to handle Greeting Card option
                    GreetingCard();
                    break;
                case 2:
                    // Call method to handle Name Tag Formatter option
                    NameTagFormatter();
                    break;
                case 3:
                    // Call method to handle Phrase Analyzer option
                    PhraseAnalyzer();
                    break;
                case 4:
                    // Call method to handle Fancy Receipt Line option
                    FancyReceiptLine();
                    break;
                case 5:
                    // Call method to handle Menu Banner Builder option
                    MenuBannerBuilder();
                    break;
                case 6:
                    // Call method to handle Exit option with string analysis
                    ExitWithStringAnalysis();
                    break;
            }

            // Add a blank line between menu actions (but not after Exit)
            if (choice != 6)
            {
                Console.WriteLine();
            }

            // ===== OPTION 1: Greeting Card =====
            // Prompts: "Enter your name: " and "Enter a short message: "
            // Required string operations:
            // - Use Trim() to clean up the name
            // - Use ToUpper() for an uppercase version
            // - Use concatenation OR interpolation for greeting text
            // - Use string.Format() for at least one output line
            // - Display a boxed card with the name, uppercase name, and message
            // Include the word "Message:" in your output

            // ===== OPTION 2: Name Tag Formatter =====
            // Prompts: "Enter first name: " and "Enter last name: "
            // Required string operations:
            // - Use Trim() on both inputs
            // - Use concatenation to build full name
            // - Use string indexing to get first characters for initials
            // - Use ToUpper() for initials
            // - Use ToLower() for lowercase version
            // Display three things:
            // - Name tag with the full name (include a bracket [)
            // - Initials (use word "Initials:" in label)
            // - Lowercase version (use word "Lowercase:" in label)

            // ===== OPTION 3: Phrase Analyzer =====
            // Prompt: "Enter a phrase: "
            // Required string operations:
            // - Use Trim() on input
            // - Use Length property
            // - Use Contains() to check for letter 'a' (convert to lowercase first)
            // - Use Replace() to change spaces to dashes
            // - Use Split() to break into words
            // - Use string.Join() to create comma-separated list
            // Display: length, contains check, dashed version, and words list

            // ===== OPTION 4: Fancy Receipt Line =====
            // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
            // Use ReadDouble for price and ReadIntInRange for quantity
            // Required:
            // - Calculate total (price * quantity)
            // - Create a receipt table with header row (ITEM, QTY, TOTAL)
            // - Use string.Format() with composite formatting for the data row
            // - Use alignment specifiers (left/right alignment)
            // - Use currency format specifier (:C2) for the total

            // ===== OPTION 5: Menu Banner Builder =====
            // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "
            // Use ReadIntInRange for width (min=30, max=60)
            // Required string operations:
            // - Create border line with equals signs (use new string constructor)
            // - Use PadLeft() to center text (formula: (width + text.Length) / 2)
            // - Use ToUpper() on title
            // - Display banner with borders and centered text
            // - Show three alignment examples (centered, left, right)

            // ===== OPTION 6: Exit with String Analysis =====
            // Prompt: "Enter a closing word: "
            // Required string operations (demonstrate these 4 methods):
            // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
            // - Use Substring() to extract first 3 characters (check length first!)
            // - Use EndsWith() to check if ends with "!"
            // - Use IndexOf() to find position of space character
            // Display the results of all four operations
            // Then print: "Goodbye!"

            // TODO 6: Add a blank line between menu actions (but not after Exit)
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number >= min && number <= max)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        while (true);

        // TODO 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number
        // return min; // Remove this placeholder
    }

    private static double ReadDouble(string prompt)
    {
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        while (true);

        // TODO 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number
        // return 0; // Remove this placeholder
    }

    private static void GreetingCard()
    {
        // Call method to handle Greeting Card option
        string divider = new string('=', 48);
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter a short message: ");
        string message = Console.ReadLine() ?? string.Empty;

        name = name.Trim();
        string upperName = name.ToUpper();

        // Prepare boxed card lines
        string nameLine = $"Name: {name}";
        string upperLine = $"Uppercase: {upperName}";
        string messageLine = $"Message: {message}";

        int boxInnerWidth = Math.Max(Math.Max(nameLine.Length, upperLine.Length), messageLine.Length);
        int boxWidth = boxInnerWidth + 4; // padding and side markers

        Console.WriteLine(divider);
        Console.WriteLine($"{nameLine.PadRight(boxInnerWidth)}");
        Console.WriteLine($"{upperLine.PadRight(boxInnerWidth)}");
        Console.WriteLine($"{string.Format("{0}", messageLine).PadRight(boxInnerWidth)}");
        Console.WriteLine(divider);
    }

    private static void NameTagFormatter()
    {
        string divider = new string('=', 48);
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        firstName = firstName.Trim();
        lastName = lastName.Trim();
        string fullName = firstName + " " + lastName;
        char firstInitial = char.ToUpper(firstName[0]);
        char lastInitial = char.ToUpper(lastName[0]);
        string initials = $"{firstInitial}{lastInitial}";
        string lowercaseName = fullName.ToLower();
        Console.WriteLine(divider);
        Console.WriteLine($"[Name Tag] {fullName}");
        Console.WriteLine($"Initials: {initials}");
        Console.WriteLine($"Lowercase: {lowercaseName}");
        Console.WriteLine(divider);
    }

    private static void PhraseAnalyzer()
    {
        string divider = new string('=', 48);
        Console.Write("Enter a phrase: ");
        string phrase = Console.ReadLine();
        phrase = phrase.Trim();
        int length = phrase.Length;
        bool containsA = phrase.ToLower().Contains('a');
        string dashedVersion = phrase.Replace(' ', '-');
        string[] words = phrase.Split(' ');
        string wordList = string.Join(", ", words);
        Console.WriteLine(divider);
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Contains 'a': {containsA}");
        Console.WriteLine($"Dashed version: {dashedVersion}");
        Console.WriteLine($"Words: {wordList}");
        Console.WriteLine(divider);
    }

    private static void FancyReceiptLine()
    {
        string divider = new string('=', 48);
        Console.Write("Enter item name: ");
        string itemName = Console.ReadLine();
        double price = ReadDouble("Enter price: ");
        int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);
        double total = price * quantity;
        Console.WriteLine(divider);
        Console.WriteLine("ITEM".PadRight(20) + "QTY".PadRight(10) + "TOTAL".PadLeft(15));
        string formattedLine = string.Format("{0,-20} {1,-10} {2,15:C2}", itemName, quantity, total);
        Console.WriteLine(formattedLine);
        Console.WriteLine(divider);
    }

    private static void MenuBannerBuilder()
    {
        Console.Write("Enter a title: ");
        string title = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter a subtitle: ");
        string subtitle = Console.ReadLine() ?? string.Empty;
        int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
        string border = new string('=', width);

        int titlePad = (width + title.Length) / 2;
        int subtitlePad = (width + subtitle.Length) / 2;

        Console.WriteLine(border);
        Console.WriteLine(title.ToUpper().PadLeft(titlePad));
        Console.WriteLine(subtitle.PadLeft(subtitlePad));
        Console.WriteLine(border);

        // Three alignment examples
        Console.WriteLine();
        Console.WriteLine("Center: " + title.ToUpper().PadLeft(titlePad));
        Console.WriteLine("Left:   " + title.PadRight(width));
        Console.WriteLine("Right:  " + title.PadLeft(width));
    }

    private static void ExitWithStringAnalysis()
    {
        string divider = new string('=', 48);
        Console.Write("Enter a closing word: ");
        string closingWord = Console.ReadLine();
        bool isGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
        string firstThreeChars = closingWord.Length >= 3 ? closingWord.Substring(0, 3) : closingWord;
        bool endsWithExclamation = closingWord.EndsWith('!');
        int spaceIndex = closingWord.IndexOf(' ');
        Console.WriteLine(divider);
        Console.WriteLine($"Equals 'goodbye' (ignore case): {isGoodbye}");
        Console.WriteLine($"First three characters: {firstThreeChars}");
        Console.WriteLine($"Ends with '!': {endsWithExclamation}");
        Console.WriteLine($"Index of space character: {spaceIndex}");
        Console.WriteLine("Goodbye!");
     }
}
