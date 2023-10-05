class Korttipakka
{
    private List<string> kortit;

    public Korttipakka()
    {
        kortit = new List<string>();
        string[] maat = { "Pata", "Risti", "Ruutu", "Hertta" };
        string[] numerot = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        foreach (string maa in maat)
        {
            foreach (string numero in numerot)
            {
                kortit.Add(maa + " " + numero);
            }
        }
    }
    public void Tulosta()
    {
        foreach (string kortti in kortit)
        {
            Console.WriteLine("kortti on: " + kortti);
        }
    }
    public void Shuffle()
    {
        Random random = new Random();
        kortit = kortit.OrderBy(x => random.Next()).ToList();
    }
}

