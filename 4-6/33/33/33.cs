using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("n is equal to 0");
            }
            if (n < 0)
            {
                Console.WriteLine("n is a negative number");
            }
            if (n > 0)
            {
                Console.WriteLine("n is a positive number");
            }
        }
    }
}
