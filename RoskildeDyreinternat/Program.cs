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

            

            //Dette er de kunder, der er oprettet
            Kunde kunde1 = new Kunde(99, "Ida", "IdaEmail", "1234567", "Højvej 1", "Kunde", 23, "Mand");
            Kunde kunde2 = new Kunde(98, "Lone", "LoneEmail", "7654321", "Blomstervej","Kunde", 67, "Kvinde");

            //Dette er de medarbejder, der er oprettet
            Medarbejder medarbejder1 = new Medarbejder(1, "Emil", "emil@hund.dk", "+45 232323", "Denvej 7", "Frivillig","Frivillig", 0);
            Medarbejder medarbejder2 = new Medarbejder(2, "Emma", "emma@kat.dk", "+45 34 34 34 34", "Gladvej 2", "Medarbejder", "Dyrpasser", 37);
            Medarbejder medarbejder3 = new Medarbejder(3, "Erik", "erik@doctor.dk", "+45 11 11 22 22", "Flotvej 63","Medarbejder","Dyrlæge", 35);

            //Dette er de hunde, der er oprettet
            Hund hund1 = new Hund(true, true, "Stella", "race", 1, "hundhund", 3, "sund", false);
            Hund hund2 = new Hund(false, false, "Dennis", "ukendt", 2, "hanhund", 6, "mangler et ben", false);
            Hund hund3 = new Hund(true, false, "Bob", "ukendt", 3, "hanhund", 2, "sund", false);
            
            
            //Dette er de katte, der er oprettet
            Kat kat1 = new Kat(true, true , "Denas", "Siamese", 123, "han", 5, "Sund", false);
            Kat kat2 = new Kat(true, false, "Hansen", "Norsk Skovkat", 456, "han", 2, "Mangler et øje" ,false);
            Kat kat3 = new Kat(false, true, "Emil", "Maine Coon", 789, "han", 12, "Har sukkersyge", false);


            //Dette er de besog, der er oprettet
            Besog besog1 = new Besog(new DateTime(2025, 4, 15), kunde1,hund3);
            Besog besog2 = new Besog(new DateTime(2025, 3, 17), kunde2, kat1);


            
            
            


            


            //try
            //{
            //    kundeRepo.AddKunde(kunde);
            //    // kundeRepo.AddKunde(kunde);

            //    besogRepo.AddBesog(besog);
                


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Der opstod en fejl, dette ID eksisterer allerede til en kunde:");
            //}



        }
    }
}
