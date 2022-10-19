using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 計算數字階乘(Factorial)
			int sum = 1;
			Console.Write("請輸入乘階:");

			string input = Console.ReadLine();
			bool canBeInt = int.TryParse(input, out int N);
			for (int i = 1; i <= N; i++)
			{
				sum *= i;
			}
			Console.WriteLine($"乘階{N}的值是{sum}");


		}
	}
}
