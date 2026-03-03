# Movie Tracker - Data Model Planning Template

## Scenario (1-2 sentences)

Build a Movie Tracker program that demonstrates creating custom classes in separate files. Students will create Movie objects with properties, display formatted information, convert ratings to star displays, and update ratings with validation.

## Class Structure

### Movie Class

**Properties (with types):**

- Title (string)
- Year (int)
- Genre (string)
- Rating (double) - scale from 0.0 to 5.0
- Director (string)

**Constructor Parameters:**

- title (string)
- year (int)
- genre (string)
- rating (double)
- director (string)

**Public Methods:**

- DisplayInfo() - void, displays formatted movie information
- UpdateRating(double newRating) - void, updates rating with validation

**Private Methods:**

- GetStarDisplay() - string, converts numeric rating to star display (★★★★☆)

## Inputs (from code, not user)

### Movie 1:

- title: "The Shawshank Redemption"
- year: 1994
- genre: "Drama"
- rating: 4.8
- director: "Frank Darabont"

### Movie 2:

- title: "Inception"
- year: 2010
- genre: "Sci-Fi"
- rating: 4.3
- director: "Christopher Nolan"

### Movie 3:

- title: "Spirited Away"
- year: 2001
- genre: "Animation"
- rating: 4.7
- director: "Hayao Miyazaki"

### Rating Updates:

- movie1.UpdateRating(5.0) - valid
- movie2.UpdateRating(6.5) - invalid (out of range)

## Calculated Values (with formulas)

### In GetStarDisplay():

- filledStars (int) = (int)Math.Round(Rating)
    - Example: Rating = 4.8 → filledStars = 5
    - Example: Rating = 4.3 → filledStars = 4
- emptyStars (int) = 5 - filledStars
    - Example: filledStars = 5 → emptyStars = 0
    - Example: filledStars = 4 → emptyStars = 1
- stars (string) = new string('★', filledStars) + new string('☆', emptyStars)
    - Example: filledStars = 4, emptyStars = 1 → "★★★★☆"

### In UpdateRating():

- oldRating (double) = current Rating value before update
- Validation: newRating must be >= 0.0 AND <= 5.0

## Outputs (what the user sees)

### Movie Display (from DisplayInfo):

```
╔════════════════════════════════════════╗
  📽️  {Title} ({Year})
  🎬 Director: {Director}
  🎭 Genre: {Genre}
  ⭐ Rating: {stars} ({Rating}/5.0)
╚════════════════════════════════════════╝
```

### Logger Messages:

- Info (yellow): "Creating first movie...", "Displaying movie 1 details:", "Updating movie 1 rating...", etc.
- Info (yellow): "Rating updated from {oldRating:0.0} to {Rating:0.0}"
- Warn (red): "Rating must be between 0.0 and 5.0!" (for invalid updates)

### Final Summary:

```
╔════════════════════════════════════════╗
  ✅ Lab Complete!
  📊 Total movies created: 3
╚════════════════════════════════════════╝
```

## Flow

1. Display program title
2. Create movie1 with Logger.Info
3. Display movie1.DisplayInfo()
4. Update movie1 rating to 5.0 (valid)
5. Display movie1 again (shows updated rating)
6. Create movie2 with Logger.Info
7. Display movie2.DisplayInfo()
8. Attempt to update movie2 rating to 6.5 (invalid - triggers warning)
9. Create movie3 with Logger.Info
10. Display movie3.DisplayInfo()
11. Print summary box

## Concepts Demonstrated

1. **Classes and Objects**
    - Movie is the class (blueprint)
    - movie1, movie2, movie3 are objects (instances)

2. **Properties**
    - Auto-properties with { get; set; }
    - Public access for external use

3. **Constructors**
    - Initialize objects with the `new` keyword
    - Named parameters for clarity

4. **Public Methods**
    - DisplayInfo() - accessible from Program.cs
    - UpdateRating() - accessible from Program.cs

5. **Private Methods**
    - GetStarDisplay() - only accessible within Movie class
    - Helper method for internal logic

6. **Static Classes**
    - Logger doesn't need to be instantiated
    - Called directly: Logger.Info(), Logger.Warn()

7. **Validation**
    - UpdateRating checks if newRating is in valid range
    - Early return if invalid

8. **Debugging**
    - Breakpoints pause execution
    - F10 steps through code line by line
    - Variables panel shows object state
    - Watch expressions evaluate custom code
    - Conditional breakpoints pause only when conditions are met

## Edge Cases to Consider

1. **Invalid Rating Range**
    - Rating < 0.0 should be rejected with warning
    - Rating > 5.0 should be rejected with warning
    - UpdateRating should NOT change the rating if invalid

2. **Private Method Access**
    - Attempting to call movie1.GetStarDisplay() from Program.cs should fail
    - Students will see that private methods don't appear in IntelliSense

3. **Object Independence**
    - Changing movie1's rating should NOT affect movie2 or movie3
    - Each object has its own copy of the properties

## Debugging Checkpoints

### Checkpoint 1: DisplayInfo()

- Set breakpoint on first Console.WriteLine in DisplayInfo()
- Inspect `this` in Variables panel to see all properties
- Step through (F10) to watch output appear
- Add Watch: Title.ToUpper() to see evaluated expression

### Checkpoint 2: UpdateRating()

- Set breakpoint at start of UpdateRating()
- Add Watches: newRating, oldRating, Rating
- Step through (F10) to see values change
- Observe validation logic with invalid rating (6.5)
- See early return when validation fails
