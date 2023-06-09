using System;

namespace Loop
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			while (a <= b)
			{
				if (a % 3 == 0 && a % 5 == 0)
				{
					Console.Write(a + " ");
				}
				a++;
			}
		}
	}
}