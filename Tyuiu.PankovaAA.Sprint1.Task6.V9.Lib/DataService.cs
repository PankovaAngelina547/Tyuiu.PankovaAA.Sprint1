using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PankovaAA.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string? Calculate(string? value)
        {
            if (value is null) return null;
            return Regex.Replace(value, @"\S+",m => MoveLastToStart(m.Value));


        }
        public static string MoveLastToStart(string word)
        {
            if (string.IsNullOrEmpty(word) || word.Length == 1) return word;
        }

    }      
}
