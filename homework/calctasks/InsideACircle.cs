using System;
namespace homework.calctasks
{
	public class InsideACircle
	{
		public InsideACircle()
		{
		}

        private static bool CheckIfPointIsInsideACircle()
        {
            Console.WriteLine("Enter x coord");

            int x_coord = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y coord");

            int y_coord = Int32.Parse(Console.ReadLine());

            int x_center = 0, y_center = -1, radius = 2;

            if (Math.Pow((x_coord - x_center), 2) - Math.Pow((y_coord - y_center), 2) <= Math.Pow(radius, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void IsInsideACircle()
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
    }
}

