using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeuSerpent;

namespace JeuSerpent
{
    internal class Program
    {
        static void Main(string[] args) 
        {
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
        }

    }
}
