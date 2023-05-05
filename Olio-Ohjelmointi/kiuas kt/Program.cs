class Program
{
    static void Main()
    {
        Kiuas kiuas = new Kiuas();

        kiuas.KytkePäälle();
        kiuas.AsetaLämpötila(82);
        kiuas.AsetaKosteus(47);
        kiuas.AsetaLämpötila(98);
        kiuas.AsetaKosteus(75);
        kiuas.KytkePois();
        Console.ReadLine();
    }
}