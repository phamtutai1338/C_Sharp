using System;

namespace Loop
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int i = 1;
			int answer = 0;
			while (i <= n)
			{
				if (n % i == 0)
				{
					answer++;
				}
				i++;
			}
			Console.Write(answer);
		}
	}
}