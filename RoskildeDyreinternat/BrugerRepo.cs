using System;
using System.Collections.Generic;
using System.ComponentModel;
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


     
    }
}
