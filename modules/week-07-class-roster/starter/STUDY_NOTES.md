# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Cleciane Oliveira Silva

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: Parallel arrays are two or more arrays using the same index and storaging related information, keeping data connected since they use the same index. I used rosterNames, rosterCredits, both storaging the same value for the credits.

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: The count starts at zero because that's when there's no student/credit to input. The count variable storages the number of students and their credits, and in this case goes up to 3. 

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: i used it while printing, copying and building the roster line, with a range of 0 to count -1 instead of looping the entire lenght of the array, because if the program used the full lenght of the array, it could lead to incorrect outputs since it would try to read empty or unused slots.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: first, using the buildrosterlines method i created an array of formatted roster lines, using a for loop so it can go through the students from 0 to count -1, thus building a string so the students names and credits can be included.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: i first copied only the used portion of the roster into the new arrays using copyusedroster method, then i used array.sort for the parallel arrays, sorting them by name and array,sort(sortedcredits, sortednames) to sort them by credits while also ordering them by name.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. use of parallel arrays
2. different types of loop applied together
3. nesting loops
4. sorting arrays
5. how to set a 'count' variable for starting values

**Which loop felt most natural to use and why?**

Answer: foreach loop. it just makes more sense to me for some reason.

## Time Spent

**Total time:** [8 hours]

**Breakdown:**

- Planning the arrays/menu: [2 hours]
- Input validation: [1 hours]
- Add + print roster features: [1 hours]
- Sorting feature: [2 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Planning arrays and menu, because the logic process, mapping where and how info are being added takes a lot o energy and seems more complicated. after figurig out how to do, the actual doing part can be easier.

## Reflection

**What would you do differently next time?**

Answer: i would try to be more practical for the logic/planning part, because sometimes i feel like i overcomplicate and my logic gets confusing.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: for works with a range, which i consider tricky sometimes, while foreach works on the loop itself in a more practical and neat way. using both of them for the same assignment clearily gave more insights about how distinct they are and how much they can do while working with arrays, especially for sorting and displaying info.
