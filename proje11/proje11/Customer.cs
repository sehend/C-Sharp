using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje11
{
    class Customer
    {

        string _Firstname;
            

        public string Firstname {


            get {


                return "Mr." + " " + _Firstname;


            }




            set{


                _Firstname = value;

            }
        }
        public string LastName { get; set; }


    }
}
