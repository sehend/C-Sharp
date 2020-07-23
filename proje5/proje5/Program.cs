using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20, number2 = 100; // local value
            var resault = add(number1, number2);
            Console.WriteLine(resault);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static int add(int number1, int number2)
        {
            number1 = 30;  // local value
            return number1 + number2;

        }



    }
}
