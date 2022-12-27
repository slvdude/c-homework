using System;

namespace homework.calctasks
{
	public class IsPrime
	{
		public IsPrime()
		{
		}


        public static void CheckPrime()
        {
            Console.WriteLine("Enter number");

            int number = Int32.Parse(Console.ReadLine());

            if (Check(number))
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }


        private static bool Check(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
    }
}

