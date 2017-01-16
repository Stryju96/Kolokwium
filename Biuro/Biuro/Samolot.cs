using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;

        public override void ObliczCene()
        {
            if (odleglosc > 200)
                cenaBiletu = odleglosc * 6.41;
            else
                cenaBiletu = 33;
        }

        public Samolot(int iloscMiejsc, int odleglosc)
        {
            this.odleglosc = odleglosc;
            this.iloscMiejsc = iloscMiejsc;

            this.ObliczCene();
        }

        public override string ToString()
        {
            return "Samolot: ilość miejsc: "+iloscMiejsc+", odległość: "+odleglosc+", cena biletu: "+cenaBiletu+".";
        }
    }
}
