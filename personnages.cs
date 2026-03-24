class Personnage
{
    protected string name;
    protected int pointsDeVie;

    public Personnage (string name, int pointsDeVie)
    {
        this.name = name;
        this.pointsDeVie = pointsDeVie;
    }

    public void RecevoirDegats(int degats)
    {
        pointsDeVie -= degats;
    }

    public virtual void Afficher()
    {
        Console.WriteLine($"{name} : {pointsDeVie}PV");
    }

    public void RecevoirDegats(int degats, int reduction)
    {
        pointsDeVie -= degats - reduction;
    }
    public void ToString()
    {
     Console.WriteLine($"{name} : {pointsDeVie}PV");
    }
}