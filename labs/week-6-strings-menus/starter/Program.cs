/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6 Lab - Cozy Cafe Sign Maker
-
- What does this program do?:
- Builds a cafe-themed menu program that practices string formatting.
- */

// Program title so users know what app they are running.
Console.WriteLine("=== Cozy Cafe Sign Maker Lab ===\n");

// TODO 1: Build a title banner using strings
// Required pieces:
// - title: "Cozy Cafe Sign Maker"
// - subtitle: "Strings + Output Patterns"
// - divider: 40 '=' characters
// Print divider, title (uppercase), subtitle, divider
// Hint: use new string('=', 40) and ToUpper()

// TODO 2: Create ReadIntInRange helper method below
// - Use a do-while loop
// - Use int.TryParse
// - Repeat until the number is in range

// TODO 3: Create ReadDouble helper method below
// - Use a do-while loop
// - Use double.TryParse

// TODO 4: Create a menu loop that repeats until the user chooses 4 (Exit)
// Hint: Use a while loop: while (choice != 4)
// Use an int named choice and start it at 0

// TODO 5: Print the menu box each time through the loop
// Use this exact text:
// +--------------------------------------+
// | 1) Welcome Sign                      |
// | 2) Menu Line Formatter               |
// | 3) Quote Styler                      |
// | 4) Exit                              |
// +--------------------------------------+

// TODO 6: Read a valid menu choice using ReadIntInRange
// Prompt: "Choose an option (1-4): "

// TODO 7: Use a switch statement to handle each choice
// Option 1: Welcome Sign
// - Prompts: "Enter shop name: " and "Enter a short tagline: "
// - Use Trim(), ToUpper(), PadRight(), and concatenation
// - Compare the shop name to "Cozy Cafe" (case-insensitive) using Equals
// - Print a boxed sign with two lines (welcome and tagline)
// - Print: "Matches favorite name: true/false"
//
// Option 2: Menu Line Formatter
// - Prompts: "Enter item name: ", "Enter price: ", "Enter calories: "
// - Use explicit placeholders (string.Format) AND interpolation
// - Print a summary line: "Item: <name> | Calories: <num> | Price: <0.00>"
// - Print a "Quick view" line using interpolation
// - Print a one-line menu entry with aligned columns and currency
//
// Option 3: Quote Styler
// - Prompt: "Enter a customer quote: "
// - Use Trim(), ToUpper(), and string.Join()
// - Use Length and Substring for a preview
// - Use Contains("cafe"), EndsWith("!" or "."), and IndexOf(' ')
// - Use placeholders and interpolation for output
// - Print uppercase, spaced letters, length, preview, contains, ends-with, and index
//
// Option 4: print "Goodbye!"

// TODO 8: Add a blank line between menu actions (but not after Exit)

static int ReadIntInRange(string prompt, int min, int max)
{
    // TODO 2A: Replace this placeholder with input validation logic
    return min;
}

static double ReadDouble(string prompt)
{
    // TODO 3A: Replace this placeholder with input validation logic
    return 0.0;
}
