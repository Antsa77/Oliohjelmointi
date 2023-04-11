using Eläintesti;

namespace Eläintesti
{
    class Koira
    {
        public string Nimi { get; set; }
        public string Rotu { get; set; }
        public float Paino { get; set; }
        public string Väri { get; set; }
        public float Ikä { get; set; }

        public string HaeTiedot()
        {
            string KoiranTiedot = " Nimi: "+Nimi + "\n Rotu: " + Rotu + "\n Paino: " + Paino + "\n Väri: " + Väri + "\n Ikä: " + Ikä.ToString();
            return KoiranTiedot;
        }
        public void Hauku()
        {
            Console.WriteLine("Woof Woof!");
        }
    }
}
