using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje13
{
    interface Interface1
    {
        void add();
        void update();
        void delete();
    }

    class SqlServerCostumerDal : Interface1
    {
        public void add()
        {
            Console.WriteLine("Sql added !!!!");
        }

        public void delete()
        {
            Console.WriteLine("Sql deleted !!!!");
        }

        public void update()
        {
            Console.WriteLine("Sql updated !!!!");
        }
    }

    class OracleCostumerDal : Interface1
    {
        public void add()
        {
            Console.WriteLine("Oracle added !!!!");
        }

        public void delete()
        {
            Console.WriteLine("Oracle deleted !!!!");
        }

        public void update()
        {
            Console.WriteLine("Oracle updated !!!!");
        }

    }

    class CustomerManager 
    {
        public void add(Interface1 customer)
        {
            customer.add();
        }
    }

}
