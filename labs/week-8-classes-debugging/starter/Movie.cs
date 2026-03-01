/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
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
    // TODO 1: Add properties
    // Properties store the movie's data and are public so they can be accessed from outside the class.
    // Required properties:
    // - Title (string)
    // - Year (int)
    // - Genre (string)
    // - Rating (double) - scale from 0.0 to 5.0
    // - Director (string)
    // Hint: Use auto-properties - public string Title { get; set; }

    /// <summary>
    /// Creates a new Movie with the given details.
    /// </summary>
    /// <param name="title">The movie title</param>
    /// <param name="year">The release year</param>
    /// <param name="genre">The movie genre</param>
    /// <param name="rating">Rating from 0.0 to 5.0</param>
    /// <param name="director">The director's name</param>
    public Movie(string title, int year, string genre, double rating, string director)
    {
        // TODO 2: Assign the parameters to the properties
        // Inside the constructor, set each property to its matching parameter.
        // Example: Title = title;
        throw new NotImplementedException();
    }

    /// <summary>
    /// Displays the movie information in a formatted way.
    /// This is a PUBLIC method - it can be called from outside the class.
    /// </summary>
    public void DisplayInfo()
    {
        // TODO 3: Display formatted movie information
        // Print a box with the movie details:
        // - Title and Year
        // - Director
        // - Genre
        // - Rating (use the GetStarDisplay helper method)
        // Use Console.WriteLine and string interpolation
        // Example first line: Console.WriteLine("╔════════════════════════════════════════╗");
        throw new NotImplementedException();
    }

    /// <summary>
    /// Converts the numeric rating to a star display (e.g., ★★★★☆).
    /// This is a PRIVATE method - it can only be called from within this class.
    /// Private methods are helpers that organize the code but shouldn't be accessed externally.
    /// </summary>
    /// <returns>A string of filled and empty stars</returns>
    private string GetStarDisplay()
    {
        // TODO 4: Convert rating to star display
        // Steps:
        // 1. Round the rating to get the number of filled stars: int filledStars = (int)Math.Round(Rating);
        // 2. Calculate empty stars: int emptyStars = 5 - filledStars;
        // 3. Build the star string: new string('★', filledStars) + new string('☆', emptyStars)
        // 4. Return the star string
        throw new NotImplementedException();
    }

    /// <summary>
    /// Updates the movie's rating with validation.
    /// This is a PUBLIC method that uses input validation.
    /// </summary>
    /// <param name="newRating">The new rating value (0.0 to 5.0)</param>
    public void UpdateRating(double newRating)
    {
        // TODO 5: Update the rating with validation
        // Steps:
        // 1. Check if newRating is less than 0.0 or greater than 5.0
        // 2. If invalid, use Logger.Warn("Rating must be between 0.0 and 5.0!") and return early
        // 3. Store the current rating in a variable: double oldRating = Rating;
        // 4. Update the Rating property: Rating = newRating;
        // 5. Log the change: Logger.Info($"Rating updated from {oldRating:0.0} to {Rating:0.0}");
        throw new NotImplementedException();
    }
}
