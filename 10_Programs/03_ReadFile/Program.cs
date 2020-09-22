using System;
using System.IO;

namespace _3_ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("data.txt");
            Console.WriteLine("Zawartość pliku:");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
