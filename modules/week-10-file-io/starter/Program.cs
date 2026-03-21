/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: Rin Peralez
 * Assignment: Week 10: Habit Tracker (File I/O)
 *
 * What does this program do?:
 * A menu-driven Habit Tracker that loads habits from a CSV file and lets you
 * view, add, update, and save your habits back to disk.
 * ******************************************************************************/

using System.Globalization;

namespace HabitTracker;

/// <summary>
/// Main program class for the Habit Tracker application.
/// Your work this week: implement the eight TODO methods below.
/// The Main method, menu loop, and ReadIntInRange helper are fully provided.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point — prompts for file paths, loads habits, then runs the menu.
    /// Fully provided; no changes needed here.
    /// </summary>
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Habit Tracker: File I/O ===");
        Console.WriteLine();

        // Prompt for the path to the habits CSV file
        Console.Write("Enter habits file path: ");
        string path = (Console.ReadLine() ?? string.Empty).Trim();
        Console.WriteLine();

        // Load all habits (you will implement LoadHabits below)
        List<Habit> habits = LoadHabits(path);

        Console.WriteLine();

        // Menu loop — keeps running until the user chooses Save & Quit
        bool running = true;
        while (running)
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. View Habits");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. Add Habit");
            Console.WriteLine("4. Update Habit");
            Console.WriteLine("5. Save & Quit");
            Console.Write("Choice (1-5): ");

            int choice = ReadIntInRange(1, 5);
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    PrintHabits(habits);
                    break;
                case 2:
                    PrintSummary(habits);
                    break;
                case 3:
                    AddHabit(habits);
                    break;
                case 4:
                    UpdateHabit(habits);
                    break;
                case 5:
                    SaveHabits(path, habits);
                    running = false;
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }

    // TODO 1: Implement LoadHabits
        private static List<Habit> LoadHabits(string path)
    {
        throw new NotImplementedException();

        List<Habit> habits = new List<Habit>();
        try{
            File.ReadAllLines(path);
            for each (string line in lines){
                if (!string.IsNullOrWhiteSpace(line)){
                    string[] parts = line.Split(',');
                    string name = parts[0].Trim();
                    string status = parts[1].Trim();
                    string frequency = parts[2].Trim();
                    bool isCompleted = status.Equals("done", StringComparison.OrdinalIgnoreCase);
                    habits.Add(new Habit(name,isCompleted,frequency));
                }
            }
            catch (FileNotFoundException){
                Console.WriteLine($"Error: File not found — {path}");
            }
            return habits;
        }
    }
    // Reads a CSV file where each line is: Name,Status,Frequency  (e.g. "Exercise,done,daily")
    //
    // Requirements:
    // - Create an empty List<Habit>
    // - Inside a try block: call File.ReadAllLines(path)
    // - Loop through the lines; skip blank ones (use string.IsNullOrWhiteSpace)
    // - For each line: split on ',' → parts[0] = name, parts[1] = status, parts[2] = frequency
    // - Trim whitespace from all parts
    // - isCompleted is true when status equals "done" (case-insensitive)
    //   Hint: parts[1].Trim().Equals("done", StringComparison.OrdinalIgnoreCase)
    // - Create new Habit(name, isCompleted, frequency) and add to the list
    // - Catch FileNotFoundException and print:
    //     Error: File not found — {path}
    //   (use — which is an em dash, not a hyphen)
    // - Return the list

    // TODO 2: Implement PrintHabits
    // Prints all habits with a status marker.
    //
    // Requirements:
    // - Print the header: --- Your Habits ---
    // - Loop through the habits list; call DisplayInfo() on each
    //
    // Recall: DisplayInfo() is already implemented on the Habit class.
    private static void PrintHabits(List<Habit> habits)
    {
        System.Console.WriteLine("--- Your Habits ---");
        foreach (Habit habit in habits){
            habit.DisplayInfo();
        }
        throw new NotImplementedException();
    }

    // TODO 3: Implement PrintSummary
    // Prints LINQ-based summary stats grouped by frequency.
    //
    // Requirements:
    // - Print: --- Summary ---
    // - Use LINQ with a predicate to count daily vs weekly habits:
    //     habits.Count(h => h.Frequency == "daily")
    //     habits.Count(h => h.Frequency == "daily" && h.IsCompleted)
    // - Guard against divide-by-zero if a group has 0 habits
    // - Format each rate to 1 decimal: rate.ToString("F1", CultureInfo.InvariantCulture)
    //
    // Example output:
    //   --- Summary ---
    //   Daily:    3/4 completed (75.0%)
    //   Weekly:   1/1 completed (100.0%)
    private static void PrintSummary(List<Habit> habits)
    {
        System.Console.WriteLine("--- Summary ---");
        int dailyTotal = habits.Count(habits => habits.Frequency == 'daily');
        int isCompletedDaily = habits.Count(habits => habits.Frequency == 'daily' && habits.IsCompleted);
        double dailyRate = dailyTotal > 0 ? (double)isCompletedDaily / dailyTotal * 100.0 : 0.0;
        System.Console.WriteLine($"Daily:    {isCompletedDaily}/{dailyTotal} completed ({dailyRate:F1}%)");
        int weeklyTotal = habits.Count(habits => habits.Frequency == 'weekly');
        int isCompletedWeekly = habits.Count(habits => habits.Frequency == 'weekly' && habits.IsCompleted);
        double weeklyRate = weeklyTotal > 0 ? (double)isCompletedWeekly / weeklyTotal * 100.0 : 0.0;
        System.Console.WriteLine($"Weekly:   {isCompletedWeekly}/{weeklyTotal} completed ({weeklyRate:F1}%)");
        throw new NotImplementedException();
    }

    // TODO 4: Implement AddHabit
    // Prompts the user for a name and frequency, then adds a new habit to the list.
    //
    // Requirements:
    // - Print: --- Add Habit ---
    // - Prompt: Habit name:
    // - Read the name; trim whitespace
    // - Prompt: Frequency ((D)aily or (W)eekly):
    // - Read input; trim and convert to uppercase
    // - Set frequency to "daily" if input is "D", otherwise "weekly"
    // - Create new Habit(name, false, frequency) and add to habits
    //   (new habits start as not completed)
    // - Print: Added: {name} ({frequency})
    private static void AddHabit(List<Habit> habits)
    {
        System.Console.WriteLine("--- Add Habit ---");
        System.Console.Write("Habit name: ");
        string name = Console.ReadLine()?.Trim() ?? string.Empty;
        System.Console.Write("Frequency ((D)aily or (W)eekly): ");
        string frequency = Console.ReadLine()?.Trim() ?? string.Empty;
        frequency = frequency.ToUpper();
        habits.Add(new Habit(name, false, frequency));
        System.Console.WriteLine($"Added: {name} ({frequency})");
        throw new NotImplementedException();
    }

    // TODO 5: Implement UpdateHabit

    // Shows a numbered list of habits, lets the user pick one,
    // optionally rename it, and toggles its completion status.
    //
    // Requirements:
    // - If the list is empty: Print: No habits to update.  then return
    // - Print: --- Update Habit ---
    // - Print a 1-based numbered list: "1. Exercise"  "2. Meditate"  etc.
    // - Prompt: Enter habit number:
    // - Read using ReadIntInRange(1, habits.Count); subtract 1 for the index
    // - Prompt: New name (press Enter to keep "{habit.Name}"):
    // - If the user types something (non-blank), set habit.Name = newName
    // - Toggle IsCompleted: if true → false; if false → true
    // - Print: Updated: {habit.Name} — now {completed or pending}
    //   Hint: (habit.IsCompleted ? "completed" : "pending")
    private static void UpdateHabit(List<Habit> habits)
    {
        if (habits.Count == 0){
            System.Console.WriteLine("No habits to update.");
            return;
        }
        System.Console.WriteLine("--- Update Habit ---");
        for (int i = 0; i < habits.Count; i++){
            System.Console.WriteLine($"{i + 1}. {habits[i].Name}");
        }
        System.Console.Write("Enter habit number: ");
        int index = ReadIntInRange(1, habits.Count) - 1;
        System.Console.Write($"New name (press Enter to keep \"{habits[index].Name}\"): ");
        string newName = Console.ReadLine()?.Trim() ?? habits[index].Name;
        habits[index].Name = newName;
        habits[index].IsCompleted = !habits[index].IsCompleted;
        System.Console.WriteLine($"Updated: {habits[index].Name} — now {habits[index].IsCompleted ? "completed" : "pending"}");
        throw new NotImplementedException();
    }

    // TODO 6: Implement SaveHabits

    // Writes the habit list back to the CSV file.
    //
    // Requirements:
    // - Build a string array — one CSV line per habit:
    //     Each element: "{habit.Name},{status},{habit.Frequency}"
    //     Hint: habits.Select(h => $"{h.Name},{(h.IsCompleted ? "done" : "pending")},{h.Frequency}").ToArray()
    // - Call File.WriteAllLines(path, lines) to overwrite the file
    // - Print: Habits saved to {path}.
    private static void SaveHabits(string path, List<Habit> habits)
    {
        string[] lines = habits.Select(h => $"{h.Name},{(h.IsCompleted ? "done" : "pending")},{h.Frequency}").ToArray();
        File.WriteAllLines(path, lines);
        System.Console.WriteLine($"Habits saved to {path}.");
        throw new NotImplementedException();
    }

    /// <summary>
    /// Reads an integer from the console, repeating until a valid value
    /// in [min, max] is entered. Fully provided — no changes needed.
    /// </summary>
    private static int ReadIntInRange(int min, int max)
    {
        while (true)
        {
            string line = (Console.ReadLine() ?? string.Empty).Trim();
            if (int.TryParse(line, out int value) && value >= min && value <= max)
            {
                return value;
            }

            Console.Write($"Please enter a number between {min} and {max}: ");
        }
    }
}

