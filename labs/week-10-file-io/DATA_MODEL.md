Planning Template

Scenario (1–2 sentences):
Build a Movie Tracker app that loads movies from a CSV file at startup (falling back to seed data if the file doesn't exist), lets the user list, add, update, and delete movies via a menu, and saves the updated list back to the CSV file.

Inputs (with types):

- filePath (string) - hardcoded to "movies.csv"
- choice (int) - menu choice 1-6
- title (string) - new movie title
- year (int) - new movie release year (1888–2030)
- genre (string) - new movie genre
- rating (double) - new movie rating (1.0–5.0)
- director (string) - new movie director
- runtime (int) - new movie runtime in minutes (1–999)
- index (int) - 1-based movie number from user, converted to 0-based for list access
- newRating (double) - replacement rating for update (1.0–5.0)

Calculated values (with formulas):

- movies (List<Movie> from File.ReadAllLines):
    - File.Exists(filePath) → ReadAllLines → split each line on ',' → new Movie(...)
    - OR LoadSeedMovies() if file not found

- csvLines (string[] for writing):
    - movies.Select(m => FormatMovieAsCsv(m)).ToArray()
    - Each line: "Title,Year,Genre,Rating,Director,RuntimeMinutes"

Outputs (what the user sees):

- Program banner
- [INFO] message showing whether file or seed was loaded
- A 6-item menu (loop until Quit)
- Movie display boxes from movie.DisplayInfo()
- [INFO] / [WARN] messages for add, update, delete, and save operations
- [INFO] Updated: {title} — rating now {newRating:0.0}
- [INFO] Deleted: {title}
- Goodbye message on exit

Edge case to consider (1):
The second run finds movies.csv from the first run — the app must correctly parse the saved CSV and restore all Movie objects.
