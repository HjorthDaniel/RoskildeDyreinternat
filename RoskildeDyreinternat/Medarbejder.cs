using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Medarbejder : Bruger
    {
        private string _stilling;
        private DateTime _ansættelsesdato;
        private string _afdeling;
        public Medarbejder(int id, string navn, string email, string telefon, string adresse, bool erAdmin,
                         string stilling, DateTime ansættelsesdato, string afdeling)
          : base(id, navn, email, telefon, adresse, erAdmin)
        {
            _stilling = stilling;
            _ansættelsesdato = ansættelsesdato;
            _afdeling = afdeling;
        }



    }


    
}

