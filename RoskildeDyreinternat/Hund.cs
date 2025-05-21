using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Hund : Dyr
    {
        public bool kanMedAndreHunde;
        public bool erTrænet;


        public Hund (bool KanMedAndreHunde,  bool ErTrænet, string navn, string race, int chipnummer, string køn, int alder, string helbredstilstand, bool erAdopteret)
            : base (navn, race, chipnummer, køn, alder, helbredstilstand, erAdopteret)
        {
            this.kanMedAndreHunde = KanMedAndreHunde;
            this.erTrænet = ErTrænet;
        }

        public bool KanMedAndreHunde
        {
            get { return KanMedAndreHunde; }
            set { KanMedAndreHunde = value; }
        }

        public bool ErTrænet
        {
            get { return ErTrænet; }
            set { erTrænet = value; }
        }

        public override void PrintAltInfo() // <- krævet af abstract base class
        {
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Race: {Race}");
            Console.WriteLine($"Chipnummer: {Chipnummer}");
            Console.WriteLine($"Køn: {Køn}");
            Console.WriteLine($"Alder: {Alder}");
            Console.WriteLine($"Helbredstilstand: {Helbredstilstand}");
            Console.WriteLine($"Er adopteret: {ErAdopteret}");
            Console.WriteLine($"Kan med andre hunde: {KanMedAndreHunde}");
            Console.WriteLine($"Er trænet: {ErTrænet}");
        }
        public override void Lavlyd()
        {
            Console.WriteLine("Hunden siger: Vuf!");
        }

    }
}
