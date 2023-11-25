namespace _09.Greater_Of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();

            if (inputType == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int greaterValue = GetMax(a, b);
                Console.WriteLine(greaterValue);
            }
            else if (inputType == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char greaterValue = GetMax(a, b);
                Console.WriteLine(greaterValue);
            }
            else if (inputType == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string greaterValue = GetMax(a, b);
                Console.WriteLine(greaterValue);
            }
        }

        private static string GetMax(string a, string b)
        {
            int result = a.CompareTo(b);

            if (result > 0)
            {
                return a;
            }

            return b;
        }

        private static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}