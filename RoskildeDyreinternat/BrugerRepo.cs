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
    public class BrugerRepo
    {
        //Dictionary bruges til at så noget op hurtigt ved hjælp af en key (Kunde ID) (Medarbejder ID)
        Dictionary<int, Kunde> _kundeListe = new Dictionary<int, Kunde>();
        Dictionary<int, Medarbejder> _medarbejderListe = new Dictionary<int, Medarbejder>();


        public void OpretKunde(int id, string navn, string email, string telefon, string adresse, string rolle, string køn, int alder)
        // Opretter en ny kunde og tilføjer den til listen, hvis ID'et ikke allerede findes
        {
            if (!_kundeListe.ContainsKey(id))
            {
                Kunde nyKunde = new Kunde(id, navn, email, telefon, adresse, rolle, alder, køn);
                _kundeListe.Add(id, nyKunde);
            }
            else
            {
                throw new ArgumentException($"Bruger med ID {id} eksisterer allerede.");
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
                Console.WriteLine($"Bruger ID: {kunde.Id}, Rolle: {kunde.Rolle}");
            }
            else
            {
                if (_medarbejderListe.TryGetValue(id, out Medarbejder medarbejder))
                {
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
                Console.WriteLine($"Bruger ID: {kunde.Id}, Navn: {kunde.Navn}, Email: {kunde.Email}, Tlf: {kunde.Telefon}, Adresse: {kunde.Adresse}, Alder: {kunde.Alder}, Køn: {kunde.Køn}");
            }
            else
            {
                if (_medarbejderListe.TryGetValue(id, out Medarbejder medarbejder))
                {
                    Console.WriteLine($"Bruger ID: {medarbejder.Id}, Navn: {medarbejder.Navn}, Email: {medarbejder.Email}, Tlf: {medarbejder.Telefon}," 
                        + $"Adresse: {medarbejder.Adresse}, Rolle: {medarbejder.Rolle}, Stilling: {medarbejder.GetStilling}, Arbejdstimer: {medarbejder.GetAntalArbejdstimer}");
                }
                else
                {
                    throw new KeyNotFoundException($"Bruger med ID {id} blev ikke fundet.");
                }
            }

        }


















    }
}
