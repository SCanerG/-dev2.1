using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManeger = new CustomerManager();
            customerManeger.Add();
            customerManeger.Remove();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Remove();

            Customer customer = new Customer();
            customer.Id = 0;
            customer.FirstName = "Sabri";
            customer.LastName = "Genco";
            customer.City = "Antep";
            
            
            Customer customer1 = new Customer
            {
                City = "Kütahya",
                FirstName = "Caner",
                LastName = "Gencoo",
                Id = 1
            };

            Customer customer2 = new Customer(2, "Sabrii", "Canerr", "Antepp");

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
