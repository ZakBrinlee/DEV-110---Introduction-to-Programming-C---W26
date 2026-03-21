/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: YourName
 * Assignment: Week 10 Lab - Movie Tracker (Save & Load)
 *
 * What does this program do?:
 * Loads movies from a CSV file (or seed data if no file exists),
 * lets the user add movies, and saves the list back to a file.
 * ******************************************************************************/

using System.Globalization;
using System.Linq;

namespace MovieTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Movie Tracker: Save & Load ===\n");

        string filePath = "movies.csv";

        // TODO 1: Load movies from file (or fall back to seed data)
        // Check if filePath exists using File.Exists(filePath).
        //
        // If the file EXISTS:
        //   - Call LoadMovies(filePath) to parse it into a List<Movie>
        //   - Log: Logger.Info($"Loaded {movies.Count} movies from {filePath}.");
        //
        // If the file does NOT exist:
        //   - Log: Logger.Info("No movies.csv found. Loading seed movies...");
        //   - Call LoadSeedMovies() to get the default list
        //   - Log: Logger.Info($"Loaded {movies.Count} movies.");
        //
        // Store the result in: List<Movie> movies
        List<Movie> movies = LoadSeedMovies();
        Logger.Info($"Loaded {movies.Count} movies.");

        // TODO 2: Build the main menu loop
        // Requirements:
        // - Declare: bool running = true;
        // - Use a while (running) loop
        // - Inside the loop:
        //     Console.WriteLine();        ← blank line before menu
        //     Call PrintMenu()
        //     Read: int choice = ReadIntInRange("Choose an option (1-6): ", 1, 6)
        //     Console.WriteLine();        ← blank line after input
        //     Use switch(choice) to call the right method:
        //       case 1 → PrintAllMovies(movies)
        //       case 2 → AddMovie(movies)
        //       case 3 → UpdateMovie(movies)
        //       case 4 → DeleteMovie(movies)
        //       case 5 → SaveMovies(filePath, movies)
        //       case 6 → set running = false
        // ---
        Console.WriteLine("\nGoodbye!");
    }

    // TODO 3: Implement PrintAllMovies
    // Requirements:
    // - If movies.Count == 0: log Logger.Warn("No movies to display.") and return
    // - Otherwise log: Logger.Info("All movies:")
    // - Loop through movies and call movie.DisplayInfo()
    // - Print: $"Total: {movies.Count}"
    private static void PrintAllMovies(List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    // TODO 4: Implement AddMovie
    // Requirements:
    // - Print: Console.WriteLine("[INFO] Enter new movie details:");
    // - Use ReadNonEmptyString for: title, genre, director
    // - Use ReadIntInRange for:
    //     year (prompt "Year: ", min 1888, max 2030)
    //     runtime (prompt "Runtime (minutes): ", min 1, max 999)
    // - Use ReadDoubleInRange for:
    //     rating (prompt "Rating (1.0-5.0): ", min 1.0, max 5.0)
    // - Create: Movie newMovie = new Movie(title, year, genre, rating, director, runtime);
    // - movies.Add(newMovie);
    // - Log: Logger.Info($"Added: {title}");
    private static void AddMovie(List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    // TODO 5: Implement UpdateMovie
    // Shows a numbered list of movies and lets the user update one movie's rating.
    //
    // Requirements:
    // - If movies.Count == 0: log Logger.Warn("No movies to update.") and return
    // - Log: Logger.Info("Select a movie to update:")
    // - Print a numbered list: "  1) Inception (2010)", "  2) Parasite (2019)", etc.
    //     Use: for (int i = 0; i < movies.Count; i++) { Console.WriteLine($"  {i + 1}) {movies[i].Title} ({movies[i].Year})"); }
    // - Read: int index = ReadIntInRange("Enter movie number: ", 1, movies.Count) - 1;
    // - Read: double newRating = ReadDoubleInRange("New rating (1.0-5.0): ", 1.0, 5.0);
    // - Set: movies[index].Rating = newRating;
    // - Log: Logger.Info($"Updated: {movies[index].Title} — rating now {newRating:0.0}");
    private static void UpdateMovie(List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    // TODO 6: Implement DeleteMovie
    // Shows a numbered list of movies and lets the user remove one.
    //
    // Requirements:
    // - If movies.Count == 0: log Logger.Warn("No movies to delete.") and return
    // - Log: Logger.Info("Select a movie to delete:")
    // - Print the same numbered list as UpdateMovie
    // - Read: int index = ReadIntInRange("Enter movie number: ", 1, movies.Count) - 1;
    // - Save the title first: string deletedTitle = movies[index].Title;
    // - Remove: movies.RemoveAt(index);
    // - Log: Logger.Info($"Deleted: {deletedTitle}");
    private static void DeleteMovie(List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    // TODO 7: Implement FormatMovieAsCsv
    // Returns a CSV line string for one movie.
    // Format: "Title,Year,Genre,Rating,Director,RuntimeMinutes"
    // Example: "Inception,2010,Sci-Fi,4.6,Christopher Nolan,148"
    //
    // Hint: Use movie.Rating.ToString("0.0", CultureInfo.InvariantCulture) for the rating.
    private static string FormatMovieAsCsv(Movie movie)
    {
        throw new NotImplementedException();
    }

    // TODO 8: Implement SaveMovies
    // Requirements:
    // - Build a string[] of CSV lines:
    //     string[] csvLines = movies.Select(m => FormatMovieAsCsv(m)).ToArray();
    // - Write to the file: File.WriteAllLines(path, csvLines);
    // - Log: Logger.Info($"Saved {movies.Count} movies to {path}.");
    private static void SaveMovies(string path, List<Movie> movies)
    {
        throw new NotImplementedException();
    }

    // Provided: Parse one CSV line into a Movie object
    // Format expected: "Title,Year,Genre,Rating,Director,RuntimeMinutes"
    private static Movie ParseMovieLine(string line)
    {
        string[] parts = line.Split(',');
        string title = parts[0].Trim();
        int year = int.Parse(parts[1].Trim());
        string genre = parts[2].Trim();
        double rating = double.Parse(parts[3].Trim(), CultureInfo.InvariantCulture);
        string director = parts[4].Trim();
        int runtime = int.Parse(parts[5].Trim());
        return new Movie(title, year, genre, rating, director, runtime);
    }

    // Provided: Load movies from an existing CSV file
    private static List<Movie> LoadMovies(string path)
    {
        string[] lines = File.ReadAllLines(path);
        List<Movie> movies = new List<Movie>();

        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                movies.Add(ParseMovieLine(line));
            }
        }

        return movies;
    }

    // Provided: Seed movie list (used when no file exists yet)
    private static List<Movie> LoadSeedMovies()
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

    // Provided: Menu display
    private static void PrintMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1) List all movies");
        Console.WriteLine("2) Add a movie");
        Console.WriteLine("3) Update a movie's rating");
        Console.WriteLine("4) Delete a movie");
        Console.WriteLine("5) Save movies to file");
        Console.WriteLine("6) Quit");
    }

    // Provided: Read a validated integer in [min, max]
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

    // Provided: Read a validated double in [min, max]
    private static double ReadDoubleInRange(string prompt, double min, double max)
    {
        double value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    // Provided: Read a non-empty string
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
