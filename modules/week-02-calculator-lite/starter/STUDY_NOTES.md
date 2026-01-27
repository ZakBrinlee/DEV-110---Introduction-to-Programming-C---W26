# Week 2: Calculator Lite - Study Notes

**Name:** Yuwen Chen

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer:
string — stores text made up of characters, such as names, words, or sentences.

bool — stores a true or false value.

int — stores whole numbers without decimals, such as counts or quantities.

double — stores numbers that can include decimal values, commonly used for calculations involving fractions or precise measurements.
**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer:
We used double instead of int because double can store numbers with decimal values, while int can only store whole numbers. Many calculator operations, such as division, averages, and percentage calculations, often result in decimals.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer:
I first read the user’s input text and then set bool variable = if the read text == to a specific value. Like "yes" in this program. In this program, the input is converted to lowercase and checked to see if it equals "yes". If it matches, the boolean value is set to true; otherwise, it is set to false. This allows the program to turn a simple yes or no response into a true or false value that can be used in conditional logic.
## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer:
I didn't feel any challenge part in this assignment. 

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer:
As I said above, there is not hard part to solve. 
**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer:
The most confusing concept for me was conditional formatting, especially figuring out how to display numbers differently based on the user’s choice and use double for both of the user's choice.
## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: one is the result of division while the other one is the remainder of the division. 
8 / 5 = 1
8 % 5 = 3

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: 
I simply use the sum divided by 2. 

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer:
The formula are first finding the difference between the two numbers, then dividing that difference by the original value (num1) to see how large the change is relative to it. Finally, multiplying by 100 converts the result into a percentage.
## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer:
Console.ReadLine() is used to read input that the user types into the console. It waits until the user presses Enter and then returns everything they typed as a string. Because it always returns text, the input often needs to be converted into another data type, such as int, double, or bool, before it can be used in calculations or logical decisions.
**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer:
User input is read as a string, so it must be converted into a number before it can be used in calculations. This is done using Parse methods, such as double.Parse or int.Parse, which take the string input and convert it into the corresponding numeric value.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer:
String interpolation is a way to combine text and variable values into a single string. In C#, it uses the $ symbol before the string and curly braces {} inside the string to insert variable values directly into the output. I used string interpolation in Console.WriteLine() to display results and messages clearly, such as showing the user’s name or the results of calculations, without needing to concatenate multiple strings together.
## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer:
Numbers can be formatted by specifying how many decimal places should be displayed when they are printed. Using F2 formats a number to show exactly two decimal places, while F0 formats a number to show no decimal places and rounds it to a whole number. In the program, this formatting was used to control the output based on the user’s preference, allowing the same calculations to be displayed either with decimals or as whole numbers.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer:

If we don't handle and check divisio by zero, the program will crash. 
**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer:
The boolean variable was used to store the user’s preference for decimal precision as either true or false. An if/else statement checked this value to decide which formatting style to use. If the value was true, the program formatted numbers with two decimal places, and if it was false, the program formatted numbers as whole numbers. This allowed the same calculations to be displayed differently without changing the math itself.
## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. User input must be converted before it can be used in calculations.
2. Choosing the right data type affects accuracy and clarity.
3. Boolean variables help control program behavior.
4. Error checks like division by zero are important.
5. Formatting output improves readability.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer:
Double was the most useful because it allows calculations with decimals, which is necessary for averages, division, and percentages.
**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer:
It lets users choose how results are displayed, making the output clearer and more comfortable to read based on their preference.
## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer:
whole numbers, decimals, and zeros. 
**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer:
Some synthex error and use the wrong data type at first. 
## Time Spent

**Total time:** 1 hours

**Breakdown:**

-   Understanding data types: [0.1 hours]
-   Reading and parsing user input: [0.1 hours]
-   Implementing arithmetic operations: [0.2 hours]
-   Adding conditional formatting: [0.1 hours]
-   Handling division by zero: [less then 0.1 hours]
-   Testing and debugging: [0.2 hours]
-   Writing documentation: [0.2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
debugging and writing documents. Writing documentation takes long because there are a lot of words need to write down. Debugging is because i need to try and test a lot of times to solve erros and bugs. 
## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer:
Next time, I would use safer input methods like TryParse to prevent errors and make the program more robust. I would also plan the logic more clearly before writing the code.
**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer:
This assignment builds important skills like handling user input, choosing correct data types, using conditionals, and formatting output. These skills are essential for writing larger programs that need to be accurate, user-friendly, and error-resistant.