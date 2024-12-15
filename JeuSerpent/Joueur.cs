using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuSerpent
{
    internal class Joueur(String nom)
    {
        public string Nom { get; private set; } = nom;
        public int Position { get; private set; } = 0;

        public void AfficherInfos() 
        { 
            Console.WriteLine($"Joueur: {Nom}, Position: {Position}");
        }

        public static int LancerDe()
        {
            Random random = new();
            int ValeurDe = random.Next(1, 7);
            return ValeurDe;
        }

        public void Deplacer(int ValeurDe1)
        {
            Position += ValeurDe1;

            if (Position > 50)
            {
                Console.Write($"{Nom} depasse la case 50 et revient à la case 25 ! ");
                Position = 25;
            }
            Console.WriteLine($"{Nom} se deplace à la position {Position} ! ");

        }

    }
}
