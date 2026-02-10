/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Assignment: Week 6 Lab - Cozy Cafe Sign Maker
-
- What does this program do?:
- Builds a cafe-themed menu program that practices string formatting.
- */

// Program title so students know what app they are running.
Console.WriteLine("=== Cozy Cafe Sign Maker Lab ===\n");

// Title banner pieces. We store them in variables to reuse and format them.
// New concept: storing UI strings in variables makes formatting easier later.
string title = "Cozy Cafe Sign Maker";
string subtitle = "Strings + Output Patterns";
string divider = new string('=', 40);

// Print a simple banner to make the UI feel organized.
Console.WriteLine(divider);
Console.WriteLine(title.ToUpper());
Console.WriteLine(subtitle);
Console.WriteLine(divider);

// choice controls the menu loop; start at 0 so the loop runs at least once.
int choice = 0;

// Main menu loop: keep showing options until the user chooses Exit (4).
// New concept: a loop controls the full app flow, not just one action.
while (choice != 4)
{
    // Blank line for readability between menu cycles.
    Console.WriteLine();
    // Menu box: fixed-width lines keep the menu aligned.
    Console.WriteLine("+--------------------------------------+");
    Console.WriteLine("| 1) Welcome Sign                      |");
    Console.WriteLine("| 2) Menu Line Formatter               |");
    Console.WriteLine("| 3) Quote Styler                      |");
    Console.WriteLine("| 4) Exit                              |");
    Console.WriteLine("+--------------------------------------+");

    // Read a safe menu choice (1-4). This uses a helper with input validation.
    choice = ReadIntInRange("Choose an option (1-4): ", 1, 4);
    // Space before option output.
    Console.WriteLine();

    // Switch routes the user to the correct option.
    // New concept: switch is a clean way to map numbers to features.
    switch (choice)
    {
        case 1:
            // Option 1: Welcome Sign (concatenation focus)
            Console.Write("Enter shop name: ");
            string shopName = Console.ReadLine();
            Console.Write("Enter a short tagline: ");
            string tagline = Console.ReadLine();
            // Trim and uppercase create a cleaner sign.
            // New concepts: Trim removes extra spaces; ToUpper normalizes casing.
            string trimmedShopName = shopName.Trim();
            string upperShopName = trimmedShopName.ToUpper();
            // Compare two strings (case-insensitive) to show basic string comparison.
            // New concept: Equals with StringComparison controls how strings are compared.
            string favoriteName = "Cozy Cafe";
            bool matchesFavorite = trimmedShopName.Equals(favoriteName, StringComparison.OrdinalIgnoreCase);

            // Build a boxed sign using concatenation and padding.
            // New concept: PadRight adds spaces so the box edges align.
            Console.WriteLine("-" + new string('-', 38) + "-");
            Console.WriteLine(("| WELCOME TO " + upperShopName + "!").PadRight(39) + "|");
            Console.WriteLine(("| " + tagline).PadRight(39) + "|");
            Console.WriteLine("-" + new string('-', 38) + "-");
            // Show comparison result as a simple true/false output.
            Console.WriteLine("Matches favorite name: " + matchesFavorite);
            break;
        case 2:
            // Option 2: Menu Line Formatter (placeholders + interpolation)
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine().Trim();
            double price = ReadDouble("Enter price: ");
            int calories = ReadIntInRange("Enter calories: ", 0, 2000);

            // Placeholders show a clean, labeled summary line.
            // New concept: string.Format uses {0}, {1}, {2} placeholders.
            Console.WriteLine(string.Format("Item: {0} | Calories: {1} | Price: {2:0.00}", itemName, calories, price));
            // Interpolation gives a quick friendly summary.
            // New concept: $"...{value}..." is interpolation.
            Console.WriteLine($"Quick view -> {itemName} ({calories} cal) = ${price:0.00}");
            // Table header for aligned columns.
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("| ITEM                 CAL     PRICE  |");
            Console.WriteLine("+--------------------------------------+");
            // Column formatting keeps the output aligned.
            // New concept: alignment widths in placeholders create columns.
            Console.WriteLine(string.Format("| {0,-20} {1,4} {2,9:C2} |", itemName, calories, price));
            Console.WriteLine("+--------------------------------------+");
            break;
        case 3:
            // Option 3: Quote Styler (string tools + placeholders/interpolation)
            Console.Write("Enter a customer quote: ");
            string quote = Console.ReadLine();
            // Trim removes extra spaces for consistent results.
            string trimmedQuote = quote.Trim();
            // Join characters with spaces for a spaced-out style.
            // New concept: Join combines a list into one string with a separator.
            string spaced = string.Join(" ", trimmedQuote.ToUpper().ToCharArray());
            // String length is a common property for analysis.
            // New concept: Length is a property, not a method.
            int length = trimmedQuote.Length;
            // Substring gives a short preview without error for short strings.
            // New concept: Substring(start, length) extracts part of a string.
            string preview = trimmedQuote.Length >= 5 ? trimmedQuote.Substring(0, 5) : trimmedQuote;
            // Contains checks for a keyword.
            // New concept: Contains returns true/false based on a match.
            bool containsCafe = trimmedQuote.ToLower().Contains("cafe");
            // EndsWith checks if the quote ends with punctuation.
            // New concept: EndsWith checks the end of the string.
            bool endsWithPunctuation = trimmedQuote.EndsWith("!", StringComparison.Ordinal) || trimmedQuote.EndsWith(".", StringComparison.Ordinal);
            // IndexOf shows where the first space appears (or -1 if none).
            // New concept: IndexOf returns the position or -1 if not found.
            int firstSpaceIndex = trimmedQuote.IndexOf(' ');

            // Use placeholders for the first two lines.
            Console.WriteLine(string.Format("Uppercase: {0}", trimmedQuote.ToUpper()));
            Console.WriteLine(string.Format("Spaced: {0}", spaced));
            // Use interpolation for the rest of the analysis output.
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Preview: {preview}");
            Console.WriteLine($"Contains 'cafe': {containsCafe}");
            Console.WriteLine($"Ends with punctuation: {endsWithPunctuation}");
            Console.WriteLine($"First space index: {firstSpaceIndex}");
            break;
        case 4:
            // Exit option ends the loop after printing a goodbye message.
            Console.WriteLine("Goodbye!");
            break;
    }

    // Add spacing between actions so outputs don't run together.
    if (choice != 4)
    {
        Console.WriteLine();
    }
}

// Helper method: read a whole number within a range using a do-while loop.
// New concept: TryParse returns true/false instead of crashing on bad input.
static int ReadIntInRange(string prompt, int min, int max)
{
    int value;
    bool isValid;

    do
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        isValid = int.TryParse(input, out value);
    } while (!isValid || value < min || value > max);

    return value;
}

// Helper method: read a decimal number using a do-while loop.
// New concept: the same validation pattern works for doubles.
static double ReadDouble(string prompt)
{
    double value;
    bool isValid;

    do
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        isValid = double.TryParse(input, out value);
    } while (!isValid);

    return value;
}
