using System;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision program");

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the value of X1: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Y1: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of X2: ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Y2: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("X1:" + X1 + "\n" + "Y1" + Y1);
            Console.WriteLine("X2:" + X2 + "\n" + "Y2" + Y2);
            Console.WriteLine("X1:" + X1 + "\n" + "Y1" + Y1);
            Console.WriteLine("X2:" + X2 + "\n" + "Y2" + Y2);

            double lengthLine1 = Math.Sqrt((X2 - X1) ^ 2 + (Y2 - Y1) ^ 2);
            Console.WriteLine("Lenth of the Line1: " + lengthLine1);

        }
    }
}
