namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice

        double inputNumber1 = 0;
        double inputNumber2 = 0;
        double outputDecimal = 0;
        string operation = "placeholder";
        int calculationCount = 1;
        double percentageDifference = 0;




        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"

        Console.WriteLine("Enter your name");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)

        Console.WriteLine("Use decimal precision? (yes/no):");

        string detailChoice = Console.ReadLine().ToLower();
        bool useDecimals = detailChoice == "yes" || detailChoice == "y";

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double

        Console.WriteLine("Please enter the first number");
        if (useDecimals == true)
        {
            inputNumber1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"stored {inputNumber1}, please enter second number");
            inputNumber2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"stored {inputNumber2}, please enter operation");
            Console.WriteLine("Your choices are +,-,*,/,%,avg");

        }
        else
        {
            inputNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"stored {inputNumber1}, please enter second number");
            inputNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"stored {inputNumber2}, please enter operation");
            Console.WriteLine("Your choices are +,-,*,/,%,avg");
        }

        operation = Console.ReadLine();



        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        // - difference (subtraction: -)
        // - product (multiplication: *)
        // - quotient (division: /)
        // - remainder (modulus: %)
        // - average ((num1 + num2) / 2)

        if (operation == "+" || operation == "addition")
        {

            outputDecimal = inputNumber1 + inputNumber2;
            if (useDecimals == true)
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F2}!\n");
            }
            else
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F0}!");
            }

    }
        else if (operation == "-")
        {
            Console.WriteLine($"You have chosen {operation}, calculating");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            outputDecimal = inputNumber1 - inputNumber2;
            if (useDecimals == true)
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F2}");
            }
            else
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F0}");
            }
        }

        else if (operation == "*")
        {
            Console.WriteLine($"You have chosen {operation}, calculating");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            outputDecimal = inputNumber1 * inputNumber2;
            if (useDecimals == true)
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F2}");
            }
            else
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F0}");
            }
        }

        else if (operation == "/")
        {
            if(inputNumber2 == 0 )
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
            Console.WriteLine($"You have chosen {operation}, calculating");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            outputDecimal = inputNumber1 / inputNumber2;
                if (useDecimals == true)
                {
                    Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F2}!");
                }
                else
                {
                    Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F0}!");
                }
            }
        }
        else if (operation == "%")
        {
            Console.WriteLine($"You have chosen {operation}, calculating");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            outputDecimal = inputNumber1 % inputNumber2;
            if (useDecimals == true)
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F2}");
            }
            else
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F0}!");
            }

        }
        else if (operation == "avg")
        {
            outputDecimal = (inputNumber1 + inputNumber2)/2;
            if (useDecimals == true)
            {
            Console.WriteLine($"({inputNumber1} + {inputNumber2}) / 2 = {outputDecimal:F2}\n");
            }
            else
            {
                Console.WriteLine($"{inputNumber1} {operation} {inputNumber2} = {outputDecimal:F0}!\n");
            }
        }
        else{Console.WriteLine("Please enter a valid input");}
        calculationCount =+ 1;
        Console.WriteLine ($"Performed {calculationCount} calculations for {userName}!");

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
        percentageDifference = ((inputNumber1 - inputNumber2)/inputNumber1) * 100;
        Console.WriteLine($"There is a {percentageDifference}% difference.");


        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
