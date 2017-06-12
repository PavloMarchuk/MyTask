using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_TaskId
	{
	class Program
		{
		static void MyTask()
			{
			//Thread.CurrentThread.IsBackground = false;
			Console.WriteLine($"MyTask() запущен. ThreadID = {Task.CurrentId}");
			for(int count = 0; count < 10; count++)
				{
				Thread.Sleep(500);
				Console.WriteLine($"В методе MyTask({Task.CurrentId}), счетчик равен: {count}"  );
				}
			Console.WriteLine("MyTask() завершен.");
			}
		static void Main(string[] args)
			{			
			Console.WriteLine($"Thread main - CurrentID = {Task.CurrentId}");
			

			Task task1 = new Task(MyTask);			
			Task task2 = new Task(MyTask);
			task1.Start();
			task2.Start();

			Console.WriteLine($"task1 ID={task1.Id}");
			Console.WriteLine($"task2 ID={task2.Id}");

			Console.ReadKey();
			}
		}
	}
