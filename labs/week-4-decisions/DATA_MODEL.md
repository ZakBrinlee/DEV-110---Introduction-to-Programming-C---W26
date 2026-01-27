Planning Template

Scenario (1–2 sentences):
Create a Logic Lounge program that asks the user about age, snack size, membership, and activity choices, then uses decisions to determine prices and membership level.

Inputs (with types):

- userName (string)
- age (int)
- snackChoice (string)
- memberInput (string) → isMember (bool)
- activityChoice (int)

Calculated values (with formulas):

- snackPrice (double):
    - "S" → 3.50, "L" → 5.00, otherwise 0.0
- membershipLevel (string):
    - if isMember and age >= 18 → "Gold"
    - if isMember and age < 18 → "Junior"
    - if not isMember → "None"
- activityName (string) + activityCost (double):
    - 1 → Movie, 12.00
    - 2 → Arcade, 8.00
    - 3 → Study Lounge, 4.00
    - 4 → goto case 2 (Arcade), 8.00
    - default → Unknown, 0.0
- total (double): snackPrice + activityCost (only if both > 0)

Outputs (what the user sees):

- Welcome banner
- Prompts for name, age, snack size, membership, activity
- Optional warnings for invalid snack/activity choices
- Summary of name, age, snack price, membership status/level, activity, activity cost
- Total cost when both selections are valid

Edge case to consider (1):
User enters a snack size or activity number that isn’t listed (invalid input).
