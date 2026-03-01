/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Assignment: Week 8 Lab - Movie Tracker
-
- What does this file do?:
- Represents a single movie with properties and methods to display and update info.
- Demonstrates the structure of a class with public and private members.
- */

namespace MovieTracker;

/// <summary>
/// Represents a movie with title, year, genre, rating, and director.
/// </summary>
public class Movie
{
    // Properties: store the movie's data
    // These are public so they can be accessed from outside the class
    public string Title { get; set; }

    public int Year { get; set; }

    public string Genre { get; set; }

    public double Rating { get; set; } // 0.0 to 5.0 scale

    public string Director { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Movie"/> class.
    /// Creates a new Movie with the given details.
    /// </summary>
    /// <param name="title">The movie title.</param>
    /// <param name="year">The release year.</param>
    /// <param name="genre">The movie genre.</param>
    /// <param name="rating">Rating from 0.0 to 5.0.</param>
    /// <param name="director">The director's name.</param>
    public Movie(string title, int year, string genre, double rating, string director)
    {
        Title = title;
        Year = year;
        Genre = genre;
        Rating = rating;
        Director = director;
    }

    /// <summary>
    /// Displays the movie information in a formatted way.
    /// This is a PUBLIC method - it can be called from outside the class.
    /// </summary>
    public void DisplayInfo()
    {
        // Call the private helper to get the star display
        string stars = GetStarDisplay();

        // Print formatted movie information
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine($"  📽️  {Title} ({Year})");
        Console.WriteLine($"  🎬 Director: {Director}");
        Console.WriteLine($"  🎭 Genre: {Genre}");
        Console.WriteLine($"  ⭐ Rating: {stars} ({Rating}/5.0)");
        Console.WriteLine("╚════════════════════════════════════════╝");
    }

    /// <summary>
    /// Converts the numeric rating to a star display (e.g., ★★★★☆).
    /// This is a PRIVATE method - it can only be called from within this class.
    /// Private methods are helpers that organize the code but shouldn't be accessed externally.
    /// </summary>
    /// <returns>A string of filled and empty stars.</returns>
    private string GetStarDisplay()
    {
        // Round the rating to determine filled stars
        int filledStars = (int)Math.Round(Rating);
        int emptyStars = 5 - filledStars;

        // Build the star string
        string stars = new string('★', filledStars) + new string('☆', emptyStars);
        return stars;
    }

    /// <summary>
    /// Updates the movie's rating with validation.
    /// This is a PUBLIC method that uses input validation.
    /// </summary>
    /// <param name="newRating">The new rating value (0.0 to 5.0).</param>
    public void UpdateRating(double newRating)
    {
        // Validate the rating is in the correct range
        if (newRating < 0.0 || newRating > 5.0)
        {
            Logger.Warn("Rating must be between 0.0 and 5.0!");
            return;
        }

        // Store the old rating for comparison
        double oldRating = Rating;

        // Update to the new rating
        Rating = newRating;

        // Log the change
        Logger.Info($"Rating updated from {oldRating:0.0} to {Rating:0.0}");
    }
}
