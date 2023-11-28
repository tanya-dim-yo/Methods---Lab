namespace _11.Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            double result = MathCalculation(firstNumber, operation, secondNumber);
            Console.WriteLine(result);
        }

        private static double MathCalculation(double a, string @operator, double b)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }

            return result;
        }
    }
}