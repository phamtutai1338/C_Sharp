using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In 15 years, age of " + name + " will be " + (age + 15));
        }
    }
}