using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje14
{
    class Program
    {
        static void Main(string[] args)
        {
             

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }
    interface IWoeker
    {
        void work();

        
    }

    interface IEat
    {
    
        void Eat();
  

    }
    interface ISalary
    {
        
        void GetSalary();
        
    }



    class Manager : IWoeker , IEat , ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWoeker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWoeker
    {
        public void work()
        {
            throw new NotImplementedException();
        }
    }


}
