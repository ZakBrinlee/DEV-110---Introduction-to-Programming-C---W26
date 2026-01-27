namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string Name;
        bool DecimalPrecision = false;
        double FirstNumber;
        double SecondNumber;
        int CalculationsPerformed = 0;
        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.WriteLine("Enter Your Name:");
        Name = Console.ReadLine();
        Console.WriteLine("Hello, " + Name);
        // TODO: Ask if they want to use decimals (bool)
        Console.WriteLine("Use Decimal Precision? (yes/no):");
        string Input = Console.ReadLine();
        DecimalPrecision = Input == "yes";


        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)


        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        if (DecimalPrecision)
        {
            Console.WriteLine("Enter first number(decimals allowed):");
            FirstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number(decimals allowed):");
            SecondNumber = double.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Enter first number (whole numbers only):");
            FirstNumber = (double)int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number (whole numbers only):");
            SecondNumber = (double)int.Parse(Console.ReadLine());
        }
        // TODO: Prompt user for second number (same type as first)

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)
        if (DecimalPrecision)
        {
            Console.WriteLine($"Addition: {FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber:F2}");
            Console.WriteLine($"Subtraction: {FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber:F2}");
            Console.WriteLine($"Multiplicaton: {FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber:F2}");
            Console.WriteLine($"Remainder: {FirstNumber % SecondNumber:F2}");
            Console.WriteLine($"Average: {FirstNumber} + {SecondNumber} / 2 = {(FirstNumber + SecondNumber) / 2:F2}");

        }
        else
        {
            Console.WriteLine($"Addition: {FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}");
            Console.WriteLine($"Subtraction: {FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}");
            Console.WriteLine($"Multiplicaton: {FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}");
            Console.WriteLine($"Remainder: {FirstNumber % SecondNumber:F2}");
            Console.WriteLine($"Average: {FirstNumber} + {SecondNumber} / 2 = {(FirstNumber + SecondNumber) / 2}");

        }
        if (SecondNumber == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        else
        {
            if (DecimalPrecision)
            {
                Console.WriteLine($"Division: {FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber:F2}");

            }
            else
            {
                Console.WriteLine($"Division: {(int)FirstNumber} / {(int)SecondNumber} = {(int)(FirstNumber / SecondNumber)}");
            }
        }
        if (FirstNumber == 0)
        {
            Console.WriteLine("Percentage Difference: Cannot calculate because first number is zero");
        }
        else
        {
            if (DecimalPrecision)
            {
                Console.WriteLine($"Percentage Difference: (({FirstNumber} - {SecondNumber}) / {FirstNumber}) * 100 = {(FirstNumber - SecondNumber) / FirstNumber * 100:F2}%");
            }
            else
            {
                Console.WriteLine($"Percentage Difference: (({FirstNumber} - {SecondNumber}) / {FirstNumber}) * 100 = {(FirstNumber - SecondNumber) / FirstNumber * 100}%");
            }
        }
        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        CalculationsPerformed = CalculationsPerformed + 7;
        Console.WriteLine($"Performed {CalculationsPerformed} calculations for {Name}");
        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
