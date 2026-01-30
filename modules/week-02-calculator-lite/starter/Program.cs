/*********************************************************************
*    Course: DEV 110
*    Instructor: Elyana Bekele
*    Term: Winter 2026
*
*    Programmer: Elyana Bekele
*    Assignment: Calculator Lite
*
*    Description:   What does this program do?
*    Program requests user input for name, decimal precision,
*    and two numbers. It performs calculations, handles division by zero,
*    and displays results with user-chosen formatting.
*
*/

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string userName;
        bool useDecimal;
        double num1, num2;
        int calculationCount;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}! Let's do some calculations.\n");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        useDecimal = DecimalPreference();
        bool continueCalculation = true;

        while (continueCalculation)
        {
            // TODO: Prompt user for second number (same type as first)
            num1 = GetNumber("Enter the first number: ", useDecimal);
            num2 = GetNumber("Enter the second number: ", useDecimal);

            // Reset the calculation count
            calculationCount = 0;

            Console.WriteLine("\nResults:");

            // TODO: Calculate ALL arithmetic operations:
            // - sum (addition: +)
            // - difference (subtraction: -)
            // - product (multiplication: *)
            // - quotient (division: /)
            // - remainder (modulus: %)
            // - average ((num1 + num2) / 2)

            DisplayResult("Sum", num1, num2, num1 + num2, useDecimal, "+");
            calculationCount++;

            DisplayResult("Difference", num1, num2, num1 - num2, useDecimal, "-");
            calculationCount++;

            DisplayResult("Product", num1, num2, num1 * num2, useDecimal, "*");
            calculationCount++;

            if (num2 != 0)
            {
                DisplayResult("Quotient", num1, num2, num1 / num2, useDecimal, "/");
                calculationCount++;
            }
            else
            {
                Console.WriteLine("Quotient: Cannot divide by zero");

            }


            if (num2 != 0)
            {
                DisplayResult("Remainder", num1, num2, num1 % num2, useDecimal, "%");
                calculationCount++;

            }
            else
            {
                Console.WriteLine("Remainder: Cannot calculate (division by zero)");
            }

            DisplayResult("Average", num1, num2, (num1 + num2) / 2, useDecimal, "average");
            calculationCount++;


            // TODO: Calculate percentage difference
            // Formula: ((num1 - num2) / num1) * 100
            // Display with % symbol

            if (num1 != 0)
            {
                double percentDifference = ((num1 - num2) / num1) * 100;
                string percentResult;

                if (useDecimal)
                {
                    percentResult = percentDifference.ToString("F2");
                }
                else
                {
                    percentResult = percentDifference.ToString("F0");
                }

                Console.WriteLine($"Percentage difference: {percentResult}%");
            }
            else
            {
                Console.WriteLine("Percentage difference: Cannot calculate (division by zero)");
                calculationCount++;

            }


            // TODO: Count total calculations performed (int)
            // Display: "Performed [count] calculations for [name]!"
            int requiredCalculations = calculationCount;
            int displayCount = requiredCalculations;
            if (num2 == 0) displayCount++;
            Console.WriteLine($"\nPerformed {displayCount} calculations for {userName}!\n");

            // Ask the user to go repeat
            Console.Write("Do you want to calculate again? (yes/no): ");
            string repeat = Console.ReadLine();
            continueCalculation = repeat.Trim().ToLower() == "yes" || repeat.Trim().ToLower() == "y";
            Console.WriteLine();
        }
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }

    // Ask the user if they want decimal precision
    static bool DecimalPreference()
    {
        while (true)
        {
            Console.Write("Use decimal precision? (yes/no): ");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "yes" || input == "y") return true;
            if (input == "no" || input == "n") return false;
            Console.WriteLine("Invalid input. Please enter yes or no.");
        }
    }

    // Getting the number of the input
    static double GetNumber(string Prompt, bool useDecimal)
    {
        double number;
        while (true)
        {
            Console.Write(Prompt);
            string input = Console.ReadLine();

            if (useDecimal)
            {
                if (double.TryParse(input, out number)) break;
            }
            else
            {
                if (int.TryParse(input, out int intValuble))
                {
                    number = intValuble;
                    break;
                }
            }
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return number;
    }

    // TODO: Display results with proper formatting
    // Show 2 decimal places: {value:F2}
    static void DisplayResult(string label, double num1, double num2, double result, bool useDecimal, string operation)
    {
        string formattingNum1;
        string formattingNum2;
        string formattingOutcome;

        if (useDecimal)
        {
            formattingNum1 = num1.ToString("F2");
            formattingNum2 = num2.ToString("F2");
            formattingOutcome = result.ToString("F2");
        }
        else
        {
            formattingNum1 = num1.ToString("F0");
            formattingNum2 = num2.ToString("F0");
            formattingOutcome = result.ToString("F0");
        }

        // Display the label and operation
        if (operation == "average")
        {
            Console.Write($"{label}: ({formattingNum1} + {formattingNum2}) / 2 = ");
        }
        else
        {
            Console.Write($"{label}: {formattingNum1} {operation} {formattingNum2} = ");
        }

        // Color output, positve green, negative red
        if (result > 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (result < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ResetColor();
        }

        Console.WriteLine(formattingOutcome);
        Console.ResetColor();

    }

}

