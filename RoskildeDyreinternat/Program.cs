using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RoskildeDyreinternat
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Alle Objekter 
            // Opretter en ny instans af KundeRepo
            BrugerRepo brugerRepo = new BrugerRepo();
            BesogRepo besogRepo = new BesogRepo();
            DyrRepo dyrRepo = new DyrRepo();    
            

            //Dette er de kunder, der er oprettet
            //Kunde kunde1 = new Kunde(99, "Ida", "IdaEmail", "1234567", "Højvej 1", "Kunde", 23, "Mand");
            //Kunde kunde2 = new Kunde(98, "Lone", "LoneEmail", "7654321", "Blomstervej","Kunde", 67, "Kvinde");

            ////Dette er de medarbejder, der er oprettet
            //Medarbejder medarbejder1 = new Medarbejder(1, "Emil", "emil@hund.dk", "+45 232323", "Denvej 7", "Frivillig","Frivillig", 0);
            //Medarbejder medarbejder2 = new Medarbejder(2, "Emma", "emma@kat.dk", "+45 34 34 34 34", "Gladvej 2", "Medarbejder", "Dyrpasser", 37);
            //Medarbejder medarbejder3 = new Medarbejder(3, "Erik", "erik@doctor.dk", "+45 11 11 22 22", "Flotvej 63","Medarbejder","Dyrlæge", 35);

            //Oprettede dyr nedenunder:

            ////Dette er de hunde, der er oprettet
            //Hund hund1 = new Hund(true, true, "Stella", "race", 1, "hundhund", 3, "sund", false);
            //Hund hund2 = new Hund(false, false, "Dennis", "ukendt", 2, "hanhund", 6, "mangler et ben", false);
            //Hund hund3 = new Hund(true, false, "Bob", "ukendt", 3, "hanhund", 2, "sund", false);
            
            
            ////Dette er de katte, der er oprettet
            //Kat kat1 = new Kat(true, true , "Denas", "Siamese", 123, "han", 5, "Sund", false);
            //Kat kat2 = new Kat(true, false, "Hansen", "Norsk Skovkat", 456, "han", 2, "Mangler et øje" ,false);
            //Kat kat3 = new Kat(false, true, "Emil", "Maine Coon", 789, "han", 12, "Har sukkersyge", false);


            //Dette er de besog, der er oprettet
            //Besog besog1 = new Besog(new DateTime(2025, 4, 15), kunde1,hund3);
            //Besog besog2 = new Besog(new DateTime(2025, 3, 17), kunde2, kat1);
            #endregion

            //Oprettelse af dyr (Både hunde og katte), både som objekt i sin egen klasse og i dyrRepo.

            dyrRepo.OpretHund(true, true, "Stella", "race", 1, "hundhund", 3, "sund", false);
            dyrRepo.OpretHund(false, false, "Dennis", "ukendt", 2, "hanhund", 6, "mangler et ben", false);
            dyrRepo.OpretHund(true, false, "Bob", "ukendt", 3, "hanhund", 2, "sund", false);

            dyrRepo.OpretKat(true, true, "Denas", "Siamese", 123, "han", 5, "Sund", false);
            dyrRepo.OpretKat(true, false, "Hansen", "Norsk Skovkat", 456, "han", 2, "Mangler et øje", false);
            dyrRepo.OpretKat(false, true, "Emil", "Maine Coon", 789, "han", 12, "Har sukkersyge", false);


            //Oprettelse af brugere (Både kunder og medarbejdere), både som objekt i egen klasse og i brugerRepo.

            brugerRepo.OpretKunde(99, "Ida", "IdaEmail", "1234567", "Højvej 1", "Kunde", "Kvinde", 22);
            brugerRepo.OpretKunde(98, "Lone", "LoneEmail", "7654321", "Blomstervej", "Kunde", "Kvinde", 67);

            brugerRepo.OpretMedarbejder(1, "Emil", "emil@hund.dk", "+45 232323", "Denvej 7", "Frivillig", "Frivillig", 0);
            brugerRepo.OpretMedarbejder(2, "Emma", "emma@kat.dk", "+45 34 34 34 34", "Gladvej 2", "Medarbejder", "Dyrpasser", 37);
            brugerRepo.OpretMedarbejder(3, "Erik", "erik@doctor.dk", "+45 11 11 22 22", "Flotvej 63", "Medarbejder", "Dyrlæge", 35);

            //Kan søges frem via. 



            
            brugerRepo.VisBrugerInfo(1);

            brugerRepo.VisBrugerInfo(2);

            brugerRepo.VisBrugerInfo(3);

            brugerRepo.VisBrugerInfo(4);

    

            //Skaber Mellemrum
            Console.WriteLine();
            //Oprettelse af brugere (Både kunder og medarbejdere), både som objekt i egen klasse og i brugerRepo.

     


            Console.WriteLine("Søger dyr frem:");

            dyrRepo.VisDyrInfo(123);
            dyrRepo.VisDyrInfo(456);
            dyrRepo.VisDyrInfo(1);
            dyrRepo.VisDyrInfo(2);
            dyrRepo.VisDyrInfo(6);
           

            //Skaber Mellemrum
            Console.WriteLine();

            //Console.WriteLine(hund3.PrintAltInfo());
            //Console.WriteLine(hund3.Lavlyd());
        



            // Dette bruges til at fange og håndtere fejl - fx forsger man her, at tilføje en kunde med et ID som allreede findes 
            //try
            //{
            //brugerRepo.OpretKunde(kunde1);
            //brugerRepo.OpretKunde(kunde2);

            //besogRepo.AddBesog(besog1);



            //    //Lav det som en kommentar og prøv at kør den. Fixed, kør!
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Der opstod en fejl, dette ID eksisterer allerede til en kunde/medarbejder:");
            //}

            #region Switch menu
            {
            
                Console.WriteLine("Velkommen til DyreAdoptionsSystemet!");
                Console.WriteLine("Vælg din rolle:");
                Console.WriteLine("1. Gæst");
                Console.WriteLine("2. Kunde");
                Console.WriteLine("3. Medarbejder");

                string rolleValg = Console.ReadLine();

                switch (rolleValg)
                {
                    case "1": // Gæst
                        Console.WriteLine("Opret ny konto");
                        Console.Write("Indtast navn: ");
                        string navn = Console.ReadLine();
                        Console.Write("Indtast mail: ");
                        string mail = Console.ReadLine();
                        Console.Write("Indtast adresse: ");
                        string adresse = Console.ReadLine();
                        Console.Write("Indtast telefonnummer: ");
                        string telefon = Console.ReadLine();

                        Console.WriteLine($"Tak {navn}, din konto er oprettet!");
                        break;

                    case "2": // Kunde
                        Console.WriteLine("Hvad vil du gerne gøre?");
                        Console.WriteLine("1. Se alle dyr");
                        Console.WriteLine("2. Filtrér dyr");
                        Console.WriteLine("3. Book besøg");

                        string kundeValg = Console.ReadLine();
                        switch (kundeValg)
                        {
                            case "1":
                                Console.WriteLine("Her er alle dyr til adoption...");
                                // Her kunne du vise liste over dyr
                                break;
                            case "2":
                                Console.WriteLine("Filtrér dyr (fx efter art, alder)...");
                                // Her kunne du tilføje filtreringslogik
                                break;
                            case "3":
                                Console.Write("Vælg dato (dd-mm-åååå): ");
                                string dato = Console.ReadLine();
                                Console.Write("Vælg tidspunkt (fx 14:00): ");
                                string tid = Console.ReadLine();
                                Console.Write("Vælg hvilket dyr du vil besøge: ");
                                string dyrNavn = Console.ReadLine();

                                Console.WriteLine($"Du har booket et besøg med {dyrNavn} den {dato} kl. {tid}");
                                break;
                            default:
                                Console.WriteLine("Ugyldigt valg.");
                                break;
                        }
                        break;

                    case "3": // Medarbejder
                        Console.WriteLine("Medarbejdermenu:");
                        Console.WriteLine("1. Opret nyt dyr");
                        Console.WriteLine("2. Rediger oplysninger om dyr");
                        Console.WriteLine("3. Se kundeoplysninger");

                        string medarbejderValg = Console.ReadLine();
                        switch (medarbejderValg)
                        {
                            case "1":
                                Console.Write("Indtast navn på dyret: ");
                                string dyrenavn = Console.ReadLine();
                                Console.Write("Indtast race: ");
                                string race = Console.ReadLine();
                                Console.Write("Indtast chipnummer: ");
                                string chip = Console.ReadLine();

                                Console.WriteLine($"{dyrenavn} er nu oprettet som 'ledig'.");
                                break;

                            case "2":
                                Console.Write("Indtast navn på dyret du vil redigere: ");
                                string redigerNavn = Console.ReadLine();
                                Console.Write("Opdateret alder: ");
                                string alder = Console.ReadLine();
                                Console.Write("Opdateret helbredstilstand: ");
                                string helbred = Console.ReadLine();

                                Console.WriteLine($"{redigerNavn}'s oplysninger er opdateret.");
                                break;

                            case "3":
                                Console.Write("Indtast kundens navn: ");
                                string kundenavn = Console.ReadLine();
                                Console.WriteLine($"Viser oplysninger for {kundenavn}...");
                                // Her kunne du vise kontaktoplysninger og bookinger
                                break;

                            default:
                                Console.WriteLine("Ugyldigt valg.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Ugyldig rolle valgt.");
                        break;
                }
            }
        }
        #endregion
    }
}
