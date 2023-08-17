using System;
namespace Ineritance
{
	public class Teacher : Person
	{
		private string department;
		private double salary;

		public Teacher(string name, string dept): base(name, 23)
		{
			this.fullname = name;
			this.department = dept;
		}

		public void TeachClass()
		{
			Console.WriteLine(this.fullname + " is teaching!!!");
		}

		public void SetSalary(double salary)
		{
			this.salary = salary;
		}

        public override void Talk()
        {
            base.Talk();

			Console.WriteLine("Done Talking!!!");
        }
    }
}

