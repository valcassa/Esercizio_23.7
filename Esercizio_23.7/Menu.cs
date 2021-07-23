using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Esercizio_23._7
{

    class Menu
    {
        public static object ViewEmployers { get; private set; }

        internal static void Start()
        {

            int choice;

            do
            {
                Console.WriteLine("*** Programma eseguito ***");
                Console.WriteLine("Scegli tra le seguenti opzioni:");
                Console.WriteLine("1- Visualizza tutti gli impiegati");
                Console.WriteLine("2- Mostra impiegati dei settori");
                Console.WriteLine("3- Inserisci un nuovo impiegato");
                Console.WriteLine("4- Rimuovi impiegato");

            }
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 5);
            {
                Console.WriteLine("Inserisci un'opzione valida");
            }

            switch (choice)
            {
                case 1:
                    EmployersList.FetchAll();
                    break;
                case 2:
                    Menu.SearchEmployer();
                    break;
                case 3:
                    AddNew();
                    break;
                case 4:
                    Menu.RemoveEmployer();
                    break;
                default:
                    Console.WriteLine("Inserisci scelta valida");
                    break;
                case 0:
                    break;
            }


            static void AddNew()
            {
                string codf;

                do
                {
                    Console.WriteLine("Inserisci il codice fiscale del nuovo impiegato:");
                    codf = Console.ReadLine();
                } while (codf.Length == 16);

                if (codf != null)
                {

                    Console.WriteLine("Impiegato già presente!");
                }
                else Employer.AddNew();
            }
        }

        private static void SearchEmployer()
        {
            throw new NotImplementedException();
        }

        private static void RemoveEmployer()
        {
        }

        static void RemoveEmployer(Employer employertoremove)
        {
            Employer.Remove(employertoremove);
        }

        static void SearchEmployer(string getEmployer)
        {

            Console.WriteLine("Inserisci un campo che vuoi ricercare:");
            string field = Console.ReadLine();

        }
    }
     
    }




