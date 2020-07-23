using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje17
{
    class Program
    {
        static void Main(string[] args)
        {
            product Product = new product(2, "computer");

            Product.write();

            Console.ReadLine();

        }
    }

    class product
    {
        public product()
        {

        }
        int _id;
        string _name;
        public product(int id , string name1)
        {
            _id = id;
            _name = name1;
        }
       public int Id { get; set; }
        public string Name { get; set; }
        public void write()
        {
            Console.WriteLine(_id);
            Console.WriteLine(_name);
        }
    }



}
