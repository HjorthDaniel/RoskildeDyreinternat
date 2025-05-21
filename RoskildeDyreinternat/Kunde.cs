using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    // Private fields med lille begyndelsesbogstav
    public class Kunde : Bruger
    {
        // Private fields med lille begyndelsesbogstav
        private int alder;
        private string køn;


        // Konstruktør med parametre 
        public Kunde(int id, string navn, string email, string telefon, string adresse, string rolle, int alder, string køn)
            : base(id, navn, email, telefon, adresse, rolle)
        {
            this.alder = alder;
            this.køn = køn;
        }
        //Propetities
        public int Alder
        {
            get { return this.alder; }
            set { this.alder = value; }
        }
        public string Køn
        {
            get { return this.køn; }
            set { this.køn = value; }
        }

        //den printer info om ALLE Kunde
        public override void PrintAltInfo()
        {
            Console.WriteLine($"Kunde Info:");
            Console.WriteLine($"Navn: {Navn}, ID: {Id}, Email: {Email}, Tlf: {Telefon}, Adresse: {Adresse},Alder: {Alder},Rolle: {Rolle}, Køn: {Køn}");

        }
    }
}
