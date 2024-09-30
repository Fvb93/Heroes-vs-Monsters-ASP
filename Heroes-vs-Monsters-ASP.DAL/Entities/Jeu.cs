using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_vs_Monsters_ASP.DAL.Entities
{
    public class Jeu
    {
        public Dictionary<string, Monstre> Init () 
        {
            Dictionary<string, Monstre> Monstres = new Dictionary<string, Monstre>();
            for (int i = 1; i <= 10; i++)
            {
                Random random = new Random();
                int monstreAleatoire = random.Next(1,4);
                switch (monstreAleatoire) {
                    case 1:
                        string nomVariable = "monstre_" + i;
                        Monstres[nomVariable] = new Dragonnet();
                        break;

                    case 2:
                        nomVariable = "monstre_" + i;
                        Monstres[nomVariable] = new Loup();
                        break;

                    case 3:
                        nomVariable = "monstre_" + i;
                        Monstres[nomVariable] = new Orque();
                        break;
                }
                
            }
            return Monstres;
        }
        public void Combat(Heros hero, Monstre monstre)
        {
            int pointDeVieInitial = hero.PointsDeVie;
            Console.WriteLine($"{hero.Nom} rencontre un {monstre.Nom} !");

            while (hero.PointsDeVie > 0 && monstre.PointsDeVie > 0)
            {
                int degat = hero.Frappe(monstre);
                hero.AffichageDegat(hero, monstre, degat);
                if (monstre.PointsDeVie > 0)
                {
                    degat = monstre.Frappe(hero);
                    monstre.AffichageDegat(monstre, hero, degat);
                }
            }

            if (hero.PointsDeVie > 0)
            {
                Console.WriteLine($"{hero.Nom} a vaincu {monstre.Nom} !");
                Console.WriteLine($"Récompense: Or = {monstre.Or}, Cuir = {monstre.Cuir}");
                hero.RestaurerPointDeVie();
            }
            else
            {
                Console.WriteLine($"{monstre.Nom} a vaincu {hero.Nom} !");
            }
        }
    }
}
