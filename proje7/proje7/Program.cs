using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[5, 3] {

                {"istanbul","izmir","balıkesir" },
                {"ankara","konya","kırkkale" },
                {"antalya","adana","mersin" },
                {"rize","travzon","samsun" },
                {"izmir","mugla","manisa" }
                
                };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }

                Console.WriteLine("");
            }

            Console.ReadLine();

        }
    }
}
