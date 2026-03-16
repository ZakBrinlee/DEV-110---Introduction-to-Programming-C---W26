/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 *
 * What does this program do?:
 * Loads flashcards from a CSV File, then runs a menu-driven
 * app where the user can add, view, quiz, and save.
 *
 *******************************************************************************/

namespace FlashcardQuiz;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== FlashCard Quiz App ===\n");

        string filePath = "flashcards.csv";
        List<FlashCard> cards = new List<FlashCard>();

        // Guard Clause for file existance
        if (File.Exists(filePath))
        {
            cards = LoadCards(filePath);
            Console.WriteLine($"Loaded {cards.Count} flashcard(s) from {filePath}");
        }
        else
        {
            Console.WriteLine($"No {filePath} found.");
        }

        bool running = true;
        while (running)
        {
            PrintMenu();

            string input = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (input.Trim())
            {
                case "1":
                    ViewAllCards(cards);
                    break;
                case "2":
                    AddCard(cards);
                    break;
                case "3":
                    // RunQuiz(cards);
                    break;
                case "4":
                    // SaveCards(filePath, cards);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter 1-5.");
                    break;
            }
        }

        Console.WriteLine("\nGoodbye!");
    }

    private static void PrintMenu()
    {
        Console.WriteLine("--- Menu ---");
        Console.WriteLine("1. View all cards");
        Console.WriteLine("2. Add a card");
        Console.WriteLine("3. Take a quiz");
        Console.WriteLine("4. Save cards");
        Console.WriteLine("5. Quit");
        Console.Write("Choose an option (1-5): ");
    }

    private static List<FlashCard> LoadCards(string filePath)
    {
        List<FlashCard> cards = new List<FlashCard>();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                cards.Add(FlashCard.Parse(line));
            }
        }
        return cards;
    }

    private static void AddCard(List<FlashCard> cards)
    {
        Console.WriteLine("\n--- Add a New Card ---");

        string question = ReadNonEmptyString("Question: ");
        string answer = ReadNonEmptyString("Answer: ");

        cards.Add(new FlashCard(question, answer));
        Console.WriteLine($"Card added! You now have {cards.Count} card(s).");

    }
    private static void ViewAllCards(List<FlashCard> cards)
    {
        if (cards.Count == 0)
        {
            Console.WriteLine("No cards to display. Add some to the file!");
            return;
        }

        Console.WriteLine("\n--- All Flashcards ---");
        Console.WriteLine($"{"#",-4}{"Question",-52}{"Answer",-32}");
        Console.WriteLine(new string('-', 68));

        for (int i = 0; i < cards.Count; i++)
        {
            Console.WriteLine($"{i + 1,-4}{cards[i].Question,-52}{cards[i].Answer,-32}");
        }

        Console.WriteLine($"\nTotal: {cards.Count} card(s)");
    }
    private static void RunQuiz(List<FlashCard> cards) { }
    private static void SaveCards(string filePath, List<FlashCard> cards) { }

    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
        }
    }
}
