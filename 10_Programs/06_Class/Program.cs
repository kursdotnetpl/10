using System;

namespace _6_Class
{
    class Program
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

        class Employee : Person
        {

        }

        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.DateOfBirth = DateTime.Now.AddYears(-25);
            Console.WriteLine("Wiek: " + person.GetAge());
        }
    }
}
