/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        {
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

            // TODO 5: Use a switch statement to handle each menu option

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
        // TODO 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number

        return min; // Remove this placeholder
    }

    private static double ReadDouble(string prompt)
    {
        // TODO 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number

        return 0; // Remove this placeholder
    }
}
