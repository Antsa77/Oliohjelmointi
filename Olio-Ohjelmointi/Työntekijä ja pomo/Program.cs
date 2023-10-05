class Program
{
    static void Main(string[] args)
    {
        Työntekijä työntekijä = new Työntekijä("Matti", "Tehtaan työntekijä", 2500, 40);
        Pomo pomo = new Pomo("Juha", "Toimitusjohtaja", 8000, 2000, "Mersu");

        double työntekijänPalkka = työntekijä.LaskePalkka();
        double pomonPalkka = pomo.LaskePalkka();

        Console.WriteLine("Työntekijän kuukausipalkka: " + työntekijänPalkka);
        Console.WriteLine("Pomon kuukausipalkka: " + pomonPalkka);
    }
}