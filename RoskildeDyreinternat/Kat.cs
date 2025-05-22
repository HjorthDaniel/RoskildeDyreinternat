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
        public Kat(bool kanMedAndreKatte, bool skalVæreIndekat, string navn, string race, int chipnummer, string køn, int alder, string helbredstilstand, bool erAdopteret)

            : base (navn, race, chipnummer, køn, alder, helbredstilstand, erAdopteret)
        {
            // Brug af 'this.' for at skelne mellem felt og parameter
            this.kanMedAndreKatte = kanMedAndreKatte;
            this.skalVæreIndekat = skalVæreIndekat;
            
        }

        public bool KanMedAndreKatte
        {
            get { return this.kanMedAndreKatte; }
            set { this.kanMedAndreKatte = value; }
        }
        public bool SkalVæreIndekat
        {
            get { return this.skalVæreIndekat; }
            set { this.skalVæreIndekat = value; }
        }
        public override string PrintAltInfo()
        {
            return $"Navn: {Navn}\nRace: {Race}\nChipnummer: {Chipnummer}\nKøn: {Køn}\nAlder{Alder}\nHelbredstilstand {Helbredstilstand}\nErAdopteret {ErAdopteret}\nKanMedAndreHunde{KanMedAndreKatte}\nSkalVæreIndekat{SkalVæreIndekat}";
        }
        public override string Lavlyd()
        {
            return "Katten siger: Miau!";
        }
    }

}
