using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje11
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Firstname = "Sehend";
            customer.LastName = "Sina";

            Console.WriteLine(customer.Firstname + " " + customer.LastName);

            Console.ReadLine();

        }
    }
}
