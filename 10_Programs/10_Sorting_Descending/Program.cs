using System;
using System.Linq;

namespace _10_Sorting_Descending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 7, 3, 8, 8, 66, 7, 33, 100, 42891, 9 };
            var numbersToSort = numbers.ToList();
            numbersToSort.Sort();

            var sortedNumbers = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedNumbers[numbers.Length - 1-i] = numbersToSort[i];
            }
                
            Console.WriteLine(string.Join(", ", sortedNumbers));
        }
    }
}