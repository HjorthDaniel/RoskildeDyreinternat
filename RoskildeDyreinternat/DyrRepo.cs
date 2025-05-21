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

        
        // tilføj
        public bool AddHund(Hund hund)
        {
            if (hund != null && !HundeListe.Contains(hund))
            {
                this.HundeListe.Add(hund);
                return true;
            }
            else
            {
                // Eksempel: du kan tilføje en logbesked her
                Console.WriteLine("Hunden findes allerede.");
                return false;

            }
        }
            

            public List<Hund> GetAllHunde()
            {
                return HundeListe;
            }


        // KatteListe
        public bool AddKat(Kat _kat)
        {

            foreach (Kat kat in KatteListe)
            {
                //Tjekker om den nyoprettede kat, ikke har samme chipnummer som en kat på listen.
                if (_kat != null && kat.chipnummer==_kat.chipnummer)
                {
                    KatteListe.Add(_kat); // gemmer hvilke katte der blev tilføjet
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