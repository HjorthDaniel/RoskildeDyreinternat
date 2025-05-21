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

            Kunde kunde = new Kunde(1, "Ida", "IdaEmail", "1234567", "Højvej 1", false);
            Besog besog = new Besog(1, "2023-10-01", "10:00", "11:00");

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
