using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje8
{
    class Program
    {
        static void Main(string[] args)
        {

            var sentence = "Sehend Sina";
            bool result = sentence.EndsWith("a");
            bool result2 = sentence.StartsWith("S");
            var result3 = sentence.IndexOf("Sina");
            var result4 = sentence.LastIndexOf("a");
            var result5 = sentence.Insert(0 ,"My Name is ");
            var result6 = sentence.Replace(" ","-");
          



            if (result == true)
                Console.WriteLine("this sentence is end of a");
            else
                Console.WriteLine("this sentence is not end of a");
            if (result2 == true)
                Console.WriteLine("this sentence is start of S");
            else
                Console.WriteLine("this sentence is not start of S");
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);


             

            Console.ReadLine();

        }
    }
}
