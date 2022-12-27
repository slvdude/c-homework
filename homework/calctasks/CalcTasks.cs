using System;

namespace homework.calctasks
{
	public class CalcTasks
	{
		public CalcTasks()
		{
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
                        IsPrime.CheckPrime();
                        break;
                    }
                case "2":
                    {
                        LeapYear.IsLeapYear();
                        break;
                    }
                case "3":
                    {
                        InsideACircle.IsInsideACircle();
                        break;
                    }
                case "4":
                    {
                        MultiplicationTable.GetMultiplicationTable();
                        break;
                    }
                case "5":
                    {
                        SendSmtp.SendEmail();
                        break;
                    }
                case "6":
                    {
                        SortArray.Sort();
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

