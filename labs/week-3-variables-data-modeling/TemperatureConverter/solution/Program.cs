namespace TemperatureConverter;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Temperature Converter ===\n");

        // Get user's name (string type)
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}! Let's convert some temperatures.\n");

        // Ask if user wants to see detailed output (bool type)
        Console.Write("Show detailed calculations? (yes/no): ");
        string detailChoice = Console.ReadLine().ToLower();
        bool showDetails = detailChoice == "yes" || detailChoice == "y";

        // Get temperature value (double type)
        Console.Write("Enter a temperature value: ");
        double inputTemp = double.Parse(Console.ReadLine());

        // Get unit (string type)
        Console.Write("Is this temperature in (C)elsius or (F)ahrenheit? ");
        string conversionChoice = Console.ReadLine().ToUpper();

        // Track number of conversions performed (int type)
        int conversionCount = 0;

        Console.WriteLine("\n=== Conversion Results ===\n");

        // Perform conversions based on input unit
        if (conversionChoice == "C" || conversionChoice == "CELSIUS")
        {
            // Convert Celsius to Fahrenheit
            // Formula: F = (C × 9/5) + 32
            double convertedTemp = (inputTemp * 9.0 / 5.0) + 32.0;
            conversionCount++;

            Console.WriteLine($"Temperature in Celsius: {inputTemp:F2}°C");
            Console.WriteLine($"Temperature in Fahrenheit: {convertedTemp:F2}°F");

            if (showDetails)
            {
                Console.WriteLine($"\nFormula used: F = (C × 9/5) + 32");
                Console.WriteLine($"Calculation: ({inputTemp:F2} × 9/5) + 32 = {convertedTemp:F2}");
            }

            // Additional interesting facts
            Console.WriteLine("\n=== Temperature Analysis ===");
            double diffFromFreezing = inputTemp - 0.0;
            double diffFromBoiling = 100.0 - inputTemp;

            Console.WriteLine($"Difference from water freezing point (0°C): {diffFromFreezing:F2}°C");
            Console.WriteLine($"Difference from water boiling point (100°C): {diffFromBoiling:F2}°C");

            // Determine temperature range
            if (inputTemp < 0)
            {
                Console.WriteLine("Status: Below freezing (water is ice)");
            }
            else if (inputTemp >= 0 && inputTemp < 100)
            {
                Console.WriteLine("Status: Between freezing and boiling (water is liquid)");
            }
            else
            {
                Console.WriteLine("Status: Above boiling (water is steam)");
            }
        }
        else if (conversionChoice == "F" || conversionChoice == "FAHRENHEIT")
        {
            // Convert Fahrenheit to Celsius
            // Formula: C = (F - 32) × 5/9
            double convertedTemp = (inputTemp - 32.0) * 5.0 / 9.0;
            conversionCount++;

            Console.WriteLine($"Temperature in Fahrenheit: {inputTemp:F2}°F");
            Console.WriteLine($"Temperature in Celsius: {convertedTemp:F2}°C");

            if (showDetails)
            {
                Console.WriteLine($"\nFormula used: C = (F - 32) × 5/9");
                Console.WriteLine($"Calculation: ({inputTemp:F2} - 32) × 5/9 = {convertedTemp:F2}");
            }

            // Additional interesting facts
            Console.WriteLine("\n=== Temperature Analysis ===");
            double diffFromFreezing = inputTemp - 32.0;
            double diffFromBoiling = 212.0 - inputTemp;

            Console.WriteLine($"Difference from water freezing point (32°F): {diffFromFreezing:F2}°F");
            Console.WriteLine($"Difference from water boiling point (212°F): {diffFromBoiling:F2}°F");

            // Determine temperature range
            if (inputTemp < 32)
            {
                Console.WriteLine("Status: Below freezing (water is ice)");
            }
            else if (inputTemp >= 32 && inputTemp < 212)
            {
                Console.WriteLine("Status: Between freezing and boiling (water is liquid)");
            }
            else
            {
                Console.WriteLine("Status: Above boiling (water is steam)");
            }
        }
        else
        {
            Console.WriteLine("Invalid unit! Please enter 'C' for Celsius or 'F' for Fahrenheit.");
            conversionCount = 0;
        }

        // Display conversion count
        if (conversionCount > 0)
        {
            Console.WriteLine($"\nPerformed {conversionCount} temperature conversion(s) for {userName}!");
        }

        Console.WriteLine("\nThank you for using Temperature Converter!");
    }
}
