using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class DyrRepo

    {
            List<Hund> HundeListe = new List<Hund>();
            List<Kat> KatteListe = new List<Kat>();

            

        
        // Hundeliste hvor der kan tilføjes en hund
        public bool AddHund(Hund hund)
        {
            if (hund != null && !HundeListe.Contains(hund))
            {
                this.HundeListe.Add(hund);
                return true;
            }
            else
            {
                //Her kan der tilføjes en besked her
                Console.WriteLine("Hunden findes allerede.");
                return false;

            }
        }
        //   søgning

        public List<Hund> GetAllHunde()
        {
            return HundeListe;
        }

        public void OpretHund(bool kanMedAndreHunde, bool erTrænet, string navn, string race, int chipnummer,
        string køn, int alder, string helbredstilstand, bool erAdopteret)
        {
            if (HundeListe.Any(h => h.GetChipnummer() == chipnummer))
            {
                throw new ArgumentException($"Hund med chipnummer {chipnummer} findes allerede.");
            }

            Hund nyHund = new Hund(kanMedAndreHunde, erTrænet, navn, race, chipnummer, køn, alder, helbredstilstand, erAdopteret);
            HundeListe.Add(nyHund);
        }

        public void OpretKat(bool kanMedAndreKatte, bool skalVæreIndekat, string navn, string race, int chipnummer,
            string køn, int alder, string helbredstilstand, bool erAdopteret)
        {
            if (KatteListe.Any(k => k.GetChipnummer() == chipnummer))
            {
                throw new ArgumentException($"Kat med chipnummer {chipnummer} findes allerede.");
            }

            Kat nyKat = new Kat(kanMedAndreKatte, skalVæreIndekat, navn, race, chipnummer, køn, alder, helbredstilstand, erAdopteret);
            KatteListe.Add(nyKat);
        }

        public void VisDyrInfo(int chipnummer)
        {
            // Søg i hundelisten
            foreach (var hund in HundeListe)
            {
                if (hund.GetChipnummer() == chipnummer)
                {
                    Console.WriteLine($"Du har søgt efter Chipnummeret: {chipnummer}:");
                    Console.WriteLine("Hund fundet:");
                    Console.WriteLine();
                    Console.WriteLine(hund.PrintAltInfo()); ;
                    Console.WriteLine();
                    return;
                }
            }

            // Søg i kattelisten
            foreach (var kat in KatteListe)
            {
                if (kat.GetChipnummer() == chipnummer)
                {
                    Console.WriteLine($"Du har søgt efter Chipnummeret: {chipnummer}:");
                    Console.WriteLine("Kat fundet:");
                    Console.WriteLine();
                    Console.WriteLine(kat.PrintAltInfo()); // Bruger ToString()
                    Console.WriteLine();
                    return;
                }
            }

            // Hvis ingen dyr blev fundet
            Console.WriteLine($"Intet dyr fundet med chipnummer {chipnummer}.");
        }

        public bool TilføjDyr(Dyr dyr)
        {
            if (dyr == null)
                return false;

            if (dyr is Hund hund)
            {
                return AddHund(hund);
            }
            else if (dyr is Kat kat)
            {
                return AddKat(kat);
            }
            else
            {
                Console.WriteLine("Ukendt dyretype.");
                return false;
            }
        }



        // KatteListe hvor der kan tilføjes en hund
        public bool AddKat(Kat _kat)
        {
            if (_kat == null)
                return false;

            // Tjek om katten med samme chipnummer allerede findes
            foreach (Kat kat in KatteListe)
            {
                if (kat.GetChipnummer() == _kat.GetChipnummer())
                {
                    // Katten findes allerede - tilføj ikke
                    return false;
                }
            }

            // Hvis vi kommer her, findes katten ikke - tilføj den
            KatteListe.Add(_kat);
            return true;
        }


        //While-loop: Tjekker om den nyoprettede kat, ikke har samme chipnummer som en kat på listen.
        //public bool AddKat(Kat _kat)
        //{
        //    if (_kat == null)
        //        return false;

        //    int i = 0;
        //    while (i < KatteListe.Count)
        //    {
        //        if (KatteListe[i].chipnummer == _kat.chipnummer)
        //        {
        //            return false; // Dublet fundet – tilføj ikke
        //        }
        //        i++;
        //    }

        //    KatteListe.Add(_kat); // Ingen dublet fundet – tilføj katten
        //    return true;
        //}


    }

}