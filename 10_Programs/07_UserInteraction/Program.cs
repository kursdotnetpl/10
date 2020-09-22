using System;

namespace _7_UserInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wiek.");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);

            if (age > 18)
            {
                Console.WriteLine("Gratulacje. Jesteś pełnoletni!");
            }
            else
            {
                var years = 18 - age;
                Console.WriteLine($"Jeszcze nie jesteś pełnoletni. Musisz poczekać {years} lat.");
            }


        }
    }
}
