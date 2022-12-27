using System;
namespace homework
{
    public class Cat : Animal
    {

        public string pogonyalo;

        public Cat(string pogonyalo) : base("Cat", 1, 100)
        {
            this.pogonyalo = pogonyalo;
            Console.WriteLine("this is a" + spicie);
        }

        public override void Say()
        {
            Console.WriteLine("meow");
        }
    }
}

