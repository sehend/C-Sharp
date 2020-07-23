using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje4
{
    class Program
    {
        static void Main(string[] args)
        {

            var sonuc = add(6);
            Console.WriteLine(sonuc);
            Console.ReadLine();

        }
        static int add(int number1, int number2 = 30) // defuld of value only uaw is right and we use a lot of defuld of value
        {


            return number1 + number2;
        }
    }
}
