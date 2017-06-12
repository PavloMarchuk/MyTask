using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_StatusTask
	{
	class Program
		{
		static void Test()
			{
			Thread.Sleep(2000);
			}
		static void Main(string[] args)
			{
			Task task = new Task(Test);
			Console.WriteLine($"1.Create - Status={task.Status}");
			task.Start();
			
			Console.WriteLine($"1.Create - Status={task.Status}");
			Thread.Sleep(1000);
			Console.WriteLine($"1.Create - Status={task.Status}");
			Thread.Sleep(2000);
			Console.WriteLine($"1.Create - Status={task.Status}");


			Console.WriteLine("MAin END!");
			Console.ReadKey();
			}
		}
	}
