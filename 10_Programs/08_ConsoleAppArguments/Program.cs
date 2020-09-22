using System;

namespace _8_ConsoleAppArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nie podano żadnego argumentu podczas wywołania programu.");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($" argument numer {i} to: args[i]");
                }
            }
        }
    }
}
