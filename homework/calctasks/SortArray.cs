using System;
using System.Collections.Generic;
using System.IO;

namespace homework.calctasks
{
    public class SortArray
    {
        public SortArray() {

        }

        public static void Sort() {
            string[] arr = File.ReadAllLines("file.txt");

            Console.WriteLine("unsorted array:");

            Console.WriteLine($"{string.Join(", ", arr)}");

            string[] newArr = bubbleSort(arr);

            Console.WriteLine("sorted array:");

            Console.WriteLine($"{string.Join(", ", newArr)}");
        }

        public static string[] bubbleSort(string[] arr)
        {
            string temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}

