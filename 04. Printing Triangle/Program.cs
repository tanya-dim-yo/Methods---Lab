namespace _04.Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            PrintingTriangle(rows);
        }

        private static void PrintingTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            { 
                PrintingLine(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintingLine(1, i);
            }
        }

        private static void PrintingLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}