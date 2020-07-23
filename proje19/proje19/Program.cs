using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            

            List<Customer> ctr = new List<Customer>();
            ctr.Add(new Customer{Id=12,FirstName="sehend" });
            ctr.Add(new Customer { Id = 42, FirstName = "Barış" });

            foreach (var cstmr in ctr)
            {
                Console.WriteLine(cstmr.Id +" "+cstmr.FirstName);
            }



            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
