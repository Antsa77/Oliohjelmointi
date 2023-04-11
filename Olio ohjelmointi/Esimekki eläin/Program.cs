using Eläintesti;

class program
{
    static void Main(string[] args)
    {
        Koira KoiraOlio = new Koira();

        KoiraOlio.Nimi = "Masa";
        KoiraOlio.Rotu = "Sekarotu";
        KoiraOlio.Paino = 16.0f;
        KoiraOlio.Väri = "Beige";
        KoiraOlio.Ikä = 2.5;

        KoiraOlio.Hauku();

        Console.WriteLine(KoiraOlio.HaeTiedot());

        KoiraOlio.Hauku();

    }
}