using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_TASK_Factorio
	{
	class Program
		{
		static void MyTask()
			{
			Thread.CurrentThread.IsBackground = false;
			Console.WriteLine("MyTask() запущен.");
			for(int count = 0; count < 5; count++)
				{
				Thread.Sleep(200);
				Console.WriteLine("В методе MyTask(), счетчик равен: " + count);
				}

			Console.WriteLine("MyTask() завершен.");
			}
		static int SumInt(object v)
			{
			int x = (int)v, sum = 0;

			for(; x > 0; x--)
				{
				sum += x;
				}

			Thread.Sleep(200);
			return sum;
			}
		static void Main(string[] args)
			{
			Task task = Task.Factory.StartNew(MyTask);
			task.Wait();

			Task<int> task_int = Task.Factory.StartNew<int>(SumInt, 100);
			task_int.Wait();
			Console.WriteLine(task_int.Result);
			}
		}
	}
