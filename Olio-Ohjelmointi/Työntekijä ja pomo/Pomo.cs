class Pomo : Henkilö
{
    public double Boonus { get; set; }
    public string Auto { get; set; }

    public Pomo(string nimi, string työpaikka, double palkka, double boonus, string auto)
        : base(nimi, työpaikka, palkka)
    {
        Boonus = boonus;
        Auto = auto;
    }

    public override double LaskePalkka()
    {
        return Palkka + Boonus;
    }
}