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
            if (hund != null && !HundeListe.Any(h => h.GetChipnummer() == hund.GetChipnummer()))
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

        public bool AddKat(Kat kat)
        {
            if (kat != null && !KatteListe.Any(k => k.GetChipnummer() == kat.GetChipnummer()))
            {
                this.KatteListe.Add(kat);
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
        //public bool AddKat(Kat _kat)
        //{
        //    if (_kat == null)
        //        return false;

        //    // Tjek om katten med samme chipnummer allerede findes
        //    foreach (Kat kat in KatteListe)
        //    {
        //        if (kat.GetChipnummer() == _kat.GetChipnummer())
        //        {
        //            // Katten findes allerede - tilføj ikke
        //            return false;
        //        }
        //    }

        //    // Hvis vi kommer her, findes katten ikke - tilføj den
        //    KatteListe.Add(_kat);
        //    return true;
        //}


        public void Valgtedyr(int Valgtedyr)
        {
            Console.WriteLine("----------------------------------");
            if (Valgtedyr == 1)
            {
                
                foreach (var hund in HundeListe)
                {
                    Console.WriteLine(hund.PrintAltInfo());
                    Console.WriteLine("----------------------------------");
                }
               
            }
            else if (Valgtedyr == 2)
            {
                foreach (var kat in KatteListe)
                    
                {
                    Console.WriteLine(kat.PrintAltInfo());
                    Console.WriteLine("----------------------------------");
                }
                
            }
            else
            {
                Console.WriteLine("Ukendt dyretype");
            }
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