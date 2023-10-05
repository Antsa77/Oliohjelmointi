using System;
class Radio
{
    private bool _power = false;
    private int _volume = 5; // Oletusäänenvoimakkuus
    private double _frequency = 88.0; // Oletustaajuus

    public bool Power
    {
        get { return _power; }
        set { _power = value; }
    }
    public int Volume
    {
        get { return _volume; }
        set
        {
            if (value >= 0 && value <= 9)
            {
                _volume = value;
            }
            else
            {
                Console.WriteLine("Virhe: Äänenvoimakkuus on sallitun rajan ulkopuolella (0-9).");
            }
        }
    }
    public double Frequency
    {
        get { return _frequency; }
        set
        {
            if (value >= 88.0 && value <= 107.9)
            {
                _frequency = value;
            }
            else
            {
                Console.WriteLine("Virhe: Taajuus on sallitun rajan ulkopuolella (88.0-107.9).");
            }
        }
    }
    public void PrintStatus()
    {
        Console.WriteLine($"Radio: Päällä: {Power}, Äänenvoimakkuus: {Volume}, Taajuus: {Frequency}");
    }
}