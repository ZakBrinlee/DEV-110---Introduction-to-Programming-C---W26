```markdown
Planning Template

Scenario (1–2 sentences):
Build a Movie Tracker reports app that uses a pre-seeded list of movies and LINQ to generate sorted lists and summary statistics.

Inputs (with types):

- choice (int) - menu choice (1-5)
- genre (string) - user-entered genre for the genre report

Calculated values (with formulas):

- sortedByTitle (movies ordered by title):
    - movies.OrderBy(m => m.Title)
- topRated (top 3 movies):
    - movies.OrderByDescending(m => m.Rating).Take(3)
- matches (movies in a genre):
    - movies.Where(m => m.Genre equals genre, case-insensitive)
    - then OrderByDescending(m => m.Rating)
- minRating / maxRating / averageRating:
    - Min(m => m.Rating)
    - Max(m => m.Rating)
    - Average(m => m.Rating)
- minRuntime / maxRuntime / averageRuntime:
    - Min(m => m.RuntimeMinutes)
    - Max(m => m.RuntimeMinutes)
    - Average(m => m.RuntimeMinutes)

Outputs (what the user sees):

- Program banner
- A menu with 5 choices
- A list of movies (formatted boxes) for list/top/genre reports
- Overall stats printed as lines (min/max/avg)
- A warning if a genre has no matches

Edge case to consider (1):
User enters a genre that doesn’t exist in the movie list.
```
