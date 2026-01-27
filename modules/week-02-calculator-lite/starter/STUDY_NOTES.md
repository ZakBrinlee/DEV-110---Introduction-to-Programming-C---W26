# Week 2: Calculator Lite - Study Notes

**Name:**

## Understanding Data Types

**What are the four data types you used in this assignment?**
Bool: A boolean that stores a true or false variable
String: a string of text
Integer: a whole number
double: a number

[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: Bool: A boolean that stores a true or false variable
String: a string of text
Integer: a whole number
double: a number


**Why did we use `double` instead of `int` for the calculations?**
A double is like a float, it can use decimals

[Explain the difference between int and double, and why double is better for this calculator]

Answer: A double is like a float, it can use decimals

**How do you convert a string to a boolean?**
with an if then statement ( if yes then true; if no then false ) this is obviosly oversimplified

[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: with an if then statement ( if yes then true; if no then false ) this is obviosly oversimplified

## Challenges and Solutions

**Biggest challenge with this assignment:**
understanding the interface. the preview ghosting thing kept showing up, which was kind of nice. I also forgot to save, and it took me 10 minutes to remember and figure that out.

[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: understanding the interface. the preview ghosting thing kept showing up, which was kind of nice. I also forgot to save, and it took me 10 minutes to remember and figure that out.

**How you solved it:**
I fixed those issues by ignoring the previews, remembering to save, then I also had another bug but the clanker helped me fix it.

[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I fixed those issues by ignoring the previews, remembering to save, then I also had another bug but the clanker helped me fix it.

**Most confusing concept:**
Parsing input probably

[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Parsing input probably

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
one gives a quotient while the other gives a remainder left after dividing

[Explain what each operator does and give an example]

Answer: one gives a quotient while the other gives a remainder left after dividing

**How do you calculate the average of two numbers?**
add them together and divide by 2

[Write the formula in your own words]

Answer: add them together and divide by 2

**What is the formula for percentage difference?**
((num1 - num2) / num1) * 100)
number 1 minus number 2, divide by bumber 1 and then multiply by 100

[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: ((num1 - num2) / num1) * 100)
number 1 minus number 2, divide by bumber 1 and then multiply by 100

## Input and Output

**How do you read user input in C#?**
that line reads what the user inputs and retruns it as a string

[Explain what Console.ReadLine() does and what type of data it returns]

Answer: that line reads what the user inputs and retruns it as a string

**How do you convert string input to a number?**
I used double.Parse()

[Explain the Parse methods you used, like double.Parse()]

Answer: I used double.Parse()

**What is string interpolation and how did you use it?**
It lets you add variables right into a string

[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: It lets you add variables right into a string

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
f2 shows 2 decimal places, f0 shows no decimal places ( whole number )

[Explain the :F2 and :F0 format specifiers]

Answer:f2 shows 2 decimal places, f0 shows no decimal places ( whole number )

**Why is it important to check for division by zero?**
trying to divide by 0 messes things up

[Explain what happens if you try to divide by zero and how you handled it]

Answer: trying to divide by 0 messes things up

**How did you use the boolean variable to control formatting?**
its a simple boolean that the user sets to true or false. it checks this boolean before giving the actual answers, and adjusts appropiately.

[Explain how you used if/else to format output differently based on user preference]

Answer: its a simple boolean that the user sets to true or false. it checks this boolean before giving the actual answers, and adjusts appropiately.


## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. I learned to always save
2. I learned that I can press tab to fill things out
3. I learned that a double is the same thing as a float
4.
5.

**Which data type concept was most useful?**
I already know string, bool, and int. from Unreal Engine, the only 'new' one was the double, which is basically just a float.

[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: I already know string, bool, and int. from Unreal Engine, the only 'new' one was the double, which is basically just a float.

**How does conditional formatting improve user experience?**
it allows for more precision and customization

[Why is it helpful to let users choose decimal precision?]

Answer: it allows for more precision and customization


## Testing and Debugging

**What test cases did you use to verify your program works?**
I tested whole numbers, small numbers, big numbers, negative numbers, zero, decimals, etc.


[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: I tested whole numbers, small numbers, big numbers, negative numbers, zero, decimals, etc.

**What bugs or errors did you encounter and fix?**
I discovered an unknown bug that the clanker fixed for me

[Describe any errors you got and how you fixed them]

Answer: I discovered an unknown bug that the clanker fixed for me

## Time Spent

**Total time:** [1 hours]

**Breakdown:**

-   Understanding data types: [0.2 hours]
-   Reading and parsing user input: [0.1 hours]
-   Implementing arithmetic operations: [0.3 hours]
-   Adding conditional formatting: [0.2 hours]
-   Handling division by zero: [0.1 hours]
-   Testing and debugging: [0.1 hours]
-   Writing documentation: [0.25 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

probably writing the actual code

Answer: probably writing the actual code

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: nothing

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: teaching the basics and fundamentals.
