using System;
namespace inh
{
	 class Class2 : test1
	{
		public void test3()
		{
			Console.WriteLine("in my class");

		}

			static void Main(String[] args)
			{

				Class2 c = new Class2();

				c.tests1();
				c.tests2();
				Console.ReadLine();

			}
		
		}
	}


