using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podróży
{
    class Podroz : IZarzadzaj, IData
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 0;
        public void DodajAutobus(int iloscMiejsc)
        {

            planPodrozy.Add(new Autobus(iloscMiejsc));
            koszt += Autobus.ObliczCene();
        }

        void DodajPociag(int iloscMiejsc, int dlugoscTrasy)
        {
            planPodrozy.Add(new Pociag(iloscMiejsc, dlugoscTrasy));
            koszt += Pociag.ObliczCene();
        }
        void UsunOstatni()
        {
            planPodrozy.Last().Remove();
        }

        void Wyczysc()
        {
            
            planPodrozy.Clear();
        }
        void UsatwDate(DateTime data)
        {
            try
            {
                dataPodrozy = data;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Zle wprowadzone dane!");
            }
        }


        bool SprawdzDate()
        {
            if (dataPodrozy > DateTime.Now)
            {
                return true;
            }
            return false;
        }
        override string ToString()
        {
            foreach (SrodekLokomocji elm in planPodrozy)
            {
                return 
            }
        }
    }
}