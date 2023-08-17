using System;
namespace AbstractClasses
{
	public class Cat : Pet
	{
		public Cat()
		{
		}

		public Cat(string name)
		{
			this.PetName = name;
		}

        public override void MakeSound(int times)
        {
			Console.WriteLine(this.PetName + " said...");

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Meowww!!!");
            }
        }

		public virtual void MakeSound()
		{
            Console.WriteLine("Meowww!!!");
        }
    }
}

