using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        double num1;
        double num2;
        string userID;
        string calcChoice;
        int calculationCount = 0;
        string format;


        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.Write("Enter your name: ");
        userID = Console.ReadLine();
        Console.WriteLine($"Hello, {userID}");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        bool useDecimals;
        Console.Write("Use decimal precision? (yes/no): ");
        if (Console.ReadLine() == "yes")
        {
            useDecimals = true;
        }
        else
        {
            useDecimals = false;
        }

        format = useDecimals ? "F2" : "F0";


        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        Console.Write("Enter your first member: ");
        if (useDecimals)
        {
            num1 = double.Parse(Console.ReadLine());
        }
        else
        {
            num1 = int.Parse(Console.ReadLine());
        }



        // TODO: Prompt user for second number (same type as first)
        Console.Write("Enter your second member: ");
        if (useDecimals)
        {
            num2 = double.Parse(Console.ReadLine());
        }
        else
        {
            num2 = int.Parse(Console.ReadLine());
        }

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double average = (num1 + num2) / 2;

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation
        Console.WriteLine("\n=== Results ===");
        Console.WriteLine($"Sum: {sum.ToString(format)}");
        Console.WriteLine($"Difference: {difference.ToString(format)}");
        Console.WriteLine($"Product: {product.ToString(format)}");
        Console.WriteLine($"Average: {average.ToString(format)}");
        calculationCount += 4;


        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }
        if (num2 == 0)
        {
            Console.WriteLine("Quotient: Cannot divide by zero");
            Console.WriteLine("Remainder: Cannot divide by zero");
        }
        else
        {
            double quotient = num1 / num2;
            double remainder = num1 % num2;

            Console.WriteLine($"Quotient: {quotient.ToString(format)}");
            Console.WriteLine($"Remainder: {remainder.ToString(format)}");

            calculationCount += 2;
        }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        Console.WriteLine($"\nPerformed {calculationCount} calculations for {userID}!");

        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        if (num1 != 0)
        {
            double percentDifference = ((num1 - num2) / num1) * 100;
            Console.WriteLine($"Percentage Difference: {percentDifference.ToString(format)}%");
        }
        else
        {
            Console.WriteLine("Percentage Difference: Error (division by zero)");
        }

        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
