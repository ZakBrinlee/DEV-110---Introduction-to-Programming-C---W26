# Week 2: Calculator Lite - Study Notes

**Name: Eric Rogers**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer:
string - an array of characters
bool - binary true or false value
int - a whole number
double - a real number with decimals

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: int is more compact and uses less memory while a double stores and reflects more accurate data.
That makes it better for calculations as it can handle decimals.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: Set the bool to false by default and changed to true with an if statement if yes was input.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: Understanding the formatting output of :F and :F2. Many of the sites said: Console.WriteLine(integerNumber.ToString("F",
                  CultureInfo.InvariantCulture)); would work but it did not. I made it even harder by trying to pass F or F0 in as a string variable to save lines of code which thankfully did work out in the end.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I googled arround for the right syntax then adjusted the inputs and debugged accordingly to if it worked or not.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Again, the :F0 part because i didnt understand it initially and couldnt find accurate information at first when searching online. Everything was vauge about it or didnt show it in a full coding context.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: 10 / 5 division returns 2. Whereas modulus 10 % 5 returns the remainder which is 0 as the operation divides cleanly

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: (x + y ) / 2 . The sum of the numbers divided by 2.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: subtracts num 1 from num 2. Then divides the result by num 1. Tnen multiplies that result by 100

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Accepts terminal input from the user and returns it as a string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: Converts one variable into another variable type. In this case double.parse() takes a string and returns it as a double (if all chars are valid_)

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: $ symbol converts to string. idk what the {} does honestly.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: Shifts the decimal place by Fx where x is the rightmost decimals.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: The program breaks, can be avoided by a an if divisor != 0 that prevents program running the divide by 0 operation

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: The if else altered a variable which changed the string (either F0, or F2) which was passed into each operation.
I felt this was more efficient than doing an else if for each operation as that would double the operation lines of code visually.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. Actually having time to do assignments is nice
2. Strings vars can be passed into functions
3. How to use and manipulate variables
4.
5.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: string because it can accept and be converted to many other var types and can also work when passed into functions

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: Because its an acessebility feature that lets users tailor the information presented to their preferences.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: Tested all of the listed above, as well as decimals for the non decimal user preference.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: my biggest error was having the wrong syntax for :f0 and :f2. Mentioned a few questions above i used the wrong function.
More googling and testing fixed this though.

## Time Spent

**Total time:** [8.5 hours]

**Breakdown:**

-   Understanding data types: [2 hours]
-   Reading and parsing user input: [1 hours]
-   Implementing arithmetic operations: [1 hours]
-   Adding conditional formatting: [1 hours]
-   Handling division by zero: [0.5 hours]
-   Testing and debugging: [2 hours]
-   Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Understanding data types took the longest because I struggled a lot with understanding :F0 and :F2.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: No
Actually yes, i just did the tests and everything fails. I'm guessing its because everything is in a while loop which maybe the testing program doesnt know how to interpret (there is an extra user input afterwards that breaks the loop)

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: They build the foundation for conditional statements and working with variables and user input in the future.
