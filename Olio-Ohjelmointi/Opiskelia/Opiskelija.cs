using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    internal class Opiskelija
    {
        private string Nimi { get; set; }
        private string OpiskelijaID { get; set; }
        private int Opintopisteet { get; set; }

        public Opiskelija(string _nimi, string _id, int _op)
        {
            OpiskelijaID = _id;
            Opintopisteet = _op;
            Nimi = _nimi;
        }
        public void TulostaData()
        {
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("OpiskelijaID: " + OpiskelijaID);
            Console.WriteLine("Opintopisteet: " + Opintopisteet);
            Console.WriteLine();
        }
        public void muokkaaopintopistetitä(int i)
        {
            Opintopisteet += i;

            if (Opintopisteet < 0)
            {
                Opintopisteet = 0;
            }
        }
    }
}

