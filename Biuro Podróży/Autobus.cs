using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podróży
{
    class Autobus : SrodekLokomocji
    {
        override public void ObliczCene()
        {
            cenaBiletu = 50;
        }
        public Autobus(int iloscM)
        {
            iloscMiejsc = iloscM;
            ObliczCene();

           
        }
        public override string ToString()
        {
            return "Autobus: "+"ilość miejsc:"+iloscMiejsc+", cena biletu: "+cenaBiletu+".";
        }
    }
}
