/************************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 7 Lab - Study Group Sign-Up (Arrays)
-
- What does this program do?:
- Builds a menu-driven roster using parallel arrays (names + section numbers), then prints and sorts the roster.
- */

Console.WriteLine("=== Study Group Sign-Up (Arrays) ===");
Console.WriteLine();

// Data setup (we'll use these throughout the lab)
const int rosterCapacity = 3;
string[] rosterNames = new string[rosterCapacity];
int[] rosterSectionNumbers = new int[rosterCapacity];
int count = 0;

int choice = 0;

// Menu loop: repeats until the user chooses 4 (Exit)
while (choice != 4)
{
    // Print the menu options (every loop)
    Console.WriteLine("1) Add multiple students");
    Console.WriteLine("2) Print class roster");
    Console.WriteLine("3) Print roster (sorted)");
    Console.WriteLine("4) Exit");

    // TODO 3: Read the menu choice using ReadIntInRange
    // Prompt: "Choose an option: "
    // Range: 1 to 4
    choice = ReadIntInRange("Choose an option: ", 1, 4);

    Console.WriteLine();

    // Handle menu choices
    switch (choice)
    {
        case 1:
            /* ===== OPTION 1: Add multiple students ===== */
            // TODO 5: If the roster is full (count == rosterCapacity), print:
            // "Roster is full. Cannot add more students." then break.

            // TODO 6: Calculate remainingSlots = rosterCapacity - count

            // TODO 7: Ask how many to add (1 to remainingSlots)
            // Prompt: $"How many students do you want to add? (1-{remainingSlots}): "
            // Use ReadIntInRange

            // TODO 8: Create temporary arrays sized to howManyToAdd
            // - string[] newNames
            // - int[] newSectionNumbers

            // TODO 9: Use a for loop to fill the temporary arrays
            // Name prompt: $"Enter name for student {i + 1}: "
            // Section prompt: $"Enter section number for {newNames[i]} (1-99): " (range 1-99)

            // TODO 10: Copy the new values into the main roster arrays
            // Hint: start writing into index = count
            // After each copy, increment count

            // TODO 11: Print: "Students added."
            break;

        case 2:
            /* ===== OPTION 2: Print class roster ===== */
            // TODO 12: If count is 0, print: "Roster is empty." and break.

            // TODO 13: Print header: "Class Roster:"

            // TODO 14: Print each roster line using a foreach loop
            // Hint: Use BuildRosterLines(...) to create a string[] first
            // Then foreach over the lines
            break;

        case 3:
            /* ===== OPTION 3: Print roster (sorted) ===== */
            // TODO 15: If count is 0, print: "Roster is empty." and break.

            // TODO 16: Print the sort menu:
            // Sort by:
            // 1) Name
            // 2) Section Number

            // TODO 17: Read sortChoice using ReadIntInRange (range 1-2)

            // TODO 18: Copy only the USED part of the roster into new arrays
            // Hint: Use CopyUsedRoster(...) (TODO 18.1)

            // TODO 19: Sort based on sortChoice
            // - Name: Array.Sort(sortedNames, sortedSectionNumbers, StringComparer.OrdinalIgnoreCase)
            // - Section Number: Array.Sort(sortedSectionNumbers, sortedNames)

            // TODO 20: Print header: "Class Roster (Sorted):"
            // Then print each line with a foreach loop (use BuildRosterLines)
            break;

        case 4:
            /* ===== OPTION 4: Exit ===== */
            // TODO 21: Print: "Goodbye." and end the program
            break;
    }

    // Optional: spacing between actions can be added later
}

/* Helper method: read a whole number within a range using a do-while loop. */
static int ReadIntInRange(string prompt, int min, int max)
{
    int value;
    bool isValid;

    do
    {
        Console.Write(prompt);
        string input = Console.ReadLine() ?? string.Empty;
        isValid = int.TryParse(input, out value);

        if (!isValid || value < min || value > max)
        {
            Console.WriteLine($"Please enter a number from {min} to {max}.");
        }
    }
    while (!isValid || value < min || value > max);

    return value;
}

static string[] BuildRosterLines(string[] names, int[] sectionNumbers, int count)
{
    // TODO 14.1: Build and return an array of roster lines
    // - Create a string[] sized to count
    // - Use a for loop to fill it
    // - Include BOTH name and section number on each line
    // Example line idea: "- Ada (Section 12)"

    // TODO 14.2: Replace this placeholder return
    return Array.Empty<string>();
}

static void CopyUsedRoster(
    string[] sourceNames,
    int[] sourceSectionNumbers,
    int count,
    out string[] names,
    out int[] sectionNumbers)
{
    // TODO 18.1: Copy only the USED roster values into new arrays
    // - Create names and sectionNumbers arrays sized to count
    // - Use a for loop to copy each used element
    // TODO 18.2: Replace these placeholder assignments
    names = Array.Empty<string>();
    sectionNumbers = Array.Empty<int>();
}
