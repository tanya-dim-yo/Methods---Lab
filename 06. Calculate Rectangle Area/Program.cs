﻿namespace _06.Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = RectangleArea(width, height);
            Console.WriteLine(area);
        }

        private static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}