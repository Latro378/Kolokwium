using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podróży
{
    class Pociag:SrodekLokomocji
    {
        private int dlugoscTrasy;

        override public void ObliczCene()
        {
            if(dlugoscTrasy>100){
                cenaBiletu = (dlugoscTrasy * 1.43);
            }
            else
            {
                cenaBiletu = 50;
            }

        }
        public Pociag(int iloscM,int dlugoscTrasy)
        {
            iloscMiejsc = iloscM;
            ObliczCene();
        }
        public override string ToString()
        {
            return "Pociag: ilosc miejsc:"+iloscMiejsc+", dlugosc trasy: "+dlugoscTrasy+", cena biletu: "+cenaBiletu+".";
        }
    }
}
