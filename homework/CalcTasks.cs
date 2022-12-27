using System;
namespace homework
{
	public class CalcTasks
	{
		public CalcTasks()
		{
		}

        public void IsPrime()
        {
            Console.WriteLine("Enter number");

            int number = Int32.Parse(Console.ReadLine());

            CalcTasks calcTasks = new CalcTasks();

            if (calcTasks.CalcIsPrime(number))
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }


        private bool CalcIsPrime(int number)
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

        private bool CheckLeapYear(int year)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "out of range");
            }
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        public void IsLeapYear()
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

        private bool CheckIfPointIsInsideACircle()
        {
            Console.WriteLine("Enter x coord");

            int x_coord = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y coord");

            int y_coord = Int32.Parse(Console.ReadLine());

            int x_center = 0, y_center = -1, radius = 2;

            if (Math.Pow((x_coord - x_center), 2) - Math.Pow((y_coord - y_center), 2) <= Math.Pow(radius, 2)) {
                return true;
            } else
            {
                return false;
            }
        }

        public void IsInsideACircle()
        {
            bool check = CheckIfPointIsInsideACircle();

            if (check)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public void MultiplicationTable()
        {
            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                }
                Console.Write("\n");
            }
        }

        public static void Start()
        {
            Console.WriteLine("Choose a task");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Prime number check");
            Console.WriteLine("2 - Leap year check");
            Console.WriteLine("3 - Is point inside a circle check");
            Console.WriteLine("4 - Multiplication table");

            string value = Console.ReadLine();

            CalcTasks calcTasks = new CalcTasks();

            switch (value)
            {
                case "1":
                    {
                        calcTasks.IsPrime();
                        break;
                    }
                case "2":
                    {
                        calcTasks.IsLeapYear();
                        break;
                    }
                case "3":
                    {
                        calcTasks.IsInsideACircle();
                        break;
                    }
                case "4":
                    {
                        calcTasks.MultiplicationTable();
                        break;
                    }
                case "0":
                    {
                        return;
                    }
            }
        }
    }
}

