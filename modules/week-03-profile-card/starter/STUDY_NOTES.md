# Week 3: Personal Profile Card - Study Notes

**Name:** Katherine Ayala

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
Answer:String was used in this assignment to store text information like name, hometown, favorite color, dream job and major. Int was used for whole numbers for age, graduation year, birth year, years to graduation and age in months. Double was used for numbers with decimals like for example GPA and height in inches. Bool was uesd for true/false values like for when it asked if im a full time student yes/no.

**Why did you use `double` for GPA instead of `int`?**
Answer:I used double for GPA because GPA values often include decimals. using double allows the program to store decimal values, while using int would remove decimals and GPA would be inaccurate.

**How did you convert the yes/no input into a boolean?**
Answer:I converted the input to lowercase and checked if it was equal to "yes". If it was "yes", the value became true; otherwise it became false.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
Answer:I grouped the information into personal information, academic details, and calculated statistics so the profile is easier to understand.

**Which pieces of information did you calculate rather than ask for?**
Answer:I calculated the birth year, years to graduation, height; feet and inches, honor student status, and age in months.

**Why is it better to calculate birth year from age rather than ask for both?**
Answer:Calculating birth year from age just makes everything more accurate and consistent instead of relying on two separate inputs.

## Challenges and Solutions

**Biggest challenge with this assignment:**
Answer:The biggest challenge was formatting the output cleanly and making sure all values displayed in the correct sections.

**How you solved it:**
Answer:I solved it by working step by step, testing the program often, and adjusting the output formatting until it matched the expected results.

**Most confusing concept:**
Answer:The most confusing concept was converting height from inches to feet and inches using division and modulus.

## Type Conversion and Calculations

**How do you convert string input to a number?**
Answer:When the user types something into the console, it comes in as a string. Since you can’t do math with strings, I had to convert the input into numbers. I used int.Parse() for whole numbers like age and graduation year, and double.Parse() for numbers that can have decimals like GPA and height.

**What calculation did you use to convert height from inches to feet and inches?**
Answer:I used division to figure out how many full feet were in the total number of inches, because there are 12 inches in a foot. Then I used modulus to find the leftover inches after the feet were taken out. This way the height could be shown as feet and inches instead of just inches.

**How did you determine if someone is an honor student?**
Answer:Instead of asking the user, the program checks the GPA. If the GPA is 3.5 or higher, the program considers the student an honor student. This is done using a true or false comparison.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
Answer:I used the :F2 format when printing the GPA so it always shows two decimal places, even if the number is a whole value like 4.0.

**How did you display different text based on whether someone is full-time or part-time?**
Answer:I checked whether the value was true or false. If it was true, the program printed “Yes”, and if it was false, it printed “No”.

**What techniques did you use to make the output look organized?**
Answer:I used spacing and clear labels to separate the information and make the output easy to read.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
Answer:Other calculated fields could include BMI if weight was added or the number of years / months until graduation

**Why is choosing the right data type important in real applications?**
Answer:Choosing the right data type helps prevent errors and makes sure data is stored and used correctly, especially when doing calculations.

**How does this profile card relate to real-world applications?**
Answer:This profile card is similar to systems like student records or like the website indeed where information is collected and displayed.
## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Calculating values is better for accuracy rather than asking for it
2. boolean values are useful for true or false(yes/no) decisions
3. formatting helps make sure the program is easier to read
4. 0
5. 0

**Which data type was most challenging to work with and why?**
Answer:Double was the most challenging because I had to be careful when converting and formatting decimal values like GPA and height.

**How does understanding data types help you write better programs?**
Answer:Understanding data types helps prevent errors, makes calculations accurate, and keeps programs more organized.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
Answer:I tested different GPA values, different heights in inches, and different ages to make sure the calculations for honor student status, height conversion, and birth year worked correctly.

**What bugs or errors did you encounter and fix?**
Answer:I ran into issues with formatting warnings and failing tests related to my study notes file. I fixed them by adjusting spacing in the code, filling out all sections of STUDY_NOTES.md, and rerunning the tests until everything passed.

**How did you validate that your data types were correct?**
Answer:I ran the program with different inputs and made sure numbers were calculated correctly and displayed properly without errors.

## Time Spent

**Total time:** 2 hours

**Breakdown:**

-   Understanding data types and planning variables: 0.5 hours
-   Collecting user input with correct types: 0.5 hours
-   Implementing calculations: 0.25 hours
-   Formatting output: 0.25 hours
-   Testing and debugging: 0.25 hours
-   Writing documentation: 0.25 hours

**Most time-consuming part:**
Answer:Formatting output and fixing test issues was the most consuming.

## Reflection

**What would you do differently if you started over?**
Answer:I would plan the output format earlier so I wouldn’t need to adjust it as much at the end.

**How does proper data modeling make programs easier to maintain?**
Answer:It keeps data organized and consistent, which makes the program easier to read and do updates.

**What real-world system would you like to model next?**
Answer:I feel like a shopping cart system would be fun to do in this class, we can have it calculate totals and discounts.
