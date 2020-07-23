using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(add(2, 4, 6, 8));
            Console.ReadLine();


        }



        static int add(params int[] numbers)
        {

            return numbers.Sum();

        }
    }
}
