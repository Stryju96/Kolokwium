using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro 
{
    class Express : SrodekLokomocji
    {
        public Express(int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
            base.ObliczCene();
        }

        public override string ToString()
        {
            return "Express: ilość miejsc: " + this.iloscMiejsc + ", cena biletu: " + this.cenaBiletu;
        }
    }
}
