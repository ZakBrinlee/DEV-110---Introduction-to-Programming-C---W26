using Microsoft.VisualBasic;

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.Write("Please Enter Your Name:");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        Console.Write("Would you like to choose decimal precision for calculations? (Y/N): ");
        string decimalChoice = Console.ReadLine().ToUpper();

        bool isDecimal = decimalChoice == "Y" || decimalChoice == "YES";
        Console.WriteLine($"bool is {isDecimal}");
        string format = isDecimal ? "F2" : "F0";//for format
        int count = 0; //count the calculations
        // TODO: Prompt user for first number (double or int based on choice)
        double num1, num2, result;
        // // If no decimals: use int.Parse() then cast to double
        if (!isDecimal)
        {
            Console.WriteLine("please typing the first number");
            // It will implicit conversion to Double
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please typing the second number");
            num2 = int.Parse(Console.ReadLine());
        }
        else
        {
            // If decimals: use double.Parse()
            Console.WriteLine("please typing the first number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("please typing the second number");
            num2 = double.Parse(Console.ReadLine());
        }


        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)
        double sum = num1 + num2;
        double diff = num1 - num2;
        double product = num1 * num2;
        double quotient;
        double remainder;
        double average = (num1 + num2) / 2;


        //add,sub,mul

        Console.WriteLine($"The result of add is: {sum.ToString(format)}");
        count++;
        Console.WriteLine($"explain: {num1} + {num2} = {sum}");
        Console.WriteLine($"The result of sub is: {diff.ToString(format)}");
        count++;
        Console.WriteLine($"explain: {num1} - {num2} = {diff}");
        Console.WriteLine($"The result of multi is: {product.ToString(format)}");
        count++;
        Console.WriteLine($"explain: {num1} * {num2} = {product}");
        Console.WriteLine($"The result of average is: {average.ToString(format)}");
        count++;
        Console.WriteLine($"explain: ( {num1} * {num2} ) / 2 = {average}");



        //divde
        if (num2 != 0)
        {
            quotient = num1 / num2;
            Console.WriteLine($"The result of divide is: {quotient.ToString(format)}");
            Console.WriteLine($"explain: {num1} / {num2} = {quotient}");
            count++;
            remainder = num1 % num2;
            Console.WriteLine($"The result of mold is: {remainder.ToString(format)}");
            Console.WriteLine($"explain: {num1} % {num2} = {remainder}");
            count++;

        }
        else
        {
            Console.WriteLine($"The num2 couldn't be dividor because is 0");
        }


        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        Console.WriteLine($"Total calculation is {count}");
        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        double percent = ((num1 - num2) / num1) * 100;
        Console.WriteLine($"The percentage difference is {percent.ToString(format)}%");
        Console.WriteLine($"explain: (({num1} - {num2}) / {num1} ) * 100) = {percent.ToString(format)}%");

        Console.ReadLine();
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
