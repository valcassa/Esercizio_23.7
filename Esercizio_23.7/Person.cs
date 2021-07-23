using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_23._7
{
    class Person
    {
        public static string Name {set; get;}
        public static string  LastName { set; get; }
        public static string CodFiscale { set; get; }


        public Person(string name, string lastname, string codf)
        {
            Name = name;
            LastName = lastname;
            CodFiscale = codf;

        }

        public Person() { 
        }

    }
}
