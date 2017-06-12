using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_TASK_First
	{
	class Program
		{	
			static void MyTask()
			{
			Thread.CurrentThread.IsBackground = false;
			Console.WriteLine("MyTask() запущен.");			
			for(int count = 0; count < 20; count++)
				{
				Thread.Sleep(500);
				Console.WriteLine("В методе MyTask(), счетчик равен: " + count);
				}

			Console.WriteLine("MyTask() завершен.");
			}
		static void Main(string[] args)
			{
			Task task = new Task(MyTask);
			task.Start();
			Thread.Sleep(10);
			//Thread.Sleep(2000);
			Console.WriteLine("Main thread END!");
			}
		}
	}
