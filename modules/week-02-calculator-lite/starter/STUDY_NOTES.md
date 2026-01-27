# Week 2: Calculator Lite - Study Notes

**Name:**Ethan

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer:
string - stores a group of characters
bool - can be either true or false
int - stores a whole number
double - is a number that includes decimals

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer:an int is a whole number and a double includes decimals

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I checked if the string equaled yes, if so then it output false

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: performing calculations

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: to overcome performing all the calculations correctly I tried multiple approaches until I found one that worked

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer:Parsing input was probably the most difficult thing to understand

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer:% finds the remainder, and / performs division

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: (first number - second number) / 2

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: this formula finds the percentage difference between two numbers

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer:Console.ReadLine() reads what the user types and returns a string

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: double.parse() converts a string into a number with decimals

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer:string interpolation is a way to combine text and variables into a single string

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer:F2 allows two decimal places, while F0 allows only whole numbers

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer:dividing by 0 will give an error. what i did to avoid this was to check if the second number was 0, if it was
it would output an error message instead

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer:I used if/else to determine whether to use decimal precision or not

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1.the purpose of parse
2.the difference between double and int
3.how to perform mathmatic equations using C#
4.proper workflow when designing a program
5.how to better use git

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer:Bool was the most useful because it helped me manage logic

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer:because sometimes the user might not need decimals in answers.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer:I tested whole numbers, 0, decimals, and negative numbers

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer:most of the bugs that I ran into had to do with syntax

## Time Spent

**Total time:** [X hours]

**Breakdown:**

-   Understanding data types: [1 hours]
-   Reading and parsing user input: [1/2 hours]
-   Implementing arithmetic operations: [1/2 hours]
-   Adding conditional formatting: [1/2 hours]
-   Handling division by zero: [1/3 hours]
-   Testing and debugging: [1/3 hours]
-   Writing documentation: [1/3 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Fixing various errors that I ran into was the most time consuming part

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer:be more descriptive in making an outline before coding so I run into less buggs

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer:It teaches me how to manage variables, especialy int and double, which will be used in almost all programs.
