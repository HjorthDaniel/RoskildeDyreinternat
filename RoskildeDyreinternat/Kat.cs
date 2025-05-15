using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Kat : Dyr
    {
        public bool kanMedAndreKatte;
        public bool skalVæreIndekat;

        public Kat (bool kanMedAndreKatte, bool skalVæreIndekat)
        {
            KanMedAndreKatte = this.kanMedAndreKatte;
            SkalVæreIndekat = this.skalVæreIndekat;
            
        }

        public bool KanMedAndreKatte
        {
            get { return this.KanMedAndreKatte; }
            set { this.KanMedAndreKatte = value; }
        }
        public bool SkalVæreIndekat
        {
            get { return this.SkalVæreIndekat; }
            set { this.SkalVæreIndekat = value; }
        }
    }

}
