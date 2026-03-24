namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Lucas", 25);
        p1.Afficher();
        p1.RecevoirDegats(24);

        Personnage p2 = new Guerrier("Arthur", 100, 20);
        Personnage p3 = new Magicien("Merlin", 80, 50);

        List<Personnage> Personnages = new List<Personnage>();

        Personnages.Add(p2); 
        Personnages.Add(p3); 

        foreach(var perso in Personnages)
        {
            if (perso is Guerrier g)
            {
                g.Attaquer();
                perso.Afficher();
            } else if (perso is Magicien magicien)
            {
                magicien.LancerSort();
                perso.Afficher();
            }
        }
    }
}