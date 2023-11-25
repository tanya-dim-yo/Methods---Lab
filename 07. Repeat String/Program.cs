using System.Text;

namespace _07.Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            int timesToRepeatString = int.Parse(Console.ReadLine());
            string repeatedString = RepeatString(myString, timesToRepeatString);
            Console.WriteLine(repeatedString);
        }

        private static string RepeatString(string myString, int timesToRepeatString)
        {
            StringBuilder repeatedString = new StringBuilder();
            for (int i = 0; i < timesToRepeatString; i++)
            {
                repeatedString.Append(myString);
            }
            return repeatedString.ToString();
        }
    }
}