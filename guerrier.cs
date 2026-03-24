class Guerrier: Personnage
{
    protected int armure;

    public Guerrier(string name, int pv, int armure):base(name, pv)
    {
        this.name = name;
        this.pointsDeVie = pv;
        this.armure = armure;
    }

    public override void Afficher()
    {
        Console.WriteLine($"{name} : {pointsDeVie}PV/{armure}ARM");
    }

    public void Attaquer()
    {
        Console.WriteLine("Le guerrier attaque");
    }
}