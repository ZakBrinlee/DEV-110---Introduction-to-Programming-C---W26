# Week 3: Personal Profile Card - Study Notes

Rin Peralez

## Understanding Variables and Data Types

Answer: What are the four main data types you used in this assignment?
String: I used string for strings of characters to make sure it would not be multiplied or try to bring any errors in the code.
int: I used int for numbers that did not need decimals such as age or years, which are only whole numbers.
double: I used doubles for the numbers that needed precision such as the GPA value, the numbers needed to have decimal values and for the height which needed to be divided.
bool: I used bool for true and false statements, this makes it easy for me to say yes or no to thinks like honors status, full time status, etc. Giving only 2 options of output and input.

**Why did you use `double` for GPA instead of `int`?**

Answer: Double has the ability to hold more data, such as the decimal values of numbers, while int generally ignores and decimal. GPA is generally not a whole number, it goes from the value of 0.00-4.0 so in that area it has many decimals to hold the values in between.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: I made sure to use the ? {:}and equalling my answer into true.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: Personal to me meant anything that the person has intrinsically, not related to their academics. Academics was anything related to school or their time/years in school. Anything that I needed to evaluate or that was not in either category got put in the last category of Calculated.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: I calculated the Years to graduation, converted the height, birth year, honor student status, and age in months.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: Age helps us figure out the years from birth, acting as a good reference for how far they are from their birth year. If we had done both, it would have been the same data, but more input would have been needed to be held.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: The hardest part for me was the formatting, making sure every specific part was where it needed to be and that I did not forget any of the areas.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I referenced the example given in the repository and tried my best to list off any remaining areas that I could.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: Boolean logic was interesting to me because I had never changed string input to boolean values, so it took me a while to figure that out.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: You grab the variable and put it through int.Parse or double.Parse which makes it so that the program interprets the input as the data type listed instead of a string.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: I divided feet by inches and made sure I would get getting a whole number, converting the value to int, i then grabbed the remaining inches and mod by 12, giving me the values that were not the "whole" amounts of 12.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: This checks whether or not the value is equal to or greater than 3.5 it makes it so that if the expression is true then that makes the expression true.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: The F2 format makes it so that the double is only shown as 2 decimal points instead of every single one possible.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: What I did was the same as the yes, no boolean value change and i had the output based on the value of the input ? {Full-time, Part-Time}

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: I made sure that the spacing looked the same amongst all the sections and that all the words were aligned, I also changed some of the titles so they were short enough to keep the length.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: You could add your blood type, your dream car, dream city as well.

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: Keeping the right data type helps with memory usage, if you were to have many doubles instead of ints, overtime it would slow down the program. Alternatively if you have not enough and need to switch it to a double, it can mess up a lot of different functions as well.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: Social Media, resumes, and even job interviews, rely on the search of data. Having a resume that stands out from a sea of applicants can be incredible. In the day of data explosions, having a way to read data easily and seamlessly means a lot.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Realized how much it matters to keep track of variables
2. Understood how difficult it can be to create a good looking model for variables
3. Spent time looking at what it takes to make a good looking UI
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: I think for me bool is the most challenging since I have not worked with it as much as the others.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: It helps you make sure you are not at risk of data or memory leaks due to improper data types.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: Typical values for the most part to test the formats.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: I struggled with accidentally using the same variable for my boolean conversion

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I made sure to add extra decimals to test the different values.

## Time Spent

**Total time:** [2.5 hours]

**Breakdown:**

-   Understanding data types and planning variables: [0.2 hours]
-   Collecting user input with correct types: [0.2 hours]
-   Implementing calculations: [0.6 hours]
-   Formatting output: [0.3 hours]
-   Testing and debugging: [0.4 hours]
-   Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Documentation always takes the longest, I just really dont like having to write out everything.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: I would have made some more values available and maybe organized the program with more comments.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: It makes the readability easy with proper naming and having consistent data types as well.

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: Probably either a receipt or character stats
