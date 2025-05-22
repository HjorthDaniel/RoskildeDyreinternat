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


        public void VisDyreInfo(int chipnummer)
        {
            // Søg i hundelisten
            foreach (var hund in HundeListe)
            {
                if (hund.GetChipnummer() == chipnummer)
                {
                    Console.WriteLine("Hund fundet:");
                    Console.WriteLine(hund); // Bruger ToString()
                    return;
                }
            }

            // Søg i kattelisten
            foreach (var kat in KatteListe)
            {
                if (kat.GetChipnummer() == chipnummer)
                {
                    Console.WriteLine("Kat fundet:");
                    Console.WriteLine(kat); // Bruger ToString()
                    return;
                }
            }

            // Hvis ingen dyr blev fundet
            Console.WriteLine($"Intet dyr fundet med chipnummer {chipnummer}.");
        }




        // KatteListe hvor der kan tilføjes en hund
        public bool AddKat(Kat _kat)
        {

            foreach (Kat kat in KatteListe)
            {
                //Tjekker om den nyoprettede kat, ikke har samme chipnummer som en kat på listen.
                if (_kat != null && kat.GetChipnummer == _kat.GetChipnummer)
                {
                    KatteListe.Add(_kat); // gemmer de katte der blev tilføjet
                    return true;
                }
            }

            //for-loop: Tjekker om den nyoprettede kat, ikke har samme chipnummer som en kat på listen.
            //for (int i = 0; i < KatteListe.Count; i++)
            //{
            //    if (!(KatteListe[i].chipnummer == _kat.chipnummer))
            //    {
            //        KatteListe.Add(_kat);
            //        return true;
            //    }
            //}


            return false; // returnerer listen over katte, der blev tilføjet
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