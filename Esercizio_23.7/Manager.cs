using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_23._7
{
    class Manager : Person
    {
        public int ExtraHour { set; get; }
        public int BaseSalary { set; get; }


        public Manager(string name, string lastname, string codf, int exth, int basal)

        : base(name, lastname, codf)
        {
            ExtraHour = exth;
            BaseSalary = basal;

        }

        public Manager(string name, string lastname, string codf) : base(name, lastname, codf)
        {
        }

        static void ManagerSalary(int basal, int exth)
        {
            int mansal;
            mansal = basal + (exth * 10);

        }

    }
}
