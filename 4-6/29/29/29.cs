using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine("Circumference = " + (2 * pi * r));
        }
    }
}
