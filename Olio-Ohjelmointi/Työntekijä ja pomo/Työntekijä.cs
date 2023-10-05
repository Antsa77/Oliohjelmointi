class Työntekijä : Henkilö
{
    public double ViikottaisetTunnit { get; set; }

    public Työntekijä(string nimi, string työpaikka, double palkka, double viikottaisetTunnit)
        : base(nimi, työpaikka, palkka)
    {
        ViikottaisetTunnit = viikottaisetTunnit;
    }

    public override double LaskePalkka()
    {
        return Palkka * (ViikottaisetTunnit * 4);
    }
}