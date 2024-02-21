using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Person(){FirstName="Sabri"},
                new Customer(){FirstName="Caner"},
                new Student(){FirstName= "Genco"}
            };
            foreach (Person person in persons)
                Console.WriteLine(person.FirstName);
            
            Console.ReadLine(); 
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Student : Person
    {

    }
    class Customer : Person
    {

    }
}
