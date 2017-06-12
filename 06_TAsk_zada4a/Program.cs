using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_TAsk_zada4a
	{
	class Program
		{
		static bool MyTask()
			{
			Thread.Sleep(500);
			return true;
			}
		//метод поверта суму
		static int SumInt(object v)
			{
			int x = (int)v, sum = 0;

			for(; x>0; x--)
				{
				sum += x;
				}

			Thread.Sleep(300);
			return sum;
			}

		static void Main(string[] args)
			{
			Task<bool> task1 = new Task<bool>(MyTask);
			task1.Start();
			Console.WriteLine($"Результат = {task1.Result}"); //основний потік зачекає до закінчення вторинного без жодних вайтів. ВАУ!
			
			Task<int> task_int = new Task<int>(SumInt, 1000);
			task_int.Start();
			
			Console.WriteLine($"Результат = {task_int.Result}");

			
			}
		}
	}
