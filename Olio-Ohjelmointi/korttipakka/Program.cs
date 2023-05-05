internal class Program
{
    private static void Main(string[] args)
    {
        Korttipakka pakka = new Korttipakka();
        pakka.Tulosta();
        pakka.Shuffle();
        Console.WriteLine();
        Console.WriteLine("sekoituksen jälkeen: ");
        pakka.Tulosta();
    }
}