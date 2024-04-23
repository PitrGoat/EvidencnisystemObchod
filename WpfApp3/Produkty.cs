using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    
    public class Produkt
    {
        public string Název { get; set; }
        public string Počet { get; set; }
        public int Cena { get; set; }
        public int Množství { get; set; }

        public Produkt(string název, string počet, int cena, int množství)
        {
            Název = název;
            Počet = počet;
            Cena = cena;
            Množství = množství;
        }

        public override string ToString()
        {
            return $"{Název} {Počet} {Cena} {Množství}";
        }
    }
}
