# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Conner Walker

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: Parallel arrays are 2 related arrays used to connect 2 types of data to one another, intended to be indexed through at the same time.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: the count variable stores how many total slots are in use, and is added/subtracted from whenever someone is added or removed.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: i used count to loop through adding or subtracting new students

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: the foreach loops through each item in the lines array and prints them, to show the total roster.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: I sorted the roster by first copying the original info and sorting them either by alphabetical or credit number with array.sort

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. how/when to use the out keyword
2. strengthened looping practices
3. arrays and array sorting

**Which loop felt most natural to use and why?**

Answer: For loop, as i have used it the most.

## Time Spent

**Total time:** 1 hour

**Breakdown:**

- Planning the arrays/menu: [10 Minutes]
- Input validation: [10 Minutes]
- Add + print roster features: [10 Minutes]
- Sorting feature: [10 Minutes]
- Testing and debugging: [10 Minutes]
- Writing documentation: [10 Minutes]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: All took roughly the same amount of time.

## Reflection

**What would you do differently next time?**

Answer: I would work on the helper methods first so i better understood them.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: using foreach for the arrays made it much easier to understand the difference between the two and how they each sort through arrays.
