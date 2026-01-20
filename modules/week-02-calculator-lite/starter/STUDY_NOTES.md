# Week 2: Calculator Lite - Study Notes

**Name:** James Garside

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: String is a sequence of characters. Bool is a true or false value. int is a integer between -2^31 - 2^31. Double is a real number (technically a range of real numbers)

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: int is an integer, while double is a real number. Double is better because it offers more precision (and decimal places) than an integer.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I got the string and then checked it as the value of the boolean.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: The hardest part was probably getting user input because I forgot that I had to write using a seperate method.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I saw the error and fixed it.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Percentage formula because I have never seen it before.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: Division is standard division. Modulus is the remainded of division.

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: the sum of the two numbers and then divided by two.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: gets the difference between the two numbers, divides by num1 (to make it relative) and then multiplies by 100 to make it a percentage.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Console.ReadLine() watches user input and ends once and enter key is pressed.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: I used double.Parse() because it is the one that I have used before. Other parse methods are probably better,but unnecessary because of scope.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: The $ is used to inform the string that it is going to be interpolated. The curly brackets are used for interpolation, in my case, I used them to output the values of variables and perform basic arithmetic (and format).

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: F2 and F0 are just the number of decimal places that are shown.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: Division by zero results in an error. I first check if a division by zero could occur, and then don't do the math (while informing the user).

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: I used it by asking the user if they wanted decimals and then swapping between logic paths based on their answer.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. Learned a bit more about parsing.
2. Learned how to ask the user for information (through console).
3. First work with the git, and then work on the code.
4.
5.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: Double is the most interesting because of it is very technical.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: It is not. I am currently interning at Microsoft for UX design and have learned that extra features like this actually harm the UX. It would be better to round to 7 decimal places, because that is more useful and looks better.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I checked for any two numbers, then a zero in the first number and a zero in the second.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: The only errors I got were because I misspelled the variable names (because I wrote in a text processor, not an IDE).

## Time Spent

**Total time:** 1.5 hours

**Breakdown:**

-   Understanding data types: 0 minutes
-   Reading and parsing user input: 7 minutes
-   Implementing arithmetic operations: 8 minutes
-   Adding conditional formatting: 4 minutes
-   Handling division by zero: 2 minutes
-   Testing and debugging: 25 minutes
-   Writing documentation: 50 minutes

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Writing documentation took the most time because I accidentally deleted the codebase (probably because of my branch switching). Rewriting what I wrote took around fourty extra minutes.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: Fuck around with Git BEFORE doing the code. Not after.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: These skills are important because they are about basic logic and variables.
