/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 9 Lab - Movie Tracker (LINQ Reports)
-
- What does this program do?:
- Defines a Movie class used by the Movie Tracker LINQ Reports lab.
- */

namespace MovieTracker;

public class Movie
{
    public string Title { get; set; }

    public int Year { get; set; }

    public string Genre { get; set; }

    public double Rating { get; set; } // 1.0 to 5.0 scale

    public string Director { get; set; }

    public int RuntimeMinutes { get; set; }

    public Movie(string title, int year, string genre, double rating, string director, int runtimeMinutes)
    {
        Title = title;
        Year = year;
        Genre = genre;
        Rating = rating;
        Director = director;
        RuntimeMinutes = runtimeMinutes;
    }

    public void DisplayInfo()
    {
        string stars = GetStarDisplay();

        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine($"  📽️  {Title} ({Year})");
        Console.WriteLine($"  🎬 Director: {Director}");
        Console.WriteLine($"  🎭 Genre: {Genre}");
        Console.WriteLine($"  ⏱️  Runtime: {RuntimeMinutes} min");
        Console.WriteLine($"  ⭐ Rating: {stars} ({Rating:0.0}/5.0)");
        Console.WriteLine("╚════════════════════════════════════════╝");
    }

    private string GetStarDisplay()
    {
        int filledStars = (int)Math.Round(Rating);
        int emptyStars = 5 - filledStars;

        string stars = new string('★', filledStars) + new string('☆', emptyStars);
        return stars;
    }
}
