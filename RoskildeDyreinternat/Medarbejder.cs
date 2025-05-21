using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    // Private fields med lille begyndelsesbogstav
    public class Medarbejder : Bruger
    {
        //private fields med små bogstav
        private string stilling;
        private int antalarbejdstimer;

        // Konstruktør med parametre 

        public Medarbejder(int id, string navn, string email, string telefon, string adresse, string rolle, string stilling, int antalarbejdstimer)
          : base(id, navn, email, telefon, adresse, rolle)
        {
            // Brug af 'this.' for at skelne mellem felt og parameter
            this.stilling = stilling;
            this.antalarbejdstimer = antalarbejdstimer;
        }

        // Propetities
        private string Stilling
        {
            get { return stilling; }
            set { stilling = value; }
        }

        private int Antaltarbejdstimer

        {
            get { return antalarbejdstimer; }
            set { antalarbejdstimer = value; }

        }


        //den printer info om ALLE medarbejder
        public override void PrintAltInfo()
        {
            Console.WriteLine($"Medarbejder Info:");
            Console.WriteLine($"Navn: {Navn}, ID: {Id}, Email: {Email}, Tlf: {Telefon}, Adresse: {Adresse}, Rolle: {Rolle}, Stilling: {Stilling}, Antal af arbejdstimer: {Antaltarbejdstimer}");

        }

        public string GetStilling
        {
            get { return Stilling; }
            set { Stilling = value; }
        }

        public int GetAntalArbejdstimer
        {
            get { return Antaltarbejdstimer; }
            set { Antaltarbejdstimer = value; }
        }
    }
}

