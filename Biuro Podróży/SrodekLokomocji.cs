using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podróży
{
   class SrodekLokomocji
    {
       protected int iloscMiejsc;
       protected double cenaBiletu;
       public SrodekLokomocji()
       {
           iloscMiejsc = 0;
           cenaBiletu = 0;
       }

       virtual void ObliczCene();

       public double Cena()
       {
           return cenaBiletu;
       }
    }
}
