/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Assignment: Week 8 Lab - Movie Tracker
-
- What does this program do?:
- Demonstrates how to create and use a custom class (Movie).
- Shows the difference between public and private methods.
- Practices using the debugger with breakpoints and step-through execution.
- */

namespace MovieTracker;

internal class Program
{
    private static void Main(string[] args)
    {
        // Program title
        Console.WriteLine("=== Movie Tracker Lab ===\n");

        // PART 1: Create a Movie object
        // New concept: We're creating an INSTANCE (object) of the Movie class
        // The 'new' keyword calls the constructor
        Logger.Info("Creating first movie...");
        Movie movie1 = new Movie(
            title: "The Shawshank Redemption",
            year: 1994,
            genre: "Drama",
            rating: 4.8,
            director: "Frank Darabont");

        // PART 2: Display movie information
        // New concept: Calling a PUBLIC method on the object
        // DisplayInfo() is accessible because it's marked 'public'
        Console.WriteLine();
        Logger.Info("Displaying movie 1 details:");
        movie1.DisplayInfo();

        // PART 3: Update the rating
        // This demonstrates method validation
        Console.WriteLine();
        Logger.Info("Updating movie 1 rating...");
        movie1.UpdateRating(5.0);

        // Display the updated information
        Console.WriteLine();
        movie1.DisplayInfo();

        // PART 4: Create a second movie
        // Shows that we can create multiple objects from the same class
        Console.WriteLine();
        Logger.Info("Creating second movie...");
        Movie movie2 = new Movie(
            title: "Inception",
            year: 2010,
            genre: "Sci-Fi",
            rating: 4.3,
            director: "Christopher Nolan");

        // Display the second movie
        Console.WriteLine();
        Logger.Info("Displaying movie 2 details:");
        movie2.DisplayInfo();

        // PART 5: Try an invalid rating update
        // Shows how validation works in the UpdateRating method
        Console.WriteLine();
        Logger.Info("Attempting invalid rating update...");
        movie2.UpdateRating(6.5);  // This should trigger a warning

        // PART 6: Create a third movie
        Console.WriteLine();
        Logger.Info("Creating third movie...");
        Movie movie3 = new Movie(
            title: "Spirited Away",
            year: 2001,
            genre: "Animation",
            rating: 4.7,
            director: "Hayao Miyazaki");

        Console.WriteLine();
        Logger.Info("Displaying movie 3 details:");
        movie3.DisplayInfo();

        // Summary
        Console.WriteLine();
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("  ✅ Lab Complete!");
        Console.WriteLine($"  📊 Total movies created: 3");
        Console.WriteLine("╚════════════════════════════════════════╝");
    }
}
