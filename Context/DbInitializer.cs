using System;
using System.Collections.Generic;
using System.Text;

namespace Context
{
    public class DbInitializer
    {
		public static void Initialize(ApplicationContext context)
		{
			context.Database.EnsureCreated();

		
		}
	}
}
