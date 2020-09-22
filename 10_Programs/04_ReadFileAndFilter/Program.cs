using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _4_ReadFileAndFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = File.ReadLines("data.txt");
            List<string> filteredNames = new List<string>();

            string nametoFind = "Nowak";

            foreach (var name in names)
            {
                if (name.Contains(nametoFind))
                {
                    filteredNames.Add(name);
                }
            }

            Console.Write($"Nazwiska zawierające słowo {nametoFind}: ");
            Console.WriteLine(string.Join(", ", filteredNames));
            Console.ReadLine();
        }
    }
}
