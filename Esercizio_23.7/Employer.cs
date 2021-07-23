using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_23._7
{
    class Employer : Person
    {
        public static string Field { get; set; }
        public List<Employer> EmployersEnum { get; set; } = new List<Employer>();


        public Employer(string name, string lastname, string codf, string field)

            : base(name, lastname, codf)
        {
            Field = field;
        }

        public Employer(){
        }

        public Employer(string name, string lastname, string codf) : base(name, lastname, codf)
        {
        }

        static void Salary(int sal){
            
         }

       internal static void AddNew()
        {
            string name;
            string lastname; 

            Console.WriteLine("Inserisci il Nome del nuovo impiegato:");
            name = Console.ReadLine();
            Console.WriteLine("Inserisci il Cognome del nuovo impiegato:");
            lastname = Console.ReadLine();
        }


        public enum EmployerEnum
        {
            Name,
            LastName,
            Field,
            Salary,
        }

        internal static void Remove(Employer e)
        {
         }
    }
}
