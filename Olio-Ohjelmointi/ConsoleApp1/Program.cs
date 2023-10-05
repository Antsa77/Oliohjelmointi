using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Ajoneuvo auto = new Ajoneuvo();
        auto.Nimi = "BMW";
        auto.Renkaat = 4;
        auto.Nopeus = 230;

        auto.TulostaData();

        string autonTiedot = auto.ToString();

        Console.WriteLine(autonTiedot);

        Console.WriteLine();

        Ajoneuvo mopo = new Ajoneuvo();
        mopo.Nimi = "Derbi";
        mopo.Nopeus = 45;
        mopo.Renkaat = 2;

        mopo.TulostaData();

        Console.WriteLine(mopo.ToString());
    }
}