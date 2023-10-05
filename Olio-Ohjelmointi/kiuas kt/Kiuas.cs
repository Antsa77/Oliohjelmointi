class Kiuas
{
    private bool onPäällä;
    private int lämpötila;
    private int kosteus;

    public Kiuas()
    {
        onPäällä = false;
        lämpötila = 0;
        kosteus = 0;
    }
    public void KytkePäälle()
    {
        onPäällä = true;
        Console.WriteLine("Kiuas on päällä.");
    }
    public void KytkePois()
    {
        onPäällä = false;
        Console.WriteLine("Kiuas on sammutettu.");
    }
    public void AsetaKosteus(int uusiKosteus)
    {
        kosteus = uusiKosteus;
        Console.WriteLine("Kiuaksen kosteus on nyt " + kosteus + " prosenttia.");
    }
    public void AsetaLämpötila(int uusiLämpötila)
    {
        lämpötila = uusiLämpötila;
        Console.WriteLine("Kiuaksen lämpötila on nyt " + lämpötila + " astetta.");
    }
}
