internal class Program
{
    private static void Main(string[] args)
    {
        Albumi albumi = new Albumi("Vastustamaton", "Gettomasa", 1982);
        albumi.LisääKappale(new Kappale("Vastustamaton", "Gettomasa", 203));
        albumi.LisääKappale(new Kappale("Rantatontti", "Gettomasa", 357));
        albumi.LisääKappale(new Kappale("Shamppanjadietillä", "Gettomasa", 258));
        albumi.LisääKappale(new Kappale("Hyvä me", "Gettomasa", 295));
        albumi.LisääKappale(new Kappale("Ei leiki", "Gettomasa", 295));
        albumi.LisääKappale(new Kappale("Ne otti hoon pois", "Gettomasa", 295));
        albumi.Tulosta();

        Console.ReadLine();

    }
}