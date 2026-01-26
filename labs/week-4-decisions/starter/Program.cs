// Week 4 Logic Lounge Lab - Starter
// Follow the TODOs to complete the program.

Console.WriteLine("=== Logic Lounge ===\n");

// TODO 1: Ask for the user's name and store it in userName (string)
Console.Write("Enter your name: ");
string userName = Console.ReadLine();

// TODO 2: Ask for the user's age and store it in age (int)
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// TODO 3: Use a simple if statement
// If the age is under 13, print a message about age restrictions.

// TODO 4: Ask for snack size (S or L)
Console.Write("Choose a snack size (S/L): ");
string snackChoice = Console.ReadLine().ToUpper();

// TODO 5: Use an if/else to set snackPrice
// Small: 3.50, Large: 5.00, otherwise 0.00 with a warning message
double snackPrice = 0.0;

// TODO 6: Ask if the user is a club member (yes/no)
Console.Write("Are you a club member? (yes/no): ");
string memberInput = Console.ReadLine().ToLower();
bool isMember = memberInput == "yes" || memberInput == "y";

// TODO 7: Use a nested if to set membershipLevel
// If isMember is true: age >= 18 -> "Gold", else -> "Junior"
// If isMember is false: "None"
string membershipLevel = "None";

// TODO 8: Show a menu of activities
Console.WriteLine("\nChoose an activity:");
Console.WriteLine("1) Movie");
Console.WriteLine("2) Arcade");
Console.WriteLine("3) Study Lounge");
Console.Write("Enter 1, 2, or 3: ");
int activityChoice = int.Parse(Console.ReadLine());

// TODO 9: Use a switch statement to set activityName and activityCost
string activityName = "";
double activityCost = 0.0;

// TODO 10: Print a summary of the user's selections
// Include: name, age, snack price, member status, membership level, activity, activity cost

// TODO 11: If both snackPrice and activityCost are greater than 0, show the total cost
