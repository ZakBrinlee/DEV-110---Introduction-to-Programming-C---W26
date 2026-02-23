/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 9: Score Stats (Methods + LINQ)
-
- What does this program do?:
- Prompts for test scores and prints summary stats using methods and LINQ.
- */

using System.Globalization;
using System.Linq;

namespace ScoreStats;

/// <summary>
/// Main program class for the Score Stats application.
/// This week's focus: implementing LINQ-based report methods in the ScoreReport class.
/// All input/parsing helper methods are provided below.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point for the application.
    /// Runs a loop that allows the user to analyze multiple sets of scores.
    /// </summary>
    /// <param name="args">Command-line arguments (not used).</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Score Stats: Methods + LINQ ===");
        Console.WriteLine();

        // Main loop: allows the user to analyze multiple score sets
        // This pattern (do-while with a bool flag) is common for menu-driven programs
        bool analyzeAgain;
        do
        {
            // Analyze one set of scores
            RunOneAnalysis();
            Console.WriteLine();

            // Ask if the user wants to continue
            analyzeAgain = ReadYesNo("Analyze another set? (y/n): ");
            Console.WriteLine();
        }
        while (analyzeAgain);
    }

    /// <summary>
    /// Runs one complete score analysis cycle.
    /// This is a "wrapper method" that coordinates input reading and report generation.
    /// </summary>
    private static void RunOneAnalysis()
    {
        // Step 1: Read and validate scores from CSV input
        int[] scores = ReadScoresCsv("Enter scores (comma-separated 0-100): ");

        // Step 2: Read and validate the passing threshold
        int threshold = ReadIntInRange("Enter passing threshold (0-100): ", 0, 100);
        Console.WriteLine();

        // Step 3: Create a report object and let it print the analysis
        // The ScoreReport class encapsulates all the score analysis logic
        ScoreReport report = new ScoreReport(scores, threshold);
        report.PrintReport();
    }

    /// <summary>
    /// Reads and validates a comma-separated list of scores from user input.
    /// Keeps prompting until valid input is provided.
    /// </summary>
    /// <param name="prompt">The prompt to display to the user.</param>
    /// <returns>An array of valid scores (0-100).</returns>
    private static int[] ReadScoresCsv(string prompt)
    {
        // Loop until we get valid input
        // This pattern ensures the program never crashes from bad input
        while (true)
        {
            // Get a non-empty line from the user
            string line = ReadNonEmptyString(prompt);

            // Try to parse it into an array of scores
            // If successful, return the scores; otherwise, loop and try again
            if (TryParseScores(line, out int[] scores))
            {
                return scores;
            }
        }
    }

    /// <summary>
    /// Attempts to parse a comma-separated string into an array of valid scores.
    /// </summary>
    /// <param name="input">The comma-separated input string.</param>
    /// <param name="scores">Output parameter that receives the parsed scores if successful.</param>
    /// <returns>True if parsing succeeded and all scores are valid (0-100); false otherwise.</returns>
    private static bool TryParseScores(string input, out int[] scores)
    {
        // Default to an empty array in case parsing fails
        scores = Array.Empty<int>();

        // Split the input by commas
        // RemoveEmptyEntries ensures we skip blank segments (e.g., from "10, ,20")
        string[] pieces = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
        if (pieces.Length == 0)
        {
            return false;
        }

        // Build up a list of parsed scores
        List<int> parsed = new List<int>();

        // Process each piece (potential score)
        foreach (string piece in pieces)
        {
            // Trim whitespace so "10" and " 10 " both work
            string trimmed = piece.Trim();

            // Try to parse as an integer
            bool isInt = int.TryParse(trimmed, out int value);

            // Validate: must be a valid int AND in range 0-100
            if (!isInt || value < 0 || value > 100)
            {
                return false;
            }

            parsed.Add(value);
        }

        // Convert the list to an array and return success
        scores = parsed.ToArray();
        return scores.Length > 0;
    }

    /// <summary>
    /// Reads an integer from the user and validates it's within a specified range.
    /// Keeps prompting until valid input is provided.
    /// </summary>
    /// <param name="prompt">The prompt to display to the user.</param>
    /// <param name="min">The minimum acceptable value (inclusive).</param>
    /// <param name="max">The maximum acceptable value (inclusive).</param>
    /// <returns>A valid integer within [min, max].</returns>
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        // do-while ensures we prompt at least once
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;

            // Try to parse the input as an integer
            isValid = int.TryParse(input, out value);

            // Keep looping if:
            // - Parse failed (not a valid integer), OR
            // - Value is outside the acceptable range
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    /// <summary>
    /// Reads a yes/no response from the user.
    /// Accepts 'y' or 'n' (case-insensitive) and keeps prompting until valid input is provided.
    /// </summary>
    /// <param name="prompt">The prompt to display to the user.</param>
    /// <returns>True if user entered 'y'; false if user entered 'n'.</returns>
    private static bool ReadYesNo(string prompt)
    {
        // Infinite loop until we get valid input
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            // Check for 'y' (case-insensitive)
            if (string.Equals(input, "y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            // Check for 'n' (case-insensitive)
            if (string.Equals(input, "n", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            // If neither 'y' nor 'n', loop continues (implicit re-prompt)
        }
    }

    /// <summary>
    /// Reads a non-empty string from the user.
    /// Keeps prompting until a non-whitespace string is entered.
    /// </summary>
    /// <param name="prompt">The prompt to display to the user.</param>
    /// <returns>A non-empty, trimmed string.</returns>
    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            // Return as soon as we get something that isn't just whitespace
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
        }
    }
}
