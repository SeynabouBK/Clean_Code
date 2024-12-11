using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuSerpent
{
    internal class Joueur
    {
        public string Nom { get; private set; }
        public int Position { get; private set; }
        public Joueur(String nom) 
        {
            Nom = nom;
            Position = 0;
        }

        public void AfficherInfos() 
        { 
            Console.WriteLine($"Joueur: {Nom}, Position: {Position}");
        }
    }
}
