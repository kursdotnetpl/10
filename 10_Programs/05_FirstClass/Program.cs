using System;

namespace _05_FirstClass
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }

        public int GetAge()
        {
            return (DateTime.Now - DateOfBirth).Days / 365;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.DateOfBirth = DateTime.Now.AddYears(-25);
            Console.WriteLine("Wiek: " + person.GetAge());
        }
    }
}
