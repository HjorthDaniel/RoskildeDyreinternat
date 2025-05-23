﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    // Private fields med lille begyndelsesbogstav
    public abstract class Dyr
    {
        //private fields med små bogstav
        private string navn;
        private string race;
        private int chipnummer;
        private string køn;
        private int alder;
        private string helbredstilstand;
        private bool erAdopteret;

        // Konstruktør med parametre 

        public Dyr(string navn, string race, int chipnummer, string køn, int alder, string helbredstilstand, bool erAdopteret)
        {
            // Brug af 'this.' for at skelne mellem felt og parameter
            this.navn = navn; 
            this.race = race;
            this.chipnummer = chipnummer;
            this.køn = køn; 
            this.alder = alder;
            this.helbredstilstand = helbredstilstand;
            this.erAdopteret = erAdopteret;
        }

        // Propetities
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

        public int Chipnummer
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

        //den printer info om ALLE dyr

        public int GetChipnummer()
        {
            return (this.chipnummer);
        }

        public string GetKøn()
        {
            return (this.køn);
        }

        public abstract string PrintAltInfo();

        public virtual string Lavlyd()
        {
            return "Dyret siger lyd.";
        }
    }
}
