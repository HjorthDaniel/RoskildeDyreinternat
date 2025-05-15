using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Bruger
    {
        public int Id;
        public string Navn;
        public string Email;
        public string Telefon;
        public string Adresse;
        public bool ErAdmin;


        public Bruger(int id, string navn, string email, string telefon, string adresse, bool erAdmin)
        {
            Id = id;
            Navn = navn;
            Email = email;
            Telefon = telefon;
            Adresse = adresse;
            ErAdmin = erAdmin;
        }

        public void VisBrugerInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefon: {Telefon}");
            Console.WriteLine($"Adresse: {Adresse}");
            Console.WriteLine($"Er Admin?: {ErAdmin}");
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
            Console.WriteLine($"Er Admin?:  {ErAdmin}");
        }

        public void OpdaterBrugerRolle(bool erAdmin)
        {
            ErAdmin = erAdmin;
            Console.WriteLine($"Brugerens rolle er blevet opdateret til: {ErAdmin}");
        }

        
    }


}
