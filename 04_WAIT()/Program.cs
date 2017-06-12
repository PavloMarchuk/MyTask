using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_WAIT__
	{
	class Program
		{
		static void MyTask(object args)
			{
			//Thread.CurrentThread.IsBackground = false;
			Console.WriteLine($"MyTask() запущен. ThreadID = {Task.CurrentId}");
			for(int count = 0; count < 80; count++)
				{
				Thread.Sleep(30);
				Console.Write($"{args}");
				}
			Console.Write($"\nMyTask({args}) завершен.");
			}
		static void Main(string[] args)
			{
			Task task1 = new Task(MyTask, ".");
			Task task2 = new Task(MyTask, "-");
			task1.Start();
			task2.Start();

			Task.WaitAll(task1, task2); // = чекає завершення всіх

			//Task.WaitAny(task1, task2); // чекає закінчення першої
			//Task.WhenAny(task1, task2);   //як тільки якась почнеться
			//Task.WhenAll(task1, task2);   // чекає початку всіх
			//task1.Wait();					//визивається для одного единого таска
			Console.Write("\n MAIN завершено.");
			}
		}
	}
