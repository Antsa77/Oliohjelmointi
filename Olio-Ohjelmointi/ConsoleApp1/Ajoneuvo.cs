using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ajoneuvo
    {
        public string Nimi { get; set; }
        public int Renkaat { get; set; }
        public int Nopeus { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("Nimi: "+ Nimi);
            Console.WriteLine("Renkaat: " + Renkaat);
            Console.WriteLine("Nopeus: " + Nopeus);

        }

        public string ToString()
        {
            string merkkijono = "Ajoneuvo nimi: " + Nimi + " Renkaat : " + Renkaat + " kpl" + " Nopeus: " + Nopeus + " km/h";
            return merkkijono;
        }
    }
}
