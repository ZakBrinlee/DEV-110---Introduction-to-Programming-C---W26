Planning Template

Scenario (1–2 sentences):
Build a menu-driven Study Group Sign-Up program that stores up to 3 students in parallel arrays (name + section number), can print the roster, and can print a sorted roster.

Inputs (with types):

- choice (int)
- howManyToAdd (int)
- studentName (string)
- sectionNumber (int)
- sortChoice (int)

Calculated values (with formulas):

- rosterCapacity (int): 3
- rosterNames (string[]): length = rosterCapacity
- rosterSectionNumbers (int[]): length = rosterCapacity
- count (int): number of used slots in the arrays
- remainingSlots (int): rosterCapacity - count
- sortedNames (string[]): copy of the used names (length = count)
- sortedSectionNumbers (int[]): copy of the used section numbers (length = count)
- rosterLines (string[]): lines to print (length = count)

Outputs (what the user sees):

- Menu options (add multiple, print roster, print sorted roster, exit)
- Empty roster message when count == 0
- Full roster message when count == rosterCapacity
- Roster lines showing name + section number
- Sorted roster output

Edge case to consider (1):
User tries to add students when the roster is already full, or tries to print/sort when the roster is empty.
