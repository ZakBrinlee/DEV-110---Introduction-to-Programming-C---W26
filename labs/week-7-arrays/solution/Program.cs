/************************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Zak Brinlee
- Assignment: Week 7 Lab - Study Group Sign-Up (Arrays)
-
- What does this program do?:
- Builds a menu-driven roster using parallel arrays (names + section numbers), then prints and sorts the roster.
- */

Console.WriteLine("=== Study Group Sign-Up (Arrays) ===");
Console.WriteLine();

const int rosterCapacity = 3;
string[] rosterNames = new string[rosterCapacity];
int[] rosterSectionNumbers = new int[rosterCapacity];
int count = 0;

int choice = 0;

while (choice != 4)
{
    Console.WriteLine("1) Add multiple students");
    Console.WriteLine("2) Print class roster");
    Console.WriteLine("3) Print roster (sorted)");
    Console.WriteLine("4) Exit");

    choice = ReadIntInRange("Choose an option: ", 1, 4);
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            if (count == rosterCapacity)
            {
                Console.WriteLine("Roster is full. Cannot add more students.");
                break;
            }

            int remainingSlots = rosterCapacity - count;
            int howManyToAdd = ReadIntInRange($"How many students do you want to add? (1-{remainingSlots}): ", 1, remainingSlots);

            string[] newNames = new string[howManyToAdd];
            int[] newSectionNumbers = new int[howManyToAdd];

            for (int i = 0; i < howManyToAdd; i++)
            {
                Console.Write($"Enter name for student {i + 1}: ");
                newNames[i] = (Console.ReadLine() ?? string.Empty).Trim();

                newSectionNumbers[i] = ReadIntInRange($"Enter section number for {newNames[i]} (1-99): ", 1, 99);
            }

            for (int i = 0; i < howManyToAdd; i++)
            {
                rosterNames[count] = newNames[i];
                rosterSectionNumbers[count] = newSectionNumbers[i];
                count++;
            }

            Console.WriteLine("Students added.");
            break;

        case 2:
            if (count == 0)
            {
                Console.WriteLine("Roster is empty.");
                break;
            }

            Console.WriteLine("Class Roster:");
            string[] rosterLines = BuildRosterLines(rosterNames, rosterSectionNumbers, count);

            foreach (string line in rosterLines)
            {
                Console.WriteLine(line);
            }

            break;

        case 3:
            if (count == 0)
            {
                Console.WriteLine("Roster is empty.");
                break;
            }

            Console.WriteLine("Sort by:");
            Console.WriteLine("1) Name");
            Console.WriteLine("2) Section Number");

            int sortChoice = ReadIntInRange("Choose an option: ", 1, 2);

            CopyUsedRoster(rosterNames, rosterSectionNumbers, count, out string[] sortedNames, out int[] sortedSectionNumbers);

            if (sortChoice == 1)
            {
                Array.Sort(sortedNames, sortedSectionNumbers, StringComparer.OrdinalIgnoreCase);
            }
            else
            {
                Array.Sort(sortedSectionNumbers, sortedNames);
            }

            Console.WriteLine("Class Roster (Sorted):");
            string[] sortedLines = BuildRosterLines(sortedNames, sortedSectionNumbers, count);

            foreach (string line in sortedLines)
            {
                Console.WriteLine(line);
            }

            break;

        case 4:
            Console.WriteLine("Goodbye.");
            break;
    }

    if (choice != 4)
    {
        Console.WriteLine();
    }
}

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
    string[] lines = new string[count];

    for (int i = 0; i < count; i++)
    {
        lines[i] = $"- {names[i]} (Section {sectionNumbers[i]})";
    }

    return lines;
}

static void CopyUsedRoster(
    string[] sourceNames,
    int[] sourceSectionNumbers,
    int count,
    out string[] names,
    out int[] sectionNumbers)
{
    names = new string[count];
    sectionNumbers = new int[count];

    for (int i = 0; i < count; i++)
    {
        names[i] = sourceNames[i];
        sectionNumbers[i] = sourceSectionNumbers[i];
    }
}
