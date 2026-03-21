/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: YourName
 * Assignment: Week 10 Lab - Movie Tracker (Save & Load)
 *
 * What does this program do?:
 * Provides a global logging utility for informational and warning messages.
 * This file is fully provided — no changes needed here.
 * ******************************************************************************/

using System.Text.Json;

namespace MovieTracker;

internal static class Logger
{
    public static void Info(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[INFO] {message}");
        Console.ResetColor();
    }

    public static void Warn(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[WARN] {message}");
        Console.ResetColor();
    }

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
