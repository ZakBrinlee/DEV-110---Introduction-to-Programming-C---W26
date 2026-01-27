# Week 2: Calculator Lite - Study Notes

**Name:**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer:string,int,double,bool

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: calculation with number could make decimal, type of int is for whole number.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: using if statment can conversion to boolean

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: For me to understand the int.parse could be implicit conversion to type of double, when I read the instruction of comments "If no decimals: use int.Parse() then cast to double", I was confusion". After that I see it could be auto to conversion.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer:Search online according erro information in my cmd, and check it out, it could be automacticlly conversion to double.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer:Everything is fine, just search something with formatting about "F2", I discoverd the convinient the way to use it, to shorten the code and if statement.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: % for modle, / is for devide

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: number1 plus number2 and the result of their sum, then divide by 2;

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: ((18 - 7) / 18 ) * 100) = 61.11%

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: Allow to typing character, and return string.

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: using int.Parse() or double.Parse();

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: set it in the front of the quot

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: declare a global string variable to assignment a "F2" or "F0" , tostring() When WriteLine

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: if divide by zero, it got be erro.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: use if statements to determine.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. I have learned in the C# a type of int variable could implicit conversion to double.
2. I have learned the writeconsole line format
3. I have learned the if statments to control the flow.
4.
5.

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer:bool is the most useful, because using it with if statement to determine logic.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer:

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer:(18,7) ,(-10,-5),(34.06, -7.8)

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: I got the error is: "error CS1503: Argument 1: cannot convert from 'double' to 'System.ReadOnlySpan<byte>'". I was use write: double num1 = double.parse(int.parse(Console.Readline())); so I delete elimate the int.parse().

## Time Spent

**Total time:** [3 hours]

**Breakdown:**

-   Understanding data types: [1 hours]
-   Reading and parsing user input: [0.5 hours]
-   Implementing arithmetic operations: [20 min]
-   Adding conditional formatting: [0.5 hours]
-   Handling division by zero: [10min]
-   Testing and debugging: [0.5 hours]
-   Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: I took the most time on reading the construction, document and requirements.

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer:I would like do extra code and more practicing.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer:These is the foundation of C# coding. Is important to understand the if conditon statements and formatting.
