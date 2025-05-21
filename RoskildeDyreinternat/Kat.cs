using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Kat : Dyr
    {
        // Private fields med lille begyndelsesbogstav
        private bool kanMedAndreKatte;
        private bool skalVæreIndekat;

        // Konstruktør med parametre 
        public Kat(string navn, string race, int chipnummer, string køn, int alder, string helbredstilstand, bool erAdopteret, bool kanMedAndreKatte, bool skalVæreIndekat)

            : base (navn, race, chipnummer, køn, alder, helbredstilstand, erAdopteret)
        {
            // Brug af 'this.' for at skelne mellem felt og parameter
            this.kanMedAndreKatte = kanMedAndreKatte;
            this.skalVæreIndekat = skalVæreIndekat;
            
        }

        public bool KanMedAndreKatte
        {
            get { return this.KanMedAndreKatte; }
            set { this.KanMedAndreKatte = value; }
        }
        public bool SkalVæreIndekat
        {
            get { return this.SkalVæreIndekat; }
            set { this.SkalVæreIndekat = value; }
        }
        public override void PrintAltInfo()
        {
            Console.WriteLine($"Kat Info:");
            Console.WriteLine($"Navn: {Navn}, Race: {Race}, Chipnummer: {Chipnummer}, Køn: {Køn}, Alder: {Alder}, Helbredstilstand: {Helbredstilstand}, Kan med andre katte: {KanMedAndreKatte}, Er indekat: {SkalVæreIndekat}");

        }
    }

}
