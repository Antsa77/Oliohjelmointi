class Program
{
    static void Main()
    {
        Radio radio = new Radio();

        while (true)
        {
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1. Kytke radio päälle / pois");
            Console.WriteLine("2. Säädä äänenvoimakkuutta");
            Console.WriteLine("3. Säädä taajuutta");
            Console.WriteLine("4. Tulosta radion tila");
            Console.WriteLine("5. Poistu");

            int valinta = int.Parse(Console.ReadLine());

            switch (valinta)
            {
                case 1:
                    radio.Power = !radio.Power;
                    break;
                case 2:
                    Console.WriteLine("Anna äänenvoimakkuus (0-9):");
                    int uusiAanenvoimakkuus = int.Parse(Console.ReadLine());
                    radio.Volume = uusiAanenvoimakkuus;
                    break;
                case 3:
                    Console.WriteLine("Anna taajuus (88.0-107.9):");
                    double uusiTaajuus = double.Parse(Console.ReadLine());
                    radio.Frequency = uusiTaajuus;
                    break;
                case 4:
                    radio.PrintStatus();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
        }
    }
}