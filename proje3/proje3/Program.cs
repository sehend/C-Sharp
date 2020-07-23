using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    class Program
    {
        static void Main(string[] args)
        {

           var sonuc = add(5, 3);
            Console.WriteLine(sonuc);
            Console.ReadLine();

        }
        static int add(int number1,int number2) 
        {
            

            return number1+number2;
        }
    }
}
