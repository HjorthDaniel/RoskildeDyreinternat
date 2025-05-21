using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Kunde : Bruger
    {
        private int _alder;
        private string _køn;    
    

    //kontruktor til kunde

        public Kunde(int id, string navn, string email, string telefon, string adresse, bool erMedarbejder) : base(id, navn, email, telefon, adresse, )
        {

        }
    }
}
