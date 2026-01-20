namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}!");

        Console.Write("\nUse decimal precision (yes/no): ");
        string userInputDecimal = Console.ReadLine();

        // I want both “yes” and “y” to work. Therefore, I am not checking inline.
        bool useDecimal = userInputDecimal == "yes" || userInputDecimal == "y";

        int numOfCalculations = 7;

        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        if (num1 == 0)
        {
            numOfCalculations -= 1;
        }

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        if (num2 == 0)
        {
            numOfCalculations -= 2;
        }

        if (useDecimal)
        {
            // If decimal is requested.
            Console.WriteLine($"Sum: {num1:F2} + {num2:F2} = {num1 + num2:F2}");
            Console.WriteLine($"Difference: {num1:F2} - {num2:F2} = {num1 - num2:F2}");
            Console.WriteLine($"Product: {num1:F2} * {num2:F2} = {num1 * num2:F2}");

            // Ternary operators used to check for division by zero.
            Console.WriteLine(num2 == 0 ? "Division cannot be performed because of division by zero" : $"Quotient: {num1:F2} / {num2:F2} = {num1 / num2:F2}");
            Console.WriteLine(num2 == 0 ? "Modulus cannot be performed because of division by zero" : $"Modulus: {num1:F2} % {num2:F2} = {num1 % num2:F2}");
            Console.WriteLine($"Average: {num1:F2} + {num2:F2} / 2.00 = {(num1 + num2) / 2:F2}");

            // Ternary operators used to check for division by zero.
            Console.WriteLine(num1 == 0 ? "Percent difference cannot be performed because of division by zero." : $"Percent difference: ({num1:F2} - {num2:F2}) / {num1:F2} * 100.00 = {(num1 - num2) / num1 * 100:F2}");
        }
        else
        {
            // If decimal is not requested.
            Console.WriteLine($"Sum: {num1:F0} + {num2:F0} = {num1 + num2:F0}");
            Console.WriteLine($"Difference: {num1:F0} - {num2:F0} = {num1 - num2:F0}");
            Console.WriteLine($"Product: {num1:F0} * {num2:F0} = {num1 * num2:F0}");

            // Ternary operators used to check for division by zero.
            Console.WriteLine(num2 == 0 ? "Division cannot be performed because of division by zero" : $"Quotient: {num1:F0} / {num2:F0} = {num1 / num2:F0}");
            Console.WriteLine(num2 == 0 ? "Modulus cannot be performed because of division by zero" : $"Modulus: {num1:F0} % {num2:F0} = {num1 % num2:F0}");
            Console.WriteLine($"Average: {num1:F0} + {num2:F0} / 2 = {(num1 + num2) / 2:F0}");

            // Ternary operators used to check for division by zero.
            Console.WriteLine(num1 == 0 ? "Percent difference cannot be performed because of division by zero" : $"Percent difference: ({num1:F0} - {num2:F0}) / {num1:F0} * 100 = {(num1 - num2) / num1 * 100:F0}");
        }

        Console.WriteLine($"Performed {numOfCalculations} calculations for {userName}!");

        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
