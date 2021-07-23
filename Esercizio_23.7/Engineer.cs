using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_23._7
{
    internal class Engineer : Person
    {

        public int HourlyPay {get; set;}
        public int HourWork { get; set; }
 
        public Engineer(string name, string lastname, string codf, int hpay, int hwork)

         : base(name, lastname, codf)
        {
            HourlyPay = hpay;
            HourWork = hwork;
        }

        static void  SalaryCal( int hpay, int hwork)
        {
            int salcal = hpay * hwork;
               
        }

    }
}
