using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje18
{
    class Program
    {
        static void Main(string[] args)
        {

            teacher.Number = 10;
            Console.WriteLine(teacher.Number);
            Utilities.Validate();
            Manager.Dosomething();
            Manager manager = new Manager();
            manager.Dosomething2();
            Console.ReadLine();

        }
      
    }
    static class teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }
                           
        public static void Validate()
        {
            Console.WriteLine("Validate is done");
        }
        

    }
    class Manager
    {
        public static void Dosomething()
        {
            Console.WriteLine("Done");
        }
        public  void Dosomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
                        
}
