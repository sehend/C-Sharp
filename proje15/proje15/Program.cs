using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje15
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlserver = new SqlServer();
            MySql mysql = new MySql();
            sqlserver.add();
            mysql.add();
            Console.ReadLine();



        }

        class Database
        {
            public virtual void add()
            {
                Console.WriteLine("added by default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }


        }
        class  SqlServer : Database {
            public override void add()
            {
                Console.WriteLine("added by Sql code !!!!");
                
            }

        }
        class MySql : Database
        {

        }


    }
}
