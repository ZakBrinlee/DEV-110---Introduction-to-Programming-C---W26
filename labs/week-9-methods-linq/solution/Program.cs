/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 9 Lab - Movie Tracker (LINQ Reports)
-
- What does this program do?:
- Runs a menu-driven movie reports app using LINQ (Min/Max/Average/OrderBy).
- */

using System.Globalization;
using System.Linq;

namespace MovieTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Movie Tracker: LINQ Reports ===\n");

        // Talking point: This lab is intentionally "pre-seeded" so we can focus on LINQ.
        // (No "add a movie" input flow this week.)
        List<Movie> movies = CreateSeedMovies();
        Logger.Info($"Loaded {movies.Count} movies.");

        // Talking point: A simple bool-controlled loop is an easy pattern for menus.
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            PrintMenu();

            // Talking point: Input validation belongs in a helper method so Main stays readable.
            int choice = ReadIntInRange("Choose an option (1-5): ", 1, 5);
            Console.WriteLine();

            // Talking point: switch is a clear way to map menu choices to actions.
            switch (choice)
            {
                case 1:
                    PrintAllMoviesSortedByTitle(movies);
                    break;
                case 2:
                    PrintTopRatedMovies(movies, 3);
                    break;
                case 3:
                    PrintGenreReport(movies);
                    break;
                case 4:
                    PrintOverallStats(movies);
                    break;
                case 5:
                    running = false;
                    break;
            }
        }

        Console.WriteLine("\nGoodbye!");
    }

    private static void PrintMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1) List all movies (sorted by title)");
        Console.WriteLine("2) Show top 3 highest-rated movies");
        Console.WriteLine("3) Genre report (sorted by rating)");
        Console.WriteLine("4) Overall stats (Min/Max/Average)");
        Console.WriteLine("5) Quit");
    }

    private static List<Movie> CreateSeedMovies()
    {
        return new List<Movie>
        {
            new Movie("The Shawshank Redemption", 1994, "Drama", 5.0, "Frank Darabont", 142),
            new Movie("Inception", 2010, "Sci-Fi", 4.6, "Christopher Nolan", 148),
            new Movie("Spirited Away", 2001, "Animation", 4.9, "Hayao Miyazaki", 125),
            new Movie("The Dark Knight", 2008, "Action", 4.8, "Christopher Nolan", 152),
            new Movie("Parasite", 2019, "Thriller", 4.7, "Bong Joon-ho", 132),
            new Movie("Toy Story", 1995, "Animation", 4.4, "John Lasseter", 81),
            new Movie("The Grand Budapest Hotel", 2014, "Comedy", 4.3, "Wes Anderson", 99),
            new Movie("Interstellar", 2014, "Sci-Fi", 4.5, "Christopher Nolan", 169),
        };
    }

    private static void PrintAllMoviesSortedByTitle(List<Movie> movies)
    {
        Logger.Info("Listing all movies (sorted by title)...");

        // Talking point: OrderBy returns a NEW sequence; it does not change the original list.
        // We're sorting by Title (A→Z).
        IEnumerable<Movie> sorted = movies.OrderBy(m => m.Title);

        foreach (Movie movie in sorted)
        {
            movie.DisplayInfo();
        }

        Console.WriteLine($"Total: {movies.Count}");
    }

    private static void PrintTopRatedMovies(List<Movie> movies, int topCount)
    {
        Logger.Info($"Top {topCount} highest-rated movies:");

        // Talking point: This is a LINQ "pipeline": sort → tie-break → take.
        // - OrderByDescending: highest rating first
        // - ThenBy: stable tie-breaker (same rating sorts by Title)
        // - Take: only keep the first N items
        IEnumerable<Movie> top = movies
            .OrderByDescending(m => m.Rating)
            .ThenBy(m => m.Title)
            .Take(topCount);

        foreach (Movie movie in top)
        {
            movie.DisplayInfo();
        }
    }

    private static void PrintGenreReport(List<Movie> movies)
    {
        // Talking point: Genre input is user-entered, so we validate it isn't blank.
        string genre = ReadNonEmptyString("Enter a genre: ");

        // Talking point: We compare genres case-insensitively so "drama" matches "Drama".
        // ToList() materializes the query so we can count once and reuse results.
        List<Movie> matches = movies
            .Where(m => string.Equals(m.Genre, genre, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(m => m.Rating)
            .ThenBy(m => m.Title)
            .ToList();

        if (matches.Count == 0)
        {
            Logger.Warn($"No movies found for genre: {genre}");
            return;
        }

        Logger.Info($"Genre report for: {matches[0].Genre}");

        // Talking point: Min/Max/Average are LINQ "aggregation" methods.
        // They scan the sequence and produce a single value.
        double minRating = matches.Min(m => m.Rating);
        double maxRating = matches.Max(m => m.Rating);
        double averageRating = matches.Average(m => m.Rating);

        Console.WriteLine($"Count: {matches.Count}");

        // Talking point: InvariantCulture keeps decimal formatting consistent across computers.
        // (Some locales use comma instead of a decimal point.)
        Console.WriteLine($"Min rating: {minRating.ToString("0.0", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Max rating: {maxRating.ToString("0.0", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Avg rating: {averageRating.ToString("0.0", CultureInfo.InvariantCulture)}");
        Console.WriteLine();

        foreach (Movie movie in matches)
        {
            movie.DisplayInfo();
        }
    }

    private static void PrintOverallStats(List<Movie> movies)
    {
        Logger.Info("Overall stats:");

        // Talking point: These work on the whole list (not filtered).
        double minRating = movies.Min(m => m.Rating);
        double maxRating = movies.Max(m => m.Rating);
        double averageRating = movies.Average(m => m.Rating);

        int minRuntime = movies.Min(m => m.RuntimeMinutes);
        int maxRuntime = movies.Max(m => m.RuntimeMinutes);
        double averageRuntime = movies.Average(m => m.RuntimeMinutes);

        Console.WriteLine($"Movies: {movies.Count}");
        Console.WriteLine($"Rating (min/max/avg): {minRating:0.0} / {maxRating:0.0} / {averageRating.ToString("0.0", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Runtime (min/max/avg): {minRuntime} / {maxRuntime} / {averageRuntime.ToString("0.0", CultureInfo.InvariantCulture)}");

        // Talking point: First() grabs one item from a sorted sequence.
        // It's a clean way to ask "which movie is best/shortest?"
        Movie highestRated = movies.OrderByDescending(m => m.Rating).ThenBy(m => m.Title).First();
        Movie shortest = movies.OrderBy(m => m.RuntimeMinutes).ThenBy(m => m.Title).First();

        Console.WriteLine();
        Console.WriteLine("Highest rated:");
        highestRated.DisplayInfo();

        Console.WriteLine("Shortest runtime:");
        shortest.DisplayInfo();
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        // Talking point: do/while ensures the prompt runs at least once.
        // We validate BOTH: it must parse to an int, and it must be within range.
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    private static string ReadNonEmptyString(string prompt)
    {
        // Talking point: This loop continues until the user gives us a non-blank answer.
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
        }
    }
}
