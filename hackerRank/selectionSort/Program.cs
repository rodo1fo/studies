using System;

namespace selectionSort
{
    class Program
    {
        static int[] Sort(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[i])
                    {
                        int aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            }

            return list;
        }

        static void Print(int[] list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void PrintAndSort(string message, int[] list)
        {
            Console.WriteLine(message);

            Print(list);
            list = Sort(list);
            Print(list);
        }

        static void Main(string[] args)
        {
            int[] list;

            // random
            list = new int[] { 8, 4, 1, 8, 9, 3 };
            PrintAndSort("random", list);

            // sorted 
            list = new int[] { 1, 1, 5, 8, 10, 50, 50 };
            PrintAndSort("sorted", list);

            // inverted
            list = new int[] { 50, 40, 30, 20, 10, 1 };
            PrintAndSort("inverted", list);
        }
    }
}
