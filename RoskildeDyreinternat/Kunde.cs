using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Kunde : Bruger
    {
        public List<Besog> BookedeBesøg;


        public Kunde(int id, string navn, string email, string telefon, string adresse, bool erAdmin) : base(id, navn, email, telefon, adresse, erAdmin)
        {
            BookedeBesøg = new List<Besog>();
        }

        public void BookBesog(Besog besog)
        {
            BookedeBesøg.Add(besog);
        }

        public void AfbestilBesog(Besog besog)
        {
            BookedeBesøg.Remove(besog);
        }
    }
}
