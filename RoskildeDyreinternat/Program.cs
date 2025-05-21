using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RoskildeDyreinternat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opretter en ny instans af KundeRepo
            BrugerRepo kundeRepo = new BrugerRepo();
            BesogRepo besogRepo = new BesogRepo();

            //Dette er de kunder, som der er oprettet
            Kunde kunde1 = new Kunde(1, "Ida", "IdaEmail", "1234567", "Højvej 1", "Kunde", 23);
            Kunde kunde2 = new Kunde(2, "Lone", "LoneEmail", "7654321", "Blomstervej","Kunde", 67);

            //Dette er de medarbejder, som der er oprettet
            Medarbejder medarbejder1 = new Medarbejder(1, "Emil", "email@hund.dk", "+45 12 34 56 78", "vej 3", "frivillig", 0);
            Medarbejder medarbejder2 = new Medarbejder(2, "Emma", "emma@kat.dk", "+45 34 34 34 34", "Gladvej 2", "dyrpasser", 37);
            Medarbejder medarbejder3 = new Medarbejder(3, "Erik", "erik@doctor.dk", "+45 11 11 22 22", "Flotvej 63", "dyrlæge", 35)

            //Dette er de besog, som der er oprettet
            Besog besog1 = new Besog(1, "2023-10-01", "10:00", "11:00");
            Besog besog2 = new Besog(2, "2025-02-003", "12:15", "13:15");

            //Dette er de hunde, som der er oprettet
            Hund hund1 = new Hund(true, true, "Stella", "race", 1, "hundhund", "sund", false);
            Hund hund2 = new Hund(false, false, "Dennis", "ukendt", 2, "hanhund", "mangler et ben", false);
            Hund hund3 = new Hund(true, false, "Bob", "ukendt", 3, "hanhund", "sund", false);

            //Dette er de katte, som der er oprettet
            Kat kat1 = new Kat("Tove", "Siameser", 12, "hun", 9, "Sund", "Kan med andre katte", "Er indekat");
            Kat kat2 = new Kat("", "Norsk Skovkat", 12, "han", 2, "Mangler et øje", "Kan med andre katte", "Er indekat");
            Kat kat3 = new Kat("Emil", "Siameser", 12, "hun", 9, "Sund", "Kan med andre katte", "Er indekat");
            
            try
            {
                kundeRepo.AddKunde(kunde);
                // kundeRepo.AddKunde(kunde);

                besogRepo.AddBesog(besog);
                


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Der opstod en fejl, dette ID eksisterer allerede til en kunde:");
            }



        }
    }
}
