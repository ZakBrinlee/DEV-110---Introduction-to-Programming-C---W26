# Week 2: Calculator Lite - Study Notes

**Name:Elyana Bekele**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer:
- string -> this data type stores text so I have used it for the users name and their input or yes/no
- bool -> this data type stores ture/false, which I have used it for to decided if the user want to use decimal or not
- int -> this data type stores whole numbers and I have used it for my calculations, to count how many were being counted
- double -> this data type stores decimal and I have used it for my calculations.

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: int is a whole number while double stores decimals. The reason why double was better because the assignment / the calacuation of the calculator uses different mathematical operations, like division and averages so its important to use double because it allows us to get accuare results.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: I converted the user's "yes/no" by reading it as a string and by checking whether if it was yes/no, and then i used used boolean to set yes as in true and no as in fasle.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: The most challenging part was making sure all the calulation ran smoothly and correcly and trying to match it with the assignment.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I just played around with the numbers and adjusting when the calculation increased and decreaced and tried to count it carfuly.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: the hardest part to understand or to do was when the calculation counted during division by zero

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: divison gives you the outcome of the results of the two numbers being divided but Modulus gives you the remainder

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: you add two numbers together and then after you get the outcome divide it by two.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: This formula calculates the difference between the second number and the frist numbers and then shows the percentage difference of frist number.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: it reads the input typed by the user and returns it as a string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: i used double.Parse and int.Parse to convert string input into a number.

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: string interpolation allows us to place our variables inside a string using $ symbol and the curly brackets. The way i used it is to display the outcomes and also personalized messages for the user.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: :F0 formats numbers as a whole number while on the other hand :F2 formats numbers to two decimal places.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: it's important to check for division by zero because it can cause the program to crash so I think by checking ahead of the time for any errors could be helpful to prevent any crashes.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: The way I used boolean variable with if/else statement is to ask the user if they decided to go with decimal or whole number and then giving the outcome as they requested.
## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. Using arithmetic operation
2. Debugging / preventing runtime errors especially when dividing by zero
3. Using different data types
4. Using if/else statments
5. Learning about Escape Sequence

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: I found bool data type most interesting and most helpful for this assignment because it helped the program decide what to do and not to do. and it was interesting to learn how you can control things for example whether to run something or changes or even stop a process.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: its helpful because it makes the program easier to read and understand and also lets the user see results in whichever format the prefer.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I used whole numbers, zero, decimal numbers,

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: I encountered errors when it came to incorrect calculation count and I fixed them by continuting to adjust the condition and just checking if it increased or decreased ------

## Time Spent

**Total time:** [13 hours]

**Breakdown:**

-   Understanding data types: [1 hours]
-   Reading and parsing user input: [1 hours]
-   Implementing arithmetic operations: [2 hours]
-   Adding conditional formatting: [2.5 hours]
-   Handling division by zero: [2 hours]
-   Testing and debugging: [3 hours]
-   Writing documentation: [2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: testing and debugging, because the count would be off so I had to fix it and some of incorrect spelling.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: I think I need to focus on knowing how to solve the problem ahead of the time. It can even be creating a structure to know how it will go instead of just starting to code and figuring it on the way.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: Skills like debugging, using variables, and using if/else statments etc, it's very important to know because it gives of a sense of how programming as a programer would look like.
