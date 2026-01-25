// Week 4 Logic Lounge Lab - Solution
// This version includes brief comments to explain each decision type.

// Welcome banner
// Purpose: set the tone and show the program title before any input is requested.
Console.WriteLine("=== Logic Lounge ===\n");

// String input
// Console.ReadLine() always returns a string, so names are a natural fit.
Console.Write("Enter your name: ");
string userName = Console.ReadLine();

// Convert string input to int
// We need numeric comparison for age, so we parse the string into an int.
// If the user types non-numeric text, int.Parse will throw an error.
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// Simple if statement (single condition)
// This runs only when the condition is true. There is no else branch here.
if (age < 13)
{
    Console.WriteLine("Note: Some activities are for ages 13+.");
}

// Normalize input to uppercase for easy comparison
// This makes the comparisons case-insensitive ("s" and "S" behave the same).
Console.Write("Choose a snack size (S/L): ");
string snackChoice = Console.ReadLine().ToUpper();

double snackPrice;
// if/else-if/else for multi-path decisions
// We map a letter to a price. The else branch is our fallback for invalid input.
if (snackChoice == "S")
{
    snackPrice = 3.50;
}
else if (snackChoice == "L")
{
    snackPrice = 5.00;
}
else
{
    snackPrice = 0.0;
    Console.WriteLine("Invalid snack size. Snack price set to $0.00.");
}

// Convert yes/no input to a bool
// We reduce the user's choice to true or false so later checks are simpler.
Console.Write("Are you a club member? (yes/no): ");
string memberInput = Console.ReadLine().ToLower();
bool isMember = memberInput == "yes" || memberInput == "y";

string membershipLevel;
// Nested if: decision inside another decision
// First: are they a member? If yes, a second decision checks age for level.
if (isMember)
{
    if (age >= 18)
    {
        membershipLevel = "Gold";
    }
    else
    {
        membershipLevel = "Junior";
    }
}
else
{
    membershipLevel = "None";
}

// Multi-choice menu
// We display numbered choices so we can use a switch with an int.
Console.WriteLine("\nChoose an activity:");
Console.WriteLine("1) Movie");
Console.WriteLine("2) Arcade");
Console.WriteLine("3) Study Lounge");
Console.WriteLine("4) Arcade (student discount)");
Console.Write("Enter 1, 2, 3, or 4: ");
int activityChoice = int.Parse(Console.ReadLine());

string activityName;
double activityCost;

// switch handles multiple discrete options
// Each case is a specific choice. The default is the safety net for invalid input.
switch (activityChoice)
{
    case 1:
        activityName = "Movie";
        activityCost = 12.00;
        break;
    case 4:
        // goto case redirects to another case inside the same switch
        // This avoids repeating the Arcade pricing logic while still showing a new option.
        Console.WriteLine("Student discount selected. Redirecting to Arcade pricing...");
        goto case 2;
    case 2:
        activityName = "Arcade";
        activityCost = 8.00;
        break;
    case 3:
        activityName = "Study Lounge";
        activityCost = 4.00;
        break;
    default:
        activityName = "Unknown";
        activityCost = 0.0;
        Console.WriteLine("Invalid activity selection. Activity cost set to $0.00.");
        break;
}

// Summary output
// We display all key choices so the user can confirm their selections.
Console.WriteLine("\n=== Summary ===");
Console.WriteLine($"Name: {userName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Snack price: ${snackPrice:F2}");
Console.WriteLine($"Member: {isMember}");
Console.WriteLine($"Membership level: {membershipLevel}");
Console.WriteLine($"Activity: {activityName}");
Console.WriteLine($"Activity cost: ${activityCost:F2}");

// Only show a total if both items are valid
// If either price is 0, we assume the selection was invalid and skip the total.
if (snackPrice > 0 && activityCost > 0)
{
    double total = snackPrice + activityCost;
    Console.WriteLine($"Total cost: ${total:F2}");
}

Console.WriteLine("\nThanks for visiting Logic Lounge!");
