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


        // HundeListe
        public bool AddHund(Hund hund)
            {
            if (hund != null && !HundeListe.Contains(hund))

                {
                    this.HundeListe.Add(hund);
                    return true;
                }
                return false;
            }

            public List<Hund> GetAllHunde()
            {
                return HundeListe;
            }
  
     
        // KatteListe
            public bool AddKat(Kat kat)
            {
                if (kat != null && !KatteListe.Contains(kat))
            {
                    this.KatteListe.Add(kat);
                    return true;
                }
                return false;
            }

            public List<Kat> GetAllKatte()
            {
                return KatteListe;
            }
        
    }

}