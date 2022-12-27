using System;
namespace homework.calctasks
{
	public class MultiplicationTable
	{
		public MultiplicationTable()
		{
		}


        public static void GetMultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                }
                Console.Write("\n");
            }
        }
    }
}

