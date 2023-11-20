namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());

            OrderSum(product, productQuantity);
        }

        private static void OrderSum(string product, int productQuantity)
        {
            double orderSum = 0;

            switch (product)
            {
                case "coffee":
                    orderSum = productQuantity * 1.50;
                    break;
                case "water":
                    orderSum = productQuantity * 1.0;
                    break;
                case "coke":
                    orderSum = productQuantity * 1.40;
                    break;
                case "snacks":
                    orderSum = productQuantity * 2.0;
                    break;
            }

            Console.WriteLine($"{orderSum:F2}");
        }
    }
}