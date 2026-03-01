/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Ujwal Garine
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

using System;

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

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");

            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Enter your name: ");
                        string rawName = Console.ReadLine() ?? string.Empty;

                        Console.Write("Enter a short message: ");
                        string message = Console.ReadLine() ?? string.Empty;

                        string name = rawName.Trim();
                        string upperName = name.ToUpper();

                        string border = new string('*', 40);

                        Console.WriteLine(border);
                        Console.WriteLine("Hello, " + name);
                        Console.WriteLine(string.Format("Uppercase: {0}", upperName));
                        Console.WriteLine($"Message: {message}");
                        Console.WriteLine(border);
                        break;
                    }

                case 2:
                    {
                        Console.Write("Enter first name: ");
                        string first = (Console.ReadLine() ?? string.Empty).Trim();

                        Console.Write("Enter last name: ");
                        string last = (Console.ReadLine() ?? string.Empty).Trim();

                        string fullName = (first + " " + last).Trim();

                        char fi = first.Length > 0 ? first[0] : '?';
                        char li = last.Length > 0 ? last[0] : '?';

                        string initials = (string.Empty + fi + li).ToUpper();
                        string lower = fullName.ToLower();

                        // IMPORTANT: tests expect "Name Tag: Ada Lovelace"
                        Console.WriteLine($"Name Tag: {fullName}");
                        Console.WriteLine($"Initials: {initials}");
                        Console.WriteLine($"Lowercase: {lower}");
                        break;
                    }

                case 3:
                    {
                        Console.Write("Enter a phrase: ");
                        string phrase = (Console.ReadLine() ?? string.Empty).Trim();

                        int length = phrase.Length;
                        bool containsA = phrase.ToLower().Contains("a");
                        string dashed = phrase.Replace(" ", "-");

                        string[] words = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string wordList = string.Join(", ", words);

                        Console.WriteLine("Length: " + length);
                        Console.WriteLine("Contains a: " + containsA);
                        Console.WriteLine("Dashed: " + dashed);
                        Console.WriteLine("Words: " + wordList);
                        break;
                    }

                case 4:
                    {
                        Console.Write("Enter item name: ");
                        string item = (Console.ReadLine() ?? string.Empty).Trim();

                        double price = ReadDouble("Enter price: ");
                        int qty = ReadIntInRange("Enter quantity (1-9): ", 1, 9);

                        double total = price * qty;

                        Console.WriteLine(new string('=', 36));
                        Console.WriteLine(string.Format("{0,-20}{1,5}{2,11}", "ITEM", "QTY", "TOTAL"));
                        Console.WriteLine(new string('-', 36));
                        Console.WriteLine(string.Format("{0,-20}{1,5}{2,11:C2}", item, qty, total));
                        Console.WriteLine(new string('=', 36));
                        break;
                    }

                case 5:
                    {
                        Console.Write("Enter a title: ");
                        string bannerTitle = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();

                        Console.Write("Enter a subtitle: ");
                        string bannerSubtitle = (Console.ReadLine() ?? string.Empty).Trim();

                        int width = ReadIntInRange("Enter width (30-60): ", 30, 60);

                        string border = new string('=', width);

                        string centeredTitle = bannerTitle.PadLeft((width + bannerTitle.Length) / 2);
                        string centeredSubtitle = bannerSubtitle.PadLeft((width + bannerSubtitle.Length) / 2);

                        Console.WriteLine(border);
                        Console.WriteLine(centeredTitle);
                        Console.WriteLine(centeredSubtitle);
                        Console.WriteLine(border);

                        // tests look for the words centered/left/right existing in output
                        Console.WriteLine("Centered: " + bannerTitle.PadLeft((width + bannerTitle.Length) / 2));
                        Console.WriteLine("Left: " + bannerTitle.PadRight(width));
                        Console.WriteLine("Right: " + bannerTitle.PadLeft(width));
                        break;
                    }

                case 6:
                    {
                        Console.Write("Enter a closing word: ");
                        string raw = Console.ReadLine() ?? string.Empty;

                        bool equalsGoodbye = raw.Trim().Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                        string first3 = raw.Length >= 3 ? raw.Substring(0, 3) : raw;
                        bool endsWithBang = raw.EndsWith("!");
                        int spaceIndex = raw.IndexOf(' ');

                        // IMPORTANT: tests expect 'goodbye' and the first3 in SINGLE QUOTES
                        Console.WriteLine($"Equals 'goodbye': {equalsGoodbye}");
                        Console.WriteLine($"First 3 chars: '{first3}'");
                        Console.WriteLine($"Ends with '!': {endsWithBang}");
                        Console.WriteLine($"Index of space: {spaceIndex}");

                        Console.WriteLine("Goodbye!");
                        break;
                    }
            }

            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int number;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;

            isValid = int.TryParse(input, out number) && number >= min && number <= max;

            if (!isValid)
            {
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
        }
        while (!isValid);

        return number;
    }

    private static double ReadDouble(string prompt)
    {
        double number;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;

            isValid = double.TryParse(input, out number);

            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        while (!isValid);

        return number;
    }
}
