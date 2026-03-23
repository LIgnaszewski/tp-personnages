namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Lucas", 25);
        p1.Afficher();
        p1.recevoirDegats(24);

        Guerrier p2 = new Guerrier("Romain", 1500, 50);
        p2.Afficher();
        Magicien p3 = new Magicien("Antoine", 2000, 200);
        p3.Afficher();
    }
}
