using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskildeDyreinternat
{
    public class Hund : Dyr
    {
        public bool kanMedAndreHunde;
        public bool erTrænet;


        public bool KanMedAndreHunde
        {
            get { return this.KanMedAndreHunde; }
            set { this.KanMedAndreHunde = value; }
        }

        public bool ErTrænet
        {
            get { return this.ErTrænet; }
            set { this.ErTrænet = value; }
        }

    }
}
