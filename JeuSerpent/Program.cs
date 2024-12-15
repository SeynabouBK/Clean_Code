using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuSerpent;

Console.WriteLine("Entrez le nom du premier joureur");
string? InputJoueur1 = Console.ReadLine();
string NomJoueur1 = InputJoueur1 ?? "Joueur 1";

Console.WriteLine("Entrez le nom du deuxieme joureur");
string? InputJoueur2 = Console.ReadLine();
string NomJoueur2 = InputJoueur2 ?? "Joueur 2";

Joueur Joueur1 = new(NomJoueur1);
Joueur Joueur2 = new(NomJoueur2);

Console.WriteLine("\nJoueurs initialisés : ");
Joueur1.AfficherInfos();
Joueur2.AfficherInfos();

Console.WriteLine("\nDébut du jeu !");

int CompteurTours = 0;
bool jeuEnCours = true;

while(jeuEnCours)

{
    CompteurTours++;


    int LancerDeJoueur1 = Joueur.LancerDe();
    Console.WriteLine($"{Joueur1.Nom} lance le De et obtient {LancerDeJoueur1}");
    Joueur1.Deplacer(LancerDeJoueur1);
    Console.WriteLine($"{Joueur1.Nom} est maintenant à la position : {Joueur1.Position}");
    Thread.Sleep(1000);

    if (Joueur1.Position == 50)
    {
        Console.WriteLine($"\n {Joueur1.Nom} a gagne la partie");
        break;
    }

    int LancerDeJoueur2 = Joueur.LancerDe();
    Console.WriteLine($"{Joueur2.Nom} lance le De et obtient {LancerDeJoueur2}");
    Joueur2.Deplacer(LancerDeJoueur2);
    Console.WriteLine($"{Joueur2.Nom} est maintenant à la position : {Joueur2.Position}");
    Thread.Sleep(1000);

    if (Joueur2.Position == 50)
    {
        Console.WriteLine($"\n {Joueur2.Nom} a gagne la partie");
        break;
    }

    if (CompteurTours > 100)
    {
        Console.WriteLine("\nLa partie est terminée après 100 tours sans vainqueur.");
        break; 
    }

    Console.WriteLine(); 
}
