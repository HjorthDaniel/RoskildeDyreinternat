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
                _besogListe.Add(besog)
                    return true;
            }
            return false;
        }
        
    }
}
