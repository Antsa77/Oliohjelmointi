namespace Opiskelija
{
    class Program
    {
        private static void Main(string[] args)
        {
            Opiskelija Opiskelija1 = new Opiskelija("Matti", "TVTP2022", 0);

            Opiskelija1.TulostaData();
            Opiskelija1.muokkaaopintopistetitä(5);
            Opiskelija1.TulostaData();
            Console.ReadLine();
        }
    }
}