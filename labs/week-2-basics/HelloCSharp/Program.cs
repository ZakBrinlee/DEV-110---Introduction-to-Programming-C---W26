namespace HelloCSharp;

public class Program
{
    public static void Main(string[] args)
    {
        // string x;
        // // Input
        // Console.Write("Hello Please provide your name: ");
        // // Processing the variable
        // x = Console.ReadLine();
        // // Output
        // Console.WriteLine("Welcome {0}!", x);

        // int num1, num2, sum, prod, quot, rem;

        // // Get inputs
        // num1 = int.Parse(Console.ReadLine());
        // num2 = int.Parse(Console.ReadLine());

        // // Processing
        // sum = num1 + num2;
        // prod = num1 * num2;
        // quot = num1 / num2;
        // rem = num1 % num2;

        // // Output
        // Console.WriteLine("{0} + {1} = {2}", num1, num2, sum.ToString());

        // Console.WriteLine("{0} * {1} = {2}", num1, num2, prod.ToString());

        // Console.WriteLine("{0} / {1} = {2}", num1, num2, quot.ToString());

        // Console.WriteLine("{0} % {1} = {2}", num1, num2, rem.ToString());
        // Console.WriteLine();

        Console.WriteLine("Please enter a year: ");
        // Input
        int year = int.Parse(Console.ReadLine());

        // Process
        Boolean isLeapYear; // Will only be true or false

        // Year divided by 4 is not zero AND year divided by 100 does not have a remainder of 0
        isLeapYear = (year % 4 == 0) && (year % 100 != 0);
        isLeapYear = isLeapYear || (year % 400 == 0);

        // Output
        Console.WriteLine("The Year {0} is {1} ", year.ToString(), isLeapYear.ToString());

        Console.ReadLine();
    }
}
