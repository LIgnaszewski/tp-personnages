namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Lucas", 25);
        p1.Afficher();
        p1.RecevoirDegats(24);

        Guerrier p2 = new Guerrier("Arthur", 100, 20);
        p2.Afficher();
        Magicien p3 = new Magicien("Merlin", 80, 50);
        p3.Afficher();
    }
}