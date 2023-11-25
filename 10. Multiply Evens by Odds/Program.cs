namespace _10.Multiply_Evens_By_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int sumEven = GetSum(inputNumber, true);
            int sumOdd = GetSum(inputNumber, false);
            int result = sumEven * sumOdd;
            Console.WriteLine(result);
        }

        private static int GetSum(string numbers, bool isEven)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 48 && numbers[i] <= 57)
                {
                    int currentNumber = int.Parse(numbers[i].ToString());

                    if (currentNumber % 2 == 0 && isEven)
                    {
                        sum += currentNumber;
                    }
                    else if (currentNumber % 2 != 0 && !isEven)
                    {
                        sum += currentNumber;
                    }
                }
            }

            return sum;
        }
    }
}