using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class BrugerRepo : IBrugerRepo
    {
        //Dictionary bruges til at så noget op hurtigt ved hjælp af en key (Kunde ID) (Medarbejder ID)
        Dictionary<int, Kunde> _kundeListe = new Dictionary<int, Kunde>();
        Dictionary<int, Medarbejder> _medarbejderListe = new Dictionary<int, Medarbejder>();

        private BesogRepo _besogRepo;

        public BrugerRepo(BesogRepo besogRepo)
        {
            _besogRepo = besogRepo;
        }


        public void OpretKunde(Kunde kunde)
        // Opretter en ny kunde og tilføjer den til listen, hvis ID'et ikke allerede findes
        {
            if (!_kundeListe.ContainsKey(kunde.Id))
            {
                 _kundeListe.Add(kunde.Id, kunde);
            }
            else
            {
                throw new ArgumentException($"Bruger med ID {kunde.Id} eksisterer allerede.");
            }
        }

        public void OpretMedarbejder(Medarbejder medarbejder)
        {   
            if(!_medarbejderListe.ContainsKey(medarbejder.Id))
            {
                _medarbejderListe.Add(medarbejder.Id, medarbejder);
            }
            else
            {
                throw new ArgumentException($"Medarbejder med ID {medarbejder.Id} eksisterer allerede.");
            } 
        }

        public void OpdaterKundeInfo(int id, string navn, string email, string telefon, string adresse)
        {
            if (_kundeListe.TryGetValue(id, out Kunde kunde))
            {
                kunde.Navn = navn;
                kunde.Email = email;
                kunde.Telefon = telefon;
                kunde.Adresse = adresse;
            }
            else
            {
                throw new KeyNotFoundException($"Bruger med ID {id} blev ikke fundet.");
            }
        }

        public void SletKunde(int id)
        {
            if (_kundeListe.TryGetValue(id, out Kunde kunde))
            {
                _kundeListe.Remove(id);
            }
            else
            {
                throw new KeyNotFoundException($"Bruger med ID {id} blev ikke fundet.");
            }
        }
        //søgfunktion ud fra rollen
        public void VisBrugerRolle(int id)
        {
            if (_kundeListe.TryGetValue(id, out Kunde kunde))
            {
                Console.WriteLine($"Du har søgt efter ID: {id}:");
                Console.WriteLine($"Bruger ID: {kunde.Id}, Rolle: {kunde.Rolle}");
            }
            else
            {
                if (_medarbejderListe.TryGetValue(id, out Medarbejder medarbejder))
                {
                    Console.WriteLine($"Du har søgt efter ID: {id}:");
                    Console.WriteLine($"Bruger ID: {medarbejder.Id}, Rolle: {medarbejder.Rolle}");
                }
                else
                {
                    throw new KeyNotFoundException($"Bruger med ID {id} blev ikke fundet.");
                }
            }  
        }
        //søgfunktion ud fra ID
        public void VisBrugerInfo(int id)
        {
            if (_kundeListe.TryGetValue(id, out Kunde kunde))
            {
                Console.WriteLine($"Du har søgt efter ID: {id}:");
                Console.WriteLine();
                Console.WriteLine($"Bruger ID: {kunde.Id}\n Navn: {kunde.Navn}\n Email: {kunde.Email}\n Tlf: {kunde.Telefon}\n Adresse: {kunde.Adresse}\n Alder: {kunde.Alder}\n Køn: {kunde.Køn}");
                Console.WriteLine();
                var kundeBesog = _besogRepo.HentBesogForKunde(kunde);
                Console.WriteLine("Bookinger:");
                if (kundeBesog.Count == 0)
                {
                    Console.WriteLine("Ingen bookinger fundet.");
                }
                else
                {
                    foreach (var besog in kundeBesog)
                    {
                        Console.WriteLine($"- Dato: {besog.Dato}, Dyr: {besog.PrintBesogsInfo()}");
                    }
                }

            }
            else if (_medarbejderListe.TryGetValue(id, out Medarbejder medarbejder))
            {
                Console.WriteLine($"Du har søgt efter ID: {id}:");
                Console.WriteLine();
                Console.WriteLine($"Bruger ID: {medarbejder.Id}\n Navn: {medarbejder.Navn}\n Email: {medarbejder.Email}\n Tlf: {medarbejder.Telefon}\n"
                    + $" Adresse: {medarbejder.Adresse}\n Rolle: {medarbejder.Rolle}\n Stilling: {medarbejder.Stilling}\n Arbejdstimer: {medarbejder.Antalarbejdstimer}");
                Console.WriteLine();
            }
            else
            {
                throw new KeyNotFoundException($"Bruger med ID {id} blev ikke fundet.");
            }
        }


        
















    }
}
