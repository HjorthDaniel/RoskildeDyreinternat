using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class BesogRepo
    {
        List<Besog> _besogListe = new List<Besog>();
        public bool AddBesog(Besog besog)
        {
            if (besog != null && !_besogListe.Contains(besog))
            {
                _besogListe.Add(besog);
                    return true;
            }
            return false;
        }
        public List<Besog> HentBesogForKunde(Kunde kunde)
        {
            return _besogListe.Where(b => b.Kunde == kunde).ToList();
        }

       public string ToString()
        {
            string sb = "";
            foreach (var besog in _besogListe)
            {
                sb += ($"Besøg #{besog.Besogsnummer} - {besog.Dato} ");
                sb += ($"Kunde: {besog.Kunde.Navn} ");
                sb += ($"Dyr: {besog.Dyr.Navn}");
                sb += ("\n");
            }
            return sb.ToString();
        }


    }
}
