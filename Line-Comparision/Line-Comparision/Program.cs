using System;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision program");

            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the value of X1: ");   //Taking input values of X and Y
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

            double lengthLine1 = Math.Sqrt((X2 - X1) ^ 2 + (Y2 - Y1) ^ 2);  //calculating length of the line1
            Console.WriteLine("Lenth of the Line1: " + lengthLine1);

            Console.WriteLine("Enter the value of P1: ");
            int P1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Q1: ");
            int Q1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of P2: ");
            int P2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Q2: ");
            int Q2 = Convert.ToInt32(Console.ReadLine());

            double lengthLine2 = Math.Sqrt((P2 - P1) ^ 2 + (Q2 - Q1) ^ 2); //calculating length line2
            Console.WriteLine("Lenth of the Line2: " + lengthLine2);

            double result = lengthLine1.CompareTo(lengthLine2);//comparing two lines using Compareto Method

            if (result == 0)  //checking wheteher both lines are equal or not
            {
                Console.WriteLine("Lines are EQUALS");
            }
            else
            {
                Console.WriteLine("Line are NOT EQUALS");
            }


        }
    }
}
