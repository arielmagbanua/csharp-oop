using System;
namespace AbstractClasses
{
	public abstract class Pet
	{
		private string name;

		// encapsulation
		public string PetName {
			get {
				return this.name;
			}

			protected set {
				this.name = value;
			}
		}

		public virtual void Eat(string food)
		{
			Console.WriteLine(this.name + " eats " + food);
		}

		public void Sleep()
		{
			Console.WriteLine(this.name + " is sleeping");
		}

		public abstract void MakeSound(int times);

		public void SetName(string name)
		{
			this.name = name;
		}
	}
}
