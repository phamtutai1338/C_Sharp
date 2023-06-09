using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = (char)(char.Parse(Console.ReadLine()) + 1);
            Console.WriteLine(c);
        }
    }
}
