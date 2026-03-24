class Personnage
{
    protected string name;
    protected int pointsDeVie;

    public Personnage (string name, int pointsDeVie)
    {
        this.name = name;
        this.pointsDeVie = pointsDeVie;
    }

    public void recevoirDegats(int degats)
    {
        pointsDeVie -= degats;
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"{name} : {pointsDeVie}PV");
    }
}