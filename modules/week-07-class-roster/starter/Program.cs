/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Ujwal Garine
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Builds a class roster using parallel arrays and a simple menu.
- */

namespace ClassRoster;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Class Roster ===");
        Console.WriteLine();

        // TODO 1: Create parallel arrays with a fixed capacity of 3
        // Create:
        // - string[] rosterNames
        // - int[] rosterCredits
        // Also create an int named count and set it to 0
        // Meaning: the first 0 slots are in use
        string[] rosterNames = new string[3];
        int[] rosterCredits = new int[3];
        int count = 0;
        int rosterCapacity = rosterNames.Length;
        int choice = 0;

        // TODO 2: Create a menu loop that repeats until the user chooses 4 (Exit)
        while (choice != 4)
        {
            // Print the menu options (every loop)
            Console.WriteLine("1) Add multiple students");
            Console.WriteLine("2) Print class roster");
            Console.WriteLine("3) Print roster (sorted)");
            Console.WriteLine("4) Exit");

            // TODO 3: Get the menu choice using ReadIntInRange
            // Prompt: "Choose an option: "
            // Range: 1 to 4
            choice = ReadIntInRange("Choose an option:", 1, 4);

            // TODO 4: Use a switch statement to handle choices 1-4
            switch (choice)
            {
                // ===== OPTION 1: Add multiple students =====
                // TODO 5: If the roster is full (count == rosterCapacity), print:
                // "Roster is full. Cannot add more students."
                // Otherwise:
                // - remainingSlots = rosterCapacity - count
                // - Ask how many to add:
                //   $"How many students do you want to add? (1-{remainingSlots}): "
                // - Create new arrays sized to the number to add:
                //   string[] newNames
                //   int[] newCredits
                // - Use a for loop to fill the new arrays:
                //   name prompt: $"Enter name for student {i + 1}: "
                //   credits prompt: $"Enter credits for {newNames[i]} (0-200): " (range 0-200)
                // - Copy the new arrays into the roster arrays (use a for loop)
                // - Print: "Students added."
                case 1:
                    if (count == rosterCapacity)
                    {
                        Console.WriteLine("Roster is full. Cannot add more students.");
                    }
                    else
                    {
                        int remainingSlots = rosterCapacity - count;

                        Console.Write($"How many students do you want to add? (1-{remainingSlots}): ");
                        int numberToAdd = int.Parse(Console.ReadLine());

                        // Validate input
                        if (numberToAdd < 1 || numberToAdd > remainingSlots)
                        {
                            Console.WriteLine("Invalid number.");
                            break;
                        }

                        // Create temporary arrays
                        string[] newNames = new string[numberToAdd];
                        int[] newCredits = new int[numberToAdd];

                        // Fill temporary arrays
                        for (int i = 0; i < numberToAdd; i++)
                        {
                            Console.Write($"Enter name for student {i + 1}: ");
                            newNames[i] = Console.ReadLine();

                            int credits;
                            do
                            {
                                Console.Write($"Enter credits for {newNames[i]} (0-200): ");
                                credits = int.Parse(Console.ReadLine());
                            }
                            while (credits < 0 || credits > 200);

                            newCredits[i] = credits;
                        }

                        // Copy into main roster arrays
                        for (int i = 0; i < numberToAdd; i++)
                        {
                            rosterNames[count] = newNames[i];
                            rosterCredits[count] = newCredits[i];
                            count++;
                        }

                        Console.WriteLine("Students added.");
                    }
                    break;

                // ===== OPTION 2: Print class roster =====
                // TODO 6: If count is 0, print: "Roster is empty."
                // Otherwise:
                // - Build a string[] of lines using BuildRosterLines (TODO 6.1)
                // - Print header: "Class Roster:"
                // - Print each line using a foreach loop

                case 2:
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                    }
                    else
                    {
                        string[] dataArr = BuildRosterLines(rosterNames, rosterCredits, count);
                        Console.WriteLine("Class Roster");
                        foreach (string line in dataArr)
                        {
                            Console.WriteLine(line);
                        }
                    }

                    break;

                // ===== OPTION 3: Print roster (sorted) =====
                // TODO 7: If count is 0, print: "Roster is empty."
                // Otherwise:
                // - Print:
                //   Sort by:
                //   1) Name
                //   2) Credits
                // - Get sort choice using ReadIntInRange (range 1-2)
                // - Copy only the USED part of the roster into new arrays (CopyUsedRoster - TODO 7.1)
                // - Sort:
                //   Name: Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase)
                //   Credits: Array.Sort(sortedCredits, sortedNames)
                // - Print header: "Class Roster (Sorted):"
                // - Print each line using a foreach loop
                case 3:
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Sort by:");
                        Console.WriteLine("1) Name");
                        Console.WriteLine("2) Credits");
                        int sortChoice = ReadIntInRange("Enter choice (1-2): ", 1, 2);
                        string[] sortedNames;
                        int[] sortedCredits;
                        CopyUsedRoster(rosterNames, rosterCredits, count, out sortedNames, out sortedCredits);
                        // Sort
                        if (sortChoice == 1)
                        {
                            Array.Sort(sortedNames, sortedCredits,
                                       StringComparer.OrdinalIgnoreCase);
                        }
                        else
                        {
                            Array.Sort(sortedCredits, sortedNames);
                        }
                        Console.WriteLine("Class Roster (Sorted):");
                        string[] lines = BuildRosterLines(sortedNames, sortedCredits, count);

                        foreach (string line in lines)
                        {
                            Console.WriteLine(line);
                        }

                    }
                    break;

                // ===== OPTION 4: Exit =====
                // TODO 8: When the user chooses 4, print: "Goodbye." and end the program
                // TODO 9: Add a blank line between menu actions (but not after Exit)
                case 4:
                    Console.WriteLine("Goodbye.");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine();
            }

            Console.WriteLine("(Starter project) Follow the TODO steps in Program.cs.");
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }


    private static string[] BuildRosterLines(string[] names, int[] credits, int count)
    {
        // TODO 6.1: Build and return an array of roster lines
        // - Create a string[] sized to count (hint: initialize with new)
        // - Use a for loop to fill it (hint: use index accessor for the variable you just created)
        // - Include BOTH name and credits on each line
        string[] lines = new string[count];

        for (int i = 0; i < count; i++)
        {
            lines[i] = $"{names[i]} - {credits[i]} credits";
        }

        return lines;
    }

    private static void CopyUsedRoster(
        string[] sourceNames,
        int[] sourceCredits,
        int count,
        out string[] names,
        out int[] credits)
    {
        // TODO 7.1: Copy only the USED roster values into new arrays
        // - Create names and credits arrays sized to count
        // - Use a for loop to copy each used element

        names = new string[count];
        credits = new int[count];

        for (int i = 0; i < count; i++)
        {
            names[i] = sourceNames[i];
            credits[i] = sourceCredits[i];
        }
    }
}
