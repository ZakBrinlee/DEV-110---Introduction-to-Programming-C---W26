namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice

        double num1, num2;
        int validCalcs = 0;
        int totalCalcs = 0;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"

        Console.WriteLine("Please enter your name: ");
        string user = Console.ReadLine();
        Console.WriteLine("\nHello " + user + ", nice to meet you brotato chip!");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)

        Console.WriteLine("\nWould you like to use decimal precision " + user + "? (Yes/No)");

        // default decimal prefence is off @ F0
        bool decmialPref = false;
        string dPVal = "F0";
        string prefInput = Console.ReadLine().ToLower();

        if (prefInput == "yes" || prefInput == "y")
        {
            Console.WriteLine("\nPreference is saved brotein shake, I will show you the decimals.");
            decmialPref = true;
            dPVal = "F2";
        }
        else
        {
            Console.WriteLine("\nPreference is saved brochacho, I will not show you the decimals.");
        }

        //Calculator loop
        bool calcActive = true;
        while (calcActive == true)
        {
            // TODO: Prompt user for first number (double or int based on choice)
            // If decimals: use double.Parse()
            // If no decimals: use int.Parse() then cast to double

            Console.WriteLine("\nEnter first number: ");
            if (decmialPref == true)
            {
                //parses through direct to double
                num1 = double.Parse(Console.ReadLine());
            }
            else
            {
                //parses to int then casts to double
                num1 = (double)int.Parse(Console.ReadLine());
            }

            // TODO: Prompt user for second number (same type as first)
            Console.WriteLine("\nEnter second number: ");
            if (decmialPref == true)
            {
                //parses through direct to double
                num2 = double.Parse(Console.ReadLine().ToString(dPVal));
            }
            else
            {
                //parses to int then casts to double
                num2 = (double)int.Parse(Console.ReadLine());
            }

            // TODO: Display results with proper formatting
            // Show 2 decimal places: {value:F2}
            // Include descriptive labels for each operation

            Console.WriteLine("\nResults:");

            // TODO: Calculate ALL arithmetic operations:
            // - sum (addition: +)
            Console.WriteLine("Addition : " + num1 + " + " + num2 + " = " + (num1 + num2).ToString(dPVal));
            validCalcs++;
            totalCalcs++;

            // - difference (subtraction: -)
            Console.WriteLine("Subtract : " + num1 + " - " + num2 + " = " + (num1 - num2).ToString(dPVal));
            validCalcs++;
            totalCalcs++;

            // - product (multiplication: *)
            Console.WriteLine("Product  : " + num1 + " * " + num2 + " = " + (num1 * num2).ToString(dPVal));
            validCalcs++;
            totalCalcs++;

            // TODO: Check if second number is zero BEFORE dividing
            // Use if statement: if (num2 == 0) { show error } else { calculate }

            // - quotient (division: /)
            if (num2 != 0)
            {
                Console.WriteLine("Quotient : " + num1 + " / " + num2 + " = " + (num1 / num2).ToString(dPVal));
                validCalcs++;
            }
            else
            {
                Console.WriteLine("Quotient : " + num1 + " / " + num2 + " = " + "Div0 Error!");
            }
            totalCalcs++;

            // - remainder (modulus: %)
            if (num2 != 0)
            {
                Console.WriteLine("Remaindr : " + num1 + " % " + num2 + " = " + (num1 % num2).ToString(dPVal));
                validCalcs++;
            }
            else
            {
                Console.WriteLine("Remaindr : " + num1 + " % " + num2 + " = " + "Div0 Error!");
            }
            totalCalcs++;

            // - average ((num1 + num2) / 2)
            Console.WriteLine("Average  : " + num1 + " ~ " + num2 + " = " + ((num1 + num2) / 2).ToString(dPVal));
            validCalcs++;
            totalCalcs++;

            // TODO: Calculate percentage difference
            // Formula: ((num1 - num2) / num1) * 100
            // Display with % symbol
            if (num2 != 0)
            {
                Console.WriteLine("% Diff   : " + num1 + " > " + num2 + " = " + (((num1 - num2) / num1) * 100).ToString(dPVal) + "%");
                validCalcs++;
            }
            else
            {
                Console.WriteLine("% Diff   : " + num1 + " > " + num2 + " = " + "Div0 Error!");
            }
            totalCalcs++;

            // Exits while loop
            Console.WriteLine("\nWould you like to do another calculation " + user + "? (Yes/No)");
            prefInput = Console.ReadLine().ToLower();
            if (prefInput == "yes" || prefInput == "y")
            {
                Console.WriteLine("\nI got you twin, preparing for another calculation.");
            }
            else
            {
                Console.WriteLine("\nUnderstood, see you later Brotosynthesis.");
                calcActive = false;
            }
        }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"

        Console.WriteLine("\nYo, " + user + " peep these stats twin:");
        Console.WriteLine("Successful Calculations : " + validCalcs);
        Console.WriteLine("Total Calculations      : " + totalCalcs);
        if (totalCalcs > 0)
        {
            Console.WriteLine("Success Percentage      : " + ((validCalcs / totalCalcs) * 100).ToString(dPVal) + "%");
        }
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
