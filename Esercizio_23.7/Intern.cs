using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_23._7
{
    class Intern : Person
    {
        int InternshipDur { get; set; }
        int InternshipSalary { get; set;  }

        public Intern(string name, string lastname, string codf, int intdur, int intsal)

             : base(name, lastname, codf)
        {
            InternshipDur = intdur;
            InternshipSalary = intsal;

            InternshipSalary = 600;

        }

        public Intern(string name, string lastname, string codf) : base(name, lastname, codf)
        {
        }
    }
}
