/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
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
    internal static void Main(string[] args)
    {
        // Program title
        Console.WriteLine("=== Movie Tracker Lab ===\n");

        // TODO 6: Create the first Movie object
        // Use the Movie constructor with named parameters:
        // - title: "The Shawshank Redemption"
        // - year: 1994
        // - genre: "Drama"
        // - rating: 4.8
        // - director: "Frank Darabont"
        // Store it in a variable: Movie movie1 = new Movie(...);
        // BEFORE creating the movie, log: Logger.Info("Creating first movie...");

        // TODO 7: Display the first movie
        // Print a blank line: Console.WriteLine();
        // Log: Logger.Info("Displaying movie 1 details:");
        // Call the DisplayInfo method on movie1

        // TODO 8: Update the movie rating
        // Print a blank line: Console.WriteLine();
        // Log: Logger.Info("Updating movie 1 rating...");
        // Call movie1.UpdateRating(5.0);

        // TODO 9: Display the updated movie
        // Print a blank line: Console.WriteLine();
        // Call movie1.DisplayInfo() again to show the updated rating

        // TODO 10: Create the second Movie object
        // Print a blank line: Console.WriteLine();
        // Log: Logger.Info("Creating second movie...");
        // Create movie2 with these details:
        // - title: "Inception"
        // - year: 2010
        // - genre: "Sci-Fi"
        // - rating: 4.3
        // - director: "Christopher Nolan"

        // TODO 11: Display the second movie
        // Print a blank line: Console.WriteLine();
        // Log: Logger.Info("Displaying movie 2 details:");
        // Call movie2.DisplayInfo()

        // TODO 12: Try an invalid rating update
        // Print a blank line: Console.WriteLine();
        // Log: Logger.Info("Attempting invalid rating update...");
        // Call movie2.UpdateRating(6.5); - this should trigger a warning!

        // TODO 13: Create the third Movie object
        // Print a blank line: Console.WriteLine();
        // Log: Logger.Info("Creating third movie...");
        // Create movie3 with these details:
        // - title: "Spirited Away"
        // - year: 2001
        // - genre: "Animation"
        // - rating: 4.7
        // - director: "Hayao Miyazaki"

        // TODO 14: Display the third movie
        // Print a blank line: Console.WriteLine();
        // Log: Logger.Info("Displaying movie 3 details:");
        // Call movie3.DisplayInfo()

        // TODO 15: Print the summary
        // Print a blank line: Console.WriteLine();
        // Print this box:
        // ╔════════════════════════════════════════╗
        //   ✅ Lab Complete!
        //   📊 Total movies created: 3
        // ╚════════════════════════════════════════╝
    }
}
