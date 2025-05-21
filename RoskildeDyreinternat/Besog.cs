using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Besog
    {
        public int BesogNr;
        public Kunde Kunde;
        public Dyr Dyr;
        public DateTime Tidspunkt;
        public int næsteNr = 1;


        //lav en kontruktor til besog

        public Besog(Kunde kunde, Dyr dyr, DateTime tidspunkt)
        {
            BesogNr = naesteNr++;
            Kunde = kunde;
            Dyr = dyr;
            Tidspunkt = tidspunkt;
        }
    
         
    }
}
