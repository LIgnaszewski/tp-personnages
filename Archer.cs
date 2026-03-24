class Archer : Personnage
{
    protected int precision;

    public void Tirer()
    {
        Console.WriteLine($"L’archer tire une flèche avec une précision de {precision}");
    }

    public Archer(string name, int pv, int precision):base(name, pv)
    {
        this.name = name;
        this.pointsDeVie = pv;
        this.precision = precision;
    }

    public override void Afficher()
    {
        Console.WriteLine($"{name} : {pointsDeVie}PV/{precision} PRECISION");
    }
}