using System;

namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        //Customer customer = new Customer();
        Person[] persons = new Person[3]
        {
            new Customer{FirsName = "Engin"},
            new Student{FirsName = "Derin"},
            new Person{FirsName = "Salih"}
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirsName);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }

    

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person 
    {
        public string Department { get; set; }
    }
}

