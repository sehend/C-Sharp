using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje13
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager costumer = new CustomerManager();
            //costumer.add(new SqlServerCostumerDal());
            //costumer.add(new OracleCostumerDal());
            Interface1[] CustumerDals = new Interface1[2] {
                new SqlServerCostumerDal(),
                new OracleCostumerDal()
            };

            foreach (var Interface1 in CustumerDals)
            {
                Interface1.add();
                Interface1.update();
                Interface1.delete();
            }


            Console.ReadLine();
        }
    }
}
