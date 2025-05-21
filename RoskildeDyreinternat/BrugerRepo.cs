using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class BrugerRepo
    {
        Dictionary<int, Kunde> _kundeListe = new Dictionary<int, Kunde>();

        public void AddKunde(Kunde kunde)
        {
           _kundeListe.Add(kunde.Id, kunde);
        }


        public void VisBrugerInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefon: {Telefon}");
            Console.WriteLine($"Adresse: {Adresse}");
            Console.WriteLine($"Rolle: {Rolle}");
        }

        public void OpdaterBrugerInfo(string navn, string email, string telefon, string adresse)
        {
            Navn = navn;
            Email = email;
            Telefon = telefon;
            Adresse = adresse;
        }

        public void SletBruger()
        {
            // Logik til at slette brugeren fra systemet
            Console.WriteLine($"Bruger {Navn} er blevet slettet.");
        }

        public void VisBrugerRolle()
        {
            Console.WriteLine($"Rolle:  {Rolle}");
        }

        public void OpdaterBrugerRolle(string rolle)
        {
            Rolle = rolle;
            Console.WriteLine($"Brugerens rolle er blevet opdateret til: {Rolle}");
        }

    }
}
