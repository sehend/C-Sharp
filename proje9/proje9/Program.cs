using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje9
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerMAnager = new CustomerManager();

            customerMAnager.add();
            customerMAnager.Update();

            Console.ReadLine();


        }
    }




 
}
