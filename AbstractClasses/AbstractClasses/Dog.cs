using System;
namespace AbstractClasses
{
	public class Dog : Pet
	{
		public Dog()
		{
		}

		public Dog(string name)
		{
			this.PetName = name;
		}

        public override void MakeSound(int times)
        {
            Console.WriteLine(this.PetName + " said...");

            for (int i = 0; i < times; i++) {
				Console.WriteLine("Arfff!!!");
			}
        }
    }
}

