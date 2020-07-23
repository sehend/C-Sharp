using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje10
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Sehend";
            customer.LastName = "Sina";
            customer.Id = 1348;
            customer.City = "İstanbul";

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.Id + " " +  customer.City);

            Console.ReadLine();
        }
    }
}
