using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareInt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 主旨: [作業___] - 座號 姓名

			// 計算 1 + (2 + 2) * 3 - 1
			int number1 = 1 + (2 + 2) * 3 - 1;
			Console.WriteLine(number1);

			// 求 120 / 7 的商以及餘數各是多少
			int number2 = 120;
			Console.WriteLine("120的商數為 " + number2 / 7);
			Console.WriteLine("120的餘數為 " + number2 % 7);

			// 判斷 9, 202 個別是奇數或是偶數
			int[] list = new int[] { 9, 202 };
			int n = 0;
			int len = list.Length;
			for (n = 0; n <= len - 1; n++)
			{
				if (list[n] % 2 == 0)
				{
					Console.WriteLine(list[n] + "為偶數");
				}
				else
				{
					Console.WriteLine(list[n] + "為奇數");
				}
			}

			// 根據兩個變數大小, 視需要對調兩個變數的值
			Console.Write("數字1 : ");
			string num1 = Console.ReadLine();
			int n1 = Convert.ToInt32(num1);
			Console.Write("數字2 : ");
			String num2 = Console.ReadLine();
			int n2 = Convert.ToInt32(num2);
			if (n1 > n2)
			{
				Console.WriteLine(num2 + " , " + num1);
			}
			else
			{
				Console.WriteLine(num1 + " , " + num2);
			}
		}
	}
}
