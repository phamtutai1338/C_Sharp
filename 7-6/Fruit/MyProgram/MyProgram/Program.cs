using System;

namespace MyProgram {

    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;
            Console.WriteLine("Nhap vao 1 so: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Tong cac so: " + sum);
            Console.ReadLine();
        }
    }
}


