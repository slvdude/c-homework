using System;
namespace homework
{
	public abstract class Animal
	{
		public string spicie;
		public int hunger;
		public int health;

		protected Animal(string spicie, int hunger, int health)
		{
			this.hunger = hunger;
            this.spicie = spicie;
            this.health = health;
        }

		public abstract void Say();

        public void Eat()
		{
			if (hunger == 0)
			{
				health++;
				hunger++;
				Console.WriteLine("Eating...");
			}
        }


        public void Fight()
        {

            health--;
            hunger--;
            Console.WriteLine("Ouch...");
        }
    }

	public class Cat : Animal
	{

        public string pogonyalo;

        public Cat(string pogonyalo) : base("Cat", 1, 100)
		{
            this.pogonyalo = pogonyalo;
            Console.WriteLine("this is a" + spicie );
		}

		public override void Say()
		{
			Console.WriteLine("meow");
		}
	}

    public class Dog : Animal
    {
		public string pogonyalo;

        public Dog(string pogonyalo) : base("Dog", 2, 100)
        {
			this.pogonyalo = pogonyalo;
            Console.WriteLine("this is a" + spicie);
        }

        public override void Say()
        {
            Console.WriteLine("bark");
        }
    }
}

