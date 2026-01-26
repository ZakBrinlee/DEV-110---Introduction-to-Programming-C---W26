# Week 2: Calculator Lite - Study Notes

**Name:** Yanlin Tang

Yanlin Tang

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: String stores text, bool stores true or false, int stores a whole number and double stores numbers with decimals

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: double can hold both whole numbers and decimals, int can only hold one, so for our purposes it's better to have double because we'll likely deal with decimals at some point

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I basically just did what we did from lab and set the boolean to true if the input was "yes" or "y"

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: figuring out how to get the output exactly as the tests want it, i ended up doing it a bit weirdly with a bunch of if statements

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I couldn't, I get the correct outputs when testing but can't get the tests to pass for some reason. I tried changing the text output to match exactly what the test wants but it still didn't work.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: the most confusing part was figuring out when and where to use if statements, I feel like I ended up using too many and it ended being a jumbled mess.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: / gives you a number that has been divided by the second number from the first number,

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: (input1 + input2)/2

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: you divide the new number by the original number, then multiply it to turn it to a percentage

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: it reads the text input from the user's console, it returns string (string)

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: you use datatype.Parse to transform the type of data that Console.ReadLine() stores.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: $ tells the program that there will be variables inside, the curly braces are the way for the program to recognize it as a variable

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer:  you use :F# for the amount of decimal places that you want. if you want 2 places you do :F2, if you want none you do :F0

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: if you try to divide by 0 usually the computer will either crash or freak out. I included a check that sees if the second input is 0 when dividing. If the check is true then it doesn't try to calculate it.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: i used if/else to check for which operations the user wanted to do. the entire 2nd half of the calculator program depends on an if statement to do the calculations, if the user wants to do addition, then the section for addition runs.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. How parsing works for variables, especially if you have 2 types of data you need stored.
2. trying to include less if statements inside if statements.
3. I need to organize my code more.
4.
5.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: string because it has a lot of possibilities and I found the most fun writing code involving string.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: some users might not want decimals

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I tested positive numbers, dividing by zero, decimals, negative numbers, remainders

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: I didn't really encounter anything except syntax errors and the tests not passing despite my best efforts (and the outputs being correct!)

## Time Spent

**Total time:** 4 hours

**Breakdown:**

-   Understanding data types: [.5 hours]
-   Reading and parsing user input: [.5 hours]
-   Implementing arithmetic operations: [.5 hours]
-   Adding conditional formatting: [.5 hours]
-   Handling division by zero: [.5 hours]
-   Testing and debugging: [1 hours]
-   Writing documentation: [.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: trying to figure out why the test won't pass despite outputs being right

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I would try to organize my code a bit more, it ended being kind of everywhere.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: Learning the basic data types are important because the programs in the future won't work without the correct data types.
