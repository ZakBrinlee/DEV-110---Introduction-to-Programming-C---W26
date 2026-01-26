namespace TemperatureConverter;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Display the welcome message
        // Print "=== Temperature Converter ===" with blank lines before and after


        // TODO: Get the user's name (string type)
        // 1. Display a prompt asking for their name
        // 2. Read their input and store it in a variable called userName


        // TODO: Greet the user by name
        // Display: "Hello, {userName}! Let's convert some temperatures."


        // TODO: Ask if user wants detailed calculations (bool type)
        // 1. Display prompt: "Show detailed calculations? (yes/no): "
        // 2. Read their input and store it in a variable
        // 3. Convert the input to lowercase using .ToLower()
        // 4. Create a bool variable called showDetails
        // 5. Set showDetails to true if the input is "yes" or "y" (use || for OR)


        // TODO: Get the temperature value (double type)
        // 1. Display prompt: "Enter a temperature value: "
        // 2. Read the input
        // 3. Convert it to a double using double.Parse()
        // 4. Store it in a variable called inputTemp


        // TODO: Get the unit (string type)
        // 1. Display prompt: "Is this temperature in (C)elsius or (F)ahrenheit? "
        // 2. Read the input and convert to uppercase using .ToUpper()
        // 3. Store it in a variable called conversionChoice


        // TODO: Create a counter for conversions (int type)
        // Initialize an int variable called conversionCount to 0


        // TODO: Display section header
        // Print "=== Conversion Results ===" with blank lines


        // TODO: Check which conversion to perform
        // Use if/else to check if conversionChoice is "C" or "CELSIUS"

        // if (conversionChoice == "C" || conversionChoice == "CELSIUS")
        // {
        // TODO: Convert Celsius to Fahrenheit
        // Formula: F = (C × 9/5) + 32
        // IMPORTANT: Use 9.0 and 5.0 (not 9 and 5) for decimal division!
        // Store the result in a variable called convertedTemp


        // TODO: Increment the conversion counter
        // Add 1 to conversionCount


        // TODO: Display the results
        // Show both the input temperature and converted temperature
        // Use :F2 to format numbers with 2 decimal places
        // Example: "Temperature in Celsius: 25.00°C"


        // TODO: Show detailed calculation if requested
        // Use an if statement to check if showDetails is true
        // If yes, display the formula and calculation steps


        // TODO: Display temperature analysis
        // Print "=== Temperature Analysis ===" header


        // TODO: Calculate differences from water phase-change points
        // 1. Difference from freezing (0°C)
        // 2. Difference from boiling (100°C)
        // Store results and display with :F2 formatting


        // TODO: Determine water state based on temperature
        // Use if/else to check temperature ranges:
        // - Below 0°C: "Below freezing (water is ice)"
        // - Between 0°C and 100°C: "Between freezing and boiling (water is liquid)"
        // - Above 100°C: "Above boiling (water is steam)"

        // }
        // else if (conversionChoice == "F" || conversionChoice == "FAHRENHEIT")
        // {
        // TODO: Convert Fahrenheit to Celsius
        // Formula: C = (F - 32) × 5/9
        // IMPORTANT: Use 32.0, 5.0, and 9.0 for decimal division!
        // Store the result in convertedTemp


        // TODO: Increment the conversion counter


        // TODO: Display the results
        // Show both temperatures with :F2 formatting


        // TODO: Show detailed calculation if requested
        // Check if showDetails is true


        // TODO: Display temperature analysis header


        // TODO: Calculate differences from water phase-change points
        // 1. Difference from freezing (32°F)
        // 2. Difference from boiling (212°F)


        // TODO: Determine water state based on temperature
        // Use if/else to check temperature ranges:
        // - Below 32°F: "Below freezing (water is ice)"
        // - Between 32°F and 212°F: "Between freezing and boiling (water is liquid)"
        // - Above 212°F: "Above boiling (water is steam)"

        // }
        // else
        // {
        // TODO: Handle invalid unit input
        // Display error message and set conversionCount to 0

        // }

        // TODO: Display conversion count if successful
        // Use an if statement to check if conversionCount is greater than 0
        // If yes, display: "Performed {conversionCount} temperature conversion(s) for {userName}!"


        // TODO: Display closing message
        // Print "Thank you for using Temperature Converter!"

    }
}
