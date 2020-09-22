using System;
using System.Linq;

namespace _9_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 4, 7, 3, 8, 8, 66, 7, 33, 100, 42891, 9};
            var numbersToSort = numbers.ToList();

            numbersToSort.Sort();

            Console.WriteLine(string.Join(", ", numbersToSort));
        }
    }
}
