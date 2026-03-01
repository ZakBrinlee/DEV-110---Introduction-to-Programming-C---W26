# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Ujwal Garine

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer:
Parallel arrays are two or more arrays that store related data at the same index. In this assignment, rosterNames and rosterCredits were parallel arrays. The student’s name at index 0 matched the credits at index 0, and so on. Keeping the indexes aligned ensured each student’s data stayed connected.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer:
The count variable tracks how many roster slots are currently in use. Even though the arrays have a fixed capacity, not all slots are filled at the start. count helps us know how many students have actually been added.

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer:
I used count in loops when printing and copying data. Instead of looping through the entire array length, I looped from 0 to count - 1. This prevents accessing empty array slots and ensures we only work with real student data.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer:
I first built a new string[] using the BuildRosterLines method. Each element combined a student’s name and credits into one formatted line. Then I used a foreach loop to print each line cleanly without worrying about indexes.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer:
I copied only the used portion of the roster into new arrays using CopyUsedRoster. Then I used Array.Sort with parallel arrays. This allowed the names and credits to stay aligned while sorting by either name or credits.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How parallel arrays work and why index alignment matters.

2. Why tracking “used” elements with a count variable is important.

3. The difference between for and foreach loops.

4. How to sort two related arrays together using Array.Sort.

5. How copying data before sorting protects the original order.

**Which loop felt most natural to use and why?**

Answer:

The for loop felt most natural because it gives full control over the index. Since this assignment relied heavily on index alignment between arrays, for made more sense when copying and modifying data.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Planning the arrays/menu: [0.5 hours]
- Input validation: [0.5 hours]
- Add + print roster features: [1 hours]
- Sorting feature: [0.25 hours]
- Testing and debugging: [0.25 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
Input validation took the longest because I had to carefully handle invalid input and prevent the program from crashing.

## Reflection

**What would you do differently next time?**

Answer:
Next time, I would probably use a Student class instead of parallel arrays. That would make the code cleaner and easier to manage, especially if more fields were added later.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer:
Using both loops helped me understand when indexes matter and when they don’t. for showed me how arrays are structured internally, while foreach made it clear how to safely read through collections without modifying them.dotnet test ../tests
