namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");
        // TODO: Declare variables for storing user input (use descriptive names)
        string Username;
        bool UseDecimals;
        double Num1;
        double Num2;
        int CalculationCount = 0;
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        // TODO: Ask for user's name (string) and greet them
        Console.Write("Enter your name: ");
        Username = Console.ReadLine() ?? "User";
        Console.WriteLine($"Hello, {Username}!");
        // Example: "Enter your name: " then "Hello, [name]!"
        // TODO: Ask if they want to use decimals (bool)
        Console.Write("Use decimal precision? (yes/no): ");
        string decimalInput = Console.ReadLine() ?? "no";
        UseDecimals = decimalInput.ToLower() == "yes";
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        // TODO: Prompt user for first number (double or int based on choice)
        if (UseDecimals)
        {
            Console.Write("Enter the first number (decimal): ");
            Num1 = double.Parse(Console.ReadLine() ?? "0");
        }
        else
        {
            Console.Write("Enter the first number (integer): ");
            Num1 = (double)int.Parse(Console.ReadLine() ?? "0");
        }
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        // TODO: Prompt user for second number (same type as first)
        if (UseDecimals)
        {
            Console.Write("Enter the second number (decimal): ");
            Num2 = double.Parse(Console.ReadLine() ?? "0");
        }
        else
        {
            Console.Write("Enter the second number (integer): ");
            Num2 = (double)int.Parse(Console.ReadLine() ?? "0");
        }
        // TODO: Calculate ALL arithmetic operations:
        double sum = Num1 + Num2;
        double difference = Num1 - Num2;
        double product = Num1 * Num2;
        double quotient = 0;
        double remainder = 0;
        double average = (Num1 + Num2) / 2;
        if (Num2 != 0)
        {
            quotient = Num1 / Num2;
            remainder = Num1 % Num2;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero for quotient and remainder calculations.");
        }
        CalculationCount++; // Increment calculation count
        // Operations to perform:

        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)
        // TODO: Display results with proper formatting
        Console.WriteLine($"\nResults for {Username}:");
        if (UseDecimals)
        {
            Console.WriteLine($"Sum: {sum:F2}");
            Console.WriteLine($"Difference: {difference:F2}");
            Console.WriteLine($"Product: {product:F2}");
            if (Num2 != 0)
            {
                Console.WriteLine($"Quotient: {quotient:F2}");
                Console.WriteLine($"Remainder: {remainder:F2}");
            }
            Console.WriteLine($"Average: {average:F2}");
        }
        else
        {
            Console.WriteLine($"Sum: {(int)sum}");
            Console.WriteLine($"Difference: {(int)difference}");
            Console.WriteLine($"Product: {(int)product}");
            if (Num2 != 0)
            {
                Console.WriteLine($"Quotient: {(int)quotient}");
                Console.WriteLine($"Remainder: {(int)remainder}");
            }
            Console.WriteLine($"Average: {(int)average}");
        }
        // Use if statement: if (num2 == 0) { show error } else { calculate }
        // TODO: Count total calculations performed (int)
        Console.WriteLine($"\nPerformed {CalculationCount} calculations for {Username}!");
        // Display: "Performed [count] calculations for [name]!"
        // TODO: Calculate percentage difference
        if (Num1 != 0)
        {
            double percentageDifference = ((Num1 - Num2) / Num1) * 100;
            if (UseDecimals)
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
            }
            else
            {
                Console.WriteLine($"Percentage Difference: {(int)percentageDifference}%");
            }
        }
        else
        {
            Console.WriteLine("Cannot calculate percentage difference with first number as zero.");
        }


        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
