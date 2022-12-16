using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("0 - 1 TicTacToe");

            string value = Console.ReadLine();

            switch(value)
            {
                case "1":
                    {
                        TicTacToe.Start();
                        return;
                    }
                case "0":
                    {
                        return;
                    }
            }
        }
    }
}

