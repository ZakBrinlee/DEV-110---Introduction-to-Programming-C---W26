using System;
namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string user;
        bool choice;
        double num1, num2;
        int successCount = 0;
        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.WriteLine("Enter Your Name: ");
        user = Console.ReadLine();
        Console.WriteLine($"Hello, {user}!");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        Console.WriteLine("Use decimal precision? (yes/no): ");
        string Choice = Console.ReadLine();
        choice = Choice == "yes";
        string fmt = choice ? "F2" : "F0";
        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        Console.WriteLine("Enter the first number: ");
        if (choice)
        {
            num1 = double.Parse(Console.ReadLine());
        }
        else
        {
            num1 = int.Parse(Console.ReadLine());
        }


        // TODO: Prompt user for second number (same type as first)
        Console.WriteLine("Enter the second number: ");
        if (choice)
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
        Console.WriteLine($"Addition: {num1.ToString(fmt)} + {num2.ToString(fmt)} = {sum.ToString(fmt)}");
        successCount++;
        double difference = num1 - num2;
        Console.WriteLine($"Subtraction: {num1.ToString(fmt)} - {num2.ToString(fmt)} = {difference.ToString(fmt)}");
        successCount++;
        double product = num1 * num2;
        Console.WriteLine($"Multiplication: {num1.ToString(fmt)} * {num2.ToString(fmt)} = {product.ToString(fmt)}");
        successCount++;
        if (num2 == 0)
        {
            Console.WriteLine("Division: Cannot divide by zero");
        }
        else
        {
            double quotient = num1 / num2;
            Console.WriteLine($"Division: {num1.ToString(fmt)} / {num2.ToString(fmt)} = {quotient.ToString(fmt)}");
            successCount++;
        }

        if (num2 == 0)
        {
            Console.WriteLine("Modulus: Cannot divide by zero");
        }
        else
        {
            double remainder = num1 % num2;
            Console.WriteLine($"Modulus: {num1.ToString(fmt)} % {num2.ToString(fmt)} = {remainder.ToString(fmt)}");
            successCount++;
        }

        double average = sum/2;
        Console.WriteLine($"Average: ({num1.ToString(fmt)} + {num2.ToString(fmt)}) / 2 = {average.ToString(fmt)}");
        successCount++;
        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"

        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        if (num1 == 0)
        {
            Console.WriteLine("Percentage difference: Cannot divide by zero");
        }
        else
        {
            double percentDiff = ((num1 - num2) / num1) * 100.0;
            Console.WriteLine($"Percentage difference: {percentDiff.ToString(fmt)}%");
            successCount++;
        }
        Console.WriteLine($"\nPerformed {successCount} calculations for {user}!");
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
