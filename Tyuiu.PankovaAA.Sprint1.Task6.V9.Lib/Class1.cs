using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PankovaAA.Sprint1.Task6.V9.Lib;

public class DataService : ISprint1Task6V9
{
    public string MoveLetterToStart(string value)
    {
        string input = value;

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string[] transformedWords = words.Select(word =>
        {
            if (word.Length <= 1)
                return word;

            char lastChar = word[word.Length - 1];
            string restOfWord = word.Substring(0, word.Length - 1);
            return lastChar + restOfWord;
        }).ToArray();

        string result = string.Join(" ", transformedWords);

        return result;
    }
}
