﻿using System;
using System.Collections.Generic;
using System.IO;

namespace homework
{
    class Abonent
    {
        public string name;
        public string phonenumber;

        public Abonent(string _name, string _phonenumber)
        {
            name = _name;
            phonenumber = _phonenumber;

        }
    }

    class Phonebook
    {
        public List<Abonent> abonents;

        public Phonebook()
        {
            abonents = new List<Abonent>();

            try
            {
                foreach(string elem in File.ReadAllText("./abonents.txt").Split(Environment.NewLine))
                {
                    string[] data = elem.Split("-");

                    if (data.Length == 2)
                    {
                        abonents.Add(new Abonent(data[0], data[1]));
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        #nullable enable
        private Abonent? Get(string arg)
        {
            return abonents.Find(abonent => abonent.name == arg || abonent.phonenumber == arg);

        }

        public void AddAbonent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string number = Console.ReadLine();

            if (abonents.Exists(abonent => abonent.name == name || abonent.phonenumber == number))
            {
                Console.WriteLine("Такой абонент уже существует");
            }
            else
            {
                abonents.Add(new Abonent(name, number));
                new StreamWriter(@"./abonents.txt", true).WriteLine(name + ":" + number);
            }
        }

        public void GetAbonent()
        {
            Console.Write("Enter a name or phone number");
            string arg = Console.ReadLine();
            Abonent? abonent = Get(arg);
            Console.WriteLine();
            if (abonent != null)
            {
                Console.WriteLine(abonent.name + ": " + abonent.phonenumber);
            }
            else
            {
                Console.WriteLine("Abonent wasn't founded");
            }
        }


        public void DeleteAbonent()
        {
            Console.Write("Enter a name or phone number");
            string arg = Console.ReadLine();
            Abonent? abonent = Get(arg);
            Console.WriteLine();
            if (abonent != null)
            {
                abonents.Remove(abonent);
            }
            else
            {
                Console.WriteLine("Abonent wasn't founded");
            }
        }


        public static void Start()
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Add to phonebook");
            Console.WriteLine("2 - Delete from phonebook");
            Console.WriteLine("3 - Get contact by name");
            Console.WriteLine("4 - Get contact by number");

            string value = Console.ReadLine();

            Phonebook phonebook = new Phonebook();

            switch (value)
            {
                case "1":
                    {
                        phonebook.AddAbonent();
                        return;
                    }
                case "2":
                    {
                        phonebook.DeleteAbonent();
                        return;
                    }
                case "3":
                    {
                        phonebook.GetAbonent();
                        return;
                    }
            }
        }
    }
}
