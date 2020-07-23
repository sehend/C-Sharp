using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase database = new SqlServer();
            DataBase database2 = new oracle();
            database.add();
            database.Delete();
            database2.add();
            database2.Delete();



            Console.ReadLine();

        }

        abstract class DataBase
        {
            public void add()
            {
                Console.WriteLine("added by default !!!!");
            }
            public abstract void Delete();
        }

         class SqlServer : DataBase
        {
            public override void Delete()
            {
                Console.WriteLine("Delete by defaultSql !!!!");

            }
        }
            class oracle : DataBase
            {
                public override void Delete()
                {
                    Console.WriteLine("Delete by defaultOracle !!!!");
                }
            }
        }
    
}
