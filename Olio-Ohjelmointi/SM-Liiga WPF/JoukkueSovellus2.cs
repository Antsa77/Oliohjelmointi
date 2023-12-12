using System;
using System.Collections.Generic;

namespace JoukkueSovellus2
{
    [Serializable]
    public class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }

        public override string ToString()
        {
            return $"{Nimi} - {Kotikaupunki}";
        }
    }
}