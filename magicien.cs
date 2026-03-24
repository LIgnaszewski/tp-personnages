class Magicien : Personnage
{
    protected int puissanceMagique;

    public Magicien(string name, int pv, int puissanceMagique):base(name, pv)
    {
        this.name = name;
        this.pointsDeVie = pv;
        this.puissanceMagique = puissanceMagique;
    }

    public override void Afficher()
    {
        Console.WriteLine($"{name} : {pointsDeVie}PV/{puissanceMagique}PM");
    }
}