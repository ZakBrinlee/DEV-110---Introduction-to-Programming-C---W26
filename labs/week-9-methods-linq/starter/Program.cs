/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 9 Lab - Movie Tracker (LINQ Reports)
-
- What does this program do?:
- Builds a menu-driven movie reports app using LINQ (Min/Max/Average/OrderBy).
- */

using System.Globalization;
using System.Linq;

namespace MovieTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Movie Tracker: LINQ Reports ===\n");

        // TODO 1: Create the pre-seeded movie list
        // Use the provided CreateSeedMovies() method.
        // Store it in a variable named: movies
        // After that, log how many movies were loaded:
        // Logger.Info($"Loaded {movies.Count} movies.");

        // TODO 2: Build the main menu loop
        // Requirements:
        // - Use a bool named running (start it as true)
        // - Use a while loop
        // - Each loop should:
        //   - Print a blank line
        //   - Call PrintMenu()
        //   - Read the user's choice using ReadIntInRange("Choose an option (1-5): ", 1, 5)
        //   - Print a blank line
        //   - Use a switch(choice) to call the correct report method
        //   - Quit choice (5) should set running = false
        // ---
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

    // Provided: pre-seeded movies (no input for adding movies this week)
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

    // TODO 3: Implement PrintAllMoviesSortedByTitle
    // Requirements:
    // - Log: Logger.Info("Listing all movies (sorted by title)...");
    // - Use LINQ OrderBy(m => m.Title)
    // - Loop through the sorted movies and call movie.DisplayInfo()
    // - Print: $"Total: {movies.Count}" at the end
    private static void PrintAllMoviesSortedByTitle(List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    // TODO 4: Implement PrintTopRatedMovies
    // Requirements:
    // - Log: Logger.Info($"Top {topCount} highest-rated movies:");
    // - Use LINQ OrderByDescending(m => m.Rating)
    // - Use ThenBy(m => m.Title)
    // - Use Take(topCount)
    // - Print each movie using DisplayInfo()
    private static void PrintTopRatedMovies(List<Movie> movies, int topCount)
    {
        throw new NotImplementedException();
    }

    // TODO 5: Implement PrintGenreReport
    // Requirements:
    // - Read a genre using ReadNonEmptyString("Enter a genre: ")
    // - Filter with Where(...) using case-insensitive comparison
    // - Sort matches by rating (desc) and then title
    // - If there are 0 matches, warn and return
    // - Otherwise print:
    //   Count, Min rating, Max rating, Avg rating (each to 1 decimal place)
    // - Then print each movie with DisplayInfo()
    private static void PrintGenreReport(List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    // TODO 6: Implement PrintOverallStats
    // Requirements:
    // - Log: Logger.Info("Overall stats:");
    // - Use LINQ Min/Max/Average for Rating and RuntimeMinutes
    // - Print these lines (format average to 1 decimal place):
    //   Movies: X
    //   Rating (min/max/avg): a / b / c
    //   Runtime (min/max/avg): a / b / c
    // - Use OrderByDescending to find the highest-rated movie and print it
    // - Use OrderBy to find the shortest runtime movie and print it
    private static void PrintOverallStats(List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

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
