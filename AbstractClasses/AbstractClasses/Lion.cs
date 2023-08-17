using System;
namespace AbstractClasses
{
	public class Lion : Cat
	{
		public Lion()
		{

		}

		public Lion(string name) : base(name)
		{

		}

        public override void Eat(string food)
        {
			base.Eat(food);
			// Console.WriteLine(this.PetName + " devours " + food);
        }

        public override void MakeSound()
        {
			Console.WriteLine(this.PetName + " roar!!!");
        }
    }
}

