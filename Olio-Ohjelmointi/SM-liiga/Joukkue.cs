class Joukkue
{
    public string Nimi { get; set; }
    public string Kotikaupunki { get; set; }
    private Dictionary<int, Pelaaja> Pelaajat { get; set; }

    public Joukkue()
    {
        Pelaajat = new Dictionary<int, Pelaaja>();
    }

    public Pelaaja HaePelaaja(int numero)
    {
        try
        {
            return Pelaajat[numero];
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Pelaajaa numerolla {numero} ei löytynyt.");
            return null;
        }
    }

    public void LisääPelaaja(Pelaaja pelaaja)
    {
        try
        {
            Pelaajat.Add(pelaaja.PelaajaNumero, pelaaja);
            Console.WriteLine($"Pelaaja {pelaaja.Etunimi} {pelaaja.Sukunimi} lisätty joukkueeseen.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine($"Pelaaja numerolla {pelaaja.PelaajaNumero} on jo joukkueessa.");
        }
    }

    public void PoistaPelaaja(int numero)
    {
        try
        {
            Pelaajat.Remove(numero);
            Console.WriteLine($"Pelaaja numerolla {numero} poistettu joukkueesta.");
        }
        catch (KeyNotFoundException)
        {
            Console.WriteLine($"Pelaajaa numerolla {numero} ei löytynyt joukkueesta.");
        }
    }

    public List<Pelaaja> HaePelaajat()
    {
        return new List<Pelaaja>(Pelaajat.Values);
    }
}