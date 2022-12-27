using System;
namespace homework.calctasks
{
	public class LeapYear
	{
		public LeapYear()
		{
		}


        private static bool CheckLeapYear(int year)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "out of range");
            }
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        public static void IsLeapYear()
        {
            Console.WriteLine("Enter year");

            int year = Int32.Parse(Console.ReadLine());

            bool isLeap = CheckLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

