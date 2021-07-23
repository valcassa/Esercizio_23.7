using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_23._7
{
    class EmployersList
    {
        static Dictionary<string, Employer> Employers = new Dictionary<string, Employer>()
        {
            // Nonostante indichi nuovi elementi nella lista, risulta errato.

                 { "ABC1234567891235", new Employer("Claudio", "Bruno", "Employer") },
                 { "BBC1234567891234", new Manager( "Claudia", "Torta", "Manager") },
                 { "BBC1234567891236", new Intern("Sara", "Giallo", "Intern") },
                 { "BBC1234567891237", new Engineer("Gaetano", "Giulio", "Engineer") }

        };

        internal static Dictionary<string, Employer> Employers1 { get => Employers; set => Employers = value; }


        internal static void FetchAll()
        {
                 foreach (var e in Employers)
                {
                    Console.WriteLine(e.Key + "-" + Employer.Name + " " + Employer.LastName + " " + Employer.CodFiscale);
                }
        }

    }
}

