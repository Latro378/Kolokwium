using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biuro_Podróży
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int wyb=0;
            Console.WriteLine("Co Chcesz zrobić?");
            Console.WriteLine("Dodaj Autobus - 1");
            Console.WriteLine("Dodaj Pociąg - 2");
            Console.WriteLine("Usun Ostatni - 3");
            Console.WriteLine("Wyczysc - 4");
            Console.WriteLine("Usaw Date -5 ");
            Console.WriteLine("Sprawdz date - 6");
            try
            {
                wyb = Console.Read();
            }
            catch
            {}
            switch (wyb)
            {
                case 1:
                    Console.WriteLine("Prosze podac liczbe iloscMiejsc w Autobusie");
            
                int liczbaM = Console.Read();
          
            Podroz.DodajAutobus(liczbaM);
                break;
                case 2:
                
                break;
            }

        }
    }
}
