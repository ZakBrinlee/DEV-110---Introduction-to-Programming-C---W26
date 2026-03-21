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

        // Talking point: File.Exists is a simple way to check before reading.
        // It avoids the need for a try-catch when falling back to seed data is acceptable.
        List<Movie> movies = LoadMoviesOrSeed(filePath);

        // Talking point: A bool-controlled while loop is the standard pattern for menus.
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            PrintMenu();

            int choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    PrintAllMovies(movies);
                    break;
                case 2:
                    AddMovie(movies);
                    break;
                case 3:
                    UpdateMovie(movies);
                    break;
                case 4:
                    DeleteMovie(movies);
                    break;
                case 5:
                    SaveMovies(filePath, movies);
                    break;
                case 6:
                    running = false;
                    break;
            }
        }

        Console.WriteLine("\nGoodbye!");
    }

    // Talking point: Extracting the load logic keeps Main readable.
    // File.Exists guards against FileNotFoundException without a try-catch.
    private static List<Movie> LoadMoviesOrSeed(string path)
    {
        if (File.Exists(path))
        {
            List<Movie> movies = LoadMovies(path);
            Logger.Info($"Loaded {movies.Count} movies from {path}.");
            return movies;
        }
        else
        {
            Logger.Info("No movies.csv found. Loading seed movies...");
            List<Movie> movies = LoadSeedMovies();
            Logger.Info($"Loaded {movies.Count} movies.");
            return movies;
        }
    }

    private static void PrintAllMovies(List<Movie> movies)
    {
        if (movies.Count == 0)
        {
            Logger.Warn("No movies to display.");
            return;
        }

        Logger.Info("All movies:");

        foreach (Movie movie in movies)
        {
            movie.DisplayInfo();
        }

        Console.WriteLine($"Total: {movies.Count}");
    }

    private static void AddMovie(List<Movie> movies)
    {
        // Talking point: Printing [INFO] manually (without Logger) keeps the prompt
        // consistent with the rest of the input flow — no color change mid-prompt.
        Console.WriteLine("[INFO] Enter new movie details:");

        string title = ReadNonEmptyString("Title: ");
        int year = ReadIntInRange("Year: ", 1888, 2030);
        string genre = ReadNonEmptyString("Genre: ");
        double rating = ReadDoubleInRange("Rating (1.0-5.0): ", 1.0, 5.0);
        string director = ReadNonEmptyString("Director: ");
        int runtime = ReadIntInRange("Runtime (minutes): ", 1, 999);

        Movie newMovie = new Movie(title, year, genre, rating, director, runtime);
        movies.Add(newMovie);

        Logger.Info($"Added: {title}");
    }

    // Talking point: A numbered list makes it easy to pick a movie by index.
    // ReadIntInRange validates the pick and subtracting 1 converts to 0-based index.
    private static void UpdateMovie(List<Movie> movies)
    {
        if (movies.Count == 0)
        {
            Logger.Warn("No movies to update.");
            return;
        }

        Logger.Info("Select a movie to update:");
        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine($"  {i + 1}) {movies[i].Title} ({movies[i].Year})");
        }

        int index = ReadIntInRange("Enter movie number: ", 1, movies.Count) - 1;
        double newRating = ReadDoubleInRange("New rating (1.0-5.0): ", 1.0, 5.0);

        movies[index].Rating = newRating;
        Logger.Info($"Updated: {movies[index].Title} — rating now {newRating:0.0}");
    }

    // Talking point: List.RemoveAt shifts everything after the removed element down.
    // Always validate the index with ReadIntInRange before calling RemoveAt.
    private static void DeleteMovie(List<Movie> movies)
    {
        if (movies.Count == 0)
        {
            Logger.Warn("No movies to delete.");
            return;
        }

        Logger.Info("Select a movie to delete:");
        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine($"  {i + 1}) {movies[i].Title} ({movies[i].Year})");
        }

        int index = ReadIntInRange("Enter movie number: ", 1, movies.Count) - 1;
        string deletedTitle = movies[index].Title;
        movies.RemoveAt(index);
        Logger.Info($"Deleted: {deletedTitle}");
    }

    // Talking point: FormatMovieAsCsv is the inverse of ParseMovieLine.
    // The same field order and InvariantCulture must be used in both directions.
    private static string FormatMovieAsCsv(Movie movie)
    {
        return string.Join(
            ',',
            movie.Title,
            movie.Year,
            movie.Genre,
            movie.Rating.ToString("0.0", CultureInfo.InvariantCulture),
            movie.Director,
            movie.RuntimeMinutes);
    }

    private static void SaveMovies(string path, List<Movie> movies)
    {
        // Talking point: Select + ToArray converts a List<Movie> to string[] in one line.
        // File.WriteAllLines handles file creation, overwriting, and closing automatically.
        string[] csvLines = movies.Select(m => FormatMovieAsCsv(m)).ToArray();
        File.WriteAllLines(path, csvLines);
        Logger.Info($"Saved {movies.Count} movies to {path}.");
    }

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

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        // Talking point: do-while ensures the prompt runs at least once.
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }

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
