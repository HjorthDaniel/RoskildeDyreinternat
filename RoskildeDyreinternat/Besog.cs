using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    // Public bagging fields med lille begyndelsesbogstav
    public class Besog
    {
        private static int næsteBesogsnummer = 1;
        public int Besogsnummer { get; private set; }
        public DateTime Dato { get; set; }
        public Kunde Kunde { get; set; }
        public Dyr Dyr { get; set; }

        public Besog(DateTime dato, Kunde kunde, Dyr dyr)
        {
            this.Besogsnummer = næsteBesogsnummer;
            næsteBesogsnummer++;

            Dato = dato;
            Kunde = kunde;
            Dyr = dyr;
        }

        public string Book()
        {

            {
                string besked = $"Besøg #{Besogsnummer} booket til {Dato}";
                Console.WriteLine(besked);
                return besked;
            }
        }

        public void PrintBesøgsInfo()
        {
            Console.WriteLine($"Besøg #{Besogsnummer} - {Dato}");
            Kunde.PrintAltInfo();
            Dyr.PrintAltInfo();
        }
    }
}


