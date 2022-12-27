using System;
namespace homework
{
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

