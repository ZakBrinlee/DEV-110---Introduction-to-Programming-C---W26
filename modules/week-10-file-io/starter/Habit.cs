/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: YourName
 * Assignment: Week 10: Habit Tracker (File I/O)
 *
 * What does this program do?:
 * Defines the Habit class used to represent a single habit entry.
 * This file is fully provided — no changes needed here.
 * ******************************************************************************/

namespace HabitTracker;

/// <summary>
/// Represents a single habit that can be tracked and updated.
/// All properties are mutable so the program can rename habits and toggle their status.
/// </summary>
public class Habit
{
    /// <summary>Gets or sets the name of the habit.</summary>
    public string Name { get; set; }

    /// <summary>Gets or sets whether the habit has been completed.</summary>
    public bool IsCompleted { get; set; }

    /// <summary>Gets or sets the frequency: "daily" or "weekly".</summary>
    public string Frequency { get; set; }

    /// <summary>
    /// Creates a new Habit with the given name, completion status, and frequency.
    /// </summary>
    public Habit(string name, bool isCompleted, string frequency)
    {
        Name = name;
        IsCompleted = isCompleted;
        Frequency = frequency;
    }

    /// <summary>
    /// Prints this habit's status marker, name, and frequency.
    /// Example: "  [x] Exercise (daily)"  or  "  [ ] Journal (weekly)"
    /// </summary>
    public void DisplayInfo()
    {
        string marker = IsCompleted ? "[x]" : "[ ]";
        Console.WriteLine($"  {marker} {Name} ({Frequency})");
    }
}
