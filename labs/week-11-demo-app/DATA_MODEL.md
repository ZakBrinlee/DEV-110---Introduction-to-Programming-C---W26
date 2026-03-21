# Flashcard Quiz App — Data Model

## Scenario (1–2 sentences)

Build a Flashcard Quiz console app that loads flashcards from a CSV file, lets the user
add new cards, view all cards, take a timed quiz, and save their deck back to disk.
A student (or anyone learning something new) might use this app to study for a test.

---

## Class Structure

### `Flashcard` Class

**Properties (with types):**

- `Question` (string) — the prompt shown during a quiz
- `Answer` (string) — the expected correct answer

**Constructor Parameters:**

- `question` (string)
- `answer` (string)

**Methods:**

- `ToCSV()` → string — returns `"question,answer"` as a single CSV line
- `static Parse(string line)` → Flashcard — splits a CSV line into a Flashcard object

---

## Inputs (with types)

_Values the program collects from the user or reads from a file._

- `question` (string) — the text of a flashcard question entered by the user
- `answer` (string) — the expected answer entered by the user
- `menuChoice` (string) — the user's numbered menu selection (1–5)
- `userAnswer` (string) — the user's typed answer during a quiz
- `filePath` (string) — the path to `flashcards.csv` on disk
- `line` (string) — a single raw CSV line read from the file during load
- `cards` (List\<Flashcard\>) — the in-memory list of all flashcards

---

## Calculated or Derived Values

_Values computed from inputs._

- `correct` (int) — count of quiz answers that match (case-insensitive comparison)
    - Incremented by 1 each time `userAnswer.Trim().ToLower() == card.Answer.Trim().ToLower()`
- `total` (int) — total number of cards in the quiz (`cards.Count`)
- `percent` (double) — score as a percentage
    - Formula: `(double)correct / total * 100`
    - Displayed as: `{percent:F0}%` (rounded to nearest whole number)

---

## Outputs (what the user sees)

- **Card table** (`ViewAllCards`): numbered rows with `Question` (padded to 42 chars) and `Answer` (padded to 22 chars), followed by a total count
- **Quiz prompts**: `"Card X of Y: Q: ..."` followed by `"Your answer: "`
- **Per-answer feedback**: `"Correct! ✓"` or `"Incorrect. The answer was: [answer]"`
- **Quiz summary**: `"You got X / Y correct (ZZ%)"` followed by a motivational message
- **Save confirmation**: `"Saved X card(s) to flashcards.csv."`
- **Load message**: `"Loaded X flashcards from flashcards.csv."` (or seed fallback message)

---

## Edge Case to Consider

**Commas inside an answer field** — if an answer contains a comma (e.g., `"int, double, string"`),
a naive `Split(',')` would break it into more than 2 parts and corrupt the data.

**Solution:** Use `Split(',', 2)` — the second argument limits the split to exactly 2 parts,
so only the first comma is used as the delimiter. Everything after it stays intact as the answer.
