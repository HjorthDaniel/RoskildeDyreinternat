using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public abstract class Dyr
    {
        public string navn;
        public string race;
        public string chipnummer;
        public string køn;
        public int alder;
        public string helbredstilstand;
        public bool erAdopteret;








        public string Navn
        {
            get { return this.navn; }
            set { this.navn = value; }
        }

        public string Race
        {
            get { return this.race; }
            set { this.race = value; }
        }

        public string Chipnummer
        {
            get { return this.chipnummer; }
            set { this.chipnummer = value; }
        }
        
        public string Køn
        {
            get { return this.køn; }
            set { this.køn = value; }
        }

        public int Alder
        {
            get { return this.alder; }
            set { this.alder = value; }
        }

        public string Helbredstilstand
        {
            get { return this.helbredstilstand; }
            set { this.helbredstilstand = value; }
        }

        public bool ErAdopteret
        {
            get { return this.erAdopteret; }
            set { this.erAdopteret = value; }
        }  





    }
}
