using System;

namespace Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];

			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (arr[i] > arr[j])
					{
						// Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
						int temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}

			for (int i = 0; i < n; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}