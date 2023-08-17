using System;
namespace Ineritance
{
	public class Person
	{
		protected string fullname;
		private int age;

		public Person()
		{

		}

		public Person(string fullname, int age)
		{
			this.fullname = fullname;
			this.age = age;
		}

		public void SetInfo(string fullname, int age)
		{
			this.fullname = fullname;
			this.age = age;
		}

		public virtual void Talk()
		{
			Console.WriteLine(this.fullname + " is talking");
		}
	}
}

