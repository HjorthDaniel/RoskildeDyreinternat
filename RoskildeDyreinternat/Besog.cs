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
            BesogNr = næsteNr++;
            Kunde = kunde;
            Dyr = dyr;
            Tidspunkt = tidspunkt;
        }
    
        public int besogNr()
        {
            return BesogNr;
        }

        public Kunde kunde()
        {
            return Kunde;
        }

        public Dyr dyr()
        {
            return Dyr;
        }

        public DateTime tidspunkt()
        {
            return Tidspunkt;
        }

        public void setTidspunkt(DateTime tidspunkt)
        {
            Tidspunkt = tidspunkt;
        }

        public void setDyr(Dyr dyr)
        {
            Dyr = dyr;
        }

        public void setKunde(Kunde kunde)
        {
            Kunde = kunde;
        }

        public override string ToString()
        {
            return $"Besøg nr: {BesogNr}, Kunde: {Kunde.Navn}, Dyr: {Dyr.Navn}, Tidspunkt: {Tidspunkt}";
        }

        public void setBesogNr(int besogNr)
        {
            BesogNr = besogNr;
        }

       


    }
}
