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
        //søgning





        public void OpdaterBrugerInfo(int id, string navn, string email, string telefon, string adresse)
        {
            if (_kundeListe.TryGetValue(id, out Kunde kunde))
            {
                kunde.Navn = navn;
                kunde.Email = email;
                kunde.Telefon = telefon;
                kunde.Adresse = adresse;
            }
        }

        public void SletBruger(string id)
        {
            if (_kundeliste.TryGetValue(id, out Kunde kunde))
            {
                _kundeliste.Remove(id);
            }
        }






        public void VisBrugerRolle()
        {
      
        }

        public void OpdaterBrugerRolle(string rolle)
        {
            
        }

    }
}
