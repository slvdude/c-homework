using System;
using static System.Net.Mime.MediaTypeNames;
using homework.tictactoe;
using homework.phonebook;
using homework.calctasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - TicTacToe");
            Console.WriteLine("2 - Phonebook");
            Console.WriteLine("3 - Calculation tasks");
            Console.WriteLine("4 - Send email");

            string value = Console.ReadLine();

            switch(value)
            {
                case "1":
                    {
                        TicTacToe.Start();
                        break;
                    }
                case "2":
                    {
                        Phonebook.Start();
                        break;
                    }
                case "3":
                    {
                        CalcTasks.Start();
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

