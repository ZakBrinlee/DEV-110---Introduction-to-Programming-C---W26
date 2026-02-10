Planning Template

Scenario (1–2 sentences):
Build a Cozy Cafe Sign Maker program that prints a banner, displays a menu, and uses string tools to format signage and menu lines.

Inputs (with types):

- choice (int)
- shopName (string)
- tagline (string)
- itemName (string)
- price (double)
- calories (int)
- quote (string)
- favoriteName (string)

Calculated values (with formulas):

- divider (string): new string('=', 40)
- trimmedShopName (string): shopName.Trim()
- upperShopName (string): trimmedShopName.ToUpper()
- matchesFavorite (bool): trimmedShopName.Equals(favoriteName, StringComparison.OrdinalIgnoreCase)
- trimmedQuote (string): quote.Trim()
- spaced (string): string.Join(" ", trimmedQuote.ToUpper().ToCharArray())
- length (int): trimmedQuote.Length
- preview (string): trimmedQuote.Substring(0, 5) when length >= 5
- containsCafe (bool): trimmedQuote.ToLower().Contains("cafe")
- endsWithPunctuation (bool): trimmedQuote.EndsWith("!") or trimmedQuote.EndsWith(".")
- firstSpaceIndex (int): trimmedQuote.IndexOf(' ')
- menuLine (string): formatted line using composite alignment

Outputs (what the user sees):

- Title banner with divider and subtitle
- Boxed menu with options
- Welcome sign box with uppercase name
- Welcome sign box with uppercase name
- Menu line with item, calories, and price aligned
- Quote styles (uppercase and spaced letters)
- Quote analysis (length, preview, contains, ends-with, index)
- Exit message

Edge case to consider (1):
User enters invalid or non-numeric input for the menu, calories, or price.
