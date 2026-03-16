/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 *
 * What does this Class do?:
 * Flashcard class to store the properties expected from the data file
 * Store: question + answer
 * Methods: intake (parse) - save
 *
 *******************************************************************************/

namespace FlashcardQuiz;

internal class FlashCard
{
    public string Question { get; set; }
    public string Answer { get; set; }

    public FlashCard(string question, string answer)
    {
        Question = question;
        Answer = answer;
    }

    public string ToCSV()
    {
        return $"{Question},{Answer}";
    }

    public static FlashCard Parse(string line)
    {
        string[] parts = line.Split(',', 2);

        return new FlashCard(parts[0].Trim(), parts[1].Trim());
    }
}
