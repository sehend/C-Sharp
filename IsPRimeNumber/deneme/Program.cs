using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {

        private static void IsPrimeNumber(int number)
        { bool a= false;
            for (int i = 3; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("this number is not IsPRimeNumber");
                    a = true;
                }  
            }

            
            if (a ==false)
            {
                Console.WriteLine("this number is IsPRimeNumber");
            }

        }

        static void Main(string[] args)
        {

            IsPrimeNumber(7);

            Console.ReadLine();
        }



    }

}

