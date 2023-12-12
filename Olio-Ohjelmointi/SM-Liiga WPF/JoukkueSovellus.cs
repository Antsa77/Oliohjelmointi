using System;
using System.Collections.Generic;

namespace JoukkueSovellus
{
    [Serializable]
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int PelaajaNumero { get; set; }
        public string Joukkue { get; set; }

        public override string ToString()
        {
            return $"{Etunimi} {Sukunimi} ({PelaajaNumero}), Joukkue: {Joukkue}";
        }
    }
}