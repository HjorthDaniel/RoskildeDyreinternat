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
        private int _antalarbejdstimer;
       

        public Medarbejder(int id, string navn, string email, string telefon, string adresse, bool erAdmin,
                         string stilling,int antalarbejdstimer)
          : base(id, navn, email, telefon, adresse, erAdmin)
        {
            _stilling = stilling;
            _antalarbejdstimer = antalarbejdstimer;
        }



    }


    
}

