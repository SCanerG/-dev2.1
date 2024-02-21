using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int ıd, string firstName, string lastName, string city)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }

        
        private string _firstName;
        
        public string FirstName
        {
            get
            { return "Mrs." + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
