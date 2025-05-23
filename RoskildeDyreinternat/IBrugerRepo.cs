using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public interface IBrugerRepo
    {
        void OpretKunde(int id, string navn, string email, string telefon, string adresse, string rolle, string køn, int alder)
   void OpretMedarbejder(int id, string navn, string email, string telefon, string adresse, string rolle, string stilling, int antalarbejdstimer)
   void VisBrugerInfo(int id)
   void OpdaterKundeInfo(int id, string navn, string email, string telefon, string adresse)
   void SletKunde(int id)
   void VisBrugerRolle(int id)
   void VisBrugerInfo(int id)
    }
}
