using System;

namespace Loop
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int answer = 1;
			for (; b > 0; b--)
			{
				answer *= a;
			}
			Console.Write(answer);
		}
	}
}