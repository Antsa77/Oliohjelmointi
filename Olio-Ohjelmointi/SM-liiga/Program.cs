class Program
{
    static void Main()
    {
        Joukkue joukkue = new Joukkue
        {
            Nimi = "Esimerkkijoukkue",
            Kotikaupunki = "Esimerkkikaupunki"
        };

        Pelaaja pelaaja1 = new Pelaaja
        {
            Etunimi = "Jaakko",
            Sukunimi = "Jäätinen",
            PelaajaNumero = 1
        };

        Pelaaja pelaaja2 = new Pelaaja
        {
            Etunimi = "lauri",
            Sukunimi = "Lapanen",
            PelaajaNumero = 2
        };

        joukkue.LisääPelaaja(pelaaja1);
        joukkue.LisääPelaaja(pelaaja2);

        List<Pelaaja> pelaajat = joukkue.HaePelaajat();
        Console.WriteLine("Joukkueen pelaajat:");
        foreach (var pelaaja in pelaajat)
        {
            Console.WriteLine($"{pelaaja.PelaajaNumero}: {pelaaja.Etunimi} {pelaaja.Sukunimi}");
        }

        int etsittavaNumero = 1;
        Pelaaja etsittavaPelaaja = joukkue.HaePelaaja(etsittavaNumero);

        if (etsittavaPelaaja != null)
        {
            Console.WriteLine($"Pelaaja numerolla {etsittavaNumero}: {etsittavaPelaaja.Etunimi} {etsittavaPelaaja.Sukunimi}");
        }

        int poistettavaNumero = 2;
        joukkue.PoistaPelaaja(poistettavaNumero);


        pelaajat = joukkue.HaePelaajat();
        Console.WriteLine("Joukkueen pelaajat poiston jälkeen:");
        foreach (var pelaaja in pelaajat)
        {
            Console.WriteLine($"{pelaaja.PelaajaNumero}: {pelaaja.Etunimi} {pelaaja.Sukunimi}");
        }
    }
}