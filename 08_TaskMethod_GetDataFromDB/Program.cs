using _08_TaskMethod_GetDataFromDB.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_TaskMethod_GetDataFromDB
	{
	class Program
		{
		static IEnumerable<BusinessEmployee> Get(HrContext context)
			{
			var collection = context.Database.SqlQuery<BusinessEmployee>("EXEC GetEmployee  '01.01.2013'");
			return collection;
			}
		static void Main(string[] args)
			{
			HrContext context = new HrContext();

			var collection = Get(context);
			foreach(var item in collection)
				{
				Console.WriteLine(item.FULLNAME);
				}
			}
		}
	}
