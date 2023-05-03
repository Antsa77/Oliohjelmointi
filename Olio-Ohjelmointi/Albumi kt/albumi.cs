using System;
using System.Collections.Generic;

class Kappale
{
    public string nimi;
    public string artisti;
    public int pituus; // sekunteina

    public Kappale(string nimi, string artisti, int pituus)
    {
        this.nimi = nimi;
        this.artisti = artisti;
        this.pituus = pituus;
    }

    public override string ToString()
    {
        return $"{nimi} ({artisti}) - {pituus / 60}:{pituus % 60:D2}";
    }
}

class Albumi
{
    public string nimi;
    public string artisti;
    public int vuosi;
    public List<Kappale> kappaleet = new List<Kappale>();

    public Albumi(string nimi, string artisti, int vuosi)
    {
        this.nimi = nimi;
        this.artisti = artisti;
        this.vuosi = vuosi;
    }

    public void LisääKappale(Kappale kappale)
    {
        kappaleet.Add(kappale);
    }

    public void Tulosta()
    {
        Console.WriteLine($"{nimi} ({artisti}), {vuosi}");
        foreach (Kappale kappale in kappaleet)
        {
            Console.WriteLine(" - " + kappale.ToString());
        }
    }
}
