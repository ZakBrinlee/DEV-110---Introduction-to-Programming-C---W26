/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Assignment: Week 8 Lab - Movie Tracker
-
- What does this file do?:
- Provides a global logging utility for debugging and informational messages.
- Demonstrates the use of a STATIC class that doesn't need to be instantiated.
- */

using System.Text.Json;

namespace MovieTracker;

/// <summary>
/// A static utility class for logging messages with different severity levels.
/// Static classes don't need to be created with 'new' - you call their methods directly.
/// </summary>
internal static class Logger
{
    /// <summary>
    /// Logs an informational message in yellow text.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[INFO] {message}");
        Console.ResetColor();
    }

    /// <summary>
    /// Logs a debug message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public static void Debug(string message)
    {
        Console.WriteLine($"[DEBUG] {message}");
    }

    /// <summary>
    /// Logs a warning message in red text.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public static void Warn(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[WARN] {message}");
        Console.ResetColor();
    }

    /// <summary>
    /// Logs an object as JSON for debugging purposes.
    /// </summary>
    /// <param name="label">The label to display before the JSON.</param>
    /// <param name="value">The object to serialize.</param>
    /// <param name="indented">Whether to format the JSON with indentation (default: false).</param>
    /// <param name="maxDepth">Maximum depth for JSON serialization (default: 64).</param>
    public static void DebugObject(string label, object value, bool indented = false, int maxDepth = 64)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = indented,
            MaxDepth = maxDepth,
        };

        string json = JsonSerializer.Serialize(value, options);
        Console.WriteLine($"[DEBUG] {label}: {json}");
    }
}
